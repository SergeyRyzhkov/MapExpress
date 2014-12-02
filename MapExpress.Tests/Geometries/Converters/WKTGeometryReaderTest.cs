using MapExpress.CoreGIS.Geometries;
using MapExpress.CoreGIS.Geometries.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MapExpress.Tests.Geometries.Converters
{
    [TestClass]
    public class WKTGeometryReaderTest
    {
        private static WKTGeometryReader reader = new WKTGeometryReader ();

        [TestMethod]
        public void WritePointToWKT ()
        {
            var point = new Point
                            {
                                X = 10,
                                Y = 20
                            };
            Assert.AreEqual (reader.Read ("Point (10 20)"), point);
        }

        [TestMethod]
        public void WriteLineStringToWKT ()
        {
            var lineString = new LineString ();
            lineString.Vertices.Add (new Point (null, 10, 20));
            lineString.Vertices.Add (new Point (null, 20, 30));
            lineString.Vertices.Add (new Point (null, 40, 60));
            Assert.AreEqual (reader.Read ("LineString (10 20,20 30,40 60)"), lineString);
        }

        [TestMethod]
        public void WritePolygonToWKT ()
        {
            var exteriror = new LinearRing ();
            exteriror.Vertices.Add (new Point (null, 35, 10));
            exteriror.Vertices.Add (new Point (null, 45, 45));
            exteriror.Vertices.Add (new Point (null, 15, 40));
            exteriror.Vertices.Add (new Point (null, 10, 20));
            exteriror.Vertices.Add (new Point (null, 35, 10));

            var polygon = new Polygon (null, exteriror);
            Assert.AreEqual ("Polygon ((35 10,45 45,15 40,10 20,35 10))", polygon.ExportToWKT ());

            var interior = new LinearRing ();
            interior.Vertices.Add (new Point (null, 20, 30));
            interior.Vertices.Add (new Point (null, 35, 35));
            interior.Vertices.Add (new Point (null, 30, 20));
            interior.Vertices.Add (new Point (null, 20, 30));

            var polygon2 = new Polygon (null, exteriror);
            polygon2.InteriorRings.Add (interior);
            Assert.AreEqual (reader.Read ("Polygon ((35 10,45 45,15 40,10 20,35 10),(20 30,35 35,30 20,20 30))"), polygon2);
        }

        [TestMethod]
        public void WriteMultiPointToWKT ()
        {
            var multiPoint = new MultiPoint ();
            multiPoint.Points.Add (new Point (null, 10, 40));
            multiPoint.Points.Add (new Point (null, 40, 30));
            multiPoint.Points.Add (new Point (null, 20, 20));
            multiPoint.Points.Add (new Point (null, 30, 10));

            Assert.AreEqual (reader.Read ("MultiPoint (10 40,40 30,20 20,30 10)"), multiPoint);
        }

        [TestMethod]
        public void WriteMultiLineStringToWKT ()
        {
            var multiLineString = new MultiLineString ();
            var lineString1 = new LineString ();
            var lineString2 = new LineString ();

            lineString1.Vertices.Add (new Point (null, 10, 10));
            lineString1.Vertices.Add (new Point (null, 20, 20));
            lineString1.Vertices.Add (new Point (null, 10, 40));

            lineString2.Vertices.Add (new Point (null, 40, 40));
            lineString2.Vertices.Add (new Point (null, 30, 30));
            lineString2.Vertices.Add (new Point (null, 40, 20));
            lineString2.Vertices.Add (new Point (null, 30, 10));

            multiLineString.LineStrings.Add (lineString1);
            multiLineString.LineStrings.Add (lineString2);

            Assert.AreEqual (reader.Read ("MultiLineString ((10 10,20 20,10 40),(40 40,30 30,40 20,30 10))"), multiLineString);
        }

        [TestMethod]
        public void WriteMultiPolygonToWKT ()
        {
            var exteriror = new LinearRing ();
            exteriror.Vertices.Add (new Point (null, 35, 10));
            exteriror.Vertices.Add (new Point (null, 45, 45));
            exteriror.Vertices.Add (new Point (null, 15, 40));
            exteriror.Vertices.Add (new Point (null, 10, 20));
            exteriror.Vertices.Add (new Point (null, 35, 10));

            var interior = new LinearRing ();
            interior.Vertices.Add (new Point (null, 20, 30));
            interior.Vertices.Add (new Point (null, 35, 35));
            interior.Vertices.Add (new Point (null, 30, 20));
            interior.Vertices.Add (new Point (null, 20, 30));

            var polygon = new Polygon (null, exteriror);
            polygon.InteriorRings.Add (interior);


            var exteriror1 = new LinearRing ();
            exteriror1.Vertices.Add (new Point (null, 45, 20));
            exteriror1.Vertices.Add (new Point (null, 55, 55));
            exteriror1.Vertices.Add (new Point (null, 25, 50));
            exteriror1.Vertices.Add (new Point (null, 20, 30));
            exteriror1.Vertices.Add (new Point (null, 45, 20));

            var interior1 = new LinearRing ();
            interior1.Vertices.Add (new Point (null, 30, 40));
            interior1.Vertices.Add (new Point (null, 45, 45));
            interior1.Vertices.Add (new Point (null, 40, 30));
            interior1.Vertices.Add (new Point (null, 30, 40));

            var polygon1 = new Polygon (null, exteriror1);
            polygon1.InteriorRings.Add (interior1);

            var multiPolygon = new MultiPolygon ();
            multiPolygon.Polygons.Add (polygon);
            multiPolygon.Polygons.Add (polygon1);

            Assert.AreEqual (reader.Read ("MultiPolygon (((35 10,45 45,15 40,10 20,35 10),(20 30,35 35,30 20,20 30)),((45 20,55 55,25 50,20 30,45 20),(30 40,45 45,40 30,30 40)))"), multiPolygon);
        }

        [TestMethod]
        public void WriteGeometryCollectionToWKT ()
        {
            var point = new Point (null, 4, 6);

            var lineString = new LineString (null);
            lineString.Vertices.Add (new Point (null, 4, 6));
            lineString.Vertices.Add (new Point (null, 7, 10));
            lineString.Vertices.Add (new Point (null, 10, 40));

            var geomCollection = new GeometryCollection ();
            geomCollection.Geometries.Add (point);
            geomCollection.Geometries.Add (lineString);

            var resultGeom = reader.Read ("GEOMETRYCOLLECTION(Point (4 6),LineString (4 6,7 10,10 40))");

            Assert.AreEqual (resultGeom, geomCollection);
        }
    }
}