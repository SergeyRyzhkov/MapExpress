using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class Eckert3 : Projection
    {
        public Eckert3 (ProjectionParameters parameters) : base (parameters)
        {
        }

        public Eckert3 (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var lpphi = MathUtil.DegToRad (geographCoordinate.Y);
            var lplam = MathUtil.DegToRad (geographCoordinate.X);
            var y = .84447640063154240298 * lpphi;
            var x = .42223820031577120149 * lplam * (1.0 + Math.Sqrt (1.0 - 0.4052847345693510857755 * lpphi * lpphi));
            return new Coordinate (x, y);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var phi = projectedCordinate.Y / .84447640063154240298;
            var lam = projectedCordinate.X / (.42223820031577120149 * (1.0 + Math.Sqrt (1.0 - 0.4052847345693510857755 * phi * phi)));
            return new GeographicCoordinate (MathUtil.Rad2Deg (lam), MathUtil.Rad2Deg (phi));
        }
    }
}