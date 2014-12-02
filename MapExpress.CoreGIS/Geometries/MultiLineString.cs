#region

using System.Collections.Generic;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public class MultiLineString : MultiCurve, IMultiLineString
    {
        private IList <ILineString> lineStrings;

        public MultiLineString () : this (null)
        {
        }

        public MultiLineString (ICoordinateReferenceSystem coordSys, IEnumerable <ILineString> lineStrings) : base (coordSys)
        {
            this.lineStrings = lineStrings.ToList ();
        }

        public MultiLineString (ICoordinateReferenceSystem coordSys) : base (coordSys)
        {
            lineStrings = new List <ILineString> ();
        }

        public new ILineString this [int index]
        {
            get { return lineStrings [index]; }
        }

        public bool IsClosed
        {
            get { return LineStrings.All (lineString => lineString.IsClosed); }
        }

        public override BoundingBox Bounds
        {
            get
            {
                if (lineStrings == null || lineStrings.Count == 0)
                    return BoundingBox.Empty;
                var bbox = ((LineString) lineStrings [0]).Bounds;
                for (var i = 1; i < lineStrings.Count; i++)
                    bbox = bbox.Join (((LineString) lineStrings [i]).Bounds);
                return bbox;
            }
        }

        #region IMultiLineString Members

        public override GeometryType GeometryType
        {
            get { return GeometryType.MultiLineString; }
        }

        public ICollection <ILineString> LineStrings
        {
            get { return lineStrings; }
            set { lineStrings = value.ToList (); }
        }

        public override bool IsEmpty
        {
            get
            {
                if (lineStrings == null || lineStrings.Count == 0)
                    return true;
                return lineStrings.Cast <LineString> ().All (lineString => lineString.IsEmpty);
            }
        }

        public override object Clone ()
        {
            var geoms = new MultiLineString ();
            foreach (var geometry in lineStrings)
            {
                geoms.LineStrings.Add ((ILineString) geometry.Clone ());
            }
            return geoms;
        }

        #endregion

        public bool Equals (MultiLineString g)
        {
            if (g == null)
                return false;
            if (g.LineStrings.Count != LineStrings.Count)
                return false;
            return !g.LineStrings.Where ((t, i) => !g [i].Equals (this [i])).Any ();
        }

        public override int GetHashCode ()
        {
            return lineStrings.Aggregate (0, (current, geometry) => current ^ geometry.GetHashCode ());
        }
    }
}