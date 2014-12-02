using System.Collections.Generic;
using System.Text;
using MapExpress.OpenGIS.GeoAPI.Geometries;

namespace MapExpress.CoreGIS.Geometries.Converters
{
    //TODO:Each entity has a keyword in upper case!
    public class WKTGeometryWriter : TextGeometryWriter
    {
        public WKTGeometryWriter () : base ("{0} ({1})", " ", "(", ")")
        {
        }

        protected override string WriteGeometryCollection (IGeometryCollection geometryCollection)
        {
            IList <string> stringList = new List <string> ();
            var sb = new StringBuilder ("GEOMETRYCOLLECTION(");
            foreach (var iterGeometry in geometryCollection)
            {
                stringList.Add (Write (iterGeometry));
            }
            return sb.Append (string.Join (",", stringList)).Append (")").ToString ();
        }
    }
}