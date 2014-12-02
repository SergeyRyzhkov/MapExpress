using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class ObliqueStereographic : Projection
    {
        private double c;
        private double cosc0;
        private double k1;
        private double phic0;
        private double r2;
        private double ratexp;
        private double sinc0;

        public ObliqueStereographic (ProjectionParameters parameters) : base (parameters)
        {
        }

        public ObliqueStereographic (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
            var lat0 = MathUtil.DegToRad (Parameters.LatitudeOfOrigin);
            var es = Parameters.Ellipsoid.EccentricitySquared;
            var sphi = Math.Sin (lat0);
            var cphi = Math.Cos (lat0);
            cphi *= cphi;
            c = Math.Sqrt (1 + es * cphi * cphi / (1 - es));
            phic0 = Math.Asin (sphi / c);
            var rc = Math.Sqrt (1 - es) / (1 - es * sphi * sphi);
            sinc0 = Math.Sin (phic0);
            cosc0 = Math.Cos (phic0);
            r2 = 2 * rc;
            ratexp = 0.5 * c * Parameters.Ellipsoid.Eccentricity;
            k1 = Math.Tan (0.5 * phic0 + Math.PI / 4) / (Math.Pow (Math.Tan (0.5 * lat0 + Math.PI / 4), c) * Srat (Parameters.Ellipsoid.Eccentricity * sphi, ratexp));
        }

        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var lon = AdjustLon (MathUtil.DegToRad (geographCoordinate.X) - MathUtil.DegToRad (Parameters.CentralMeridian));
            var lat = MathUtil.DegToRad (geographCoordinate.Y);
            var py = 2 * Math.Atan (k1 * Math.Pow (Math.Tan (0.5 * lat + Math.PI / 4), c) * Srat (Parameters.Ellipsoid.Eccentricity * Math.Sin (lat), ratexp)) - Math.PI / 2;
            var px = c * lon;
            var sinc = Math.Sin (py);
            var cosc = Math.Cos (py);
            var cosl = Math.Cos (px);
            var k = Parameters.ScaleFactor * r2 / (1 + sinc0 * sinc + cosc0 * cosc * cosl);
            px = k * cosc * Math.Sin (px);
            py = k * (cosc0 * sinc - sinc0 * cosc * cosl);
            px = Parameters.Ellipsoid.SemiMajorAxis * px + Parameters.FalseEasting;
            py = Parameters.Ellipsoid.SemiMajorAxis * py + Parameters.FalseNorthing;
            return new Coordinate (px, py);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double lon, lat, rho;
            var px = (projectedCordinate.X - Parameters.FalseEasting) / Parameters.Ellipsoid.SemiMajorAxis;
            var py = (projectedCordinate.Y - Parameters.FalseNorthing) / Parameters.Ellipsoid.SemiMajorAxis;
            px = px / Parameters.ScaleFactor;
            py = py / Parameters.ScaleFactor;
            if ((rho = Math.Sqrt (px * px + py * py)) > 0)
            {
                var c1 = 2 * Math.Atan2 (rho, r2);
                var sinc = Math.Sin (c1);
                var cosc = Math.Cos (c1);
                lat = Math.Asin (cosc * sinc0 + py * sinc * cosc0 / rho);
                lon = Math.Atan2 (px * sinc, rho * cosc0 * cosc - py * sinc0 * sinc);
            }
            else
            {
                lat = phic0;
                lon = 0;
            }

            const double delTol = 1e-14;
            double px1 = lon;
            double py1 = lat;

            var lon1 = px1 / c;
            var lat1 = py1;
            var num = Math.Pow (Math.Tan (0.5 * lat1 + Math.PI / 4) / k1, 1 / c);
            for (var i = 20; i > 0; --i)
            {
                lat1 = 2 * Math.Atan (num * Srat (Parameters.Ellipsoid.Eccentricity * Math.Sin (py1), -0.5 * Parameters.Ellipsoid.Eccentricity)) - Math.PI / 2;
                if (Math.Abs (lat - py1) < delTol)
                {
                    break;
                }
                py1 = lat1;
            }

            px = lon1;
            py = lat1;
            px = AdjustLon (px + MathUtil.DegToRad (Parameters.CentralMeridian));
            return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
        }
    }
}