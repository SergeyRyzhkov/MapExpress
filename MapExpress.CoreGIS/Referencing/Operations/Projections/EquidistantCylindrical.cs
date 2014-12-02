using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class EquidistantCylindrical : Projection
    {
        public EquidistantCylindrical (ProjectionParameters parameters) : base (parameters)
        {
            Name = "Equidistant Cylindrical";
        }

        public EquidistantCylindrical (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters)
            : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);
            var rc = Math.Cos (MathUtil.DegToRad (Parameters.StandardParallel1));
            var dlon = AdjustLon (lonRad - MathUtil.DegToRad (Parameters.CentralMeridian));
            var dlat = AdjustLat (latRad - MathUtil.DegToRad (Parameters.LatitudeOfOrigin));
            var x = Parameters.FalseEasting + (Parameters.SemiMajor * dlon * rc);
            var y = Parameters.FalseNorthing + (Parameters.SemiMajor * dlat);
            return new Coordinate (x, y);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var x = projectedCordinate.X;
            var y = projectedCordinate.Y;
            var rc = Math.Cos (MathUtil.DegToRad (Parameters.StandardParallel1));
            var lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + ((x - Parameters.FalseEasting) / (Parameters.SemiMajor * rc)));
            var lat = AdjustLat (MathUtil.DegToRad (Parameters.LatitudeOfOrigin) + ((y - Parameters.FalseNorthing) / (Parameters.SemiMajor)));
            return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
        }
    }
}