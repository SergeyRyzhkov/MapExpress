#region

using System;
using MapExpress.CoreGIS.OGS.Tms;
using MapExpress.CoreGIS.OGS.Tms.CoordSys;
using MapExpress.CoreGIS.OGS.Tms.TileSources;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace MapExpress.Tests.OGS
{
    [TestClass]
    public class TmsTest
    {
        //  SphericalMercatorTileMath

        [TestMethod]
        public void SphericalMercatorTileMathTest ()
        {
            var math = new SphericalMercatorTileMath ();
            var res0 = math.Resolution (0);

            var extent = math.TileBounds (new TileIndex (0, 0, 0));
        }

        [TestMethod]
        public void FileTileSourceTest ()
        {
            var source = new FileTileSource (@"C:\_dataGIS\raster_OFP_2013\2\pyramid");
            Assert.IsTrue (source.TileExists (new TileIndex (303528, 151540, 19)));
        }

        [TestMethod]
        public void HttpTileSourceTest ()
        {
            //http://nt0.reestri.gov.ge/NGCache?x=649228&y=388798&z=20&l=ORTHO_2014_COL
            //http://nt0.reestri.gov.ge/ngcache?x=649228&y=388798&z=20&l=ortho_2014_col
            var source = new HttpTileSource (@"http://nt0.reestri.gov.ge/NGCache?x={x}&y={y}&z={z}&l=ORTHO_2014_COL");
            var image = source.GetTile (new TileIndex (649228, 388798, 20));
        }

        [TestMethod]
        public void TileProviderTest ()
        {
            var provider = new TileProvider (new SphericalMercatorTileMath ());
            var source = new HttpTileSource (@"http://nt0.reestri.gov.ge/NGCache?x={x}&y={y}&z={z}&l=ORTHO_2014_COL");
            provider.AddTileSource (source);

            var tt = provider.TileMath.Resolution (2);

            var count = provider.TilesCount (4986701, 5114568, 4988072, 5116185, 20);
        }
    }
}