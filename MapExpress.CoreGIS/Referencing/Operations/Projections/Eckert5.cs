#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class Eckert5 : Projection
    {
        private const double XF = 0.44101277172455148219;
        private const double RXF = 2.26750802723822639137;
        private const double YF = 0.88202554344910296438;
        private const double RYF = 1.13375401361911319568;

        public Eckert5 (ProjectionParameters parameters) : base (parameters)
        {
        }

        public Eckert5 (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var xy = new Coordinate ();
            var lpphi = MathUtil.DegToRad (geographCoordinate.Y);
            var lplam = MathUtil.DegToRad (geographCoordinate.X);
            xy.X = XF * (1.0 + Math.Cos (lpphi)) * lplam;
            xy.Y = YF * lpphi;
            return xy;
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double lpY;
            var lpX = RXF * projectedCordinate.X / (1.0 + Math.Cos (lpY = RYF * projectedCordinate.Y));
            return new GeographicCoordinate (MathUtil.Rad2Deg (lpX), MathUtil.Rad2Deg (lpY));
        }
    }
}