#region

using System;
using MapExpress.CoreGIS.Geometries;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations
{
    // TODO Покрыть тестами и куда-то в другое место (нкймспейс перенести?)
    // TODO: В геометрии базовой сделать метод для перепроицирования transform и project с соотв. аргументами
    // TODO:  inverse где ?
    public class GeometryCoordinateTransform
    {
        public GeometryCoordinateTransform ()
        {
            Inverse = false;
        }

        public bool Inverse { get; set; }

        public  IGeometry Transform (ICoordinateOperation coordinateOperation, IGeometry geometry)
        {
            var geomType = geometry.GeometryType;
            switch (geomType)
            {
                case GeometryType.Point:
                    return Transform (coordinateOperation, (IPoint) geometry);
                case GeometryType.LineString:
                    return Transform (coordinateOperation, (ILineString) geometry);
                case GeometryType.Polygon:
                    return Transform (coordinateOperation, (IPolygon) geometry);
                case GeometryType.MultiPoint:
                    return Transform (coordinateOperation, (IMultiPoint) geometry);
                case GeometryType.MultiLineString:
                    return Transform (coordinateOperation, (IMultiLineString) geometry);
                case GeometryType.MultiPolygon:
                    return Transform (coordinateOperation, (IMultiPolygon) geometry);
                case GeometryType.GeometryCollection:
                    return Transform (coordinateOperation, (IGeometryCollection) geometry);
                default:
                    new ArgumentException (String.Format ("Could not transform geometry type '{0}'", geometry.GeometryType));
                    break;
            }
            return null;
        }


        public  IPoint Transform (ICoordinateOperation coordinateOperation, IPoint point)
        {
            return Inverse ? new Point (coordinateOperation.TargetCRS, coordinateOperation.MathTransform.TransformInverse (point.X, point.Y, point.Z)) : new Point (coordinateOperation.TargetCRS, coordinateOperation.MathTransform.Transform (point.X, point.Y, point.Z));
        }


        public  ILinearRing Transform (ICoordinateOperation coordinateOperation, ILinearRing lineString)
        {
            var result = new LinearRing (coordinateOperation.TargetCRS);
            foreach (var iterPoint in lineString.Vertices)
            {
                result.Vertices.Add (Transform (coordinateOperation, iterPoint));
            }
            return result;
        }

        public  ILineString Transform (ICoordinateOperation coordinateOperation, ILineString lineString)
        {
            var result = new LineString (coordinateOperation.TargetCRS);
            foreach (var iterPoint in lineString.Vertices)
            {
                result.Vertices.Add (Transform (coordinateOperation, iterPoint));
            }
            return result;
        }

        public  IPolygon Transform (ICoordinateOperation coordinateOperation, IPolygon polygon)
        {
            var result = new Polygon (coordinateOperation.TargetCRS) {ExteriorRing = Transform (coordinateOperation, polygon.ExteriorRing)};
            foreach (var iterInteriorRing in polygon.InteriorRings)
            {
                result.InteriorRings.Add (Transform (coordinateOperation, iterInteriorRing));
            }
            return result;
        }

        public  IMultiPoint Transform (ICoordinateOperation coordinateOperation, IMultiPoint multiPoint)
        {
            var result = new MultiPoint (coordinateOperation.TargetCRS);
            foreach (var iterPoint in multiPoint.Points)
            {
                result.Points.Add (Transform (coordinateOperation, iterPoint));
            }
            return result;
        }

        public  IMultiLineString Transform (ICoordinateOperation coordinateOperation, IMultiLineString multiLineString)
        {
            var result = new MultiLineString (coordinateOperation.TargetCRS);
            foreach (var iterLineString in multiLineString.LineStrings)
            {
                result.LineStrings.Add (Transform (coordinateOperation, iterLineString));
            }
            return result;
        }

        public  IMultiPolygon Transform (ICoordinateOperation coordinateOperation, IMultiPolygon multiPolygon)
        {
            var result = new MultiPolygon (coordinateOperation.TargetCRS);
            foreach (var iterMultiPolygon in multiPolygon.Polygons)
            {
                result.Polygons.Add (Transform (coordinateOperation, iterMultiPolygon));
            }
            return result;
        }

        public  IGeometryCollection Transform (ICoordinateOperation coordinateOperation, IGeometryCollection geometryCollection)
        {
            var result = new GeometryCollection (coordinateOperation.TargetCRS);
            foreach (IGeometry iterGeom in geometryCollection.Geometries)
            {
                result.Geometries.Add (Transform (coordinateOperation, iterGeom));
            }
            return result;
        }
    }
}