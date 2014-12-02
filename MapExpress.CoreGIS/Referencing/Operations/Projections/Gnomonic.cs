using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class Gnomonic : Projection
    {
        private double cosp14;
        private double infinitydist;
        private int rc;
        private double sinp14;

        public Gnomonic (ProjectionParameters parameters) : base (parameters)
        {
            Name = "Gnomonic";
        }

        public Gnomonic (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
            sinp14 = Math.Sin (MathUtil.DegToRad (Parameters.LatitudeOfOrigin));
            cosp14 = Math.Cos (MathUtil.DegToRad (Parameters.LatitudeOfOrigin));
            infinitydist = 1000 * Parameters.SemiMajor;
            rc = 1;
        }

        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            double x, y;
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);
            var dlon = AdjustLon (lonRad - MathUtil.DegToRad (Parameters.CentralMeridian));
            var sinphi = Math.Sin (latRad);
            var cosphi = Math.Cos (latRad);
            var coslon = Math.Cos (dlon);
            var g = sinp14 * sinphi + cosp14 * cosphi * coslon;
            double ksp = 1.0;
            if ((g > 0) || (Math.Abs (g) <= EPSLN))
            {
                x = Parameters.FalseEasting + Parameters.SemiMajor * ksp * cosphi * Math.Sin (dlon) / g;
                y = Parameters.FalseNorthing + Parameters.SemiMajor * ksp * (cosp14 * sinphi - sinp14 * cosphi * coslon) / g;
            }
            else
            {
                x = Parameters.FalseEasting + infinitydist * cosphi * Math.Sin (dlon);
                y = Parameters.FalseNorthing + infinitydist * (cosp14 * sinphi - sinp14 * cosphi * coslon);
            }
            return new Coordinate (x, y);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var sphi = Math.Sin (MathUtil.DegToRad (Parameters.LatitudeOfOrigin));
            var cphi = Math.Cos (MathUtil.DegToRad (Parameters.LatitudeOfOrigin));
            cphi *= cphi;
            var c1 = Math.Sqrt (1 + Parameters.Ellipsoid.EccentricitySquared * cphi * cphi / (1 - Parameters.Ellipsoid.EccentricitySquared));
            var phic0 = Math.Asin (sphi / c1);

            var px = (projectedCordinate.X - Parameters.FalseEasting) / Parameters.SemiMajor;
            var py = (projectedCordinate.Y - Parameters.FalseNorthing) / Parameters.SemiMajor;

            double lon;
            double lat;
            var k0 = Parameters.ScaleFactor == 0 ? 1 : Parameters.ScaleFactor;

            px /= k0;
            py /= k0;
            var rh = Math.Sqrt (px * px + py * py);
            if (rh > 0)
            {
                var c = Math.Atan2 (rh, rc);
                var sinc = Math.Sin (c);
                var cosc = Math.Cos (c);

                lat = Asinz (cosc * sinp14 + (py * sinc * cosp14) / rh);
                lon = Math.Atan2 (px * sinc, rh * cosp14 * cosc - py * sinp14 * sinc);
                lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + lon);
            }
            else
            {
                lat = phic0;
                lon = 0;
            }

            return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
        }
    }
}