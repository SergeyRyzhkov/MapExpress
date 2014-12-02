using System;
using System.Collections.Generic;
using System.Linq;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Geometries;

namespace MapExpress.CoreGIS.Geometries.Converters
{
    // TODO: Во всех! редерах и врайтерах добавить в методы Read Write
    public static class WKBGeometryReader
    {
        public static IGeometry Read (byte[] wkb)
        {
            var pos = 0;
            return Read (wkb, ref pos);
        }

        private static IGeometry Read (byte[] wkb, ref int pos)
        {
            var geometryType = ToUInt32 (wkb, pos + 1);

            switch ((WKBGeometryType) geometryType)
            {
                case WKBGeometryType.WKBPoint:
                case WKBGeometryType.WKBPointZ:
                case WKBGeometryType.WKBPointM:
                case WKBGeometryType.WKBPointZM:
                    return ReadPoint (wkb, ref pos);
                case WKBGeometryType.WKBLineString:
                case WKBGeometryType.WKBLineStringZ:
                case WKBGeometryType.WKBLineStringM:
                case WKBGeometryType.WKBLineStringZM:
                    return ReadLineString (wkb, ref pos);
                case WKBGeometryType.WKBPolygon:
                case WKBGeometryType.WKBPolygonZ:
                case WKBGeometryType.WKBPolygonM:
                case WKBGeometryType.WKBPolygonZM:
                    return ReadPolygon (wkb, ref pos);
                case WKBGeometryType.WKBMultiPoint:
                case WKBGeometryType.WKBMultiPointZ:
                case WKBGeometryType.WKBMultiPointM:
                case WKBGeometryType.WKBMultiPointZM:
                    return ReadMultiPoint (wkb, ref pos);
                case WKBGeometryType.WKBMultiLineString:
                case WKBGeometryType.WKBMultiLineStringZ:
                case WKBGeometryType.WKBMultiLineStringM:
                case WKBGeometryType.WKBMultiLineStringZM:
                    return ReadMultiLineString (wkb, ref pos);
                case WKBGeometryType.WKBMultiPolygon:
                case WKBGeometryType.WKBMultiPolygonZ:
                case WKBGeometryType.WKBMultiPolygonM:
                case WKBGeometryType.WKBMultiPolygonZM:
                    return ReadMultiPolygon (wkb, ref pos);
                case WKBGeometryType.WKBGeometryCollection:
                case WKBGeometryType.WKBGeometryCollectionZ:
                case WKBGeometryType.WKBGeometryCollectionM:
                case WKBGeometryType.WKBGeometryCollectionZM:
                    return ReadGeometryCollection (wkb, ref pos);
                default:
                    throw new ArgumentException ("Geometry type not recognized. GeometryCode: " + geometryType);
            }
        }

        private static IPoint ReadPoint (byte[] wkb, ref int pos)
        {
            pos += 5;
            var point = new Point (null, ToDouble (wkb, pos), ToDouble (wkb, pos + 8));
            pos += 16;
            return point;
        }

        private static ILineString ReadLineString (byte[] wkb, ref int pos)
        {
            var nbPoints = ToUInt32 (wkb, pos + 5);
            pos += 9;
            var points = new Point[nbPoints];
            for (var i = 0; i < nbPoints; ++i)
            {
                points [i] = new Point (null, ToDouble (wkb, pos), ToDouble (wkb, pos + 8));
                pos += 16;
            }
            return new LineString (null, points);
        }

        private static IPolygon ReadPolygon (byte[] wkb, ref int pos)
        {
            var nbRings = ToUInt32 (wkb, pos + 5);
            pos += 9;
            var rings = new LinearRing[nbRings];
            for (var r = 0; r < nbRings; ++r)
            {
                var nbPoints = ToUInt32 (wkb, pos);
                pos += 4;
                var points = new Point[nbPoints];
                for (var i = 0; i < nbPoints; ++i)
                {
                    points [i] = new Point (null, ToDouble (wkb, pos), ToDouble (wkb, pos + 8));
                    pos += 16;
                }
                rings [r] = new LinearRing (null, points);
            }
            return new Polygon (null, rings [0], rings.Skip (1));
        }

        private static IMultiPoint ReadMultiPoint (byte[] wkb, ref int pos)
        {
            var nbPoints = ToUInt32 (wkb, pos + 5);
            pos += 9;
            var points = new Point[nbPoints];
            for (var i = 0; i < nbPoints; ++i)
            {
                points [i] = (Point) ReadPoint (wkb, ref pos);
            }
            return new MultiPoint (null, points);
        }

        private static IMultiLineString ReadMultiLineString (byte[] wkb, ref int pos)
        {
            var nbLineStrings = ToUInt32 (wkb, pos + 5);
            pos += 9;
            var lineStrings = new LineString[nbLineStrings];
            for (var i = 0; i < nbLineStrings; ++i)
            {
                lineStrings [i] = (LineString) ReadLineString (wkb, ref pos);
            }
            return new MultiLineString (null, lineStrings);
        }

        private static IMultiPolygon ReadMultiPolygon (byte[] wkb, ref int pos)
        {
            var nbPolygons = ToUInt32 (wkb, pos + 5);
            pos += 9;
            var polygons = new Polygon[nbPolygons];
            for (var r = 0; r < nbPolygons; ++r)
            {
                polygons [r] = (Polygon) ReadPolygon (wkb, ref pos);
            }
            return new MultiPolygon (null, polygons);
        }

        private static IGeometryCollection ReadGeometryCollection (byte[] wkb, ref int pos)
        {
            var nbShapes = ToUInt32 (wkb, pos + 5);
            pos += 9;
            var geometries = new List <IGeometry> ();
            for (var r = 0; r < nbShapes; ++r)
            {
                geometries.Add (Read (wkb, ref pos));
            }
            return new GeometryCollection (null, geometries);
        }

        private static double ToDouble (byte[] wkb, int position)
        {
            return BitConverter.ToInt32 (wkb, 0) == 0 ? BigEndianBitConverter.ToDouble (wkb, position) : BitConverter.ToDouble (wkb, position);
        }

        private static uint ToUInt32 (byte[] wkb, int position)
        {
            return BitConverter.ToInt32 (wkb, 0) == 0 ? BigEndianBitConverter.ToUInt32 (wkb, position) : BitConverter.ToUInt32 (wkb, position);
        }
    }
}