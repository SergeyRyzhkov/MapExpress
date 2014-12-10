using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class Mollweide : Projection
    {
        public Mollweide (ProjectionParameters parameters) : base (parameters)
        {
        }

        public Mollweide (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
        }


        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);
            var deltaLon = AdjustLon (lonRad - MathUtil.DegToRad (Parameters.CentralMeridian));
            var theta = latRad;
            var con = Math.PI * Math.Sin (latRad);
            for (var i = 0;; i++)
            {
                var deltaTheta = -(theta + Math.Sin (theta) - con) / (1 + Math.Cos (theta));
                theta += deltaTheta;
                if (Math.Abs (deltaTheta) < EPSLN)
                {
                    break;
                }
            }
            theta /= 2;
            if (Math.PI / 2 - Math.Abs (latRad) < EPSLN)
            {
                deltaLon = 0;
            }
            var x = 0.900316316158 * Parameters.Ellipsoid.SemiMajorAxis * deltaLon * Math.Cos (theta) + Parameters.FalseEasting;
            var y = 1.4142135623731 * Parameters.Ellipsoid.SemiMajorAxis * Math.Sin (theta) + Parameters.FalseNorthing;
            return new Coordinate (x, y);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double px = projectedCordinate.X - Parameters.FalseEasting;
            double py = projectedCordinate.Y - Parameters.FalseNorthing;
            double arg = py / (1.4142135623731 * Parameters.Ellipsoid.SemiMajorAxis);
            if (Math.Abs (arg) > 0.999999999999)
            {
                arg = 0.999999999999;
            }
            var theta = Math.Asin (arg);
            var lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + (px / (0.900316316158 * Parameters.Ellipsoid.SemiMajorAxis * Math.Cos (theta))));
            if (lon < (-Math.PI))
            {
                lon = -Math.PI;
            }
            if (lon > Math.PI)
            {
                lon = Math.PI;
            }
            arg = (2 * theta + Math.Sin (2 * theta)) / Math.PI;
            if (Math.Abs (arg) > 1)
            {
                arg = 1;
            }
            var lat = Math.Asin (arg);

            px = lon;
            py = lat;
            return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
        }
    }
}