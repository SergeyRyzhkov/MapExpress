using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class Eckert6 : Projection
    {
        private const double n = 2.570796326794896619231321691;
        private const int MaxIter = 8;
        private const double LoopTol = 1e-7;
        private static readonly double Cy = Math.Sqrt ((2) / n);
        private static readonly double Cx = Cy / 2;

        public Eckert6 (ProjectionParameters parameters) : base (parameters)
        {
        }

        public Eckert6 (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var lpphi = MathUtil.DegToRad (geographCoordinate.Y);
            var lplam = MathUtil.DegToRad (geographCoordinate.X);
            int i;
            var k = n * Math.Sin (lpphi);
            for (i = MaxIter; i > 0;)
            {
                var v = (lpphi + Math.Sin (lpphi) - k) / (1 + Math.Cos (lpphi));
                lpphi -= v;
                if (Math.Abs (v) < LoopTol)
                {
                    break;
                }
                --i;
            }
            if (i == 0)
            {
                throw new CoordinateOperationException ("F_ERROR");
            }
            return new Coordinate (Cx * lplam * (1 + Math.Cos (lpphi)), Cy * lpphi);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double xyy = projectedCordinate.Y / Cy;
            double phi = Math.Asin ((xyy + Math.Sin (xyy)) / n);
            double lam = projectedCordinate.X / (Cx * (1 + Math.Cos (xyy)));
            return new GeographicCoordinate (MathUtil.Rad2Deg (lam), MathUtil.Rad2Deg (phi));
        }
    }
}