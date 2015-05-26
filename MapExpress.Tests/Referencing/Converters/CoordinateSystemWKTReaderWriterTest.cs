using MapExpress.CoreGIS.Referencing.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MapExpress.Tests.Referencing.Converters
{
    [TestClass]
    public class CoordinateSystemWKTReaderWriterTest
    {
        [TestMethod]
        public void ReadUnitTest ()
        {
            var wkt = "UNIT[\"DMSH\",0.0174532925199433]";
            var unit = WKTCoordinateSystemReader.Instance.ReadUnit (wkt);
            Assert.AreEqual (wkt, WKTCoordinateSystemWriter.Instance.WriteUnit (unit));

            var wkt1 = "UNIT[\"DMSH\",0.0174532925199433,AUTHORITY[\"EPSG\",\"9108\"]]";
            var unit1 = WKTCoordinateSystemReader.Instance.ReadUnit (wkt1);
            Assert.AreEqual (wkt1, WKTCoordinateSystemWriter.Instance.WriteUnit (unit1));
        }


        [TestMethod]
        public void ReadMeridianTest ()
        {
            var wkt = "PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]]";
            var meredian = WKTCoordinateSystemReader.Instance.ReadPrimeMeridian (wkt);
            Assert.AreEqual (wkt, WKTCoordinateSystemWriter.Instance.WritePrimeMeridian (meredian));

            var wkt1 = "PRIMEM[\"Greenwich\",0]";
            var meredian1 = WKTCoordinateSystemReader.Instance.ReadPrimeMeridian (wkt1);
            Assert.AreEqual (wkt1, WKTCoordinateSystemWriter.Instance.WritePrimeMeridian (meredian1));
        }

        [TestMethod]
        public void ReadDatumTest ()
        {
            var wkt = "DATUM[\"OSGB 1936\",SPHEROID[\"Airy 1830\",6377563.396,299.3249646,AUTHORITY[\"EPSG\",\"7001\"]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[\"EPSG\",\"6277\"]]";
            var datum = WKTCoordinateSystemReader.Instance.ReadDatum (wkt);
            Assert.AreEqual (wkt, WKTCoordinateSystemWriter.Instance.WriteDatum (datum));

            var wkt1 = "DATUM[\"OSGB 1936\",SPHEROID[\"Airy 1830\",6377563.396,299.3249646],TOWGS84[0,0,0,0,0,0,0]]";
            var datum1 = WKTCoordinateSystemReader.Instance.ReadDatum (wkt1);
            Assert.AreEqual (wkt1, WKTCoordinateSystemWriter.Instance.WriteDatum (datum1));

            var wkt2 = "DATUM[\"OSGB 1936\",SPHEROID[\"Airy 1830\",6377563.396,299.3249646,AUTHORITY[\"EPSG\",\"7001\"]],AUTHORITY[\"EPSG\",\"6277\"]]";
            var datum2 = WKTCoordinateSystemReader.Instance.ReadDatum (wkt2);
            Assert.AreEqual (wkt2, WKTCoordinateSystemWriter.Instance.WriteDatum (datum2));

            var wkt3 = "DATUM[\"OSGB 1936\",SPHEROID[\"Airy 1830\",6377563.396,299.3249646,AUTHORITY[\"EPSG\",\"7001\"]]]";
            var datum3 = WKTCoordinateSystemReader.Instance.ReadDatum (wkt3);
            Assert.AreEqual (wkt3, WKTCoordinateSystemWriter.Instance.WriteDatum (datum3));
        }

        [TestMethod]
        public void ReadEllipsoidTest ()
        {
            var wkt = "SPHEROID[\"Airy 1830\",6377563.396,299.3249646,AUTHORITY[\"EPSG\",\"7001\"]]";
            var ellipsoid = WKTCoordinateSystemReader.Instance.ReadEllipsoid (wkt);
            Assert.AreEqual (wkt, WKTCoordinateSystemWriter.Instance.WriteEllipsoid (ellipsoid));

            var wkt1 = "SPHEROID[\"Airy 1830\",6377563.396,299.3249646]";
            var ellipsoid1 = WKTCoordinateSystemReader.Instance.ReadEllipsoid (wkt1);
            Assert.AreEqual (wkt1, WKTCoordinateSystemWriter.Instance.WriteEllipsoid (ellipsoid1));
        }

        [TestMethod]
        public void ReadGeographCRSTest ()
        {
            var wkt =
                "GEOGCS[\"OSGB 1936\",DATUM[\"OSGB 1936\",SPHEROID[\"Airy 1830\",6377563.396,299.3249646,AUTHORITY[\"EPSG\",\"7001\"]],TOWGS84[0,1,2,0,-1,-2,-3],AUTHORITY[\"EPSG\",\"6277\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.0174532925199433,AUTHORITY[\"EPSG\",\"9122\"]],AXIS[\"Geodetic latitude\",NORTH],AXIS[\"Geodetic longitude\",EAST],AUTHORITY[\"EPSG\",\"4277\"]]";
            var geogrCRS = WKTCoordinateSystemReader.Instance.ReadGeographicCRS (wkt);
            Assert.AreEqual (wkt, WKTCoordinateSystemWriter.Instance.WriteGeographicCRS (geogrCRS));

            var wkt1 =
                "GEOGCS[\"OSGB 1936\",DATUM[\"OSGB 1936\",SPHEROID[\"Airy 1830\",6377563.396,299.3249646,AUTHORITY[\"EPSG\",\"7001\"]],AUTHORITY[\"EPSG\",\"6277\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"DMSH\",0.0174532925199433,AUTHORITY[\"EPSG\",\"9108\"]],AXIS[\"Geodetic latitude\",NORTH],AXIS[\"Geodetic longitude\",EAST],AUTHORITY[\"EPSG\",\"4277\"]]";
            var geogrCRS1 = WKTCoordinateSystemReader.Instance.ReadGeographicCRS (wkt1);
            Assert.AreEqual (wkt1, WKTCoordinateSystemWriter.Instance.WriteGeographicCRS (geogrCRS1));

            var wkt2 = "GEOGCS[\"OSGB 1936\",DATUM[\"OSGB 1936\",SPHEROID[\"Airy 1830\",6377563.396,299.3249646]],PRIMEM[\"Greenwich\",0],UNIT[\"DMSH\",0.0174532925199433],AXIS[\"Geodetic latitude\",NORTH],AXIS[\"Geodetic longitude\",EAST]]";
            var geogrCRS2 = WKTCoordinateSystemReader.Instance.ReadGeographicCRS (wkt2);
            Assert.AreEqual (wkt2, WKTCoordinateSystemWriter.Instance.WriteGeographicCRS (geogrCRS2));

            var wgs84 =
                "GEOGCS[\"WGS 84\",DATUM[\"World Geodetic System 1984\",SPHEROID[\"WGS 84\",6378137,298.257223563,AUTHORITY[\"EPSG\",\"7030\"]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[\"EPSG\",\"6326\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.0174532925199433,AUTHORITY[\"EPSG\",\"9122\"]],AXIS[\"Geodetic latitude\",NORTH],AXIS[\"Geodetic longitude\",EAST],AUTHORITY[\"EPSG\",\"4326\"]]";
            var geogrCRSWGS84 = WKTCoordinateSystemReader.Instance.ReadGeographicCRS (wgs84);
            Assert.AreEqual (wgs84, WKTCoordinateSystemWriter.Instance.WriteGeographicCRS (geogrCRSWGS84));

        }

        [TestMethod]
        public void ReadAny ()
        {
            var wkt =
              "GEOGCS[\"OSGB 1936\",DATUM[\"OSGB 1936\",SPHEROID[\"Airy 1830\",6377563.396,299.3249646,AUTHORITY[\"EPSG\",\"7001\"]],TOWGS84[0,1,2,0,-1,-2,-3],AUTHORITY[\"EPSG\",\"6277\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.0174532925199433,AUTHORITY[\"EPSG\",\"9122\"]],AXIS[\"Geodetic latitude\",NORTH],AXIS[\"Geodetic longitude\",EAST],AUTHORITY[\"EPSG\",\"4277\"]]";

            var unit = WKTCoordinateSystemReader.Instance.ReadUnit (wkt);
            var ell = WKTCoordinateSystemReader.Instance.ReadEllipsoid (wkt);
            var datum = WKTCoordinateSystemReader.Instance.ReadDatum (wkt);
            var pm = WKTCoordinateSystemReader.Instance.ReadPrimeMeridian (wkt);
            var axis = WKTCoordinateSystemReader.Instance.ReadAxis (wkt);
            var geog = WKTCoordinateSystemReader.Instance.ReadGeographicCRS (wkt);
        
        }

        // TODO: Дореализовать
        [TestMethod]
        public void ReadGeocentricCRSTest ()
        {
            var wkt = "GEOCCS[\"POSGAR 98 (geocentric)\",DATUM[\"Posiciones_Geodesicas_Argentinas_1998\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6190\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"metre\",1,AUTHORITY[\"EPSG\",\"9001\"]],AXIS[\"Geocentric X\",OTHER],AXIS[\"Geocentric Y\",OTHER],AXIS[\"Geocentric Z\",NORTH],AUTHORITY[\"EPSG\",\"4366\"]]";
            var geocentricCRS = WKTCoordinateSystemReader.Instance.ReadGeocentricCRS (wkt);
            var wkt1 = WKTCoordinateSystemWriter.Instance.WriteGeocentricCRS (geocentricCRS);
            Assert.AreEqual (wkt, wkt1);
        }

        // TODO: Дореализовать! И проверить для ESRI - //http://epsg.io/3857 Там параметр особый
		// TODO: Проверить такую http://geocnt.geonet.ru/projections/query_proj.php?proj=1
		
        [TestMethod]
        public void ReadProjectedCRSTest ()
        {
            var wkt = "PROJCS[\"OSGB 1936 / British National Grid\",GEOGCS[\"WGS 84\",DATUM[\"World Geodetic System 1984\",SPHEROID[\"WGS 84\",6378137,298.257223563,AUTHORITY[\"EPSG\",\"7030\"]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[\"EPSG\",\"6326\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.0174532925199433,AUTHORITY[\"EPSG\",\"9122\"]],AXIS[\"Geodetic latitude\",NORTH],AXIS[\"Geodetic longitude\",EAST],AUTHORITY[\"EPSG\",\"4326\"]],"
                      + " PROJECTION[\"Transverse Mercator\",AUTHORITY[\"EPSG\",\"9807\"]],"
                      + " PARAMETER[\"latitude_of_origin\",49],"
                      + " PARAMETER[\"central_meridian\",-2],"
                      + " PARAMETER[\"scale_factor\",0.999601272],"
                      + " PARAMETER[\"false_easting\",400000],"
                      + " PARAMETER[\"false_northing\",-100000],"
                      + " AXIS[\"Easting\",EAST],"
                      + " AXIS[\"Northing\",NORTH],"
                      + " AUTHORITY[\"EPSG\",\"27700\"]"
                      + " ]";

            var wkt1 = "PROJCS[\"OSGB 1936 / British National Grid\",GEOGCS[\"WGS 84\",DATUM[\"World Geodetic System 1984\",SPHEROID[\"WGS 84\",6378137,298.257223563,AUTHORITY[\"EPSG\",\"7030\"]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[\"EPSG\",\"6326\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.0174532925199433,AUTHORITY[\"EPSG\",\"9122\"]],AXIS[\"Geodetic latitude\",NORTH],AXIS[\"Geodetic longitude\",EAST],AUTHORITY[\"EPSG\",\"4326\"]],"
                       + " PROJECTION[\"Transverse Mercator\"],"
                       + " PARAMETER[\"latitude_of_origin\",49],"
                       + " PARAMETER[\"central_meridian\",-2],"
                       + " PARAMETER[\"scale_factor\",0.999601272],"
                       + " PARAMETER[\"false_easting\",400000],"
                       + " PARAMETER[\"false_northing\",-100000],"
                       + " AXIS[\"Easting\",EAST],"
                       + " AXIS[\"Northing\",NORTH],"
                       + " AUTHORITY[\"EPSG\",\"27700\"]"
                       + " ]";

            var projectedCRS = WKTCoordinateSystemReader.Instance.ReadProjectedCRS (wkt);
            var tt1 = projectedCRS.ExportToWKT ();
            var tt = WKTCoordinateSystemWriter.Instance.WriteProjectedCRS (projectedCRS);
            var projectionMethod = WKTCoordinateSystemReader.Instance.ReadProjection (wkt);

            var projectedCRS1 = WKTCoordinateSystemReader.Instance.ReadProjectedCRS (wkt1);
            var tt2 = projectedCRS1.ExportToWKT ();
            var tt22 = WKTCoordinateSystemWriter.Instance.WriteProjectedCRS (projectedCRS1);
            var projectionMethod2 = WKTCoordinateSystemReader.Instance.ReadProjection (wkt1);

        }

        [TestMethod]
        public void ReadPrjTest ()
        {
            var prj = "PROJCS[\"m64_1\",GEOGCS[\"GCS_Pulkovo_1942\",DATUM[\"D_Pulkovo_1942\",SPHEROID[\"Krasovsky_1940\",6378245.0,298.3]],PRIMEM[\"Greenwich\",0.0],UNIT[\"Degree\",0.0174532925199433]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"False_Easting\",95942.17],PARAMETER[\"False_Northing\",-6552810.0],PARAMETER[\"Central_Meridian\",30.0],PARAMETER[\"Scale_Factor\",1.0],PARAMETER[\"Latitude_Of_Origin\",0.0],UNIT[\"Meter\",1.0]]";

            var res0 = WKTCoordinateSystemReader.Instance.ReadProjectedCRS (prj);

            
            var res1 = WKTCoordinateSystemReader.Instance.ReadProjection (prj);

            var proj4 = "+proj=tmerc +lat_0=0 +lon_0=30 +k=1 +x_0=95942.17 +y_0=-6552810 +ellps=krass +towgs84=23.92,-141.27,-80.9,-0,0.35,0.82,-0.12 +units=m +no_defs";
        }

        [TestMethod]
        public void ReadProjectedTest ()
        {
            var wkt = "PROJCS[\"Transverse Mercator\",GEOGCS[\"\",DATUM[\"\",SPHEROID[\"Krassowsky 1940\",6378245,298.3],TOWGS84[23.57,-140.95,-79.8,0,0.35,0.79,-0.22]],PRIMEM[\"Greenwich\",0],UNIT[\"degree\",0.0174532925199433],AXIS[\"Geodetic latitude\",NORTH],AXIS[\"Geodetic longitude\",EAST]],PROJECTION[\"Transverse Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"latitude_of_center\",0],PARAMETER[\"central_meridian\",30],PARAMETER[\"longitude_of_center\",30],PARAMETER[\"false_easting\",95942.17],PARAMETER[\"false_northing\",-6552810],PARAMETER[\"scale_factor\",1],PARAMETER[\"semi_major\",6378245],PARAMETER[\"semi_minor\",6356863.01877305],UNIT[\"metre\",1]]";
            var crs = WKTCoordinateSystemReader.Instance.ReadCoordinateSystem (wkt);

        }
        
    }
}