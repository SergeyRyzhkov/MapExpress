#region

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems;
using MapExpress.CoreGIS.Referencing.CoordinateSystems;
using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Referencing.Operations.Projections;
using MapExpress.CoreGIS.Referencing.Registry;
using MapExpress.CoreGIS.Referencing.Units;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;
using nRsn.Core.Util;

#endregion

// TODO: Создаваь объекты через фактори.

namespace MapExpress.CoreGIS.Referencing.Converters
{
    public class WKTCoordinateSystemReader : ICoordinateSystemReader
    {
        private static readonly WKTCoordinateSystemReader instance = new WKTCoordinateSystemReader ();

        private WKTCoordinateSystemReader ()
        {
        }

        public static WKTCoordinateSystemReader Instance
        {
            get { return instance; }
        }

        #region ICoordinateSystemReader Members

        public ICoordinateReferenceSystem ReadCoordinateSystem (string wkt)
        {
            using (var reader = new StringReader (wkt))
            {
                var tokenizer = new StreamTokenizer (reader, true);
                tokenizer.NextToken ();
                return ReadCoordinateSystem (tokenizer);
            }
        }

        public IGeocentricCRS ReadGeocentricCRS (string wkt)
        {
            string confString;
            if (TryGetConformalText (wkt, "GEOCCS", out confString))
            {
                using (var reader = new StringReader (confString))
                {
                    var tokenizer = new StreamTokenizer (reader, true);
                    tokenizer.NextToken ();
                    return ReadGeocentricCRS (tokenizer);
                }
            }
            return null;
        }

        public IGeographicCRS ReadGeographicCRS (string wkt)
        {
            string confString;
            if (TryGetConformalText (wkt, "GEOGCS", out confString))
            {
                using (var reader = new StringReader (confString))
                {
                    var tokenizer = new StreamTokenizer (reader, true);
                    tokenizer.NextToken ();
                    return ReadGeographicCRS (tokenizer);
                }
            }
            return null;
        }

        public IProjectedCRS ReadProjectedCRS (string wkt)
        {
            string confString;
            if (TryGetConformalText (wkt, "PROJCS", out confString))
            {
                using (var reader = new StringReader (confString))
                {
                    var tokenizer = new StreamTokenizer (reader, true);
                    tokenizer.NextToken ();
                    return ReadProjectedCRS (tokenizer);
                }
            }
            return null;
        }

        public IProjection ReadProjection (string wkt)
        {
            var ellipsoid = ReadEllipsoid (wkt);
            string confString;
            if (TryGetConformalText (wkt, "PROJECTION", out confString))
            {
                using (var reader = new StringReader (confString))
                {
                    var tokenizer = new StreamTokenizer (reader, true);
                    return ReadProjection (tokenizer, ellipsoid);
                }
            }
            return null;
        }

        public IGeodeticDatum ReadDatum (string wkt)
        {
            IGeodeticDatum datum = null;
            string confString;
            if (TryGetConformalText (wkt, "DATUM", out confString))
            {
                using (var reader = new StringReader (confString))
                {
                    var tokenizer = new StreamTokenizer (reader, true);
                    tokenizer.NextToken ();
                    datum = ReadDatum (tokenizer);
                }
                if (datum != null)
                {
                    datum.PrimeMeridian = ReadPrimeMeridian (wkt);
                }
            }
            return datum;
        }

        public IEllipsoid ReadEllipsoid (string wkt)
        {
            string confString;
            if (TryGetConformalText (wkt, "SPHEROID", out confString))
            {
                using (var reader = new StringReader (confString))
                {
                    var tokenizer = new StreamTokenizer (reader, true);
                    tokenizer.NextToken ();
                    return ReadEllipsoid (tokenizer);
                }
            }
            return null;
        }

        public IPrimeMeridian ReadPrimeMeridian (string wkt)
        {
            string confString;
            if (TryGetConformalText (wkt, "PRIMEM", out confString))
            {
                using (var reader = new StringReader (confString))
                {
                    var tokenizer = new StreamTokenizer (reader, true);
                    tokenizer.NextToken ();
                    return ReadPrimeMeridian (tokenizer);
                }
            }
            return null;
        }

        public IUnit ReadUnit (string wkt)
        {
            string unitString;
            if (TryGetConformalText (wkt, "UNIT", out unitString))
            {
                using (var reader = new StringReader (unitString))
                {
                    var tokenizer = new StreamTokenizer (reader, true);
                    tokenizer.NextToken ();
                    return ReadUnit (tokenizer);
                }
            }
            return null;
        }

        public ICoordinateSystemAxis ReadAxis (string wkt)
        {
            string unitString;
            if (TryGetConformalText (wkt, "AXIS", out unitString))
            {
                using (var reader = new StringReader (unitString))
                {
                    var tokenizer = new StreamTokenizer (reader, true);
                    tokenizer.NextToken ();
                    return ReadAxis (tokenizer);
                }
            }
            return null;
        }

        #endregion

        private static bool TryGetConformalText (string wkt, string first, out string result)
        {
            result = string.Empty;
            var index = wkt.IndexOf (first, StringComparison.InvariantCultureIgnoreCase);
            if (index > -1)
            {
                result = wkt.Substring (index);
                return true;
            }
            return false;
        }

        private static ICoordinateReferenceSystem ReadCoordinateSystem (StreamTokenizer tokenizer)
        {
            switch (tokenizer.GetStringValue ())
            {
                case "GEOCCS":
                    return ReadGeocentricCRS (tokenizer);
                case "GEOGCS":
                    return ReadGeographicCRS (tokenizer);
                case "PROJCS":
                    return ReadProjectedCRS (tokenizer);
                case "COMPD_CS":
                case "VERT_CS":
                case "FITTED_CS":
                case "LOCAL_CS":
                    throw new NotSupportedException ("Coordinate system is not supported.");
                default:
                    throw new InvalidOperationException ("Сcoordinate system is not recognized.");
            }
        }

        private static T ReadUnit <T> (StreamTokenizer tokenizer) where T : IUnit, new ()
        {
            var unit = new T ();
            tokenizer.ReadToken ("[");
            unit.Name = tokenizer.ReadDoubleQuotedWord ();
            tokenizer.ReadToken (",");
            tokenizer.NextToken ();
            unit.BaseValue = tokenizer.GetNumericValue ();

            tokenizer.NextToken ();
            if (tokenizer.GetStringValue () == ",")
            {
                TrySetAuthority (tokenizer, unit);
                tokenizer.ReadToken ("]");
            }
            return unit;
        }

        private static AngularUnit ReadAngularUnit (StreamTokenizer tokenizer)
        {
            return ReadUnit <AngularUnit> (tokenizer);
        }

        private static Unit ReadUnit (StreamTokenizer tokenizer)
        {
            return ReadUnit <Unit> (tokenizer);
        }

        private static LinearUnit ReadLinearUnit (StreamTokenizer tokenizer)
        {
            return ReadUnit <LinearUnit> (tokenizer);
        }

        private static ICoordinateSystemAxis ReadAxis (StreamTokenizer tokenizer)
        {
            AxisDirectionType axisDirection;
            var axis = new CoordinateSystemAxis ();

            tokenizer.ReadToken ("[");
            axis.Abbreviation = tokenizer.ReadDoubleQuotedWord ();
            tokenizer.ReadToken (",");
            tokenizer.NextToken ();

            var unitname = tokenizer.GetStringValue ();
            if (!string.IsNullOrEmpty (unitname) && Enum.TryParse (unitname.ToUpperInvariant (), true, out axisDirection))
            {
                axis.Direction = axisDirection;
            }
            tokenizer.ReadToken ("]");
            return axis;
        }

        private static IGeocentricCRS ReadGeocentricCRS (StreamTokenizer tokenizer)
        {
            tokenizer.ReadToken ("[");
            var name = tokenizer.ReadDoubleQuotedWord ();
            tokenizer.ReadToken (",");
            tokenizer.ReadToken ("DATUM");
            var datum = ReadDatum (tokenizer);
            tokenizer.ReadToken (",");
            tokenizer.ReadToken ("PRIMEM");
            datum.PrimeMeridian = ReadPrimeMeridian (tokenizer);

            var geocentricCRS = new CoordinateReferenceSystemFactory ().CreateGeocentricCRSFromCartesianCS (name, datum);

            tokenizer.NextToken ();
            if (tokenizer.GetStringValue () == ",")
            {
                tokenizer.NextToken ();
                if (tokenizer.GetStringValue () == "UNIT")
                {
                    geocentricCRS.Unit = ReadLinearUnit (tokenizer);
                    tokenizer.NextToken ();
                    tokenizer.NextToken ();
                }

                var axisList = new List <ICoordinateSystemAxis> ();
                while (tokenizer.GetStringValue () == "AXIS")
                {
                    axisList.Add (ReadAxis (tokenizer));
                    tokenizer.NextToken ();
                    if (tokenizer.GetStringValue () == ",")
                    {
                        tokenizer.NextToken ();
                    }
                }
                geocentricCRS.CoordinateSystem.AxisList = axisList.Any () ? axisList : geocentricCRS.CoordinateSystem.AxisList;

                if (tokenizer.GetStringValue () == "AUTHORITY")
                {
                    TrySetAuthority (tokenizer, geocentricCRS);
                    tokenizer.ReadToken ("]");
                }
            }

            if (tokenizer.GetStringValue () == "]")
            {
                tokenizer.NextToken ();
            }

            return geocentricCRS;
        }

        private static IGeographicCRS ReadGeographicCRS (StreamTokenizer tokenizer)
        {
            tokenizer.ReadToken ("[");
            var name = tokenizer.ReadDoubleQuotedWord ();
            tokenizer.ReadToken (",");
            tokenizer.ReadToken ("DATUM");
            var datum = ReadDatum (tokenizer);
            tokenizer.ReadToken (",");
            tokenizer.ReadToken ("PRIMEM");
            datum.PrimeMeridian = ReadPrimeMeridian (tokenizer);

            var geographicCRS = new CoordinateReferenceSystemFactory ().CreateGeographicCRS (name, datum);

            tokenizer.NextToken ();
            if (tokenizer.GetStringValue () == ",")
            {
                tokenizer.NextToken ();
                if (tokenizer.GetStringValue () == "UNIT")
                {
                    geographicCRS.Unit = ReadAngularUnit (tokenizer);
                    tokenizer.NextToken ();
                    tokenizer.NextToken ();
                }

                var axisList = new List <ICoordinateSystemAxis> ();
                while (tokenizer.GetStringValue () == "AXIS")
                {
                    axisList.Add (ReadAxis (tokenizer));
                    tokenizer.NextToken ();
                    if (tokenizer.GetStringValue () == ",")
                    {
                        tokenizer.NextToken ();
                    }
                }
                geographicCRS.CoordinateSystem.AxisList = axisList.Any () ? axisList : geographicCRS.CoordinateSystem.AxisList;

                if (tokenizer.GetStringValue () == "AUTHORITY")
                {
                    TrySetAuthority (tokenizer, geographicCRS);
                    tokenizer.ReadToken ("]");
                }
            }

            if (tokenizer.GetStringValue () == "]")
            {
                tokenizer.NextToken ();
            }

            return geographicCRS;
        }

        private static IProjectedCRS ReadProjectedCRS (StreamTokenizer tokenizer)
        {
            tokenizer.ReadToken ("[");
            var name = tokenizer.ReadDoubleQuotedWord ();
            tokenizer.ReadToken (",");
            tokenizer.ReadToken ("GEOGCS");
            var baseCRS = ReadGeographicCRS (tokenizer);

            var conversionFromBase = ReadProjection (tokenizer, baseCRS.Datum.Ellipsoid);

            var projectedCRS = new CoordinateReferenceSystemFactory ().CreateProjectedCRS (name, baseCRS, conversionFromBase);

            if (tokenizer.GetStringValue () == "UNIT")
            {
                projectedCRS.Unit = ReadLinearUnit (tokenizer);
                tokenizer.NextToken ();
                tokenizer.NextToken ();
            }

            var axisList = new List <ICoordinateSystemAxis> ();
            while (tokenizer.GetStringValue () == "AXIS")
            {
                axisList.Add (ReadAxis (tokenizer));
                tokenizer.NextToken ();
                if (tokenizer.GetStringValue () == ",")
                {
                    tokenizer.NextToken ();
                }
            }
            projectedCRS.CoordinateSystem.AxisList = axisList.Any () ? axisList : projectedCRS.CoordinateSystem.AxisList;

            if (projectedCRS.AuthorityAliases.Contains ("WGS_1984_Web_Mercator_Auxiliary_Sphere") || projectedCRS.AuthorityAliases.Contains (3857) || projectedCRS.AuthorityAliases.Contains (3758))
            {
                ((Projection) projectedCRS.ConversionFromBase).Parameters.SemiMajor = 6378137.0;
                ((Projection) projectedCRS.ConversionFromBase).Parameters.SemiMinor = 6378137.0;
            }


            if (tokenizer.GetStringValue () == "AUTHORITY")
            {
                TrySetAuthority (tokenizer, projectedCRS);
                tokenizer.ReadToken ("]");
            }

            return projectedCRS;
        }

        // TODO: Проверить еще на AUTHORITY
        private static IProjection ReadProjection (StreamTokenizer tokenizer, IEllipsoid ellipsoid)
        {
            tokenizer.ReadToken ("PROJECTION");
            tokenizer.ReadToken ("[");
            var projectionName = tokenizer.ReadDoubleQuotedWord ();

            var projection = ProjectionRegistry.Instance.GetByAuthority (AuthorityType.EPSG, projectionName);
            if (projection == null)
            {
                projection = ProjectionRegistry.Instance.GetFirstByAuthorityName (projectionName);
            }
            if (projection == null)
            {
                throw new MapExpressException ("Unsupported projection: " + projectionName);
            }

            var paramList = new ProjectionParameters ();
            projection.Parameters = paramList;

            tokenizer.NextToken ();

            if (tokenizer.GetStringValue () == ",")
            {
                TrySetAuthority (tokenizer, projection);
                tokenizer.NextToken ();
            }

            tokenizer.NextToken ();
            tokenizer.ReadToken ("PARAMETER");

            while (tokenizer.GetStringValue () == "PARAMETER")
            {
                tokenizer.ReadToken ("[");
                var paramName = tokenizer.ReadDoubleQuotedWord ();
                tokenizer.ReadToken (",");
                tokenizer.NextToken ();
                var paramValue = tokenizer.GetNumericValue ();
                tokenizer.ReadToken ("]");
                tokenizer.ReadToken (",");
                tokenizer.NextToken ();

                if (ProjectionParameters.IsParamNameValid (paramName))
                {
                    paramList.CreateOrReplaceParameter (paramName, paramValue, true);
                }
                else
                    throw new MapExpressException ("Unsupported projection parameter: " + paramName);
            }

            projection.Parameters.Ellipsoid = ellipsoid;
            projection.InitializeConstants ();

            // projection.InitializeAliases ();

            return projection;
        }

        private static IGeodeticDatum ReadDatum (StreamTokenizer tokenizer)
        {
            var datum = new GeodeticDatum ();
            tokenizer.ReadToken ("[");
            datum.Name = tokenizer.ReadDoubleQuotedWord ();
            tokenizer.ReadToken (",");
            tokenizer.ReadToken ("SPHEROID");
            datum.Ellipsoid = ReadEllipsoid (tokenizer);
            tokenizer.NextToken ();
            while (tokenizer.GetStringValue () == ",")
            {
                tokenizer.NextToken ();
                if (tokenizer.GetStringValue ().Equals ("TOWGS84"))
                {
                    datum.ToWGS84 = ReadToWGSParameters (tokenizer);
                    tokenizer.NextToken ();
                }
                else if (tokenizer.GetStringValue () == "AUTHORITY")
                {
                    TrySetAuthority (tokenizer, datum);
                    tokenizer.ReadToken ("]");
                }
            }
            return datum;
        }

        private static IEllipsoid ReadEllipsoid (StreamTokenizer tokenizer)
        {
            var ellipsoid = new Ellipsoid ();
            tokenizer.ReadToken ("[");
            ellipsoid.Name = tokenizer.ReadDoubleQuotedWord ();
            tokenizer.ReadToken (",");
            tokenizer.NextToken ();
            ellipsoid.SemiMajorAxis = tokenizer.GetNumericValue ();
            tokenizer.ReadToken (",");
            tokenizer.NextToken ();
            ellipsoid.InverseFlattening = tokenizer.GetNumericValue ();
            tokenizer.NextToken ();
            if (tokenizer.GetStringValue () == ",")
            {
                TrySetAuthority (tokenizer, ellipsoid);
                tokenizer.ReadToken ("]");
            }
            return ellipsoid;
        }

        private static IPrimeMeridian ReadPrimeMeridian (StreamTokenizer tokenizer)
        {
            var meridian = new PrimeMeridian ();
            tokenizer.ReadToken ("[");
            meridian.Name = tokenizer.ReadDoubleQuotedWord ();
            tokenizer.ReadToken (",");
            tokenizer.NextToken ();
            meridian.Longitude = tokenizer.GetNumericValue ();

            tokenizer.NextToken ();
            if (tokenizer.GetStringValue () == ",")
            {
                TrySetAuthority (tokenizer, meridian);
                tokenizer.ReadToken ("]");
            }
            return meridian;
        }

        private static DatumShiftParameters ReadToWGSParameters (StreamTokenizer tokenizer)
        {
            double rx = 0.0, ry = 0.0, rz = 0.0, ds = 0.0;

            tokenizer.ReadToken ("[");
            tokenizer.NextToken ();
            var dx = tokenizer.GetNumericValue ();
            tokenizer.ReadToken (",");
            tokenizer.NextToken ();
            var dy = tokenizer.GetNumericValue ();
            tokenizer.ReadToken (",");
            tokenizer.NextToken ();
            var dz = tokenizer.GetNumericValue ();
            tokenizer.NextToken ();
            if (tokenizer.GetStringValue () == ",")
            {
                tokenizer.NextToken ();
                rx = tokenizer.GetNumericValue ();
                tokenizer.ReadToken (",");
                tokenizer.NextToken ();
                ry = tokenizer.GetNumericValue ();
                tokenizer.ReadToken (",");
                tokenizer.NextToken ();
                rz = tokenizer.GetNumericValue ();
                tokenizer.NextToken ();
                if (tokenizer.GetStringValue () == ",")
                {
                    tokenizer.NextToken ();
                    ds = tokenizer.GetNumericValue ();
                }
            }
            if (tokenizer.GetStringValue () != "]")
            {
                tokenizer.ReadToken ("]");
            }
            return new DatumShiftParameters (dx, dy, dz, rx, ry, rz, ds);
        }

        private static void TrySetAuthority (StreamTokenizer tokenizer, IAuthorityObject authorityObject)
        {
            int authorityCode;
            if (tokenizer.GetStringValue () != "AUTHORITY")
            {
                tokenizer.ReadToken ("AUTHORITY");
            }
            tokenizer.ReadToken ("[");
            var authorityName = tokenizer.ReadDoubleQuotedWord ();
            tokenizer.ReadToken (",");
            int.TryParse (tokenizer.ReadDoubleQuotedWord (), NumberStyles.Any, CultureInfo.InvariantCulture.NumberFormat, out authorityCode);
            tokenizer.ReadToken ("]");

            // TODO: Implements
            if (authorityObject != null)
            {
                //authorityObject.DefaultAuthority.Name = authorityName;
                //authorityObject.DefaultAuthority.Code = (uint) authorityCode;
            }
        }
    }
}