#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    // TODO: Везде проверить в формулах FalseEasting  и т.д
    public class Gauss : Projection
    {
        private double c;
        private double k;
        private double phic0;
        private double ratexp;

        public Gauss (ProjectionParameters parameters) : base (parameters)
        {
        }

        public Gauss (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
            var lat0 = MathUtil.DegToRad (Parameters.LatitudeOfOrigin);
            var es = Parameters.Ellipsoid.EccentricitySquared;
            var sphi = Math.Sin (lat0);
            var cphi = Math.Cos (lat0);
            cphi *= cphi;
            c = Math.Sqrt (1 + es * cphi * cphi / (1 - es));
            phic0 = Math.Asin (sphi / c);
            ratexp = 0.5 * c * Parameters.Ellipsoid.Eccentricity;
            k = Math.Tan (0.5 * phic0 + Math.PI / 4) / (Math.Pow (Math.Tan (0.5 * lat0 + Math.PI / 4), c) * Srat (Parameters.Ellipsoid.Eccentricity * sphi, ratexp));
        }

        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var lon = MathUtil.DegToRad (geographCoordinate.X);
            var lat = MathUtil.DegToRad (geographCoordinate.Y);
            var py = 2 * Math.Atan (k * Math.Pow (Math.Tan (0.5 * lat + Math.PI / 4), c) * Srat (Parameters.Ellipsoid.Eccentricity * Math.Sin (lat), ratexp)) - Math.PI / 2;
            var px = c * lon;
            return new Coordinate (px, py);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            const double delTol = 1e-14;
            var lon = projectedCordinate.X / c;
            var lat = projectedCordinate.Y;
            var py = projectedCordinate.Y;
            var num = Math.Pow (Math.Tan (0.5 * lat + Math.PI / 4) / k, 1 / c);
            for (var i = 20; i > 0; --i)
            {
                lat = 2 * Math.Atan (num * Srat (Parameters.Ellipsoid.Eccentricity * Math.Sin (py), -0.5 * Parameters.Ellipsoid.Eccentricity)) - Math.PI / 2;
                if (Math.Abs (lat - py) < delTol)
                {
                    break;
                }
                py = lat;
            }

            var px = lon;
            py = lat;
            return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
        }
    }
}