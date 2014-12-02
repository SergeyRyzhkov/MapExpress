using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class Wagner2 : Projection
    {
        private const double C_x = 0.92483;
        private const double C_y = 1.38725;
        private const double C_p1 = 0.88022;
        private const double C_p2 = 0.88550;

        public Wagner2 (ProjectionParameters parameters) : base (parameters)
        {
        }

        public Wagner2 (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var lon = MathUtil.DegToRad (geographCoordinate.X);
            var lat = MathUtil.DegToRad (geographCoordinate.Y);
            lat = Parameters.FalseNorthing + Math.Asin (C_p1 * Math.Sin (C_p2 * lat));
            double px = Parameters.FalseEasting + C_x * lon * Math.Cos (lat);
            double py = C_y * lat;
            return new Coordinate (px, py);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double xyx = projectedCordinate.X - Parameters.FalseEasting;
            double xyy = projectedCordinate.Y - Parameters.FalseNorthing;

            double lat = xyy / C_y;
            double lon = xyx / (C_x * Math.Cos (lat));
            lat = Math.Asin (Math.Sin (lat) / C_p1) / C_p2;

            return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
        }
    }
}