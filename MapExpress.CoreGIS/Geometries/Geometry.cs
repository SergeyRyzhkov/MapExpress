#region

using MapExpress.CoreGIS.Geometries.Converters;
using MapExpress.CoreGIS.Referencing.Operations;
using MapExpress.CoreGIS.Referencing.Operations.Projections;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public abstract class Geometry : IGeometry
    {
        private static readonly WKTGeometryReader wktGeometryReader = new WKTGeometryReader ();
        private static readonly WKTGeometryWriter wktGeometryWriter = new WKTGeometryWriter ();
        private static readonly GeoJSONGeometryReader geojsonGeometryReader = new GeoJSONGeometryReader ();
        private static readonly GeoJSONGeometryWriter geojsonGeometryWriter = new GeoJSONGeometryWriter ();

        protected Geometry () : this (null)
        {
        }

        protected Geometry (ICoordinateReferenceSystem coordSys)
        {
            SpatialReferenceSystem = coordSys;
        }

        public abstract BoundingBox Bounds { get; }

        #region IGeometry Members

        public string ExportToWKT ()
        {
            return wktGeometryWriter.Write (this);
        }

        public abstract GeometryType GeometryType { get; }

        public ICoordinateReferenceSystem SpatialReferenceSystem { get; set; }

        public virtual int Dimension
        {
            get { return 1; }
        }

        public IEnvelope Envelope
        {
            get
            {
                var box = Bounds;
                return new Envelope (SpatialReferenceSystem, box.BottomLeft.X, box.BottomLeft.Y, box.TopRight.X, box.TopRight.Y);
            }
        }

        public abstract bool IsEmpty { get; }

        public abstract object Clone ();

        public bool Equals (IGeometry other)
        {
            return Equals (this, other);
        }

        #endregion

        // TODO: Сделать Export Import from WKB  

        public string ExportToGeoJSON ()
        {
            return geojsonGeometryWriter.Write (this);
        }

        public IGeometry TransformCoordinate (ICoordinateOperation coordinateOperation)
        {
            return GeometryCoordinateTransform.Transform (coordinateOperation, this);
        }

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj))
                return false;
            if (ReferenceEquals (this, obj))
                return true;
            if (!(obj is Geometry))
                return false;
            return Equals (obj as Geometry);
        }

        public override string ToString ()
        {
            return ExportToWKT ();
        }

        public static IGeometry CreateFromWKT (string wktText)
        {
            return wktGeometryReader.Read (wktText);
        }

        public static IGeometry CreateFromGeoJSON (string geoJSonText)
        {
            return geojsonGeometryReader.Read (geoJSonText);
        }

        public static bool Equals (IGeometry g1, IGeometry g2)
        {
            if (g1 == null && g2 == null)
                return true;
            if (g1 == null || g2 == null)
                return false;
            if (g1.GetType () != g2.GetType ())
                return false;
            if (g1 is Point)
                return (g1 as Point).Equals (g2 as Point);
            if (g1 is LinearRing)
                return (g1 as LinearRing).Equals (g2 as LinearRing);
            if (g1 is LineString)
                return (g1 as LineString).Equals (g2 as LineString);
            if (g1 is Polygon)
                return (g1 as Polygon).Equals (g2 as Polygon);
            if (g1 is MultiPoint)
                return (g1 as MultiPoint).Equals (g2 as MultiPoint);
            if (g1 is MultiLineString)
                return (g1 as MultiLineString).Equals (g2 as MultiLineString);
            if (g1 is MultiPolygon)
                return (g1 as MultiPolygon).Equals (g2 as MultiPolygon);
            if (g1 is GeometryCollection)
                return (g1 as GeometryCollection).Equals (g2 as GeometryCollection);
            throw new MapExpressException ("The method or operation is not implemented on this geometry type.");
        }
    }
}