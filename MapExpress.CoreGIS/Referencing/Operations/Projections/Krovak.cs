#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class Krovak : Projection
    {
        private double ad;
        private double alfa;
        private double e;
        private double k;
        private double long0;
        private double n;
        private double ro0;
        private double s0;
        private double s45;

        public Krovak (ProjectionParameters parameters) : base (parameters)
        {
            Name = "Krovak";
        }

        public Krovak (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
            const double a = 6377397.155;
            const double es = 0.006674372230614;
            e = Math.Sqrt (es);

            var lat0 = MathUtil.DegToRad (Parameters.LatitudeOfOrigin);
            long0 = MathUtil.DegToRad (Parameters.CentralMeridian);
            var k0 = Parameters.ScaleFactor;

            if (lat0 == 0)
            {
                lat0 = 0.863937979737193;
            }
            if (long0 == 0)
            {
                long0 = 0.7417649320975901 - 0.308341501185665;
            }
            if (k0 == 0)
            {
                k0 = 0.9999;
            }
            s45 = 0.785398163397448; /* 45 */
            var s90 = 2 * s45;
            var fi0 = lat0;
            const double e2 = es;
            e = Math.Sqrt (e2);
            alfa = Math.Sqrt (1 + (e2 * Math.Pow (Math.Cos (fi0), 4)) / (1 - e2));
            const double uq = 1.04216856380474;
            var u0 = Math.Asin (Math.Sin (fi0) / alfa);
            var g = Math.Pow ((1 + e * Math.Sin (fi0)) / (1 - e * Math.Sin (fi0)), alfa * e / 2);
            k = Math.Tan (u0 / 2 + s45) / Math.Pow (Math.Tan (fi0 / 2 + s45), alfa) * g;
            var k1 = k0;
            var n0 = a * Math.Sqrt (1 - e2) / (1 - e2 * Math.Pow (Math.Sin (fi0), 2));
            s0 = 1.37008346281555;
            n = Math.Sin (s0);
            ro0 = k1 * n0 / Math.Tan (s0);
            ad = s90 - uq;
        }

        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);
            var deltaLon = AdjustLon (lonRad - long0);
            var gfi = Math.Pow (((1 + e * Math.Sin (latRad)) / (1 - e * Math.Sin (latRad))), (alfa * e / 2));
            var u = 2 * (Math.Atan (k * Math.Pow (Math.Tan (latRad / 2 + s45), alfa) / gfi) - s45);
            var deltav = -deltaLon * alfa;
            var s = Math.Asin (Math.Cos (ad) * Math.Sin (u) + Math.Sin (ad) * Math.Cos (u) * Math.Cos (deltav));
            var d = Math.Asin (Math.Cos (u) * Math.Sin (deltav) / Math.Cos (s));
            var eps = n * d;
            var ro = ro0 * Math.Pow (Math.Tan (s0 / 2 + s45), n) / Math.Pow (Math.Tan (s / 2 + s45), n);
            var py = ro * Math.Cos (eps) / 1;
            var px = ro * Math.Sin (eps) / 1;

            py *= -1;
            px *= -1;
            return new Coordinate (px, py);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var px = projectedCordinate.X;
            var py = projectedCordinate.Y;

            var tmp = px;
            px = py;
            py = tmp;
            py *= -1;
            px *= -1;
            var ro = Math.Sqrt (px * px + py * py);
            var eps = Math.Atan2 (py, px);
            var d = eps / Math.Sin (s0);
            var s = 2 * (Math.Atan (Math.Pow (ro0 / ro, 1 / n) * Math.Tan (s0 / 2 + s45)) - s45);
            var u = Math.Asin (Math.Cos (ad) * Math.Sin (s) - Math.Sin (ad) * Math.Cos (s) * Math.Cos (d));
            var deltav = Math.Asin (Math.Cos (s) * Math.Sin (d) / Math.Cos (u));
            px = long0 - deltav / alfa;
            var fi1 = u;
            double ok = 0;
            var iter = 0;
            do
            {
                py = 2 * (Math.Atan (Math.Pow (k, - 1 / alfa) * Math.Pow (Math.Tan (u / 2 + s45), 1 / alfa) * Math.Pow ((1 + e * Math.Sin (fi1)) / (1 - e * Math.Sin (fi1)), e / 2)) - s45);
                if (Math.Abs (fi1 - py) < 0.000000000000001)
                {
                    ok = 1;
                }
                fi1 = py;
                iter += 1;
            } while (ok == 0 && iter < 25);
            if (iter >= 15)
            {
                return GeographicCoordinate.Empty;
            }

            return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
        }
    }
}