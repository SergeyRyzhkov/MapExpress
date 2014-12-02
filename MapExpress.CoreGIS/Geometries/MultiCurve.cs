#region

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public class MultiCurve : Geometry, IMultiCurve
    {
        private IList <ICurve> curves;

        protected MultiCurve () : this (null)
        {
        }

        protected MultiCurve (ICoordinateReferenceSystem coordSys) : base (coordSys)
        {
            curves = new Collection <ICurve> ();
        }

        public IGeometry this [int i]
        {
            get { return curves [i]; }
        }

        public override BoundingBox Bounds
        {
            get
            {
                if (Curves == null || Curves.Count == 0)
                    return BoundingBox.Empty;
                var bbox = ((Curve) this [0]).Bounds;
                for (var i = 1; i < Curves.Count; i++)
                {
                    bbox = bbox.Join (((Curve) this [i]).Bounds);
                }
                return bbox;
            }
        }

        #region IMultiCurve Members

        public ICollection <ICurve> Curves
        {
            get { return curves; }
            set { curves = value.ToList (); }
        }

        public override GeometryType GeometryType
        {
            get { return GeometryType.MultiCurve; }
        }

        public override bool IsEmpty
        {
            get { return curves == null || curves.All (geometry => geometry.IsEmpty); }
        }

        public override object Clone ()
        {
            var geoms = new MultiCurve ();
            foreach (var geometry in curves)
            {
                geoms.Curves.Add ((ICurve) geometry.Clone ());
            }
            return geoms;
        }

        #endregion

        public bool Equals (MultiCurve g)
        {
            if (g == null)
                return false;
            if (g.Curves.Count != Curves.Count)
                return false;
            return !g.Curves.Where ((t, i) => !g [i].Equals (this [i])).Any ();
        }

        public override int GetHashCode ()
        {
            return Curves.Aggregate (0, (current, geometry) => current ^ geometry.GetHashCode ());
        }
    }
}