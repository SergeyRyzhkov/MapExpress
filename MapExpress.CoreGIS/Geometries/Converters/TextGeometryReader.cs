#region

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using MapExpress.OpenGIS.GeoAPI.Geometries;

#endregion

namespace MapExpress.CoreGIS.Geometries.Converters
{
    // TODO:Переделать на типы  как в public static class WKBGeometryWriter + добавиь Write или все методы WRITE сделать и сделать приватными

    // TODO: Много раз лишнего вызывается NormalizeText  

    public abstract class TextGeometryReader
    {
        private readonly string curveCoordListDelimeter;
        private readonly string multiLineStringDelimeter;
        private readonly string multiPointDelimeter;
        private readonly string multiPolygonDelimeter;
        private readonly string pointCoordDelimeter;

        protected TextGeometryReader (string pointCoordDelimeter, string multiPointDelimeter,
                                      string multiLineStringDelimeter, string multiPolygonDelimeter,
                                      string curveCoordListDelimeter)
        {
            this.pointCoordDelimeter = pointCoordDelimeter;
            this.multiPointDelimeter = multiPointDelimeter;
            this.multiLineStringDelimeter = multiLineStringDelimeter;
            this.multiPolygonDelimeter = multiPolygonDelimeter;
            this.curveCoordListDelimeter = curveCoordListDelimeter;
        }

        // TODO:Проще нельзя сделать ?
        public virtual IGeometry Read (Stream stream)
        {
            IGeometry result;
            using (var ms = new MemoryStream ())
            {
                stream.CopyTo (ms, 4096);
                ms.Position = 0;
                result = Read (Encoding.Default.GetString ((ms.ToArray ())));
                ms.Close ();
            }
            return result;
        }

        public virtual IGeometry Read (string geomText)
        {
            var normalizedgeomText = NormalizeText (geomText);
            var geoCollectionIndex = normalizedgeomText.IndexOf (GeometryType.GeometryCollection.ToString ("F").ToUpper ());

            if (geoCollectionIndex > -1)
            {
                return GeometryCollection (normalizedgeomText.Substring (geoCollectionIndex));
            }

            var multiPointIndex = normalizedgeomText.IndexOf (GeometryType.MultiPoint.ToString ("F").ToUpper ());
            if (multiPointIndex > -1)
            {
                return MultiPoint (normalizedgeomText.Substring (multiPointIndex));
            }

            var multiLineStringIndex = normalizedgeomText.IndexOf (GeometryType.MultiLineString.ToString ("F").ToUpper ());
            if (multiLineStringIndex > -1)
            {
                return MultiLineString (normalizedgeomText.Substring (multiLineStringIndex));
            }

            var multiPoligonIndex = normalizedgeomText.IndexOf (GeometryType.MultiPolygon.ToString ("F").ToUpper ());
            if (multiPoligonIndex > -1)
            {
                return MultiPolygon (normalizedgeomText.Substring (multiPoligonIndex));
            }

            var pointIndex = normalizedgeomText.IndexOf (GeometryType.Point.ToString ("F").ToUpper ());
            if (pointIndex > -1)
            {
                return Point (normalizedgeomText.Substring (pointIndex));
            }

            var lineStringIndex = normalizedgeomText.IndexOf (GeometryType.LineString.ToString ("F").ToUpper ());
            if (lineStringIndex > -1)
            {
                return LineString (normalizedgeomText.Substring (lineStringIndex));
            }

            var polygonIndex = normalizedgeomText.IndexOf (GeometryType.Polygon.ToString ("F").ToUpper ());
            if (polygonIndex > -1)
            {
                return Polygon (normalizedgeomText.Substring (polygonIndex));
            }
            return null;
        }


        public abstract IGeometryCollection GeometryCollection (string geomText);

        public virtual IPoint Point (string geomText)
        {
            var coorinate = PointCoord (NormalizeText (geomText));
            return new Point (null, coorinate);
        }

        public virtual ILineString LineString (string geomText)
        {
            var coorinates = PointCoordList (NormalizeText (geomText));
            return new LineString (null, coorinates);
        }

        public virtual IPolygon Polygon (string geomText)
        {
            var coordinates = CurveCoordList (NormalizeText (geomText));
            var exteriror = new LinearRing (null, coordinates [0]);
            ICollection <ILinearRing> interiorRings = new Collection <ILinearRing> ();
            if (coordinates.Count > 1)
            {
                for (var index = 1; index < coordinates.Count; index++)
                {
                    var coordinate = coordinates [index];
                    interiorRings.Add (new LinearRing (null, coordinate));
                }
            }
            return new Polygon (null, exteriror, interiorRings);
        }

        public virtual IMultiPoint MultiPoint (string geomText)
        {
            var pointsText = NormalizeText (geomText).Split (new[] {multiPointDelimeter}, StringSplitOptions.None);
            var multiPoint = new MultiPoint ();
            foreach (var pointText in pointsText)
            {
                multiPoint.Points.Add (Point (pointText));
            }
            return multiPoint;
        }

        public virtual IMultiLineString MultiLineString (string geomText)
        {
            var linesStringText = NormalizeText (geomText).Split (new[] {multiLineStringDelimeter}, StringSplitOptions.None);
            var multiLineString = new MultiLineString ();
            foreach (var lineStringText in linesStringText)
            {
                multiLineString.LineStrings.Add (LineString (lineStringText));
                LineString (lineStringText);
            }
            return multiLineString;
        }

        public virtual IMultiPolygon MultiPolygon (string geomText)
        {
            var polygonsText = NormalizeText (geomText).Split (new[] {multiPolygonDelimeter}, StringSplitOptions.None);
            var multiPolygon = new MultiPolygon ();
            foreach (var polygon in polygonsText)
            {
                multiPolygon.Polygons.Add (Polygon (polygon));
            }
            return multiPolygon;
        }

        private IList <IList <double[]>> CurveCoordList (string str)
        {
            var coords = str.Split (new[] {curveCoordListDelimeter}, StringSplitOptions.None);
            return coords.Select (PointCoordList).ToList ();
        }

        private IList <double[]> PointCoordList (string str)
        {
            // var coords = str.Split (',');
            var coords = str.Split (new[] {multiPointDelimeter}, StringSplitOptions.None);
            return coords.Select (PointCoord).ToList ();
        }


        // TODO: Нужно ли здесь три раза использовать ClearText ?
        private double[] PointCoord (string str)
        {
            var result = new double[2];
            var coordinate = ClearText (str).Split (new[] {pointCoordDelimeter}, StringSplitOptions.None);
            double.TryParse (ClearText (coordinate [0]), NumberStyles.Any, CultureInfo.InvariantCulture, out result [0]);
            double.TryParse (ClearText (coordinate [1]), NumberStyles.Any, CultureInfo.InvariantCulture, out result [1]);
            return result;
        }

        protected abstract string NormalizeText (string text);

        protected abstract string ClearText (string text);

        protected string InternalNormalizeText (string text, char delimeter)
        {
            var sb = new StringBuilder ();
            var parts = text.ToUpper ().Trim ().Split (delimeter);
            foreach (var part in parts)
            {
                sb.Append (part.Trim ()).Append (delimeter);
            }
            var normalizedText = sb.ToString ().Replace (Environment.NewLine, "").TrimEnd (delimeter);
            return normalizedText;
        }
    }
}