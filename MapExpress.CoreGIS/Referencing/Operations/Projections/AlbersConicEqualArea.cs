#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class AlbersConicEqualArea : Projection
    {
        private double c;
        private double e3;
        private double ns0;
        private double rh;

        public AlbersConicEqualArea (ProjectionParameters parameters) : base (parameters)
        {
            Name = "Albers Conic Equal Area";
        }

        public AlbersConicEqualArea (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }

        public override void InitializeConstants ()
        {
            var temp = Parameters.SemiMinor / Parameters.SemiMajor;
            var es = 1 - Math.Pow (temp, 2);
            e3 = Math.Sqrt (es);
            var sinPo = Math.Sin (MathUtil.DegToRad (Parameters.StandardParallel1));
            var cosPo = Math.Cos (MathUtil.DegToRad (Parameters.StandardParallel1));
            var con = sinPo;
            var ms1 = Msfnz (e3, sinPo, cosPo);
            var qs1 = Qsfnz (e3, sinPo);
            sinPo = Math.Sin (MathUtil.DegToRad (Parameters.StandardParallel2));
            cosPo = Math.Cos (MathUtil.DegToRad (Parameters.StandardParallel2));
            var ms2 = Msfnz (e3, sinPo, cosPo);
            var qs2 = Qsfnz (e3, sinPo);
            sinPo = Math.Sin (Parameters.LatitudeOfOrigin);
            var qs0 = Qsfnz (e3, sinPo);
            if (Math.Abs (Parameters.StandardParallel1 - Parameters.StandardParallel2) > Double.Epsilon)
            {
                ns0 = (ms1 * ms1 - ms2 * ms2) / (qs2 - qs1);
            }
            else
            {
                ns0 = con;
            }
            c = ms1 * ms1 + ns0 * qs1;
            rh = Parameters.SemiMajor * Math.Sqrt (c - ns0 * qs0) / ns0;
        }

        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);
            var sinPhi = Math.Sin (latRad);
            var qs = Qsfnz (e3, sinPhi);
            var rh1 = Parameters.SemiMajor * Math.Sqrt (c - ns0 * qs) / ns0;
            var theta = ns0 * AdjustLon (lonRad - MathUtil.DegToRad (Parameters.CentralMeridian));
            var x = rh1 * Math.Sin (theta) + Parameters.FalseEasting;
            var y = rh - rh1 * Math.Cos (theta) + Parameters.FalseNorthing;
            return new Coordinate (x, y);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double rh1;
            double con, lat;
            var px = projectedCordinate.X - Parameters.FalseEasting;
            var py = rh - projectedCordinate.Y + Parameters.FalseNorthing;
            if (ns0 >= 0)
            {
                rh1 = Math.Sqrt (px * px + py * py);
                con = 1;
            }
            else
            {
                rh1 = -Math.Sqrt (px * px + py * py);
                con = -1;
            }
            double theta = 0;
            if (Math.Abs (rh1 - 0) > Double.Epsilon)
            {
                theta = Math.Atan2 (con * px, con * py);
            }
            con = rh1 * ns0 / Parameters.SemiMajor;
            if (IsSpherical)
            {
                lat = Math.Asin ((c - con * con) / (2 * ns0));
            }
            else
            {
                var qs = (c - con * con) / ns0;
                lat = Phi1Z (e3, qs);
            }
            var lon = AdjustLon (theta / ns0 + MathUtil.DegToRad (Parameters.CentralMeridian));
            return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
        }

        private static double Phi1Z (double eccent, double qs)
        {
            var phi = Asinz (0.5 * qs);
            if (eccent < EPSLN)
            {
                return phi;
            }
            var eccnts = eccent * eccent;
            for (var i = 1; i <= 25; i++)
            {
                var sinphi = Math.Sin (phi);
                var cosphi = Math.Cos (phi);
                var con = eccent * sinphi;
                var com = 1 - con * con;
                var dphi = 0.5 * com * com / cosphi * (qs / (1 - eccnts) - sinphi / com + 0.5 / eccent * Math.Log ((1 - con) / (1 + con)));
                phi = phi + dphi;
                if (Math.Abs (dphi) <= 1e-7)
                {
                    return phi;
                }
            }
            return Double.NaN;
        }
    }
}