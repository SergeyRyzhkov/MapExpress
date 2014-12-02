#region

using System.Collections.Generic;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public class MultiPolygon : Geometry, IMultiPolygon
    {
        private IList <IPolygon> polygons;

        public MultiPolygon () : this (null)
        {
        }

        public MultiPolygon (ICoordinateReferenceSystem coordSys) : base (coordSys)
        {
            polygons = new List <IPolygon> ();
        }

        public MultiPolygon (ICoordinateReferenceSystem coordSys, IEnumerable <IPolygon> polygons) : base (coordSys)
        {
            this.polygons = polygons.ToList ();
        }

        public IPolygon this [int index]
        {
            get { return polygons [index]; }
        }

        public override BoundingBox Bounds
        {
            get
            {
                if (polygons == null || polygons.Count == 0)
                    return BoundingBox.Empty;
                var bbox = ((Polygon) polygons [0]).Bounds;
                for (var i = 1; i < Polygons.Count; i++)
                    bbox = bbox.Join (((Polygon) polygons [i]).Bounds);
                return bbox;
            }
        }

        #region IMultiPolygon Members

        public override GeometryType GeometryType
        {
            get { return GeometryType.MultiPolygon; }
        }

        public ICollection <IPolygon> Polygons
        {
            get { return polygons; }
            set { polygons = value.ToList (); }
        }

        public override bool IsEmpty
        {
            get
            {
                if (polygons == null || polygons.Count == 0)
                    return true;
                return polygons.All (polygon => polygon.IsEmpty);
            }
        }

        public override object Clone ()
        {
            var geoms = new MultiPolygon ();
            foreach (var geometry in Polygons)
            {
                geoms.Polygons.Add ((IPolygon) geometry.Clone ());
            }
            return geoms;
        }

        #endregion

        public bool Equals (MultiPolygon g)
        {
            if (g == null)
                return false;
            if (g.Polygons.Count != Polygons.Count)
                return false;
            return !g.Polygons.Where ((t, i) => !g [i].Equals (this [i])).Any ();
        }

        public override int GetHashCode ()
        {
            return Polygons.Aggregate (0, (current, geometry) => current ^ geometry.GetHashCode ());
        }
    }
}