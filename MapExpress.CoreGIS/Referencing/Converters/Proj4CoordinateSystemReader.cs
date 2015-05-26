using System;
using System.Collections.Generic;
using System.Globalization;
using MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems;
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
    public class Proj4CoordinateSystemReader : ICoordinateSystemReader
    {
        private static Proj4CoordinateSystemReader instance = new Proj4CoordinateSystemReader ();

        private Proj4CoordinateSystemReader ()
        {
        }

        public static Proj4CoordinateSystemReader Instance
        {
            get { return instance; }
        }

        #region ICoordinateSystemReader Members

        public ICoordinateReferenceSystem ReadCoordinateSystem (string proj4String)
        {
            if (proj4String.Contains (Proj4Keyword.geocentric))
            {
                return ReadGeocentricCRS (proj4String);
            }
            if (proj4String.Contains (Proj4Keyword.longlat))
            {
                return ReadGeographicCRS (proj4String);
            }
            return ReadProjectedCRS (proj4String);
        }

        public IGeocentricCRS ReadGeocentricCRS (string proj4String)
        {
            var parameters = PopulateParameters (proj4String);
            string projName;
            if (parameters.TryGetValue (Proj4Keyword.proj, out projName) && projName.Equals (Proj4Keyword.geocentric, StringComparison.InvariantCultureIgnoreCase))
            {
                //TODO: Читать Unit и в зависимости от этого CreateGeocentricCRSFromCartesianCS или CreateGeocentricCRSFromSphericalCS
                return new CoordinateReferenceSystemFactory ().CreateGeocentricCRSFromCartesianCS (string.Empty, ReadDatum (parameters));
            }
            return null;
        }

        public IGeographicCRS ReadGeographicCRS (string proj4String)
        {
            var parameters = PopulateParameters (proj4String);
            string projName;
            if (parameters.TryGetValue (Proj4Keyword.proj, out projName) && projName.Equals (Proj4Keyword.longlat, StringComparison.InvariantCultureIgnoreCase))
            {
                return new CoordinateReferenceSystemFactory ().CreateGeographicCRS (string.Empty, ReadDatum (parameters));
            }
            return null;
        }

        public IProjectedCRS ReadProjectedCRS (string proj4String)
        {
            string projectionName;
            var parameters = PopulateParameters (proj4String);
            var projection = ReadProjection (parameters, out projectionName);
            var datum = ReadDatum (parameters);
            var geogrCS = new CoordinateReferenceSystemFactory ().CreateGeographicCRS (string.Empty, datum);
            var projectedCRS = new CoordinateReferenceSystemFactory ().CreateProjectedCRS (projectionName, geogrCS, projection);
            return projectedCRS;
        }

        public IProjection ReadProjection (string proj4String)
        {
            string projectionName;
            var parameters = PopulateParameters (proj4String);
            return ReadProjection (parameters, out projectionName);
        }

        public IGeodeticDatum ReadDatum (string proj4String)
        {
            var parameters = PopulateParameters (proj4String);
            return ReadDatum (parameters);
        }

        public IEllipsoid ReadEllipsoid (string proj4String)
        {
            var parameters = PopulateParameters (proj4String);
            return ReadEllipsoid (parameters);
        }

        public IPrimeMeridian ReadPrimeMeridian (string proj4String)
        {
            var parameters = PopulateParameters (proj4String);
            return ReadPrimeMeridian (parameters);
        }

        // TODO: Реализовать и доработать методы чтения СК
        public IUnit ReadUnit (string proj4String)
        {
            //if (parameters.TryGetValue (Proj4Keyword.units, out s))
            //{
            //    Unit unit = Units.Units.FindUnit (s);
            //    // TODO: report unknown units name as error
            //    if (unit != null)
            //    {
            //        projection.FromMetres = (1.0 / unit.Value);
            //        projection.Unit = unit;
            //    }
            //}

            //if (parameters.TryGetValue (Proj4Keyword.to_meter, out s))
            //    projection.FromMetres = (1.0 / Double.Parse (s, CultureInfo.InvariantCulture));
            throw new NotImplementedException ();
        }

        public ICoordinateSystemAxis ReadAxis (string proj4String)
        {
            throw new NotImplementedException ();
        }

        #endregion

        private static IProjection ReadProjection (IDictionary <string, string> parameters, out string projectionName)
        {
            Projection projection = null;

            if (parameters.TryGetValue (Proj4Keyword.proj, out projectionName))
            {
                projection = ProjectionRegistry.Instance.GetByAuthority (AuthorityType.PROJ4, projectionName);
                var tryEpsgName = projection.AuthorityAliases.FindFirstNameByAuthority (AuthorityType.EPSG);
                if (!string.IsNullOrEmpty (tryEpsgName))
                {
                    projectionName = tryEpsgName;
                }
            }
            if (projection == null)
            {
                throw new MapExpressException ("Unsupported projection: " + projectionName);
            }

            var projectionParameters = new ProjectionParameters ();
            projection.Parameters = projectionParameters;

            string s;
            if (parameters.TryGetValue (Proj4Keyword.alpha, out s))
            {
                projectionParameters.Azimuth = Double.Parse (s, CultureInfo.InvariantCulture);
            }

            if (parameters.TryGetValue (Proj4Keyword.lonc, out s))
            {
                projectionParameters.LongitudeOfCenter = Double.Parse (s, CultureInfo.InvariantCulture);
            }

            if (parameters.TryGetValue (Proj4Keyword.lat_0, out s))
            {
                projectionParameters.LatitudeOfOrigin = Double.Parse (s, CultureInfo.InvariantCulture);
                projectionParameters.LatitudeOfCenter = Double.Parse (s, CultureInfo.InvariantCulture);
            }

            if (parameters.TryGetValue (Proj4Keyword.lon_0, out s))
            {
                projectionParameters.CentralMeridian = Double.Parse (s, CultureInfo.InvariantCulture);
                projectionParameters.LongitudeOfCenter = Double.Parse (s, CultureInfo.InvariantCulture);
            }

            if (parameters.TryGetValue (Proj4Keyword.lat_1, out s))
            {
                projectionParameters.StandardParallel1 = Double.Parse (s, CultureInfo.InvariantCulture);
            }

            if (parameters.TryGetValue (Proj4Keyword.lat_2, out s))
            {
                projectionParameters.StandardParallel2 = Double.Parse (s, CultureInfo.InvariantCulture);
            }

            if (parameters.TryGetValue (Proj4Keyword.lat_ts, out s))
            {
                projectionParameters.StandardParallel1 = Double.Parse (s, CultureInfo.InvariantCulture);
            }

            if (parameters.TryGetValue (Proj4Keyword.x_0, out s))
            {
                projectionParameters.FalseEasting = Double.Parse (s, CultureInfo.InvariantCulture);
            }

            if (parameters.TryGetValue (Proj4Keyword.y_0, out s))
            {
                projectionParameters.FalseNorthing = Double.Parse (s, CultureInfo.InvariantCulture);
            }

            if (parameters.TryGetValue (Proj4Keyword.k_0, out s))
            {
                projectionParameters.ScaleFactor = Double.Parse (s, CultureInfo.InvariantCulture);
            }

            if (parameters.TryGetValue (Proj4Keyword.k, out s))
            {
                projectionParameters.ScaleFactor = Double.Parse (s, CultureInfo.InvariantCulture);
            }

            // TODO: Реализовать!
            //ReadUnit

            if (projection is TransverseMercator)
            {
                if (projectionParameters.FalseEasting == 0)
                {
                    projectionParameters.FalseEasting = 500000.0;
                }
                if (parameters.ContainsKey (Proj4Keyword.south))
                {
                    if (projectionParameters.FalseNorthing == 0)
                    {
                        projectionParameters.FalseNorthing = 10000000.0;
                    }
                }

                if (parameters.TryGetValue (Proj4Keyword.zone, out s))
                {
                    var centralMeridian = MercatorGridZoneLocator.UTMZoneCentralMeridian (Int32.Parse (s, CultureInfo.InvariantCulture));
                    projectionParameters.CentralMeridian = centralMeridian;
                }

                if (!projectionParameters.Exists ("scale_factor"))
                {
                    projectionParameters.ScaleFactor = 0.9996;
                }
            }

            var ellipsoid = ReadEllipsoid (parameters);
            projectionParameters.Ellipsoid = ellipsoid;


            return projection;
        }

        private static IGeodeticDatum ReadDatum (IDictionary <string, string> parameters)
        {
            GeodeticDatum datum;

            string name;
            if (parameters.TryGetValue (Proj4Keyword.datum, out name))
            {
                datum = (GeodeticDatum) DatumRegistry.Instance.GetByAuthority (AuthorityType.PROJ4, name);
                if (datum == null)
                {
                    throw new MapExpressException ("Unknown datum: " + name);
                }
                return datum;
            }

            var ellipsoid = ReadEllipsoid (parameters);
            var meridian = ReadPrimeMeridian (parameters);

            if (ellipsoid.Equals (EllipsoidRegistry.Instance.WGS84) && meridian.Equals (PrimeMeridianRegistry.Instance.Greenwich))
            {
                return DatumRegistry.Instance.WGS84;
            }

            datum = new GeodeticDatum (ellipsoid, meridian);

            string towgs84;
            if (parameters.TryGetValue (Proj4Keyword.towgs84, out towgs84))
            {
                double dx = 0, dy = 0, dz = 0, rx = 0, ry = 0, rz = 0, ds = 0;
                var towgs84Params = towgs84.Split (',');
                if (towgs84Params.Length >= 3)
                {
                    dx = double.Parse (towgs84Params[0], CultureInfo.InvariantCulture);
                    dy = double.Parse (towgs84Params [1],  CultureInfo.InvariantCulture);
                    dz = double.Parse (towgs84Params [2],  CultureInfo.InvariantCulture);
                }
                if (towgs84Params.Length >= 7)
                {
                    rx = double.Parse (towgs84Params[3], CultureInfo.InvariantCulture);
                    ry = double.Parse (towgs84Params[4], CultureInfo.InvariantCulture);
                    rz = double.Parse (towgs84Params[5], CultureInfo.InvariantCulture);
                    ds = double.Parse (towgs84Params[6], CultureInfo.InvariantCulture);
                }
                datum.ToWGS84 = new DatumShiftParameters (dx, dy, dz, rx, ry, rz, ds);
            }

            return datum;
        }

        private static IEllipsoid ReadEllipsoid (IDictionary <string, string> parameters)
        {
            IEllipsoid ellipsoid;
            string name;
            if (parameters.TryGetValue (Proj4Keyword.ellps, out name))
            {
                ellipsoid = EllipsoidRegistry.Instance.GetByAuthority (AuthorityType.PROJ4, name);
                if (ellipsoid == null)
                {
                    throw new MapExpressException ("Unknown ellipsoid: " + name);
                }
                return ellipsoid;
            }

            ellipsoid = new Ellipsoid (name);

            string s;
            if (parameters.TryGetValue (Proj4Keyword.a, out s))
            {
                double a = Double.Parse (s, CultureInfo.InvariantCulture);
                ellipsoid.SemiMajorAxis = a;
            }

            if (parameters.TryGetValue (Proj4Keyword.es, out s))
            {
                double es = Double.Parse (s, CultureInfo.InvariantCulture);
                ellipsoid.Flattening = 1 - Math.Sqrt (1 - es);
            }

            if (parameters.TryGetValue (Proj4Keyword.rf, out s))
            {
                double rf = Double.Parse (s, CultureInfo.InvariantCulture);
                ellipsoid.InverseFlattening = rf;
            }

            if (parameters.TryGetValue (Proj4Keyword.f, out s))
            {
                double f = Double.Parse (s, CultureInfo.InvariantCulture);
                ellipsoid.Flattening = f;
            }

            if (parameters.TryGetValue (Proj4Keyword.b, out s))
            {
                double b = Double.Parse (s, CultureInfo.InvariantCulture);
                ellipsoid.SemiMinorAxis = b;
            }

            if (parameters.TryGetValue (Proj4Keyword.e, out s))
            {
                double e = Double.Parse (s, CultureInfo.InvariantCulture);
                ellipsoid.Flattening = 1 - Math.Sqrt (1 - Math.Pow (e, 2.0));
            }

            if (ellipsoid.SemiMajorAxis == 0 || ellipsoid.SemiMinorAxis == 0)
            {
                return EllipsoidRegistry.Instance.WGS84;
            }

            return ellipsoid;
        }

        private static IPrimeMeridian ReadPrimeMeridian (IDictionary <string, string> parameters)
        {
            string name;
            IPrimeMeridian meridian = null;
            if (parameters.TryGetValue (Proj4Keyword.pm, out name))
            {
                meridian = PrimeMeridianRegistry.Instance.GetByAuthority (AuthorityType.PROJ4, name);
            }
            return meridian ?? PrimeMeridianRegistry.Instance.Greenwich;
        }

        private Dictionary <string, string> PopulateParameters (string proj4String)
        {
            var paramDictionary = new Dictionary <string, string> ();
            var spilttedParams = proj4String.Split ('+');
            foreach (var spilttedParam in spilttedParams)
            {
                var parVal = spilttedParam.Split ('=');
                var parName = parVal [0].Trim ();
                if (!string.IsNullOrEmpty (parName))
                {
                    var parValue = parVal.Length == 2 ? parVal [1].Trim () : string.Empty;
                    paramDictionary.Add (parName, parValue);
                }
            }
            return paramDictionary;
        }
    }
}