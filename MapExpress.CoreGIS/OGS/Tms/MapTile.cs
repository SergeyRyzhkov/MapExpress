#region

using System;

#endregion

namespace MapExpress.CoreGIS.OGS.Tms
{
    public struct MapTile
    {
        public MapTile (TileIndex tileIndex) : this ()
        {
            TileIndex = tileIndex;
        }

        public TileIndex TileIndex { get; set; }

        public BoundingBox Bounds { get; set; }

        public byte[] Image { get; set; }

        public bool IsDirty { get; set; }

        public DateTime LoadInCacheTime { get; set; }

        public DateTime LastAccessTime { get; set; }

        public int HitCount { get; set; }

        public override bool Equals (object obj)
        {
            return TileIndex.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return TileIndex.GetHashCode ();
        }

        public override string ToString ()
        {
            return TileIndex.ToString ();
        }
    }
}