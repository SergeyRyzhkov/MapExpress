#region

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public class LineString : Curve, ILineString
    {
        private IList <IPoint> vertices;


        public LineString () : this (null)
        {
        }

        public LineString (ICoordinateReferenceSystem coordSys, IEnumerable <double[]> verticesXy) : base (coordSys)
        {
            vertices = new Collection <IPoint> ();
            foreach (var xy in verticesXy)
            {
                vertices.Add (new Point (coordSys, xy [0], xy [1]));
            }
        }

        public LineString (ICoordinateReferenceSystem coordSys, IEnumerable <IPoint> vertices) : base (coordSys)
        {
            this.vertices = vertices.ToList ();
        }

        public LineString (ICoordinateReferenceSystem coordSys) : this (coordSys, new Collection <IPoint> ())
        {
        }


        public LineString (ICoordinateReferenceSystem coordSys, IEnumerable <ICoordinate> points) : base (coordSys)
        {
            vertices = new Collection <IPoint> ();
            foreach (var point in points)
            {
                vertices.Add (new Point (coordSys, point.X, point.Y));
            }
        }


        // TODO: Везде сделать этот метод
        public IPoint this [int index]
        {
            get { return vertices [index]; }
        }

        // TODO: Проверять на наличее нач. и кон. точек. 
        // А точно второй и третий аргумент  var bbox = new BoundingBox (StartPoint.X, StartPoint.Y, StartPoint.X, StartPoint.Y); StartPoint ?
        public override BoundingBox Bounds
        {
            get
            {
                var bbox = new BoundingBox (StartPoint.X, StartPoint.Y, StartPoint.X, StartPoint.Y);
                foreach (var iterPoint in Vertices)
                {
                    bbox.BottomLeft.X = iterPoint.X < bbox.BottomLeft.X ? iterPoint.X : bbox.BottomLeft.X;
                    bbox.BottomLeft.Y = iterPoint.Y < bbox.BottomLeft.Y ? iterPoint.Y : bbox.BottomLeft.Y;
                    bbox.TopRight.X = iterPoint.X > bbox.TopRight.X ? iterPoint.X : bbox.TopRight.X;
                    bbox.TopRight.Y = iterPoint.Y > bbox.TopRight.Y ? iterPoint.Y : bbox.TopRight.Y;
                }
                return bbox;
            }
        }

        public bool IsSimple
        {
            get
            {
                var verts = new Collection <IPoint> ();
                foreach (var vertex in vertices.Where (vertex => 0 != verts.IndexOf (vertex)))
                    verts.Add (vertex);
                return (verts.Count == vertices.Count - (IsClosed ? 1 : 0));
            }
        }

        #region ILineString Members

        public override GeometryType GeometryType
        {
            get { return GeometryType.LineString; }
        }

        public ICollection <IPoint> Vertices
        {
            get { return vertices; }
            set { vertices = value.ToList (); }
        }


        public override IPoint StartPoint
        {
            get { return vertices.First (); }
            set
            {
                if (!vertices.Any ())
                {
                    vertices.Add (value);
                }
                else
                    vertices [0] = value;
            }
        }


        public override IPoint EndPoint
        {
            get { return vertices.Last (); }
            set
            {
                if (!vertices.Any ())
                {
                    vertices.Add (value);
                }
                else
                {
                    var pointsCount = vertices.Count;
                    if (pointsCount == 1)
                    {
                        vertices.Add (value);
                    }
                    else
                    {
                        vertices [vertices.Count - 1] = value;
                    }
                }
            }
        }

        public override bool IsRing
        {
            get { return (IsClosed && IsSimple); }
        }

        public override bool IsEmpty
        {
            get { return vertices == null || vertices.Count == 0; }
        }

        public override object Clone ()
        {
            var l = new LineString (SpatialReferenceSystem);
            foreach (IPoint vertex in vertices)
                l.Vertices.Add ((IPoint) vertex.Clone ());
            return l;
        }

        #endregion

        public bool Equals (LineString lineString)
        {
            if (lineString == null)
                return false;
            if (lineString.Vertices.Count != vertices.Count)
                return false;
            return !lineString.Vertices.Where ((t, i) => !lineString [i].Equals (this [i])).Any ();
        }


        public override int GetHashCode ()
        {
            return vertices.Aggregate (0, (current, geometry) => current ^ geometry.GetHashCode ());
        }
    }
}