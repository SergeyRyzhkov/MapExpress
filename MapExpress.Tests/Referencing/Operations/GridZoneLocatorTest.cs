using MapExpress.CoreGIS.Referencing.Operations.Projections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MapExpress.Tests.Referencing.Operations
{
    [TestClass]
    public class GridZoneLocatorTest
    {
        [TestMethod]
        public void UTMZoneNumberTest ()
        {
            Assert.AreEqual (MercatorGridZoneLocator.UTMZoneNumber (3.0), 31);
            Assert.AreEqual (MercatorGridZoneLocator.UTMZoneNumber (157.0), 57);
            Assert.AreEqual (MercatorGridZoneLocator.UTMZoneNumber (-157.0), 4);

       
        }


        [TestMethod]
        public void UTMZoneCentralMeridianTest ()
        {
            Assert.AreEqual (MercatorGridZoneLocator.UTMZoneCentralMeridian (31), 3);
            Assert.AreEqual (MercatorGridZoneLocator.UTMZoneCentralMeridian (57), 159);
            Assert.AreEqual (MercatorGridZoneLocator.UTMZoneCentralMeridian (4), -159);
        }


        // TODO: Implemets!
        [TestMethod]
        public void GaussKrugerZoneNumberTest ()
        {
        }


        [TestMethod]
        public void GaussKrugerCentralMeridianTest ()
        {
        }
    }
}