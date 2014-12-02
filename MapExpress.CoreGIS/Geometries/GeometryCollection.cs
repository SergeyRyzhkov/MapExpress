#region

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public class GeometryCollection : Geometry, IGeometryCollection
    {
        private IList <IGeometry> geometries;

        public GeometryCollection () : this (null)
        {
        }

        public GeometryCollection (ICoordinateReferenceSystem coordSys) : base (coordSys)
        {
            geometries = new List <IGeometry> ();
        }

        public GeometryCollection (ICoordinateReferenceSystem coordSys, IEnumerable <IGeometry> geometries) : base (coordSys)
        {
            this.geometries = geometries.ToList ();
        }

        public override BoundingBox Bounds
        {
            get
            {
                var env = this [0].Envelope;
                var b = new BoundingBox (env.BottomLeft.X, env.BottomLeft.Y, env.TopRight.X, env.TopRight.Y);
                return geometries.Cast <Geometry> ().Aggregate (b, (current, geometry) => current.Join (geometry.Bounds));
            }
        }

        public IGeometry this [int i]
        {
            get { return geometries [i]; }
        }

        #region IGeometryCollection Members

        public override GeometryType GeometryType
        {
            get { return GeometryType.GeometryCollection; }
        }

        public override int Dimension
        {
            get
            {
                return geometries.Aggregate (0,
                                             (current, geometry) =>
                                             (current < geometry.Dimension ? geometry.Dimension : current));
            }
        }

        public override bool IsEmpty
        {
            get { return geometries == null || geometries.All (geometry => geometry.IsEmpty); }
        }

        public ICollection <IGeometry> Geometries
        {
            get { return geometries; }
            set { geometries = value.ToList (); }
        }


        public IEnumerator <IGeometry> GetEnumerator ()
        {
            return geometries.GetEnumerator ();
        }

        IEnumerator IEnumerable.GetEnumerator ()
        {
            return GetEnumerator ();
        }


        public override object Clone ()
        {
            var geoms = new GeometryCollection ();
            foreach (Geometry geometry in geometries)
            {
                geoms.Geometries.Add ((IGeometry) geometry.Clone ());
            }
            return geoms;
        }

        #endregion

        public bool Equals (GeometryCollection g)
        {
            if (g == null)
                return false;
            if (g.Geometries.Count != Geometries.Count)
                return false;
            return !g.Geometries.Where ((t, i) => !g [i].Equals (this [i])).Any ();
        }

        public override int GetHashCode ()
        {
            return geometries.Aggregate (0, (current, geometry) => current ^ geometry.GetHashCode ());
        }
    }
}