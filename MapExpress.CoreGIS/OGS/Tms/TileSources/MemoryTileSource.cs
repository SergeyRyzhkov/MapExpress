#region

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace MapExpress.CoreGIS.OGS.Tms.TileSources
{
    public class MemoryTileSource : ITileSource
    {
        private static readonly MapTileCacheEntryComparer mapTileCacheEntryComparer = new MapTileCacheEntryComparer ();
        private readonly Dictionary<string, MapTile> storage = new Dictionary<string, MapTile> ();


        public MemoryTileSource () : this (1000, 0, true)
        {
        }

        public MemoryTileSource (int maxEntryCount) : this (maxEntryCount, 0, true)
        {
        }

        public MemoryTileSource (int maxEntryCount, int maxEdgInSeconds) : this (maxEntryCount, maxEdgInSeconds, true)
        {
            MaxEntryCount = maxEntryCount;
            MaxEdgInSeconds = maxEdgInSeconds;
        }

        public MemoryTileSource (int maxEntryCount, int maxEdgInSeconds, bool isRemoveByLessHitCount)
        {
            MaxEntryCount = maxEntryCount;
            MaxEdgInSeconds = maxEdgInSeconds;
            RemoveByLessHitCount = isRemoveByLessHitCount;
        }

        public int MaxEntryCount { get; set; }

        public int MaxEdgInSeconds { get; set; }

        public bool RemoveByLessHitCount { get; set; }

        public string TileUriTemplate { get; set; }

        public Uri GetTileUri (TileIndex tileIndex)
        {
            throw new NotImplementedException ();
        }

        public byte[] GetTile (TileIndex tileIndex)
        {
            MapTile result;
            if (storage.TryGetValue (tileIndex.ToString (), out result))
            {
                result.LastAccessTime = DateTime.Now;
                result.HitCount++;
                return result.Image;
            }
            return null;
        }

        public bool Mutable
        {
            get { return true; }
            set { }
        }

        public void AddTile (TileIndex tileIndex, byte[] image)
        {
            var isContains = TileExists (tileIndex);
            if (!isContains)
            {
                lock (storage)
                {
                    MapTile result;
                    if (!storage.TryGetValue (tileIndex.ToString (), out result))
                    {
                        result = new MapTile (tileIndex);
                    }

                    result.Image = image;
                    result.LoadInCacheTime = DateTime.Now;
                    result.LastAccessTime = DateTime.Now;

                    storage.Remove (result.ToString ());
                    storage.Add (result.ToString (), result);
                }
            }

            if (storage.Count > MaxEntryCount)
            {
                CleanUpCache ();
            }
        }

        public void RemoveTile (TileIndex tileIndex)
        {
            MapTile result;
            if (storage.TryGetValue (tileIndex.ToString (), out result))
            {
                storage.Remove (tileIndex.ToString ());
            }
        }

        public bool TileExists (TileIndex tileIndex)
        {
            MapTile result;
            return storage.TryGetValue (tileIndex.ToString (), out result);
        }

        public string ImageExtension { get; set; }


        private void CleanUpCache ()
        {
            if (Mutable)
            {
                lock (storage)
                {
                    RemoveEntryByEdg ();
                    RemoveEntryByCount ();
                }
            }
        }


        private void RemoveEntryByCount ()
        {
            if (storage.Count > MaxEntryCount)
            {
                var valuesList = new MapTile [storage.Count];
                storage.Values.CopyTo (valuesList, 0);

                if (RemoveByLessHitCount)
                {
                    Array.Sort (valuesList, mapTileCacheEntryComparer);
                }

                for (var i = 0; i < MaxEntryCount / 10; i++)
                {
                    var iterEntry = valuesList [i];
                    var deltaLoad = (DateTime.Now - iterEntry.LoadInCacheTime).Seconds;
                    if (deltaLoad > MaxEdgInSeconds / 5)
                    {
                        storage.Remove (valuesList [i].TileIndex.ToString ());
                    }
                }
            }
        }


        private void RemoveEntryByEdg ()
        {
            if (MaxEdgInSeconds > 0 && storage.Count > MaxEntryCount)
            {
                var toDeleteEntryList = new List<MapTile> ();

                foreach (var iterEntry in from iterEntry in storage.Values
                                          let deltaLast =
                                              (DateTime.Now - iterEntry.LastAccessTime).Seconds
                                          let deltaLoad =
                                              (DateTime.Now - iterEntry.LoadInCacheTime).Seconds
                                          where
                                              deltaLoad > MaxEdgInSeconds / 5 &&
                                              deltaLast > MaxEdgInSeconds
                                          select iterEntry)
                {
                    toDeleteEntryList.Add (iterEntry);
                    if (storage.Count < (MaxEntryCount - MaxEntryCount / 10))
                    {
                        break;
                    }
                }
                foreach (var iterDelTile in toDeleteEntryList)
                {
                    storage.Remove (iterDelTile.ToString ());
                }
            }
        }


        internal class MapTileCacheEntryComparer : IComparer <MapTile>
        {
            #region IComparer Members

            public int Compare (MapTile x, MapTile y)
            {
                return (x).HitCount - (y).HitCount;
            }

            #endregion
        }
    }
}