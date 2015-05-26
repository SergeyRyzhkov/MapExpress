//#region

//using System;
//using System.Globalization;
//using System.IO;
//using System.Text;
//using MapExpress.CoreGIS.Referencing;
//using MapExpress.OpenGIS.GeoAPI.Geometries;

//#endregion

//namespace MapExpress.CoreGIS.Geometries.Converters
//{
//    public class KMLWriter
//    {
//        public const string AltitudeModeClampToGround = "clampToGround ";

//        public const string AltitudeModeRelativeToGround = "relativeToGround  ";

//        public const string AltitudeModeAbsolute = "absolute";

//        public static string WriteGeometry (IGeometry geometry, double z)
//        {
//            var writer = new KMLWriter
//                             {
//                                 Z = z
//                             };
//            return writer.Write (geometry);
//        }

//        public KMLWriter ()
//        {
//            CreateDefaultFormatter ();
//        }

//        private void CreateDefaultFormatter ()
//        {
//            CreateFormatter (-1);
//        }


//        public static string WriteGeometry (IGeometry geometry, double z, int precision,
//                                            bool extrude, string altitudeMode)
//        {
//            var writer = new KMLWriter
//                             {
//                                 Z = z,
//                                 Precision = precision,
//                                 Extrude = extrude,
//                                 AltitudeMode = altitudeMode
//                             };
//            return writer.Write (geometry);
//        }

//        private const int IndentSize = 2;
//        private const string CoordinateSeparator = ",";
//        private const string TupleSeparator = " ";

//        private int _maxCoordinatesPerLine = 5;
//        private double _z = Double.NaN;
//        private NumberFormatInfo _formatter;
//        private string _format;

//        public string LinePrefix { get; set; }

//        public int MaxCoordinatesPerLine
//        {
//            get { return _maxCoordinatesPerLine; }
//            set { _maxCoordinatesPerLine = Math.Max (1, value); }
//        }

//        public double Z
//        {
//            get { return _z; }
//            set { _z = value; }
//        }

//        public bool Extrude { get; set; }

//       public bool Tesselate { get; set; }

//          public string AltitudeMode { get; set; }

     
//        public int Precision
//        {
//            get { return _formatter.NumberDecimalDigits; }
//            set { CreateFormatter (value); }
//        }

//        private void CreateFormatter (int precision)
//        {
//            var precisionModel = precision < 0
//                                     ? new PrecisionModel (PrecisionModels.Floating)
//                                     : new PrecisionModel (precision);
//            _formatter = WKTWriter.CreateFormatter (precisionModel);
//            string digits = WKTWriter.StringOfChar ('#', _formatter.NumberDecimalDigits);
//            _format = String.Format ("0.{0}", digits);
//        }

//        /// <summary>
//        /// Writes a <see cref="IGeometry"/> in KML format as a string.
//        /// </summary>
//        /// <param name="geom">the geometry to write</param>
//        /// <returns>a string containing the KML geometry representation</returns>
//        public string Write (IGeometry geom)
//        {
//            var sb = new StringBuilder ();
//            Write (geom, sb);
//            return sb.ToString ();
//        }

//        /// <summary>
//        /// Writes the KML representation of a <see cref="IGeometry"/> to a <see cref="TextWriter"/>.
//        /// </summary>
//        /// <param name="geom">the geometry to write</param>
//        /// <param name="writer">the writer to write to</param>
//        public void Write (IGeometry geom, TextWriter writer)
//        {
//            var kml = Write (geom);
//            writer.Write (kml);
//        }

//        /// <summary>
//        /// Appends the KML representation of a <see cref="IGeometry"/> to a <see cref="StringBuilder"/>.
//        /// </summary>
//        /// <param name="geom">the geometry to write</param>
//        /// <param name="sb">the buffer to write into</param>
//        public void Write (IGeometry geom, StringBuilder sb)
//        {
//            WriteGeometry (geom, 0, sb);
//        }

//        private void WriteGeometry (IGeometry g, int level, StringBuilder sb)
//        {
//            if (g is IPoint)
//                WritePoint (g as IPoint, level, sb);
//            else if (g is ILinearRing)
//                WriteLinearRing (g as ILinearRing, level, sb, true);
//            else if (g is ILineString)
//                WriteLineString (g as ILineString, level, sb);
//            else if (g is IPolygon)
//                WritePolygon (g as IPolygon, level, sb);
//            else if (g is IGeometryCollection)
//                WriteGeometryCollection (g as IGeometryCollection, level, sb);
//            else
//                throw new ArgumentException (string.Format ("Geometry type not supported: {0}", g.GeometryType));
//        }

//        private void StartLine (string text, int level, StringBuilder sb)
//        {
//            if (LinePrefix != null)
//                sb.Append (LinePrefix);
//            sb.Append (WKTWriter.StringOfChar (' ', IndentSize * level));
//            sb.Append (text);
//        }

//        private string GeometryTag (string geometryName)
//        {
//            var sb = new StringBuilder ();
//            sb.Append ("<");
//            sb.Append (geometryName);
//            sb.Append (">");
//            return sb.ToString ();
//        }

//        private void WriteModifiers (int level, StringBuilder sb)
//        {
//            if (Extrude)
//                StartLine ("<extrude>1</extrude>\n", level, sb);
//            if (Tesselate)
//                StartLine ("<tesselate>1</tesselate>\n", level, sb);
//            if (AltitudeMode != null)
//            {
//                var s = String.Format ("<altitudeMode>{0}</altitudeMode>\n", AltitudeMode);
//                StartLine (s, level, sb);
//            }
//        }

//        private void WritePoint (IPoint p, int level,
//                                 StringBuilder sb)
//        {
//            // <Point><coordinates>...</coordinates></Point>
//            StartLine (GeometryTag ("Point") + "\n", level, sb);
//            WriteModifiers (level, sb);
//            Write (new[] {p.Coordinate}, level + 1, sb);
//            StartLine ("</Point>\n", level, sb);
//        }

//        private void WriteLineString (ILineString ls, int level,
//                                      StringBuilder sb)
//        {
//            // <LineString><coordinates>...</coordinates></LineString>
//            StartLine (GeometryTag ("LineString") + "\n", level, sb);
//            WriteModifiers (level, sb);
//            Write (ls.Coordinates, level + 1, sb);
//            StartLine ("</LineString>\n", level, sb);
//        }

//        private void WriteLinearRing (ILinearRing lr, int level,
//                                      StringBuilder sb, bool writeModifiers)
//        {
//            // <LinearRing><coordinates>...</coordinates></LinearRing>
//            StartLine (GeometryTag ("LinearRing") + "\n", level, sb);
//            if (writeModifiers)
//                WriteModifiers (level, sb);
//            Write (lr.Coordinates, level + 1, sb);
//            StartLine ("</LinearRing>\n", level, sb);
//        }

//        private void WritePolygon (IPolygon p, int level,
//                                   StringBuilder sb)
//        {
//            StartLine (GeometryTag ("Polygon") + "\n", level, sb);
//            WriteModifiers (level, sb);

//            StartLine ("  <outerBoundaryIs>\n", level, sb);
//            WriteLinearRing (p.ExteriorRing, level + 1, sb, false);
//            StartLine ("  </outerBoundaryIs>\n", level, sb);

//            for (var t = 0; t < p.NumInteriorRings; t++)
//            {
//                StartLine ("  <innerBoundaryIs>\n", level, sb);
//                WriteLinearRing ((ILinearRing) p.GetInteriorRingN (t), level + 1, sb, false);
//                StartLine ("  </innerBoundaryIs>\n", level, sb);
//            }

//            StartLine ("</Polygon>\n", level, sb);
//        }

//        private void WriteGeometryCollection (IGeometryCollection gc, int level,
//                                              StringBuilder sb)
//        {
//            StartLine ("<MultiGeometry>\n", level, sb);
//            for (var t = 0; t < gc.NumGeometries; t++)
//                WriteGeometry (gc.GetGeometryN (t), level + 1, sb);
//            StartLine ("</MultiGeometry>\n", level, sb);
//        }

//        /// <summary>
//        /// Takes a list of coordinates and converts it to KML.
//        /// </summary>
//        /// <remarks>
//        /// 2D and 3D aware. Terminates the coordinate output with a newline.
//        /// </remarks>
//        private void Write (Coordinate[] coords, int level,
//                            StringBuilder sb)
//        {
//            StartLine ("<coordinates>", level, sb);

//            var isNewLine = false;
//            for (var i = 0; i < coords.Length; i++)
//            {
//                if (i > 0)
//                    sb.Append (TupleSeparator);

//                if (isNewLine)
//                {
//                    StartLine ("  ", level, sb);
//                    isNewLine = false;
//                }

//                Write (coords [i], sb);

//                // break output lines to prevent them from getting too long
//                if ((i + 1) % MaxCoordinatesPerLine == 0 && i < coords.Length - 1)
//                {
//                    sb.Append ("\n");
//                    isNewLine = true;
//                }
//            }
//            sb.Append ("</coordinates>\n");
//        }

//        private void Write (Coordinate p, StringBuilder sb)
//        {
//            Write (p.X, sb);
//            sb.Append (CoordinateSeparator);
//            Write (p.Y, sb);

//            var z = p.Z;
//            // if altitude was specified directly, use it
//            if (!Double.IsNaN (Z))
//                z = Z;

//            // only write if Z present
//            // MD - is this right? Or should it always be written?
//            if (!Double.IsNaN (z))
//            {
//                sb.Append (CoordinateSeparator);
//                Write (z, sb);
//            }
//        }

//        private void Write (double d, StringBuilder sb)
//        {
//            var tos = d.ToString (_format, _formatter);
//            sb.Append (tos);
//        }
//    }
//}