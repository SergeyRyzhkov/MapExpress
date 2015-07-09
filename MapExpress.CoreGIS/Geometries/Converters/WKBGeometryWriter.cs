#region

using System;
using System.Collections.Generic;
using System.IO;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.Geometries.Converters
{
    //TODO: Методы назвать Write...
    public static class WKBGeometryWriter
    {
        public static byte[] Write (IGeometry geometry, ByteOrderType byteOrderType)
        {
            using (var memoryStream = new MemoryStream ())
            {
                Write (geometry, memoryStream, byteOrderType);
                memoryStream.Position = 0;
                return memoryStream.ToArray ();
            }
        }


        public static void Write (IGeometry geometry, Stream stream, ByteOrderType byteOrderType)
        {
            using (var memoryStream = new MemoryStream ())
            {
                Write (geometry, memoryStream, byteOrderType);
                memoryStream.CopyTo (stream);
                stream.Position = 0;
            }
        }

        private static void Write (IGeometry geometry, MemoryStream writer, ByteOrderType byteOrderType)
        {
            var type = geometry.GeometryType;
            switch (type)
            {
                case GeometryType.Point:
                    Write ((IPoint) geometry, writer, byteOrderType);
                    break;
                case GeometryType.LineString:
                    Write ((ILineString) geometry, writer, byteOrderType);
                    break;
                case GeometryType.Polygon:
                    Write ((IPolygon) geometry, writer, byteOrderType);
                    break;
                case GeometryType.MultiPoint:
                    Write ((IMultiPoint) geometry, writer, byteOrderType);
                    break;
                case GeometryType.MultiLineString:
                    Write ((IMultiLineString) geometry, writer, byteOrderType);
                    break;
                case GeometryType.MultiPolygon:
                    Write ((IMultiPolygon) geometry, writer, byteOrderType);
                    break;
                case GeometryType.GeometryCollection:
                    Write ((IGeometryCollection) geometry, writer, byteOrderType);
                    break;
                default:
                    throw new Exception ("Unsupported geometry type");
            }
        }

        private static void Write (IPoint point, MemoryStream writer, ByteOrderType byteOrderType)
        {
            WriteByteOrder (writer, byteOrderType);
            WriteInt (writer, byteOrderType, 1);

            WriteCoordinate (point, writer, byteOrderType);
        }


        private static void Write (ILineString lineString, MemoryStream writer, ByteOrderType byteOrderType)
        {
            WriteByteOrder (writer, byteOrderType);
            WriteInt (writer, byteOrderType, 2);

            WriteInt (writer, byteOrderType, lineString.Vertices.Count);
            WritePointSequence (lineString.Vertices, writer, byteOrderType);
        }

        private static void Write (IPolygon polygon, MemoryStream writer, ByteOrderType byteOrderType)
        {
            WriteByteOrder (writer, byteOrderType);
            WriteInt (writer, byteOrderType, 3);

            WriteInt (writer, byteOrderType, (polygon.InteriorRings.Count + 1));

            WriteInt (writer, byteOrderType, polygon.ExteriorRing.Vertices.Count);
            WritePointSequence (polygon.ExteriorRing.Vertices, writer, byteOrderType);

            foreach (var iterInteriorRing in polygon.InteriorRings)
            {
                WriteInt (writer, byteOrderType, iterInteriorRing.Vertices.Count);
                WritePointSequence (iterInteriorRing.Vertices, writer, byteOrderType);
            }
        }

        private static void Write (IMultiPoint multiPoint, MemoryStream writer, ByteOrderType byteOrderType)
        {
            WriteByteOrder (writer, byteOrderType);
            WriteInt (writer, byteOrderType, 4);
            WriteInt (writer, byteOrderType, multiPoint.Points.Count);
            foreach (var iterPoint in multiPoint.Points)
            {
                Write (iterPoint, writer, byteOrderType);
            }
        }

        private static void Write (IMultiLineString multiLineString, MemoryStream writer, ByteOrderType byteOrderType)
        {
            WriteByteOrder (writer, byteOrderType);
            WriteInt (writer, byteOrderType, 5);
            WriteInt (writer, byteOrderType, multiLineString.LineStrings.Count);
            foreach (var iterLineString in multiLineString.LineStrings)
            {
                Write (iterLineString, writer, byteOrderType);
            }
        }

        private static void Write (IMultiPolygon multiPolygon, MemoryStream writer, ByteOrderType byteOrderType)
        {
            WriteByteOrder (writer, byteOrderType);
            WriteInt (writer, byteOrderType, 6);
            WriteInt (writer, byteOrderType, multiPolygon.Polygons.Count);
            foreach (var iterPolygon in multiPolygon.Polygons)
            {
                Write (iterPolygon, writer, byteOrderType);
            }
        }

        private static void Write (IGeometryCollection geomCollection, MemoryStream writer, ByteOrderType byteOrderType)
        {
            WriteByteOrder (writer, byteOrderType);
            WriteInt (writer, byteOrderType, 7);
            WriteInt (writer, byteOrderType, geomCollection.Geometries.Count);
            foreach (var iterGeom in geomCollection.Geometries)
            {
                Write (iterGeom, writer, byteOrderType);
            }
        }


        private static void WriteByteOrder (MemoryStream writer, ByteOrderType byteOrderType)
        {
            writer.WriteByte ((byte) byteOrderType);
        }

        private static void WriteCoordinate (IPoint coordinate, MemoryStream writer, ByteOrderType byteOrderType)
        {
            WriteDouble (writer, byteOrderType, coordinate.X);
            WriteDouble (writer, byteOrderType, coordinate.Y);
        }

        private static void WritePointSequence (IEnumerable <IPoint> pointSequence, MemoryStream writer, ByteOrderType byteOrderType)
        {
            foreach (var point in pointSequence)
            {
                WriteCoordinate (point, writer, byteOrderType);
            }
        }

        private static void WriteInt (MemoryStream writer, ByteOrderType byteOrderType, int value)
        {
            var bytes = BitConverter.GetBytes (value);
            if (byteOrderType == ByteOrderType.BigEndian)
            {
                Array.Reverse (bytes, 0, 4);
            }
            writer.WriteByte (bytes [0]);
            writer.WriteByte (bytes [1]);
            writer.WriteByte (bytes [2]);
            writer.WriteByte (bytes [3]);
        }

        private static void WriteDouble (MemoryStream writer, ByteOrderType byteOrderType, double value)
        {
            var bytes = BitConverter.GetBytes (value);
            if (byteOrderType == ByteOrderType.BigEndian)
            {
                Array.Reverse (bytes, 0, 8);
            }
            writer.WriteByte (bytes [0]);
            writer.WriteByte (bytes [1]);
            writer.WriteByte (bytes [2]);
            writer.WriteByte (bytes [3]);
            writer.WriteByte (bytes [4]);
            writer.WriteByte (bytes [5]);
            writer.WriteByte (bytes [6]);
            writer.WriteByte (bytes [7]);
        }
    }
}