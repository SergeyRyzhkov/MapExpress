#region

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using MapExpress.OpenGIS.GeoAPI.Geometries;

#endregion

namespace MapExpress.CoreGIS.Geometries.Converters
{
    // TODO: Может использовать StringBuilder в методах, чтобы не использовать string.Format
    // TODO: Использовать MapExpressException
    public abstract class TextGeometryWriter
    {
        private static readonly NumberFormatInfo nfi = new NumberFormatInfo ();
        private readonly string closeDelimeter;
        private readonly string openDelimeter;
        private readonly string pointCoordDelimeter;
        internal readonly string textTemplate;

        protected TextGeometryWriter (string textTemplate, string pointCoordDelimeter, string openDelimeter, string closeDelimeter)
        {
            this.textTemplate = textTemplate;
            this.pointCoordDelimeter = pointCoordDelimeter;
            this.openDelimeter = openDelimeter;
            this.closeDelimeter = closeDelimeter;
            nfi.NumberDecimalSeparator = ".";
        }

        // TODO:Переделать на типы  как в public static class WKBGeometryWriter + добавиь Write или все методы WRITE сделать и сделать приватными
        public virtual string Write (IGeometry geometry)
        {
            if (geometry is IPoint)
            {
                return Point ((IPoint) geometry);
            }
            if (geometry is IMultiPoint)
            {
                return MultiPoint ((IMultiPoint) geometry);
            }
            if (geometry is ILineString)
            {
                return LineString ((ILineString) geometry);
            }
            if (geometry is IMultiLineString)
            {
                return MultiLineString ((IMultiLineString) geometry);
            }
            if (geometry is IPolygon)
            {
                return Polygon ((IPolygon) geometry);
            }
            if (geometry is IMultiPolygon)
            {
                return MultiPolygon ((IMultiPolygon) geometry);
            }
            if (geometry is IGeometryCollection)
            {
                return WriteGeometryCollection ((IGeometryCollection) geometry);
            }
            return null;

            //var type = BitConverter.ToUInt32 (wkb, pos + 1);
            //switch (type)
            //{
            //    case (uint)GeometryType.Point:
            //        return Point (wkb, ref pos);
            //    case (uint)GeometryType.LineString:
            //        return LineString (wkb, ref pos);
            //    case (uint)GeometryType.Polygon:
            //        return Polygon (wkb, ref pos);
            //    case (uint)GeometryType.MultiPoint:
            //        return MultiPoint (wkb, ref pos);
            //    case (uint)GeometryType.MultiLineString:
            //        return MultiLineString (wkb, ref pos);
            //    case (uint)GeometryType.MultiPolygon:
            //        return MultiPolygon (wkb, ref pos);
            //    case (uint)GeometryType.GeometryCollection:
            //        return GeometryCollection (wkb, ref pos);
            //    default:
            //        throw new Exception ("Unsupported type");
            //}
        }

        public void Write (IGeometry geometry, Stream stream)
        {
            var stringResult = Write (geometry);
            using (var memoryStream = new MemoryStream (Encoding.Default.GetBytes (stringResult)))
            {
                memoryStream.CopyTo (stream);
                stream.Position = 0;
                memoryStream.Close ();
            }
        }

        public virtual string Point (IPoint point)
        {
            return string.Format (textTemplate, GeometryType.Point.ToString ("F"), PointCoord (point));
        }

        public virtual string LineString (ILineString lineString)
        {
            return string.Format (textTemplate, GeometryType.LineString.ToString ("F"), PointCoordList (lineString));
        }

        public virtual string Polygon (IPolygon polygon)
        {
            var multiLineString = new MultiLineString ();
            multiLineString.LineStrings.Add (polygon.ExteriorRing);
            var allMultiLineString = multiLineString.LineStrings.Union (polygon.InteriorRings);
            return string.Format (textTemplate, GeometryType.Polygon.ToString ("F"), CurveCoordList (allMultiLineString));
        }

        public virtual string MultiPoint (IMultiPoint multiPoint)
        {
            return string.Format (textTemplate, GeometryType.MultiPoint.ToString ("F"), PointCoordList (multiPoint));
        }

        public virtual string MultiLineString (IMultiLineString multiLineString)
        {
            return string.Format (textTemplate, GeometryType.MultiLineString.ToString ("F"), CurveCoordList (multiLineString.LineStrings));
        }

        public virtual string MultiPolygon (IMultiPolygon multiPolygon)
        {
            IList <string> stringList = new List <string> ();
            foreach (var iterPolygon in multiPolygon.Polygons)
            {
                var multiLineString = new MultiLineString ();
                multiLineString.LineStrings.Add (iterPolygon.ExteriorRing);
                var allMultiLineString = multiLineString.LineStrings.Union (iterPolygon.InteriorRings);
                // TODO: Через StringBuilder.Format
                stringList.Add (openDelimeter + CurveCoordList (allMultiLineString) + closeDelimeter);
            }
            return string.Format (textTemplate, GeometryType.MultiPolygon.ToString ("F"), string.Join (",", stringList));
        }

        public virtual string PointCoordList (IMultiPoint multiPoint)
        {
            ILineString lineString = new LineString ();
            foreach (var iterPoint in multiPoint.Points)
            {
                lineString.Vertices.Add (iterPoint);
            }
            return PointCoordList (lineString);
        }

        public virtual string PointCoordList (ILineString lineString)
        {
            IList <string> stringList = new List <string> ();
            foreach (var iterPoint in lineString.Vertices)
            {
                stringList.Add (PointCoord (iterPoint));
            }
            return string.Join (",", stringList);
        }

        protected abstract string WriteGeometryCollection (IGeometryCollection geometryCollection);


        public virtual string CurveCoordList (IEnumerable <ILineString> multiLineString)
        {
            IList <string> stringList = new List <string> ();
            foreach (var iterLineString in multiLineString)
            {
                var sb = new StringBuilder ();
                stringList.Add (sb.Append (openDelimeter).Append (PointCoordList (iterLineString)).Append (closeDelimeter).ToString ());
            }
            return string.Join (",", stringList);
        }


        public virtual string PointCoord (IPoint point)
        {
            return new StringBuilder ().Append (FormatNumber (point.X)).Append (pointCoordDelimeter).Append (FormatNumber (point.Y)).ToString ();
        }

        // TODO: FormatNumber? 
        protected static string FormatNumber (double numeric)
        {
            return numeric.ToString (nfi);
        }
    }
}