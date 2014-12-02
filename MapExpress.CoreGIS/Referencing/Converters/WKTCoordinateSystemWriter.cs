#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MapExpress.CoreGIS.Referencing.CoordinateSystems;
using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.CoreGIS.Referencing.Units;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.Converters
{
    // TODO: Наименования надо брать из алиасов, в зависомсти от AuthorityType
    // TODO: Для Kroval сделать параметры по умолчанию. Они пробиты в коде
    // http://www.geotoolkit.org/apidocs/org/geotoolkit/referencing/operation/provider/Krovak.html

    public class WKTCoordinateSystemWriter : ICoordinateSystemWriter
    {
        private static WKTCoordinateSystemWriter instance = new WKTCoordinateSystemWriter ();

        private static string geocentricCRSTemplate = "GEOCCS[\"{0}\",{1},{2},{3},{4}{5}]";
        private static string geographicCRSTemplate = "GEOGCS[\"{0}\",{1},{2},{3},{4}{5}]";
        private static string projectedCRSTemplate = "PROJCS[\"{0}\",{1},{2},{3},{4}{5}]";
        private static string projectionTemplate = "PROJECTION[\"{0}\"{1}]";
        private static string projectionParametersTemplate = "PARAMETER[\"{0}\",{1}]";
        private static string datumTemplate = "DATUM[\"{0}\",{1}{2}{3}]";
        private static string primeMeridianTemplate = "PRIMEM[\"{0}\",{1}{2}]";
        private static string ellipsoidTemplate = "SPHEROID[\"{0}\",{1},{2}{3}]";
        private static string axisTemplate = "AXIS[\"{0}\",{1}]";
        private static string unitTemplate = "UNIT[\"{0}\",{1}{2}]";
        private static string authorityTemplate = ",AUTHORITY[\"{0}\",\"{1}\"]";
        private static string toWGS84Template = ",TOWGS84[{0},{1},{2},{3},{4},{5},{6}]";

        public static WKTCoordinateSystemWriter Instance
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
            return string.Format (geocentricCRSTemplate,
                                  geocentricCRS.Name,
                                  WriteDatum (geocentricCRS.Datum),
                                  WritePrimeMeridian (geocentricCRS.Datum.PrimeMeridian ?? new DatumFactory ().CreateGreenvich ()),
                                  WriteUnit (geocentricCRS.Unit ?? LinearUnit.Meter),
                                  WriteGeocentricAxises (geocentricCRS),
                                  AuthorityIfExists (geocentricCRS));
        }

        public void WriteGeocentricCRS (IGeocentricCRS geocentricCRS, Stream stream)
        {
            Write (geocentricCRS, stream, WriteGeocentricCRS);
        }

        public string WriteGeographicCRS (IGeographicCRS geographicCRS)
        {
            return string.Format (geographicCRSTemplate,
                                  geographicCRS.Name,
                                  WriteDatum (geographicCRS.Datum),
                                  WritePrimeMeridian (geographicCRS.Datum.PrimeMeridian ?? new DatumFactory ().CreateGreenvich ()),
                                  WriteUnit (geographicCRS.Unit ?? AngularUnit.Degree),
                                  WriteGeographAxises (geographicCRS),
                                  AuthorityIfExists (geographicCRS));
        }

        public void WriteGeographicCRS (IGeographicCRS geographicCRS, Stream stream)
        {
            Write (geographicCRS, stream, WriteGeographicCRS);
        }

        public string WriteProjectedCRS (IProjectedCRS projectedCRS)
        {
            return string.Format (projectedCRSTemplate,
                                  projectedCRS.Name,
                                  WriteGeographicCRS (projectedCRS.BaseCRS),
                                  WriteProjection (projectedCRS.ConversionFromBase),
                                  WriteProjectionParameters (projectedCRS.ConversionFromBase),
                                  WriteUnit (projectedCRS.Unit ?? LinearUnit.Meter),
                                  AuthorityIfExists (projectedCRS));
        }

        public void WriteProjectedCRS (IProjectedCRS projectedCRS, Stream stream)
        {
            Write (projectedCRS, stream, WriteProjectedCRS);
        }

        public string WriteProjection (IProjection projection)
        {
            return string.Format (projectionTemplate, projection.OperationMethod.Name, AuthorityIfExists (projection.OperationMethod));
        }

        public void WriteProjection (IProjection projection, Stream stream)
        {
            Write (projection, stream, WriteProjection);
        }

        public string WriteDatum (IDatum datum)
        {
            return string.Format (datumTemplate,
                                  datum.Name,
                                  WriteEllipsoid (datum.Ellipsoid),
                                  WriteToWGS84Parameters (datum),
                                  AuthorityIfExists (datum));
        }

        public void WriteDatum (IDatum datum, Stream stream)
        {
            Write (datum, stream, WriteDatum);
        }

        public string WriteEllipsoid (IEllipsoid ellipsoid)
        {
            return string.Format (ellipsoidTemplate,
                                  ellipsoid.Name,
                                  FormatNumber (ellipsoid.SemiMajorAxis),
                                  FormatNumber (ellipsoid.InverseFlattening),
                                  AuthorityIfExists (ellipsoid));
        }

        public void WriteEllipsoid (IEllipsoid ellipsoid, Stream stream)
        {
            Write (ellipsoid, stream, WriteEllipsoid);
        }

        public string WritePrimeMeridian (IPrimeMeridian primeMeridian)
        {
            return string.Format (primeMeridianTemplate,
                                  primeMeridian.Name,
                                  FormatNumber (primeMeridian.Longitude),
                                  AuthorityIfExists (primeMeridian));
        }

        public void WritePrimeMeridian (IPrimeMeridian primeMeridian, Stream stream)
        {
            Write (primeMeridian, stream, WritePrimeMeridian);
        }

        public string WriteAxis (ICoordinateSystemAxis axis)
        {
            return string.Format (axisTemplate, axis.Abbreviation, axis.Direction.ToString ("F"));
        }

        public void WriteAxis (ICoordinateSystemAxis axis, Stream stream)
        {
            Write (axis, stream, WriteAxis);
        }

        public string WriteUnit (IUnit unit)
        {
            return string.Format (unitTemplate, unit.Name, FormatNumber (unit.BaseValue), AuthorityIfExists (unit));
        }

        public void WriteUnit (IUnit unit, Stream stream)
        {
            Write (unit, stream, WriteUnit);
        }

        #endregion

        private static string WriteToWGS84Parameters (IDatum datum)
        {
            var geodDatum = datum as GeodeticDatum;
            if (geodDatum != null)
            {
                var wgsParams = geodDatum.ToWGS84;
                if (wgsParams != null)
                {
                    return string.Format (toWGS84Template,
                                          FormatNumber (wgsParams.Dx),
                                          FormatNumber (wgsParams.Dy),
                                          FormatNumber (wgsParams.Dz),
                                          FormatNumber (wgsParams.Ex),
                                          FormatNumber (wgsParams.Ey),
                                          FormatNumber (wgsParams.Ez),
                                          FormatNumber (wgsParams.Ppm));
                }
            }
            return string.Empty;
        }

        private static string WriteProjectionParameters (IProjection projection)
        {
            var sb = new StringBuilder ();
            foreach (var iterParamValue in projection.Parameters.Values)
            {
                sb.Append (string.Format (projectionParametersTemplate, iterParamValue.Descriptor.Name, FormatNumber (iterParamValue.Value))).Append (",");
            }
            return sb.ToString ().Trim (",".ToCharArray ());
        }

        private static string WriteGeographAxises (IGeodeticCRS geodeticCRS)
        {
            var sb = new StringBuilder ();
            var axisList = geodeticCRS.CoordinateSystem != null && geodeticCRS.CoordinateSystem.AxisList != null ? geodeticCRS.CoordinateSystem.AxisList : new List <ICoordinateSystemAxis> {CoordinateSystemAxis.Lat, CoordinateSystemAxis.Lon};
            foreach (var iterAxis in axisList)
            {
                sb.AppendFormat (axisTemplate, iterAxis.Abbreviation, iterAxis.Direction.ToString ("F")).Append (",");
            }
            return sb.ToString ().Trim (",".ToCharArray ());
        }

        private static string WriteGeocentricAxises (IGeodeticCRS geodeticCRS)
        {
            var sb = new StringBuilder ();
            var axisList = geodeticCRS.CoordinateSystem != null && geodeticCRS.CoordinateSystem.AxisList != null ? geodeticCRS.CoordinateSystem.AxisList : new List <ICoordinateSystemAxis> {CoordinateSystemAxis.GeocentricX, CoordinateSystemAxis.GeocentricY, CoordinateSystemAxis.GeocentricZ};
            foreach (var iterAxis in axisList)
            {
                sb.AppendFormat (axisTemplate, iterAxis.Abbreviation, iterAxis.Direction.ToString ("F")).Append (",");
            }
            return sb.ToString ().Trim (",".ToCharArray ());
        }

        // TODO: Implements
        private static string AuthorityIfExists (IAuthorityObject authority)
        {
            //if (authority != null && authority.DefaultAuthority != null)
            //{
            //    if (!string.IsNullOrEmpty (authority.DefaultAuthority.Name) && authority.DefaultAuthority.Code > 0)
            //    {
            //        return string.Format (authorityTemplate, authority.DefaultAuthority.Name, authority.DefaultAuthority.Code);
            //    }
            //}
            return string.Empty;
        }

        private static void Write <T> (T refObject, Stream stream, Func <T, string> writer)
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