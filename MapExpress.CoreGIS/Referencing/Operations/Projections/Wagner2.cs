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


        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var lon = MathUtil.DegToRad (geographCoordinate.X);
            var lat = MathUtil.DegToRad (geographCoordinate.Y);
            lat = Parameters.FalseNorthing + Math.Asin (C_p1 * Math.Sin (C_p2 * lat));
            var px = Parameters.FalseEasting + C_x * lon * Math.Cos (lat);
            var py = C_y * lat;
            return new Coordinate (px, py);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var xyx = projectedCordinate.X - Parameters.FalseEasting;
            var xyy = projectedCordinate.Y - Parameters.FalseNorthing;

            var lat = xyy / C_y;
            var lon = xyx / (C_x * Math.Cos (lat));
            lat = Math.Asin (Math.Sin (lat) / C_p1) / C_p2;

            return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
        }
    }
}