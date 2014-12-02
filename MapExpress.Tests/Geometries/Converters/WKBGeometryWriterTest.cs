using MapExpress.CoreGIS.Geometries;
using MapExpress.CoreGIS.Geometries.Converters;
using MapExpress.CoreGIS.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MapExpress.Tests.Geometries.Converters
{
    [TestClass]
    public class WKBGeometryWriterTest
    {
        [TestMethod]
        public void TestPoint ()
        {
            CheckWkbGeometry ("000000000140000000000000004010000000000000", "Point (2 4)", ByteOrderType.BigEndian);
            CheckWkbGeometry ("0101000000000000000000F03F000000000000F03F", "Point (1 1)", ByteOrderType.LittleEndian);
            CheckWkbGeometry ("010100000000000000000014400000000000003740", "Point (5 23)", ByteOrderType.LittleEndian);
        }


        [TestMethod]
        public void TestLineString ()
        {
            CheckWkbGeometry ("00000000020000000140590000000000004069000000000000", "LineString (100 200)", ByteOrderType.BigEndian);
        }


        [TestMethod]
        public void TestPolygon ()
        {
            CheckWkbGeometry ("0000000003000000010000000140590000000000004069000000000000", "POLYGON ((100 200))", ByteOrderType.BigEndian);
            CheckWkbGeometry ("000000000300000001000000024059000000000000406900000000000040590000000000004069000000000000", "POLYGON ((100 200, 100 200))", ByteOrderType.BigEndian);
        }

        [TestMethod]
        public void TestMultiGeometry ()
        {
            CheckWkbGeometry ("0104000000020000000101000000000000000000F03F000000000000F03F010100000000000000000000400000000000000040", "MultiPoint (1 1,2 2)", ByteOrderType.LittleEndian);

            CheckWkbGeometry (
                "010500000002000000010200000003000000000000000000244000000000000024400000000000003440000000000000344000000000000024400000000000004440010200000004000000000000000000444000000000000044400000000000003E400000000000003E40000000000000444000000000000034400000000000003E400000000000002440",
                "MultiLineString ((10 10,20 20,10 40),(40 40,30 30,40 20,30 10))", ByteOrderType.LittleEndian);

            CheckWkbGeometry (
                "01060000000200000001030000000100000004000000000000000000444000000000000044400000000000003440000000000080464000000000008046400000000000003E4000000000000044400000000000004440010300000001000000040000000000000000003E40000000000000344000000000000034400000000000002E40000000000000344000000000000039400000000000003E400000000000003440",
                "MultiPolygon (((40 40,20 45,45 30,40 40)),((30 20,20 15,20 25,30 20)))", ByteOrderType.LittleEndian);

            CheckWkbGeometry (
                "010700000002000000010100000000000000000010400000000000001840010200000002000000000000000000104000000000000018400000000000001C400000000000002440",
                "GeometryCollection (Point (4 6),LineString (4 6,7 10))", ByteOrderType.LittleEndian);
        }

        private void CheckWkbGeometry (string expectedHexString, string wkt, ByteOrderType byteOrderType)
        {
            var geometry = Geometry.CreateFromWKT (wkt);
            var result = WKBGeometryWriter.Write (geometry, byteOrderType);
            var resulHexString = ByteUtils.ByteArrayToHexString (result);

            Assert.AreEqual (expectedHexString, resulHexString);
        }
    }
}