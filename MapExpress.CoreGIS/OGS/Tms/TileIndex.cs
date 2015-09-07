#region

using System;

#endregion

namespace MapExpress.CoreGIS.OGS.Tms
{
    public struct TileIndex : IComparable
    {
        public static TileIndex Invalid = new TileIndex (int.MaxValue, int.MaxValue, int.MaxValue);
        private readonly int x;
        private readonly int y;
        private readonly int level;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public int Level
        {
            get { return level; }
        }

        public TileIndex (int x, int y, int level)
        {
            this.x = x;
            this.y = y;
            this.level = level;
        }

        public static bool operator == (TileIndex a, TileIndex b)
        {
            return a.Equals (b);
        }

        public static bool operator != (TileIndex a, TileIndex b)
        {
            return !a.Equals (b);
        }

        public static bool operator < (TileIndex key1, TileIndex key2)
        {
            return (key1.CompareTo (key2) < 0);
        }

        public static bool operator > (TileIndex key1, TileIndex key2)
        {
            return (key1.CompareTo (key2) > 0);
        }

        public static bool IsInvalid (TileIndex index)
        {
            return index == Invalid;
        }

        public int CompareTo (object obj)
        {
            if (!(obj is TileIndex))
            {
                throw new ArgumentException ("object of type TileIndex was expected");
            }
            return CompareTo ((TileIndex) obj);
        }

        public int CompareTo (TileIndex index)
        {
            if (x < index.x)
                return -1;
            if (x > index.x)
                return 1;
            if (y < index.y)
                return -1;
            if (y > index.y)
                return 1;
            return level - index.level;
        }

        public override bool Equals (object obj)
        {
            if (!(obj is TileIndex))
                return false;

            return Equals ((TileIndex) obj);
        }

        public bool Equals (TileIndex index)
        {
            return x == index.x && y == index.y && level == index.level;
        }

        public override int GetHashCode ()
        {
            return x.GetHashCode () * y.GetHashCode () * level.GetHashCode ();
        }

        public override string ToString ()
        {
            return string.Format ("TileIndex({0}:{1}:{2})", x, y, level);
        }
    }
}