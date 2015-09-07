#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    // TODO: Во всех Eckert что-то не учитывается смещение
    public class Eckert4 : Projection
    {
        private const double Cx = 0.42223820031577120149;
        private const double Cy = 1.32650042817700232218;
        private const double Cp = 3.57079632679489661922;
        private const double Eps = 1e-7;
        private const int Niter = 6;

        public Eckert4 (ProjectionParameters parameters) : base (parameters)
        {
        }

        public Eckert4 (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var xy = new Coordinate ();
            var lpphi = MathUtil.DegToRad (geographCoordinate.Y);
            var lplam = MathUtil.DegToRad (geographCoordinate.X);
            int i;

            var p = Cp * Math.Sin (lpphi);
            var v = lpphi * lpphi;
            lpphi *= 0.895168 + v * (0.0218849 + v * 0.00826809);
            for (i = Niter; i > 0; --i)
            {
                var c = Math.Cos (lpphi);
                var s = Math.Sin (lpphi);
                lpphi -= v = (lpphi + s * (c + 2.0) - p) /
                             (1.0 + c * (c + 2.0) - s * s);
                if (Math.Abs (v) < Eps)
                    break;
            }
            if (i == 0)
            {
                xy.X = Cx * lplam;
                xy.Y = lpphi < 0.0 ? -Cy : Cy;
            }
            else
            {
                xy.X = Cx * lplam * (1.0 + Math.Cos (lpphi));
                xy.Y = Cy * Math.Sin (lpphi);
            }
            return xy;
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double c;
            var lpY = Math.Asin (projectedCordinate.Y / Cy);
            var lpX = projectedCordinate.X / (Cx * (1.0 + (c = Math.Cos (lpY))));
            lpY = Math.Asin ((lpY + Math.Sin (lpY) * (c + 2.0)) / Cp);
            return new GeographicCoordinate (MathUtil.Rad2Deg (lpX), MathUtil.Rad2Deg (lpY));
        }
    }
}