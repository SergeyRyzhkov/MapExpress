#region

using System;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Geometries;

#endregion

namespace MapExpress.CoreGIS.Geometries.Converters
{
    public class WKTGeometryReader : TextGeometryReader
    {
        public WKTGeometryReader () : base (" ", ",", "),", ")),", "),")
        {
        }

        public override IGeometryCollection GeometryCollection (string geomText)
        {
            var result = new GeometryCollection ();
            var iterGeomText = geomText.ToUpper ().Replace ("GEOMETRYCOLLECTION", "");

            while (true)
            {
                var geometry = Read (iterGeomText);
                if (geometry != null)
                {
                    result.Geometries.Add (geometry);
                    iterGeomText = ProcessGeoemtryText (geometry, iterGeomText);
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        protected override string NormalizeText (string text)
        {
            return InternalNormalizeText (text, ')');
        }

        protected override string ClearText (string text)
        {
            var result = text.ToUpper ();
            var geomTypes = Enum.GetNames (typeof (GeometryType));
            result = geomTypes.Aggregate (result, (current, geomType) => current.Replace (geomType.ToUpper (), ""));
            return result.Replace ("(", "").Replace (")", "").Replace ("MULTI", "").Trim ();
        }

        private string ProcessGeoemtryText (IGeometry geometry, string geomText)
        {
            var geomTypeString = geometry.GeometryType.ToString ("F").ToUpper ();
            var index = geomText.IndexOf (geomTypeString);
            if (index > -1)
            {
                return geomText.Remove (index, geomTypeString.Length);
            }
            return geomText;
        }
    }
}