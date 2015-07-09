#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    // TODO :Нет реализации //2 points method см.
    public class ObliqueMercator : Projection
    {
        private double al;
        private double alpha;
        private double bl;
        private double e;
        private double el;
        private double gamma0;
        private double long0;
        private double uc;

        public ObliqueMercator (ProjectionParameters parameters) : base (parameters)
        {
            Name = "Oblique Mercator";
        }

        public ObliqueMercator (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
            var es = Parameters.Ellipsoid.EccentricitySquared;
            e = Parameters.Ellipsoid.Eccentricity;
            alpha = MathUtil.DegToRad (Parameters.Azimuth);
            var longc = MathUtil.DegToRad (Parameters.LongitudeOfCenter);
            var k0 = Parameters.ScaleFactor;
            var sinlat = Math.Sin (MathUtil.DegToRad (Parameters.LatitudeOfCenter));
            var coslat = Math.Cos (MathUtil.DegToRad (Parameters.LatitudeOfCenter));
            var con = e * sinlat;
            bl = Math.Sqrt (1 + es / (1 - es) * Math.Pow (coslat, 4));
            al = Parameters.SemiMajor * bl * k0 * Math.Sqrt (1 - es) / (1 - con * con);
            var t0 = Tsfnz (e, MathUtil.DegToRad (Parameters.LatitudeOfCenter), sinlat);
            var dl = bl / coslat * Math.Sqrt ((1 - es) / (1 - con * con));
            if (dl * dl < 1)
            {
                dl = 1;
            }
            var fl = MathUtil.DegToRad (Parameters.LatitudeOfCenter) >= 0 ? dl + Math.Sqrt (dl * dl - 1) : dl - Math.Sqrt (dl * dl - 1);
            el = fl * Math.Pow (t0, bl);
            var gl = 0.5 * (fl - 1 / fl);
            gamma0 = Math.Asin (Math.Sin (alpha) / dl);
            long0 = longc - Math.Asin (gl * Math.Tan (gamma0)) / bl;
            uc = al / bl * Math.Atan2 (Math.Sqrt (dl * dl - 1), Math.Cos (alpha));
            uc = MathUtil.DegToRad (Parameters.LatitudeOfCenter) >= 0 ? uc : -1 * uc;
        }

        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);

            var dlon = AdjustLon (lonRad - long0);
            double us1, vs;
            if (Math.Abs (Math.Abs (latRad) - MathUtil.PiHalf) <= EPSLN)
            {
                double con = latRad > 0 ? -1 : 1;
                vs = al / bl * Math.Log (Math.Tan (Math.PI / 4 + con * gamma0 * 0.5));
                us1 = -1 * con * MathUtil.PiHalf * al / bl;
            }
            else
            {
                var t = Tsfnz (e, latRad, Math.Sin (latRad));
                var ql = el / Math.Pow (t, bl);
                var sl = 0.5 * (ql - 1 / ql);
                var tl = 0.5 * (ql + 1 / ql);
                var vl = Math.Sin (bl * (dlon));
                var ul = (sl * Math.Sin (gamma0) - vl * Math.Cos (gamma0)) / tl;
                vs = Math.Abs (Math.Abs (ul) - 1) <= EPSLN ? Double.NaN : 0.5 * al * Math.Log ((1 - ul) / (1 + ul)) / bl;
                us1 = Math.Abs (Math.Cos (bl * (dlon))) <= EPSLN ? al * bl * (dlon) : al * Math.Atan2 (sl * Math.Cos (gamma0) + vl * Math.Sin (gamma0), Math.Cos (bl * dlon)) / bl;
            }

            us1 = us1 - uc;
            var x = Parameters.FalseEasting + vs * Math.Cos (alpha) + us1 * Math.Sin (alpha);
            var y = Parameters.FalseNorthing + us1 * Math.Cos (alpha) - vs * Math.Sin (alpha);
            return new Coordinate (x, y);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var px = projectedCordinate.X;
            var py = projectedCordinate.Y;

            var vs = (px - Parameters.FalseEasting) * Math.Cos (alpha) - (py - Parameters.FalseNorthing) * Math.Sin (alpha);
            var us1 = (py - Parameters.FalseNorthing) * Math.Cos (alpha) + (px - Parameters.FalseEasting) * Math.Sin (alpha);
            us1 = us1 + uc;
            var qp = Math.Exp (-1 * bl * vs / al);
            var sp = 0.5 * (qp - 1 / qp);
            var tp = 0.5 * (qp + 1 / qp);
            var vp = Math.Sin (bl * us1 / al);
            var up = (vp * Math.Cos (gamma0) + sp * Math.Sin (gamma0)) / tp;
            var ts = Math.Pow (el / Math.Sqrt ((1 + up) / (1 - up)), 1 / bl);
            if (Math.Abs (up - 1) < EPSLN)
            {
                px = long0;
                py = MathUtil.PiHalf;
            }
            else if (Math.Abs (up + 1) < EPSLN)
            {
                px = long0;
                py = -1 * MathUtil.PiHalf;
            }
            else
            {
                py = Phi2Z (e, ts);
                px = AdjustLon (long0 - Math.Atan2 (sp * Math.Cos (gamma0) - vp * Math.Sin (gamma0), Math.Cos (bl * us1 / al)) / bl);
            }
            return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
        }
    }
}