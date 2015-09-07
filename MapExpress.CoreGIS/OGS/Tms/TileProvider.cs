#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapExpress.CoreGIS.OGS.Tms.CoordSys;
using MapExpress.CoreGIS.OGS.Tms.TileSources;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.OGS.Tms
{
    public class TileProvider
    {
        private static readonly SphericalMercatorTileMath defaultTileMath = new SphericalMercatorTileMath ();
        private readonly TileMath tileMath;
        private readonly MemoryTileSource memoryMapTileSource = new MemoryTileSource ();
        private readonly List <ITileSource> tileSources = new List <ITileSource> ();
        private int processedImageCount;
        private int maxDegreeOfParallelism;

        public event TileImageLoadEventHandler TileImageBeforLoad;
        public event TileImageLoadEventHandler TileImageAfterLoad;

        public TileProvider () : this (defaultTileMath, true)
        {
        }

        public TileProvider (TileMath tileMath) : this (tileMath, true)
        {
        }

        private TileProvider (TileMath tileMath, bool useMemoryCache)
        {
            this.tileMath = tileMath;
            if (useMemoryCache)
            {
                tileSources.Add (memoryMapTileSource);
            }
        }

        public TileMath TileMath
        {
            get { return tileMath ?? defaultTileMath; }
        }

        public MemoryTileSource MemoryMapTileSource
        {
            get { return memoryMapTileSource; }
        }

        public void AddTileSource (ITileSource source)
        {
            tileSources.Add (source);
        }


        public void RemoveTileSource (ITileSource source)
        {
            tileSources.Remove (source);
        }

        public int MaxDegreeOfParallelism
        {
            get { return maxDegreeOfParallelism == 0 ? MaxDegreeOfParallelism = Environment.ProcessorCount : maxDegreeOfParallelism; }
            set { maxDegreeOfParallelism = value; }
        }


        public virtual BoundingBox TileBounds (TileIndex tile)
        {
            return tileMath.TileBounds (tile);
        }

        public virtual long TilesCount (double minX, double minY, double maxX, double maxY, int level)
        {
            return tileMath.TilesCount (minX, minY, maxX, maxY, level);
        }


        public virtual long TilesCount (BoundingBox projectedMapExtent, int level)
        {
            return tileMath.TilesCount (projectedMapExtent, level);
        }

        public virtual List <MapTile> GetTilesInView (double projectedMinX, double projectedMinY, double projectedMaxX, double projectedMaxY, int level)
        {
            var result = new List <MapTile> ();

            var tileList = tileMath.GetTilesInView (projectedMinX, projectedMinY, projectedMaxX, projectedMaxY, level);
            if (tileList != null)
            {
                Parallel.For (0, tileList.Count, new ParallelOptions
                                                     {
                                                         MaxDegreeOfParallelism = MaxDegreeOfParallelism
                                                     },
                              i => LoadImageToTile (tileList [i], result));
            }
            return result;
        }


        public virtual List <MapTile> GetTilesInView (BoundingBox projectedMapExtent, int level)
        {
            return GetTilesInView (projectedMapExtent.BottomLeft.X, projectedMapExtent.BottomLeft.Y, projectedMapExtent.TopRight.X, projectedMapExtent.TopRight.Y, level);
        }


        private void LoadImageToTile (TileIndex tileIndex, ICollection <MapTile> result)
        {
            processedImageCount++;

            OnMapTileBeforLoad (tileIndex);

            var notFindSourceList = new List <ITileSource> ();
            var mapTile = new MapTile (tileIndex);

            foreach (var iterSource in tileSources)
            {
                var isTileExistsInIterSource = iterSource.TileExists (tileIndex);

                if (mapTile.Image != null && iterSource.Mutable && !isTileExistsInIterSource)
                {
                    notFindSourceList.Add (iterSource);
                }

                if (mapTile.Image == null && isTileExistsInIterSource)
                {
                    mapTile.Image = iterSource.GetTile (tileIndex);
                    mapTile.Bounds = TileBounds (tileIndex);
                }

                if (mapTile.Image == null)
                {
                    if (iterSource.Mutable)
                    {
                        notFindSourceList.Add (iterSource);
                    }
                }
            }

            if (mapTile.Image != null)
            {
                foreach (var iterNotFindCache in notFindSourceList.Where (iterNotFindCache => iterNotFindCache.Mutable))
                {
                    iterNotFindCache.AddTile (mapTile.TileIndex, mapTile.Image);
                }
                result.Add (mapTile);
            }

            if (processedImageCount % 500 == 1)
            {
                MemoryUtil.FreeMemory ();
                processedImageCount = 0;
            }

            OnMapTileAfterLoad (tileIndex);
        }

        private void OnMapTileBeforLoad (TileIndex tileIndex)
        {
            if (TileImageBeforLoad != null)
            {
                TileImageBeforLoad (new TileImageLoadEventArgs (tileIndex));
            }
        }

        private void OnMapTileAfterLoad (TileIndex tileIndex)
        {
            if (TileImageAfterLoad != null)
            {
                TileImageAfterLoad (new TileImageLoadEventArgs (tileIndex));
            }
        }
    }
}