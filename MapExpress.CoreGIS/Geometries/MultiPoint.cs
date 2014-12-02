#region

using System.Collections.Generic;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public class MultiPoint : Geometry, IMultiPoint
    {
        private IList <IPoint> points;

        public MultiPoint () : this (null)
        {
        }

        public MultiPoint (ICoordinateReferenceSystem coordSys) : base (coordSys)
        {
            points = new List <IPoint> ();
        }

        public MultiPoint (ICoordinateReferenceSystem coordSys, IEnumerable <IPoint> points) : base (coordSys)
        {
            this.points = points.ToList ();
        }

        public IPoint this [int index]
        {
            get { return points [index]; }
        }

        public override BoundingBox Bounds
        {
            get
            {
                var firstPoint = points [0];
                var bbox = new BoundingBox (firstPoint.X, firstPoint.Y, firstPoint.X, firstPoint.Y);
                foreach (var iterPoint in points)
                {
                    bbox.BottomLeft.X = iterPoint.X < bbox.BottomLeft.X ? iterPoint.X : bbox.BottomLeft.X;
                    bbox.BottomLeft.Y = iterPoint.Y < bbox.BottomLeft.Y ? iterPoint.Y : bbox.BottomLeft.Y;
                    bbox.TopRight.X = iterPoint.X > bbox.TopRight.X ? iterPoint.X : bbox.TopRight.X;
                    bbox.TopRight.Y = iterPoint.Y > bbox.TopRight.Y ? iterPoint.Y : bbox.TopRight.Y;
                }
                return bbox;
            }
        }

        #region IMultiPoint Members

        public override GeometryType GeometryType
        {
            get { return GeometryType.MultiPoint; }
        }

        public ICollection <IPoint> Points
        {
            get { return points; }
            set { points = value.ToList (); }
        }

        public override int Dimension
        {
            get { return 0; }
        }

        public override bool IsEmpty
        {
            get { return points == null || points.Count == 0; }
        }

        public override object Clone ()
        {
            var geoms = new MultiPoint ();
            foreach (var geometry in Points)
            {
                geoms.Points.Add ((IPoint) geometry.Clone ());
            }
            return geoms;
        }

        #endregion

        public bool Equals (MultiPoint g)
        {
            if (g == null)
                return false;
            if (g.Points.Count != Points.Count)
                return false;
            return !g.Points.Where ((t, i) => !g [i].Equals (this [i])).Any ();
        }

        public override int GetHashCode ()
        {
            return Points.Aggregate (0, (current, geometry) => current ^ geometry.GetHashCode ());
        }
    }
}