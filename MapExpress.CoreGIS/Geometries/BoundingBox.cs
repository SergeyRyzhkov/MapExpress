#region

#endregion

#region

using System;
using MapExpress.CoreGIS.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public struct BoundingBox : ICloneable, IEquatable <BoundingBox>
    {
        public static BoundingBox Empty = new BoundingBox (double.NaN, double.NaN, double.NaN, double.NaN);

        public BoundingBox (ICoordinate bottomLeft, ICoordinate topRight) : this ()
        {
            BottomLeft = bottomLeft;
            TopRight = topRight;
        }

        public BoundingBox (double minX, double minY, double maxX, double maxY) : this (new Coordinate (minX, minY), new Coordinate (maxX, maxY))
        {
        }


        public ICoordinate BottomLeft { get; set; }

        public ICoordinate TopRight { get; set; }

        #region ICloneable Members

        public object Clone ()
        {
            return new BoundingBox (BottomLeft, TopRight);
        }

        #endregion

        #region IEquatable<BoundingBox> Members

        public bool Equals (BoundingBox other)
        {
            return Equals (other.BottomLeft, BottomLeft) && Equals (other.TopRight, TopRight);
        }

        #endregion

        public BoundingBox Grow (double amount)
        {
            var box = (BoundingBox) Clone ();
            box.BottomLeft.X -= amount;
            box.BottomLeft.Y -= amount;
            box.TopRight.X += amount;
            box.TopRight.Y += amount;
            return box;
        }

        public Envelope Grow (double amountInX, double amountInY)
        {
            var box = (Envelope) Clone ();
            box.BottomLeft.X -= amountInX;
            box.BottomLeft.Y -= amountInY;
            box.TopRight.X += amountInX;
            box.TopRight.Y += amountInY;
            return box;
        }

        public BoundingBox Join (BoundingBox boundingBox)
        {
            return new BoundingBox (
                Math.Min (BottomLeft.X, boundingBox.BottomLeft.X),
                Math.Min (BottomLeft.Y, boundingBox.BottomLeft.Y),
                Math.Max (TopRight.X, boundingBox.TopRight.X),
                Math.Max (TopRight.Y, boundingBox.TopRight.Y));
        }

        public override string ToString ()
        {
            return string.Format ("BottomLeft: {0}, TopRight: {1}", BottomLeft, TopRight);
        }

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (obj.GetType () != typeof (BoundingBox)) return false;
            return Equals ((BoundingBox) obj);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                return ((BottomLeft != null ? BottomLeft.GetHashCode () : 0) * 397) ^ (TopRight != null ? TopRight.GetHashCode () : 0);
            }
        }
    }
}