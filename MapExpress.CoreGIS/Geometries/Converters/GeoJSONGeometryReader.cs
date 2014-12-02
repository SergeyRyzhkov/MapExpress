#region

using System;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Geometries;

#endregion

namespace MapExpress.CoreGIS.Geometries.Converters
{
    // TODO: Избежать лишних тоаппер, если сравниваь то через StringComparison.OrdinalIgnoreCase
    // TODO: Сделать через Incntance все ридеры врайтеры 
    public class GeoJSONGeometryReader : TextGeometryReader
    {
        public GeoJSONGeometryReader () : base (",", "],", "]],", "]]],", "]],")
        {
        }

        public override IGeometryCollection GeometryCollection (string geomText)
        {
            var result = new GeometryCollection ();
            var geometriesText = geomText.ToUpper ().Replace ("GEOMETRYCOLLECTION", "").Split (new[] {"},"}, StringSplitOptions.None);
            foreach (var geometryText in geometriesText)
            {
                result.Geometries.Add (Read (geometryText));
            }
            return result;
        }

        protected override string NormalizeText (string text)
        {
            return InternalNormalizeText (text, ']');
        }


        protected override string ClearText (string text)
        {
            var result = text.ToUpper ();
            var geomTypes = Enum.GetNames (typeof (GeometryType));
            result = geomTypes.Aggregate (result, (current, geomType) => current.Replace (geomType.ToUpper (), ""));
            result = result.IndexOf ("[") > -1 ? result.Substring (result.IndexOf ("[")) : result;
            return result
                .Replace ("{", "")
                .Replace ("}", "")
                .Replace ("[", "")
                .Replace ("]", "")
                .Replace ("MULTI", "")
                .Replace (Environment.NewLine, "")
                .Replace ("COORDINATES", "")
                .Replace (":", "")
                .Trim ();
        }
    }
}