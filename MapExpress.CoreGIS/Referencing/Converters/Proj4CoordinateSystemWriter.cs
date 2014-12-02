using System;
using System.IO;
using System.Text;
using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Referencing.Operations.Projections;
using MapExpress.CoreGIS.Referencing.Registry;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

namespace MapExpress.CoreGIS.Referencing.Converters
{
    public class Proj4CoordinateSystemWriter : ICoordinateSystemWriter
    {
        private static readonly Proj4CoordinateSystemWriter instance = new Proj4CoordinateSystemWriter ();

        private Proj4CoordinateSystemWriter ()
        {
        }

        public static Proj4CoordinateSystemWriter Instance
        {
            get { return instance; }
        }

        #region ICoordinateSystemWriter Members

        public string WriteCoordinateSystem (ICoordinateReferenceSystem coordSys)
        {
            if (coordSys is IGeocentricCRS)
            {
                return WriteGeocentricCRS ((IGeocentricCRS) coordSys);
            }
            if (coordSys is IGeographicCRS)
            {
                return WriteGeographicCRS ((IGeographicCRS) coordSys);
            }
            if (coordSys is IProjectedCRS)
            {
                return WriteProjectedCRS ((IProjectedCRS) coordSys);
            }
            return string.Empty;
        }

        public void WriteCoordinateSystem (ICoordinateReferenceSystem coordSys, Stream stream)
        {
            Write (coordSys, stream, WriteCoordinateSystem);
        }

        public string WriteGeocentricCRS (IGeocentricCRS geocentricCRS)
        {
            var sb = new StringBuilder ("+").Append (Proj4Keyword.proj);
            sb.Append ("=").Append (Proj4Keyword.geocentric).Append (" ").
                Append (WriteDatum (geocentricCRS.Datum)).
                Append (" +units=m +no_defs");
            return sb.ToString ();
        }

        public void WriteGeocentricCRS (IGeocentricCRS geocentricCRS, Stream stream)
        {
            Write (geocentricCRS, stream, WriteGeocentricCRS);
        }

        public string WriteGeographicCRS (IGeographicCRS geographicCRS)
        {
            var sb = new StringBuilder ("+").Append (Proj4Keyword.proj);
            sb.Append ("=").Append (Proj4Keyword.longlat).Append (" ").
                Append (WriteDatum (geographicCRS.Datum)).
                Append (" +units=m +no_defs");
            return sb.ToString ();
        }

        public void WriteGeographicCRS (IGeographicCRS geographicCRS, Stream stream)
        {
            Write (geographicCRS, stream, WriteGeographicCRS);
        }

        public string WriteProjectedCRS (IProjectedCRS projectedCRS)
        {
            var projection = projectedCRS.ConversionFromBase as Projection;
            if (projection == null)
            {
                throw new MapExpressException ("ProjectedCRS conversionFromBase property is not Projection");
            }
            var sb = new StringBuilder (WriteProjection (projection)).
                Append (WriteDatum (projectedCRS.Datum)).
                Append (" +units=m +no_defs");
            return sb.ToString ();
        }

        public void WriteProjectedCRS (IProjectedCRS projectedCRS, Stream stream)
        {
            Write (projectedCRS, stream, WriteProjectedCRS);
        }

        public string WriteProjection (IProjection projection)
        {
            var prepearedProjection = projection as Projection;
            if (prepearedProjection == null)
            {
                throw new MapExpressException ("ProjectedCRS conversionFromBase property is not Projection");
            }

            var projectionName = projection.OperationMethod.AuthorityAliases.FindFirstNameByAuthority (AuthorityType.PROJ4);
            if (string.IsNullOrEmpty (projectionName))
            {
                throw new MapExpressException ("Unsupported projection: " + prepearedProjection.Name);
            }
            var sb = new StringBuilder ("+").Append (Proj4Keyword.proj);
            sb.Append ("=").Append (projectionName);

            const string paramFormat = " +{0}={1}";
            foreach (Parameter iterParameter in prepearedProjection.Parameters.Values)
            {
                string proj4PramaName;
                if (ProjectionParameters.TryConvertName (iterParameter.Name, AuthorityType.PROJ4, out proj4PramaName))
                {
                    sb.AppendFormat (paramFormat, proj4PramaName, FormatNumber (iterParameter.Value));
                }
                else
                    throw new MapExpressException ("Cannot convert projection parameter to Proj4. Projection parameter: " + iterParameter.Name);
            }
            // TODO: Брать в зависимости от ед.измерения в СК, через режистри, значения в C:\_Work\_Projects\proj4_units.txt
            //sb.Append (" +units=m +no_defs");
            return sb.ToString ();
        }

        public void WriteProjection (IProjection projection, Stream stream)
        {
            Write (projection, stream, WriteProjection);
        }

        public string WriteDatum (IDatum datum)
        {
            var sb = new StringBuilder ();
            var testDatum = DatumRegistry.Instance.GetByAuthority (AuthorityType.PROJ4, datum.Name);
            if (testDatum != null)
            {
                sb.Append ("+").Append (Proj4Keyword.datum).Append ("=").Append (testDatum.Name);
                sb.Append (" ").Append (WriteEllipsoid (testDatum.Ellipsoid));
            }

            if (testDatum == null && datum.Ellipsoid != null)
            {
                sb.Append (" ").Append (WriteEllipsoid (datum.Ellipsoid));
            }

            if (datum.PrimeMeridian != null)
            {
                sb.Append (" ").Append (WritePrimeMeridian (datum.PrimeMeridian));
            }

            var performedDatum = datum as GeodeticDatum;
            if (performedDatum != null && performedDatum.ToWGS84 != null)
            {
                sb.Append (" +").Append (Proj4Keyword.towgs84).Append ("=");
                sb.Append (FormatNumber (performedDatum.ToWGS84.Dx)).Append (",");
                sb.Append (FormatNumber (performedDatum.ToWGS84.Dy)).Append (",");
                sb.Append (FormatNumber (performedDatum.ToWGS84.Dz)).Append (",");
                sb.Append (FormatNumber (performedDatum.ToWGS84.Ex)).Append (",");
                sb.Append (FormatNumber (performedDatum.ToWGS84.Ey)).Append (",");
                sb.Append (FormatNumber (performedDatum.ToWGS84.Ez)).Append (",");
                sb.Append (FormatNumber (performedDatum.ToWGS84.Ppm));
            }
            return sb.ToString ();
        }

        public void WriteDatum (IDatum datum, Stream stream)
        {
            Write (datum, stream, WriteDatum);
        }

        public string WriteEllipsoid (IEllipsoid ellipsoid)
        {
            var sb = new StringBuilder ();
            var testEllipsoid = EllipsoidRegistry.Instance.GetByAuthority (AuthorityType.PROJ4, ellipsoid.Name);
            if (testEllipsoid != null)
            {
                sb.Append ("+").Append (Proj4Keyword.ellps).Append ("=").Append (testEllipsoid.Name);
            }
            else
            {
                sb.Append ("+").
                    Append (Proj4Keyword.a).Append ("=").Append (FormatNumber (ellipsoid.SemiMajorAxis)).
                    Append (" +").Append (Proj4Keyword.rf).Append ("=").Append (FormatNumber (ellipsoid.InverseFlattening));
            }
            return sb.ToString ();
        }

        public void WriteEllipsoid (IEllipsoid ellipsoid, Stream stream)
        {
            Write (ellipsoid, stream, WriteEllipsoid);
        }

        public string WritePrimeMeridian (IPrimeMeridian primeMeridian)
        {
            var testMeridian = PrimeMeridianRegistry.Instance.GetByAuthority (AuthorityType.PROJ4, primeMeridian.Name);
            return testMeridian != null ? new StringBuilder ("+").Append (Proj4Keyword.pm).Append ("=").Append (testMeridian.Name).ToString () : string.Empty;
        }

        public void WritePrimeMeridian (IPrimeMeridian primeMeridian, Stream stream)
        {
            Write (primeMeridian, stream, WritePrimeMeridian);
        }

        public string WriteAxis (ICoordinateSystemAxis axis)
        {
            return string.Empty;
        }

        public void WriteAxis (ICoordinateSystemAxis axis, Stream stream)
        {
            Write (axis, stream, WriteAxis);
        }

        // TODO: Убрать заглушку
        public string WriteUnit (IUnit unit)
        {
            return "+units=m";
        }

        public void WriteUnit (IUnit unit, Stream stream)
        {
            Write (unit, stream, WriteUnit);
        }

        #endregion

        private void Write <T> (T refObject, Stream stream, Func <T, string> writer)
        {
            var stringResult = writer (refObject);
            using (var memoryStream = new MemoryStream (Encoding.Default.GetBytes (stringResult)))
            {
                memoryStream.CopyTo (stream);
                stream.Position = 0;
                memoryStream.Close ();
            }
        }

        private static string FormatNumber (double numeric)
        {
            return numeric.ToString ().Replace (',', '.');
        }
    }
}