#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations
{
    public class GeocentricGeographicConversion : SingleCoordinateOperation, IConversion
    {
        private IEllipsoid ellipsoid;
        private GeocentricGeographicConversion inverseGeocentricGeographicConversion;

        public GeocentricGeographicConversion () : this (null)
        {
        }

        public GeocentricGeographicConversion (IEllipsoid ellipsoid) : base (null, null, ParameterGroup.Empty)
        {
            this.ellipsoid = ellipsoid;
        }

        public GeocentricGeographicConversion (IGeographicCRS sourceCRS, IGeocentricCRS targetCRS) : base (sourceCRS, targetCRS, ParameterGroup.Empty)
        {
            if (!sourceCRS.Datum.Ellipsoid.Equals (targetCRS.Datum.Ellipsoid))
            {
                throw new ArgumentException ("Not equals Ellipsoids");
            }
            ellipsoid = sourceCRS.Datum.Ellipsoid;
        }

        #region IConversion Members

        public override string ExportToWKT ()
        {
            throw new NotImplementedException ();
        }

        #endregion

        public override sealed IMathTransform Inverse ()
        {
            if (inverseGeocentricGeographicConversion == null)
            {
                inverseGeocentricGeographicConversion = new GeocentricGeographicConversion {ellipsoid = ellipsoid, IsInverse = true};

                //  InitializeAliases ();
                if (inverseGeocentricGeographicConversion.ellipsoid != null)
                {
                    InitializeConstants ();
                }
            }
            return inverseGeocentricGeographicConversion;
        }

        public override IParameterValueGroup CreateParameters ()
        {
            return ParameterGroup.Empty;
        }

        public override ICoordinate Transform (ICoordinate point)
        {
            return IsInverse ? ToGeographic (point) : ToGeocentric (new GeographicCoordinate (point));
        }

        public virtual ICoordinate ToGeocentric (GeographicCoordinate geodCoord)
        {
            var result = new Coordinate ();

            var gPoint = new GeographicCoordinate (MathUtil.DegToRad (geodCoord.Lon), MathUtil.DegToRad (geodCoord.Lat), geodCoord.EllipsoidalH);
            var v = ellipsoid.SemiMajorAxis / (Math.Pow (1.0 - ellipsoid.EccentricitySquared * Math.Pow (Math.Sin (gPoint.Lat), 2.0), 0.5));
            result.X = (v + gPoint.EllipsoidalH) * Math.Cos (gPoint.Lat) * Math.Cos (gPoint.Lon);
            result.Y = (v + gPoint.EllipsoidalH) * Math.Cos (gPoint.Lat) * Math.Sin (gPoint.Lon);
            result.Z = ((1.0 - ellipsoid.EccentricitySquared) * v + gPoint.EllipsoidalH) * Math.Sin (gPoint.Lat);

            return result;
        }

        public virtual GeographicCoordinate ToGeographic (ICoordinate coord)
        {
            var result = new GeographicCoordinate ();

            var ee = ellipsoid.EccentricitySquared / (1.0 - ellipsoid.EccentricitySquared);
            var p = Math.Pow (Math.Pow (coord.X, 2.0) + Math.Pow (coord.Y, 2.0), 0.5);
            var q = Math.Atan ((coord.Z * ellipsoid.SemiMajorAxis) / (p * ellipsoid.SemiMinorAxis));

            var lat1 = (coord.Z + ee * ellipsoid.SemiMinorAxis * Math.Pow (Math.Sin (q), 3.0));
            var lat2 = (p - ellipsoid.EccentricitySquared * ellipsoid.SemiMajorAxis * Math.Pow (Math.Cos (q), 3.0));
            var lat = Math.Atan (lat1 / lat2);

            var v = ellipsoid.SemiMajorAxis / (Math.Pow (1.0 - ellipsoid.EccentricitySquared * Math.Pow (Math.Sin (lat), 2.0), 0.5));

            result.Lon = MathUtil.Rad2Deg (Math.Atan (coord.Y / coord.X));
            result.Lat = MathUtil.Rad2Deg (lat);
            result.EllipsoidalH = (p / Math.Cos (lat)) - v;

            return result;
        }
    }
}