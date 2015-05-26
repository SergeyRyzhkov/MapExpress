using System;
using MapExpress.CoreGIS.Referencing.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MapExpress.Tests.Referencing.Converters
{
    // TODO: Сделать нормальные тесты
    [TestClass]
    public class Proj4CoordinateSystemReaderWriterTest
    {
        [TestMethod]
        public void Proj4CoordinateSystemReaderTest ()
        {
            var utmPCS = "+proj=utm +zone=56 +south +ellps=WGS84 +datum=WGS84 +units=m +no_defs";
            var cs = Proj4CoordinateSystemReader.Instance.ReadProjectedCRS (utmPCS);
            var proj = Proj4CoordinateSystemReader.Instance.ReadProjection (utmPCS);

            var proj4String = Proj4CoordinateSystemWriter.Instance.WriteProjectedCRS (cs);
        }

        [TestMethod]
        public void ReadGeocentricCRSTest ()
        {
            var geocentricCRSText = "+proj=geocent +ellps=GRS80 +units=m +no_defs";

            var test1 = Proj4CoordinateSystemReader.Instance.ReadCoordinateSystem (geocentricCRSText);

            var test2 = Proj4CoordinateSystemReader.Instance.ReadGeocentricCRS (geocentricCRSText);
        }

        [TestMethod]
        public void ReadGeogrphicCRSTest ()
        {
            var geographCRSText = "+proj = longlat   +datum  = WGS84 +no_defs";

            var test1 = Proj4CoordinateSystemReader.Instance.ReadCoordinateSystem (geographCRSText);

            var test2 = Proj4CoordinateSystemReader.Instance.ReadGeocentricCRS (geographCRSText);
        }

        [TestMethod]
        public void ReadProjectedCRSTest ()
        {
            var proj4 = "+proj=tmerc +lat_0=0 +lon_0=30 +k=1 +x_0=95942.17 +y_0=-6552810 +ellps=krass +towgs84=23.92,-141.27,-80.9,-0,0.35,0.82,-0.12 +units=m +no_defs";

            var res = Proj4CoordinateSystemReader.Instance.ReadCoordinateSystem (proj4);
        }

        [TestMethod]
        public void ReadProjectedCRSTest1 ()
        {
            var proj4 = "+proj=omerc +lat_0=40.3666666666667 +lonc=49.8333333333333 +alpha=45 +gamma=0 +k_0=1 +x_0=0 +y_0=0 +ellps=krass +towgs84=23.92,-141.27,-80.9,-0,0.35,0.82,-0.12 +units=m +no_defs";
            var res = Proj4CoordinateSystemReader.Instance.ReadCoordinateSystem (proj4);
        }

        [TestMethod]
        public void ReadSpbTest ()
        {
            var proj4 = "+proj=tmerc +lat_0=0 +lon_0=30 +k=1 +x_0=95942.17 +y_0=-6552810 +ellps=krass +towgs84=23.57,-140.95,-79.8,0,0.35,0.79,-0.22 +units=m +no_defs";
            try
            {
                var res = Proj4CoordinateSystemReader.Instance.ReadCoordinateSystem (proj4);
            }
            catch (Exception exc)
            {
                var test = "sdfdsfdsf";
            }
        }
    }
}