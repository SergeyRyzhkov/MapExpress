#region

using System.Collections.Generic;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public class Polygon : Geometry, IPolygon
    {
        public Polygon () : this (null)
        {
        }

        public Polygon (ICoordinateReferenceSystem cs, ILinearRing exteriorRing, IEnumerable <ILinearRing> interiorRings) : base (cs)
        {
            ExteriorRing = exteriorRing;
            InteriorRings = interiorRings.ToList ();
        }


        public Polygon (ICoordinateReferenceSystem cs, ILinearRing exteriorRing) : this (cs, exteriorRing, new List <ILinearRing> ())
        {
        }


        public Polygon (ICoordinateReferenceSystem cs) : this (cs, new LinearRing (cs), new List <ILinearRing> ())
        {
        }

        public virtual IPoint StartPoint
        {
            get { return ExteriorRing.StartPoint; }
        }


        public override BoundingBox Bounds
        {
            get
            {
                var bbox = new BoundingBox (StartPoint.X, StartPoint.Y, StartPoint.X, StartPoint.Y);
                foreach (var iterPoint in ExteriorRing.Vertices)
                {
                    bbox.BottomLeft.X = iterPoint.X < bbox.BottomLeft.X ? iterPoint.X : bbox.BottomLeft.X;
                    bbox.BottomLeft.Y = iterPoint.Y < bbox.BottomLeft.Y ? iterPoint.Y : bbox.BottomLeft.Y;
                    bbox.TopRight.X = iterPoint.X > bbox.TopRight.X ? iterPoint.X : bbox.TopRight.X;
                    bbox.TopRight.Y = iterPoint.Y > bbox.TopRight.Y ? iterPoint.Y : bbox.TopRight.Y;
                }
                return bbox;
            }
        }

        #region IPolygon Members

        public override GeometryType GeometryType
        {
            get { return GeometryType.Polygon; }
        }

        public override bool IsEmpty
        {
            get { return (ExteriorRing == null) || (ExteriorRing.Vertices.Count == 0); }
        }

        public ILinearRing ExteriorRing { get; set; }

        public ICollection <ILinearRing> InteriorRings { get; set; }

        public override object Clone ()
        {
            var p = new Polygon {ExteriorRing = (ILinearRing) ExteriorRing.Clone ()};
            foreach (var t in InteriorRings)
            {
                p.InteriorRings.Add ((ILinearRing) t.Clone ());
            }
            return p;
        }

        #endregion

        public bool Equals (Polygon polygon)
        {
            if (polygon == null)
                return false;
            if (!polygon.ExteriorRing.Equals (ExteriorRing))
                return false;
            if (polygon.InteriorRings.Count != InteriorRings.Count)
                return false;

            var interiorRingsList = polygon.InteriorRings.ToList ();
            var otherInteriorRingsList = polygon.InteriorRings.ToList ();
            return !polygon.InteriorRings.Where ((t, i) => !interiorRingsList [i].Equals (otherInteriorRingsList [i])).Any ();
        }

        public override int GetHashCode ()
        {
            return InteriorRings.Aggregate (ExteriorRing.GetHashCode (), (current, t) => current ^ t.GetHashCode ());
        }
    }
}