using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class LambertCylindricalEqualArea : Projection
    {
        private double k0;

        public LambertCylindricalEqualArea (ProjectionParameters parameters) : base (parameters)
        {
            Name = "Lambert Cylindrical Equal Area";
        }

        public LambertCylindricalEqualArea (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
            if (!IsSpherical)
            {
                k0 = Msfnz (Parameters.Ellipsoid.Eccentricity, Math.Sin (MathUtil.DegToRad (Parameters.StandardParallel1)), Math.Cos (MathUtil.DegToRad (Parameters.StandardParallel1)));
            }
        }

        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            double x, y;
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);
            var dlon = AdjustLon (lonRad - MathUtil.DegToRad (Parameters.CentralMeridian));
            if (IsSpherical)
            {
                x = Parameters.FalseEasting + Parameters.SemiMajor * dlon * Math.Cos (MathUtil.DegToRad (Parameters.StandardParallel1));
                y = Parameters.FalseNorthing + Parameters.SemiMajor * Math.Sin (latRad) / Math.Cos (MathUtil.DegToRad (Parameters.StandardParallel1));
            }
            else
            {
                var qs = Qsfnz (Parameters.Ellipsoid.Eccentricity, Math.Sin (latRad));
                x = Parameters.FalseEasting + Parameters.SemiMajor * k0 * dlon;
                y = Parameters.FalseNorthing + Parameters.SemiMajor * qs * 0.5 / k0;
            }
            return new Coordinate (x, y);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double lon;
            double lat;
            var px = projectedCordinate.X - Parameters.FalseEasting;
            var py = projectedCordinate.Y - Parameters.FalseNorthing;
            if (IsSpherical)
            {
                lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + (px / Parameters.SemiMajor) / Math.Cos (MathUtil.DegToRad (Parameters.StandardParallel1)));
                lat = Math.Asin ((py / Parameters.SemiMajor) * Math.Cos (MathUtil.DegToRad (Parameters.StandardParallel1)));
            }
            else
            {
                lat = Iqsfnz (Parameters.Ellipsoid.Eccentricity, 2 * py * k0 / Parameters.SemiMajor);
                lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + px / (Parameters.SemiMajor * k0));
            }
            return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
        }
    }
}