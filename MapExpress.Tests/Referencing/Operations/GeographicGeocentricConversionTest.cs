#region

using MapExpress.CoreGIS.Referencing;
using MapExpress.CoreGIS.Referencing.Operations;
using MapExpress.CoreGIS.Referencing.Registry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace MapExpress.Tests.Referencing.Operations
{
    [TestClass]
    public class GeographicGeocentricConversionTest
    {
        [TestMethod]
        public void ToGeographicTest ()
        {
            var sourceCoordinate = new Coordinate (3771793.968, 140253.342, 5124304.349);
            var resultCoordinate = new GeographicCoordinate (2.129550001320768, 53.809394439962119, 72.999930672347546);
            var convertor = new GeographicGeocentricConversion (EllipsoidRegistry.Instance.WGS84);
            Assert.AreEqual (resultCoordinate, convertor.TransformInverse (sourceCoordinate));
        }

        [TestMethod]
        public void ToGeocentricTest ()
        {
            var sourceCoordinate = new GeographicCoordinate (2.129550001320768, 53.809394439962119, 72.999930672347546);
            var resultCoordinate = new Coordinate (3771793.9680000003, 140253.342, 5124304.349);

            var convertor = new GeographicGeocentricConversion (EllipsoidRegistry.Instance.WGS84);

            Assert.AreEqual (resultCoordinate, convertor.Transform (sourceCoordinate));
        }
    }
}