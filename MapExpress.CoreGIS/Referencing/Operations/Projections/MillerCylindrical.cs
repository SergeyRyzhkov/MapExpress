using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class MillerCylindrical : Projection
    {
        public MillerCylindrical (ProjectionParameters parameters) : base (parameters)
        {
            Name = "Miller Cylindrical";
        }

        public MillerCylindrical (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
        }

        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);
            var dlon = AdjustLon (lonRad - MathUtil.DegToRad (Parameters.CentralMeridian));
            var x = Parameters.FalseEasting + Parameters.SemiMajor * dlon;
            var y = Parameters.FalseNorthing + Parameters.SemiMajor * Math.Log (Math.Tan ((Math.PI / 4) + (latRad / 2.5))) * 1.25;

            return new Coordinate (x, y);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var px = projectedCordinate.X - Parameters.FalseEasting;
            var py = projectedCordinate.Y - Parameters.FalseNorthing;
            var lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + px / Parameters.SemiMajor);
            var lat = 2.5 * (Math.Atan (Math.Exp (0.8 * py / Parameters.SemiMajor)) - Math.PI / 4);
            return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
        }
    }
}