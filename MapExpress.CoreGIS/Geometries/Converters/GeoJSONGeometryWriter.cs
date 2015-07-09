#region

using System.Collections.Generic;
using System.Text;
using MapExpress.OpenGIS.GeoAPI.Geometries;

#endregion

namespace MapExpress.CoreGIS.Geometries.Converters
{
    public class GeoJSONGeometryWriter : TextGeometryWriter
    {
        public GeoJSONGeometryWriter () : base ("{{\"type\":\"{0}\",\"coordinates\":[{1}]}}", ",", "[", "]")
        {
        }


        public override string PointCoord (IPoint point)
        {
            return new StringBuilder ("[").Append (FormatNumber (point.X)).Append (",").Append (FormatNumber (point.Y)).Append ("]").ToString ();
        }

        // TODO: А тут с форматом правильно? Не будет запятых в разделитетле?
        public override string Point (IPoint point)
        {
            return string.Format (textTemplate, GeometryType.Point.ToString ("F"), new StringBuilder ().Append (point.X).Append (",").Append (point.Y));
        }


        protected override string WriteGeometryCollection (IGeometryCollection geometryCollection)
        {
            var stringList = new List <string> ();
            var sb = new StringBuilder ("{\"type\":\"GeometryCollection\",\"geometries\":[");
            foreach (var iterGeometry in geometryCollection)
            {
                var iterString = Write (iterGeometry);
                stringList.Add (iterString);
            }
            return sb.Append (string.Join (",", stringList)).Append ("]}").ToString ();
        }
    }
}