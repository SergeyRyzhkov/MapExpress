#region

using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public class Point : Geometry, IPoint
    {
        public Point ()
        {
        }

        public Point (ICoordinateReferenceSystem coordSys, double x, double y) : base (coordSys)
        {
            X = x;
            Y = y;
        }

        public Point (ICoordinateReferenceSystem coordSys, double[] point) : base (coordSys)
        {
            X = point [0];
            Y = point [1];
        }

        public virtual double this [int index]
        {
            get { return index == 0 ? X : (index == 1 ? Y : 0); }
            set
            {
                if (index == 0)
                    X = value;
                if (index == 1)
                    Y = value;
            }
        }

        public override BoundingBox Bounds
        {
            get { return BoundingBox.Empty; }
        }

        #region IPoint Members

        public override GeometryType GeometryType
        {
            get { return GeometryType.Point; }
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override int Dimension
        {
            get { return 0; }
        }

        public override bool IsEmpty
        {
            get { return X.Equals (double.NaN) || Y.Equals (double.NaN); }
        }

        public override object Clone ()
        {
            return new Point (SpatialReferenceSystem, X, Y);
        }

        #endregion

        public static Point operator + (Point p1, Point p2)
        {
            return new Point (p1.SpatialReferenceSystem, p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator - (Point p1, Point p2)
        {
            return new Point (p1.SpatialReferenceSystem, p1.X - p2.X, p2.Y - p2.Y);
        }

        public static Point operator * (Point p1, double d)
        {
            return new Point (p1.SpatialReferenceSystem, p1.X * d, p1.Y * d);
        }

        public bool Equals (Point other)
        {
            if (ReferenceEquals (null, other)) return false;
            if (ReferenceEquals (this, other)) return true;
            return other.X.Equals (X) && other.Y.Equals (Y) && other.Z.Equals (Z);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                var result = X.GetHashCode ();
                result = (result * 397) ^ Y.GetHashCode ();
                result = (result * 397) ^ Z.GetHashCode ();
                return result;
            }
        }
    }
}