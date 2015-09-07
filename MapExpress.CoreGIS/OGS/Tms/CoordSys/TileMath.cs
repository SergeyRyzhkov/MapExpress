#region

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace MapExpress.CoreGIS.OGS.Tms.CoordSys
{
Надо проверить все методы на TMS и на OSM схему
    public abstract class TileMath
    {
        public abstract Coordinate ProjectedPointToPixelPoint (double x, double y, int level);

        public abstract Coordinate PixelPointToProjectedPoint (long x, long y, int level);

        public abstract double Resolution (int level);

        public Coordinate ToOsmPixelPoint (Coordinate tsmPixelPoint, int level)
        {
            return new Coordinate (tsmPixelPoint.X, MapSize (level) - tsmPixelPoint.Y);
        }

        public Coordinate ToTmsPixelPoint (Coordinate osmPixelPoint, int level)
        {
            return new Coordinate (osmPixelPoint.X, MapSize (level) - osmPixelPoint.Y);
        }

        public virtual TileIndex PixelPointToTile (double x, double y, int level)
        {
            return new TileIndex ((Int32)Math.Ceiling (x / 256.0) - 1, (Int32)Math.Ceiling (y / 256.0) - 1, level);
        }

        
        public virtual BoundingBox TileBounds (TileIndex tile)
        {
            var point1 = PixelPointToProjectedPoint (tile.X * 256, tile.Y * 256, tile.Level);
            var point2 = PixelPointToProjectedPoint (tile.X * 256 + 256, tile.Y * 256 + 256, tile.Level);
            return new BoundingBox (point1.X, point1.Y, point2.X, point2.Y);
        }


        public virtual long TilesCount (double projectedMinX, double projectedMinY, double projectedMaxX, double projectedMaxY, int level)
        {
            var minTile = GetTileAtProjectedMapPoint (projectedMinX, projectedMaxY, level);
            var maxTile = GetTileAtProjectedMapPoint (projectedMaxX, projectedMinY, level);
            
            var xCount = (maxTile.X - minTile.X) + 1;
            var yCount = (maxTile.Y - minTile.Y) + 1;
            return xCount * yCount;
        }


        public virtual long TilesCount (BoundingBox projectedMapExtent, int level)
        {
            return TilesCount (projectedMapExtent.BottomLeft.X, projectedMapExtent.BottomLeft.Y, projectedMapExtent.TopRight.X, projectedMapExtent.TopRight.Y, level);
        }

        public virtual TileIndex GetTileAtProjectedMapPoint (double projectedX, double projectedY, int level)
        {
            var tilePixelPoint = ProjectedPointToPixelPoint (projectedX, projectedY, level);
            return PixelPointToTile (tilePixelPoint.X, tilePixelPoint.Y, level);
        }


        public virtual List<TileIndex> GetTilesInView (double projectedMinX, double projectedMinY, double projectedMaxX, double projectedMaxY, int level)
        {
            var list = new List <TileIndex> ();

            var minTile = GetTileAtProjectedMapPoint (projectedMinX, projectedMinY, level);
            var maxTile = GetTileAtProjectedMapPoint (projectedMaxX, projectedMaxY, level);

            for (var y = minTile.Y; y <= maxTile.Y; y++)
            {
                for (var x = minTile.X; x <= maxTile.X; x++)
                {
                    var iterTile = new TileIndex (x, y, level);
                    list.Add (iterTile);
                }
            }
            return list;
        }


        public virtual List <TileIndex> GetTilesInView (BoundingBox projectedMapExtent, int level)
        {
            return GetTilesInView (projectedMapExtent.BottomLeft.X, projectedMapExtent.BottomLeft.Y, projectedMapExtent.TopRight.X, projectedMapExtent.TopRight.Y, level);
        }


        public virtual uint MapSize (int level)
        {
            return (uint) 256 << level;
        }


        protected double Clip (double n, double minValue, double maxValue)
        {
            return Math.Min (Math.Max (n, minValue), maxValue);
        }


        public static string TileXYToQuadKey (TileIndex tile)
        {
            return TileXYToQuadKey (tile.X, tile.Y, tile.Level);
        }


        public static TileIndex QuadKeyToTileXY (string quadKey)
        {
            var tileX = 0;
            var tileY = 0;
            var zoom = quadKey.Length;
            for (var i = zoom; i > 0; i--)
            {
                var mask = 1 << (i - 1);
                switch (quadKey [zoom - i])
                {
                    case '0':
                        break;

                    case '1':
                        tileX |= mask;
                        break;

                    case '2':
                        tileY |= mask;
                        break;

                    case '3':
                        tileX |= mask;
                        tileY |= mask;
                        break;

                    default:
                        throw new ArgumentException ("Invalid QuadKey digit sequence.");
                }
            }
            return new TileIndex (tileX, tileY, zoom);
        }

        public static string TileXYToQuadKey (int tileX, int tileY, int zoom)
        {
            var quadKey = new StringBuilder ();
            for (var i = zoom; i > 0; i--)
            {
                var digit = '0';
                var mask = 1 << (i - 1);
                if ((tileX & mask) != 0)
                {
                    digit++;
                }
                if ((tileY & mask) != 0)
                {
                    digit++;
                    digit++;
                }
                quadKey.Append (digit);
            }
            return quadKey.ToString ();
        }
    }
}