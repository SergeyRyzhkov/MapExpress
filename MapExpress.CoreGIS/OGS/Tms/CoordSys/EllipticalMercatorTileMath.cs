#region

using System.Drawing;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Referencing.Operations.Projections;
using MapExpress.CoreGIS.Referencing.Registry;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.OGS.Tms.CoordSys
{
    public class EllipticalMercatorTileMath : TileMath
    {
        private const double initialResolution = 2 * System.Math.PI * 6378137.0 / 256.0;
        private static readonly Mercator1SP projection;

        static EllipticalMercatorTileMath ()
        {
            var param = new ProjectionParameters (EllipsoidRegistry.Instance.WGS84) {ScaleFactor = 1};
            projection = new Mercator1SP (param);
            projection.InitializeConstants ();
        }

        public override Coordinate ProjectedPointToPixelPoint (double x, double y, int level)
        {
            var lonLat = projection.Transform (x, y, 0);
            
            var lon = lonLat [0];
            var lat = lonLat [1];
            var rLon = lon * MathUtil.DEG2RAD;
            var rLat = lat * MathUtil.DEG2RAD;
            const double a = 6378137;
            const double k = 0.0818191908426;
            
            var z = System.Math.Tan (System.Math.PI / 4 + rLat / 2) / System.Math.Pow ((System.Math.Tan (System.Math.PI / 4 + System.Math.Asin (k * System.Math.Sin (rLat)) / 2)), k);
            var z1 = System.Math.Pow (2, 23 - level);

            var dx = ((20037508.342789 + a * rLon) * 53.5865938 / z1);
            var dy = ((20037508.342789 - a * System.Math.Log (z)) * 53.5865938 / z1);

            return new Coordinate (dx, dy);
        }

        public override Coordinate PixelPointToProjectedPoint (long x, long y, int level)
        {
            double mapSize = MapSize (level);
            const double a = 6378137.0;
            const double c1 = 0.00335655146887969;
            const double c2 = 0.00000657187271079536;
            const double c3 = 0.00000001764564338702;
            const double c4 = 0.00000000005328478445;

            var mercY = 20037508.342789244 - (y * System.Math.Pow (2, 23 - level)) / 53.5865938;
            var g = System.Math.PI / 2 - 2 * System.Math.Atan (1 / System.Math.Exp (mercY / a));
            var zz = g + c1 * System.Math.Sin (2 * g) + c2 * System.Math.Sin (4 * g) + c3 * System.Math.Sin (6 * g) + c4 * System.Math.Sin (8 * g);
			
            var latitude = zz * 180 / System.Math.PI;
		    var longitude = 360 * ((Clip (x, 0, mapSize - 1) / mapSize) - 0.5);

            var xy = projection.TransformInverse (longitude, latitude, 0);

            return new Coordinate(xy[0],xy[1]);
        }

        public override double Resolution (int level)
        {
            return initialResolution / (MapSize (level));
        }
    }
}