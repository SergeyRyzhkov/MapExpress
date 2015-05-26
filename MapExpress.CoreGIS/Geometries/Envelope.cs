#region

using System;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public class Envelope : Geometry, IEnvelope
    {
        public Envelope (ICoordinateReferenceSystem coordSys) : this (coordSys, new Point (), new Point ())
        {
        }

        public Envelope (ICoordinateReferenceSystem coordSys, IPoint bottomLeft, IPoint topRight) : base (coordSys)
        {
            BottomLeft = bottomLeft;
            TopRight = topRight;
        }

        public Envelope (ICoordinateReferenceSystem coordSys, ICoordinate bottomLeft, ICoordinate topRight) : this (coordSys, new Point (coordSys, bottomLeft.X, bottomLeft.Y), new Point (coordSys, topRight.X, topRight.Y))
        {
        }


        public Envelope (ICoordinateReferenceSystem coordSys, double minX, double minY, double maxX, double maxY) : this (coordSys, new Point (coordSys, minX, minY), new Point (coordSys, maxX, maxY))
        {
        }

        public double MinX
        {
            get { return BottomLeft.X; }
        }

        public double MinY
        {
            get { return BottomLeft.Y; }
        }

        public double MaxX
        {
            get { return TopRight.X; }
        }

        public double MaxY
        {
            get { return TopRight.Y; }
        }

        public double Width
        {
            get { return Math.Abs (MaxX - MinX); }
        }

        public double Height
        {
            get { return Math.Abs (MaxX - MinY); }
        }

        public double Area
        {
            get { return Width * Height; }
        }

        public override BoundingBox Bounds
        {
            get { return new BoundingBox (MinX, MinY, MaxX, MaxY); }
        }

        public IPoint TopLeft
        {
            get { return new Point (SpatialReferenceSystem, MinX, MaxY); }
        }

        public IPoint BottomRight
        {
            get { return new Point (SpatialReferenceSystem, MaxX, MinY); }
        }

        #region IEnvelope Members

        public IPoint BottomLeft { get; set; }

        public IPoint TopRight { get; set; }


        public override GeometryType GeometryType
        {
            get { return GeometryType.Polygon; }
        }


        public override bool IsEmpty
        {
            get { return TopRight.IsEmpty || BottomLeft.IsEmpty; }
        }

        public override object Clone ()
        {
            return new Envelope (SpatialReferenceSystem, BottomLeft, TopRight);
        }

        #endregion

        public Envelope Grow (double amount)
        {
            var box = (Envelope) Clone ();
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

        public Envelope Join (IEnvelope envelope)
        {
            return (Envelope) (envelope == null
                                   ? Clone ()
                                   : new Envelope (SpatialReferenceSystem,
                                                   Math.Min (BottomLeft.X, envelope.BottomLeft.X),
                                                   Math.Min (BottomLeft.Y, envelope.BottomLeft.Y),
                                                   Math.Max (TopRight.X, envelope.TopRight.X),
                                                   Math.Max (TopRight.Y, envelope.TopRight.Y)));
        }

        public Polygon ToPolygon ()
        {
            var result = new Polygon (SpatialReferenceSystem);
            var ext = new LinearRing (SpatialReferenceSystem);
            ext.Vertices.Add (BottomLeft);
            ext.Vertices.Add (TopLeft);
            ext.Vertices.Add (TopRight);
            ext.Vertices.Add (BottomRight);
            ext.Vertices.Add (BottomLeft);
            result.ExteriorRing = ext;
            return result;
        }

        public bool Equals (Envelope other)
        {
            if (ReferenceEquals (null, other)) return false;
            if (ReferenceEquals (this, other)) return true;
            return Equals (other.BottomLeft, BottomLeft) && Equals (other.TopRight, TopRight);
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