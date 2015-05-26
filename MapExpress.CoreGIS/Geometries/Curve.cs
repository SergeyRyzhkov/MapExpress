#region

#endregion

using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Geometries
{
    // А почему абстракт?
    public abstract class Curve : Geometry, ICurve
    {
        protected Curve (ICoordinateReferenceSystem coordSys) : base (coordSys)
        {
        }

        protected Curve () : this (null)
        {
        }

        public override BoundingBox Bounds
        {
            get
            {
                var bbox = new BoundingBox (StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y)
                               {BottomLeft = {X = StartPoint.X > EndPoint.X ? EndPoint.X : StartPoint.X, Y = StartPoint.Y > EndPoint.Y ? EndPoint.Y : StartPoint.Y}, TopRight = {X = StartPoint.X > EndPoint.X ? StartPoint.X : EndPoint.X, Y = StartPoint.Y > EndPoint.Y ? StartPoint.Y : EndPoint.Y}};

                return bbox;
            }
        }

        #region ICurve Members

        public virtual IPoint StartPoint { get; set; }

        public virtual IPoint EndPoint { get; set; }

        public virtual bool IsClosed
        {
            get { return (StartPoint.Equals (EndPoint)); }
        }

        public abstract bool IsRing { get; }

        #endregion
    }
}