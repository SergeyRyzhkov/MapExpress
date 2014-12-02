using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class CassiniSoldner : Projection
    {
        private double e0;
        private double e1;
        private double e2;
        private double e3;
        private double ml0;

        public CassiniSoldner (ProjectionParameters parameters) : base (parameters)
        {
            Name = "Cassini Soldner";
        }

        public CassiniSoldner (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
            if (!IsSpherical)
            {
                var es = Parameters.Ellipsoid.EccentricitySquared;
                e0 = E0Fn (es);
                e1 = E1Fn (es);
                e2 = E2Fn (es);
                e3 = E3Fn (es);
                ml0 = Parameters.SemiMajor * Mlfn (e0, e1, e2, e3, (MathUtil.DegToRad (Parameters.LatitudeOfOrigin)));
            }
        }


        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            double x, y;
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);

            var lam = lonRad;
            var phi = latRad;
            lam = AdjustLon (lam - MathUtil.DegToRad (Parameters.CentralMeridian));

            if (IsSpherical)
            {
                x = Parameters.SemiMajor * Math.Asin (Math.Cos (phi) * Math.Sin (lam));
                y = Parameters.SemiMajor * (Math.Atan2 (Math.Tan (phi), Math.Cos (lam)) - MathUtil.DegToRad (Parameters.LatitudeOfOrigin));
            }
            else
            {
                var sinphi = Math.Sin (phi);
                var cosphi = Math.Cos (phi);
                var nl = GN (Parameters.SemiMajor, Parameters.Ellipsoid.Eccentricity, sinphi);
                var tl = Math.Tan (phi) * Math.Tan (phi);
                var al = lam * Math.Cos (phi);
                var asq = al * al;
                var cl = Parameters.Ellipsoid.EccentricitySquared * cosphi * cosphi / (1 - Parameters.Ellipsoid.EccentricitySquared);
                var ml = Parameters.SemiMajor * Mlfn (e0, e1, e2, e3, phi);
                x = nl * al * (1 - asq * tl * (1 / 6 - (8 - tl + 8 * cl) * asq / 120));
                y = ml - ml0 + nl * sinphi / cosphi * asq * (0.5 + (5 - tl + 6 * cl) * asq / 24);
            }
            x = x + Parameters.FalseEasting;
            y = y + Parameters.FalseNorthing;
            return new Coordinate (x, y);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var px = projectedCordinate.X - Parameters.FalseEasting;
            var py = projectedCordinate.Y - Parameters.FalseNorthing;
            var x = px / Parameters.SemiMajor;
            var y = py / Parameters.SemiMajor;
            double phi, lam;
            if (IsSpherical)
            {
                var dd = y + MathUtil.DegToRad (Parameters.LatitudeOfOrigin);
                phi = Math.Asin (Math.Sin (dd) * Math.Cos (x));
                lam = Math.Atan2 (Math.Tan (x), Math.Cos (dd));
            }
            else
            {
                var ml1 = ml0 / Parameters.SemiMajor + y;
                var phi1 = Imlfn (ml1, e0, e1, e2, e3);
                if (Math.Abs (Math.Abs (phi1) - MathUtil.PiHalf) <= EPSLN)
                {
                    px = MathUtil.DegToRad (Parameters.CentralMeridian);
                    py = MathUtil.PiHalf;
                    if (y < 0)
                    {
                        py *= -1;
                    }
                    return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
                }
                var nl1 = GN (Parameters.SemiMajor, Parameters.Ellipsoid.Eccentricity, Math.Sin (phi1));

                var rl1 = nl1 * nl1 * nl1 / Parameters.SemiMajor / Parameters.SemiMajor * (1 - Parameters.Ellipsoid.EccentricitySquared);
                var tl1 = Math.Pow (Math.Tan (phi1), 2);
                var dl = x * Parameters.SemiMajor / nl1;
                var dsq = dl * dl;
                phi = phi1 - nl1 * Math.Tan (phi1) / rl1 * dl * dl * (0.5 - (1 + 3 * tl1) * dl * dl / 24);
                lam = dl * (1 - dsq * (tl1 / 3 + (1 + 3 * tl1) * tl1 * dsq / 15)) / Math.Cos (phi1);
            }
            px = AdjustLon (lam + MathUtil.DegToRad (Parameters.CentralMeridian));
            py = AdjustLon (phi);
            return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
        }
    }
}