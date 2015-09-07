#region

using System;

#endregion

namespace MapExpress.CoreGIS.OGS.Tms.CoordSys
{
    public class SphericalMercatorTileMath : TileMath
    {
        private const double initialResolution = 2 * Math.PI * 6378137.0 / 256.0;
        private const double originShift = 2 * Math.PI * 6378137 / 2.0;

        public override Coordinate ProjectedPointToPixelPoint (double x, double y, int level)
        {
            var res = Resolution (level);

            var point = new Coordinate
                            {
                                X = (x + originShift) / res,
                                Y = (y + originShift) / res
                            };
            return point;
        }

        public override Coordinate PixelPointToProjectedPoint (long x, long y, int level)
        {
            var res = Resolution (level);
            var met = new Coordinate
                          {
                              X = x * res - originShift,
                              Y = y * res - originShift
                          };
            return met;
        }

        public override double Resolution (int level)
        {
            return initialResolution / (MapSize (level));
        }
    }
}