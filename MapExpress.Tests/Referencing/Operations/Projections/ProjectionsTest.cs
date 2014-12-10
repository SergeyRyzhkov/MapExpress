#region

using MapExpress.CoreGIS.Referencing;
using MapExpress.CoreGIS.Referencing.Converters;
using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Referencing.Operations.Projections;
using MapExpress.CoreGIS.Referencing.Registry;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace MapExpress.Tests.Referencing.Operations.Projections
{
    [TestClass]
    public class ProjectionsTest
    {
        [TestMethod]
        public void SphericalMercatorProjectionTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("100 20 00.000 W", "24 22 54.433 N");
            var cartesianPoint = new Coordinate (-11156569.898033172, 2796869.9355282709, 0);

            var ellipsoid = new DatumFactory ().CreateEllipsoid (6371007.0, 6371007.0);
            var parameters = new ProjectionParameters (ellipsoid);
            var projection = new SphericalMercator (parameters);

            var projectResult = projection.Transform (geographicCoordinate);
            Assert.AreEqual (projectResult, cartesianPoint);
            Assert.AreEqual (projection.Transform (geographicCoordinate), cartesianPoint);

            Coordinate reprojectResult = (Coordinate) projection.TransformInverse (projectResult);
            Assert.AreEqual (reprojectResult.Round (6), geographicCoordinate.Round (6));
            Assert.AreEqual (((GeographicCoordinate)projection.TransformInverse (projectResult)).Round (6), geographicCoordinate.Round (6));
        }

        [TestMethod]
        public void PseudoMercatorProjectionTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("100 20 00.000 W", "24 22 54.433 N");

            var cartesianPoint = new Coordinate (-11169055.58, 2800000.00, 0);

            var ellipsoid = new DatumFactory ().CreateFlattenedSphere (6378137.0, 298.257223563);
            var parameters = new ProjectionParameters (ellipsoid);
            var projection = new SphericalMercator (parameters);

            var projectResult = (Coordinate)projection.Transform (geographicCoordinate);
            Assert.AreEqual (projectResult.Round (2), cartesianPoint);

            Coordinate reprojectResult = (Coordinate) projection.TransformInverse (cartesianPoint);
            Assert.AreEqual (reprojectResult.Round (6), geographicCoordinate.Round (6));
        }


        [TestMethod]
        public void Mercator1SpProjectionTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("120 00 00.00 E", "3 00 00.00 S");
            var cartesianPoint = new Coordinate (5009726.58, 569150.82);
            var ellipsoid = new DatumFactory ().CreateFlattenedSphere (6377397.155, 299.15281);

            var parameters = new ProjectionParameters (ellipsoid)
                                 {
                                     CentralMeridian = GeographicCoordinate.LonFromString ("110 00 00 E"),
                                     FalseEasting = 3900000.00,
                                     FalseNorthing = 900000.00,
                                     ScaleFactor = 0.997
                                 };
            var projection = new Mercator1SP (parameters);

            var projectResult = (Coordinate)projection.Transform (geographicCoordinate);
            Assert.AreEqual (cartesianPoint.Round (2), projectResult.Round (2));

            Coordinate reprojectResult = (Coordinate) projection.TransformInverse (cartesianPoint);
            Assert.AreEqual (geographicCoordinate.Round (6), reprojectResult.Round (6));
        }

        [TestMethod]
        public void TranverseMercatorProjectionTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("00 30 00.00 E", "50 30 00.00 N");
            var cartesianPoint = new Coordinate (577274.99, 69740.50);
            var ellipsoid = new DatumFactory ().CreateFlattenedSphere (6377563.396, 299.32496);


            var parameters = new ProjectionParameters (ellipsoid)
                                 {
                                     CentralMeridian = GeographicCoordinate.LonFromString ("2 00 00 W"),
                                     FalseEasting = 400000.00,
                                     FalseNorthing = -100000.00,
                                     ScaleFactor = 0.9996012717,
                                     LatitudeOfOrigin = GeographicCoordinate.LatFromString ("49 00 00 N")
                                 };

            var projection = new TransverseMercator (parameters);
            var projectResult = (Coordinate) projection.Transform (geographicCoordinate);
            Assert.AreEqual (new Coordinate (577274.98, 69740.49), projectResult.Round (2));

            Coordinate reprojectResult = (Coordinate) projection.TransformInverse (cartesianPoint);
            Assert.AreEqual (geographicCoordinate.Round (4), reprojectResult.Round (4));
        }

        [TestMethod]
        public void UniversalTransverseMercatorTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("158 00 00 E", "49 00 00 N");
            var cartesianPoint = new Coordinate (426857.987717265, 5427937.52418695);

            var ellipsoid = new DatumFactory ().CreateFlattenedSphere (6378137.0, 298.257223563);

            var parameters = new ProjectionParameters (ellipsoid)
                                 {
                                     CentralMeridian = MercatorGridZoneLocator.UTMZoneCentralMeridian (57),
                                     FalseEasting = 500000.00,
                                     FalseNorthing = 0.00,
                                     ScaleFactor = 0.9996,
                                 };

            var projection = new TransverseMercator (parameters);

            var projectedPoint = (Coordinate) projection.Transform (geographicCoordinate);
            Assert.AreEqual (projectedPoint.Round (2), cartesianPoint.Round (2));

            Coordinate reprojectResult = (Coordinate) projection.TransformInverse (cartesianPoint);
            Assert.AreEqual (geographicCoordinate.Round (2), reprojectResult.Round (2));


            var utmPCS = "+proj=utm +a=6378137.0 +rf=298.257223563 +zone=57 +units=m +no_defs";
            var projection2 = (Projection) Proj4CoordinateSystemReader.Instance.ReadProjection (utmPCS);
            var projectedPoint2 = (Coordinate) projection2.Transform (geographicCoordinate);
            Assert.AreEqual (projectedPoint2.Round (2), cartesianPoint.Round (2));
        }

        [TestMethod]
        public void AlbersEqualAreaTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("132 00 00.000 E", "27 00 00.000 S");
            var projectedCoordinate = new Coordinate (0, -2926820.89);

            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.GRS1980)
                                 {
                                     StandardParallel1 = -18,
                                     StandardParallel2 = -36,
                                     LatitudeOfOrigin = 0,
                                     CentralMeridian = 132
                                 };


            var projection = new AlbersConicEqualArea (parameters);
            var result = (Coordinate) projection.Transform (geographicCoordinate);
            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (result);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));
        }

        [TestMethod]
        public void AzimuthalEquidistantTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("138 11 34.908 E", "9 35 47.493 N");
            var projectedCoordinate = new Coordinate (42665.90, 65509.82);

            var paramCoordinate = GeographicCoordinate.FromString ("138 10 07.48 E", "9 32 48.15 N");
            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.Clarke1866)
                                 {
                                     LatitudeOfOrigin = paramCoordinate.Lat,
                                     CentralMeridian = paramCoordinate.Lon,
                                     FalseEasting = 40000.00,
                                     FalseNorthing = 60000.00
                                 };

            var projection = new AzimuthalEquidistant (parameters);
            var result = (Coordinate) projection.Transform (geographicCoordinate);

            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (result);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));
        }

        [TestMethod]
        public void CassiniSoldnerTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("106 00 00.00 E", "10 00 00.00 N");
            var projectedCoordinate = new Coordinate (267188.88, 881108.91);

            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.GRS1980)
                                 {
                                     LatitudeOfOrigin = 2.121679744444445,
                                     CentralMeridian = 103.4279362361111,
                                     FalseEasting = -14810.562,
                                     FalseNorthing = 8758.32
                                 };

            var projection = new CassiniSoldner (parameters);
            var result = (Coordinate) projection.Transform (geographicCoordinate);

            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (result);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));
        }

        [TestMethod]
        public void EquidistantCylindricalSphericalTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("10 00 00.000 E", "55 00 00.000 N");
            var projectedCoordinate = new Coordinate (1113194.91, 6122571.99);

            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.WGS84);

            var projection = new EquidistantCylindrical (parameters);
            var result = (Coordinate) projection.Transform (geographicCoordinate);

            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (result);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));
        }

        [TestMethod]
        public void KrovakTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("16 50 59.179 E", "50 12 32.442 N");
            var projectedCoordinate = new Coordinate (-568991.00, -1050538.63);

            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.Bessel1841);

            var projection = new Krovak (parameters);
            var result = (Coordinate) projection.Transform (geographicCoordinate);

            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (result);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));
        }


        [TestMethod]
        public void ObliqueMercatorTest ()
        {
            var geographicCoordinate = new GeographicCoordinate (16, 48.5);
            var projectedCoordinate = new Coordinate (424714.14, 355124.59);

            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.GRS1967)
                                 {
                                     LatitudeOfCenter = 47.14439372222222,
                                     LongitudeOfCenter = 19.04857177777778,
                                     Azimuth = 90,
                                     ScaleFactor = 0.99993,
                                     FalseEasting = 650000,
                                     FalseNorthing = 200000
                                 };

            var projection = new ObliqueMercator (parameters);
            var result = (Coordinate) projection.Transform (geographicCoordinate);

            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (result);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));
        }

        [TestMethod]
        public void LambertAzimuthalEqualAreaTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("5 00 00.000 E", "50 00 00.000 N");
            var projectedCoordinate = new Coordinate (3962799.45, 2999718.85);

            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.GRS1980)
                                 {
                                     LatitudeOfOrigin = GeographicCoordinate.LatFromString ("52 00 00.000 N"),
                                     CentralMeridian = GeographicCoordinate.LatFromString ("10 00 00.000 E"),
                                     FalseEasting = 4321000.00,
                                     FalseNorthing = 3210000.00
                                 };

            var projection = new LambertAzimuthalEqualArea (parameters);
            var result = (Coordinate) projection.Transform (geographicCoordinate);

            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (result);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));
        }

        [TestMethod]
        public void ObliqueStereographicTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("6 00 00 E", "53 00 00 N");
            var projectedCoordinate = new Coordinate (196105.283, 557057.739);

            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.Bessel1841)
                                 {
                                     LatitudeOfOrigin = GeographicCoordinate.LatFromString ("52 09 22.178 N"),
                                     CentralMeridian = GeographicCoordinate.LatFromString ("5 23 15.500 E"),
                                     ScaleFactor = 0.9999079,
                                     FalseEasting = 155000.00,
                                     FalseNorthing = 463000.00
                                 };

            var projection = new ObliqueStereographic (parameters);
            var result = (Coordinate) projection.Transform (geographicCoordinate);

            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (result);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));
        }

        [TestMethod]
        public void LambertConformalConicTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("5 00 00 E", "58 00 00 N");
            var projectedCoordinate = new Coordinate (187742.70, 969521.65);

            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.International1924)
                                 {
                                     LatitudeOfOrigin = 90,
                                     CentralMeridian = 4.367486666666666,
                                     StandardParallel1 = 51.16666723333333,
                                     StandardParallel2 = 49.8333339,
                                     FalseEasting = 150000.013,
                                     FalseNorthing = 5400088.438
                                 };

            var projection = new LambertConformalConic (parameters);
            var result = (Coordinate) projection.Transform (geographicCoordinate);

            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (projectedCoordinate);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));
        }

        [TestMethod]
        public void LambertConformalConic1SPTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("76 56 37.26 W", "17 55 55.80 N");
            var projectedCoordinate = new Coordinate (255966.58, 142493.51);

            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.Clarke1866)
                                 {
                                     LatitudeOfOrigin = 18,
                                     CentralMeridian = -77,
                                     ScaleFactor = 1,
                                     FalseEasting = 250000.00,
                                     FalseNorthing = 150000.00
                                 };

            var projection = new LambertConformalConic (parameters);

            var result = (Coordinate) projection.Transform (geographicCoordinate);
            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (projectedCoordinate);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));
        }


        [TestMethod]
        public void PolarStereographicTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("44 00 00 E", "73 00 00 N");
            var projectedCoordinate = new Coordinate (3320416.75, 632668.43);

            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.WGS84)
                                 {
                                     LatitudeOfOrigin = 90,
                                     ScaleFactor = 0.994,
                                     FalseEasting = 2000000.00,
                                     FalseNorthing = 2000000.00
                                 };

            var projection = new PolarStereographic (parameters);

            var result = (Coordinate) projection.Transform (geographicCoordinate);
            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (projectedCoordinate);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));
        }


        [TestMethod]
        public void PolarStereographicaVariantBTest ()
        {
            var geographicCoordinate = GeographicCoordinate.FromString ("120 00 00.000 E", "75 00 00.000 S");
            var projectedCoordinate = new Coordinate (7255380.79, 7053389.56);

            var parameters = new ProjectionParameters (EllipsoidRegistry.Instance.WGS84)
                                 {
                                     CentralMeridian = 70,
                                     StandardParallel1 = GeographicCoordinate.LatFromString ("71 00 00.000 S"),
                                     FalseEasting = 6000000.00,
                                     FalseNorthing = 6000000.00
                                 };

            var projection = new PolarStereographic (parameters);

            Coordinate inverseResult = (Coordinate) projection.TransformInverse (projectedCoordinate);
            Assert.AreEqual (geographicCoordinate.Round (2), inverseResult.Round (2));

            var result = (Coordinate) projection.Transform (geographicCoordinate);
            Assert.AreEqual (projectedCoordinate.Round (2), result.Round (2));
        }
    }
}