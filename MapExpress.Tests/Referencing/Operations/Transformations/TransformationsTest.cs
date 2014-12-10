#region

using System;
using MapExpress.CoreGIS.Referencing;
using MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems;
using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.CoreGIS.Referencing.Operations;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Referencing.Operations.Transfomations;
using MapExpress.CoreGIS.Referencing.Registry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace MapExpress.Tests.Referencing.Operations.Transformations
{
    // TODO: Надо написать тесты используя Registry 
    [TestClass]
    public class TransformationsTest
    {
        [TestMethod]
        public void PositionVectorTransformationTest ()
        {
            var parameters = new DatumShiftParameters (0.000, 0.000, 4.5, 0.000, 0.000, 0.554, 0.219);
            var sourcePoint = CreateSourcePoint ();
            var targetPoint = CreateTargetPoint ();
            var transformer = new PositionVector (parameters);
            Assert.AreEqual (transformer.Transform (sourcePoint), targetPoint);

            var invPoint = (Coordinate) transformer.TransformInverse (targetPoint);
            Assert.AreEqual (invPoint.Round (2), sourcePoint.Round (2));
        }

        [TestMethod]
        public void CoordinateFrameRotationTransformationTest ()
        {
            var parameters = new DatumShiftParameters (0.000, 0.000, 4.5, -0.000, -0.000, -0.554, 0.219);
            var sourcePoint = CreateSourcePoint ();
            var targetPoint = CreateTargetPoint ();
            var transformer = new CoordinateFrameRotation (parameters);

            Assert.AreEqual (transformer.Transform (sourcePoint), targetPoint);
            var invPoint = (Coordinate) transformer.TransformInverse (targetPoint);
            Assert.AreEqual (invPoint.Round (2), sourcePoint.Round (2));
        }

        [TestMethod]
        public void MolodenskyBadekasTransformationTest ()
        {
            var parameter = new DatumShiftParameters (0.000, 0.000, 4.5, -0.000, -0.000, -0.554, 0.219);
            var sourcePoint = CreateSourcePoint ();
            var targetPoint = CreateTargetPoint ();
            var transformer = new MolodenskyBadekas (parameter);

            Assert.AreEqual (transformer.Transform (sourcePoint), targetPoint);
        }


        [TestMethod]
        public void MolodenskyTransformationTest ()
        {
            var sourcePoint = new GeographicCoordinate (2.12955, 53.8093944, 73);
            var targetPoint = new GeographicCoordinate (2.130965842857552, 53.810157015975207, 28.021356951622046);
            
            var sourceEllipsoid = new DatumFactory ().CreateFlattenedSphere (6378137.0, 298.2572236);
            var sourceDatum = new DatumFactory ().CreateGeodeticDatum (sourceEllipsoid);
            var sourceCS = new CoordinateReferenceSystemFactory ().CreateGeographicCRS (null, sourceDatum);

            var targetEllipsoid = new DatumFactory ().CreateFlattenedSphere (6378388.0, 297.0);
            var targetDatum = new DatumFactory ().CreateGeodeticDatum (targetEllipsoid);
            var targetCS = new CoordinateReferenceSystemFactory ().CreateGeographicCRS (null, targetDatum);

            var parameters = new DatumShiftParameters (+84.87, +96.49, +116.95);
            var transformer = new Molodensky (sourceCS, targetCS, parameters);

            var transformResult = transformer.Transform (sourcePoint);
            Assert.AreEqual (targetPoint, transformResult);

            var m = new Molodensky (new GeographicTrasformParameters (sourceEllipsoid, targetEllipsoid, parameters));
            transformResult = m.Transform (sourcePoint);
            Assert.AreEqual (targetPoint, transformResult);

            var geographicTransformation = new GeographicTransformation (sourceEllipsoid, targetEllipsoid, parameters);
            var targetCoordinate = geographicTransformation.Transform (sourcePoint);
            Assert.AreEqual (targetCoordinate.Round (5), new GeographicCoordinate (2.13096580969885, 53.810157015685963, 28.0247730538249).Round (5));

            var inverceTransformCoord = geographicTransformation.TransformInverse (targetPoint);
            Assert.AreEqual (inverceTransformCoord.Round (5), new GeographicCoordinate (2.12955003315871, 53.8093944002893, 72.9965838659555).Round (5));
        }

        [TestMethod]
        public void PositionVectorOrFrameRotation ()
        {
            var lon = 30.2336722612381;
            var lat = 59.9567963082358;

            var wgsGeocentTrans = new GeographicGeocentricConversion (EllipsoidRegistry.Instance.WG1984);
            var wgsGeocentricCoordinate = wgsGeocentTrans.Transform (lon, lat, 0);

            // ГОСТ 2008
            var fromSk42ToWGS84Parameters = new DatumShiftParameters
                                                {
                                                    Dx = 23.57,
                                                    Dy = -140.95,
                                                    Dz = -79.8,
                                                    Ex = 0,
                                                    Ey = -0.35,
                                                    Ez = -0.79,
                                                    Ppm = -0.22
                                                };

            var datumTransform = new CoordinateFrameRotation (fromSk42ToWGS84Parameters);
            //var datumTransform = new PositionVector (toSk42Parameters);
            var sk42GeocentricCoord = datumTransform.TransformInverse (wgsGeocentricCoordinate [0], wgsGeocentricCoordinate [1], wgsGeocentricCoordinate [2]);
            var sk42GeographCoord = new GeographicGeocentricConversion (EllipsoidRegistry.Instance.Krassowsky1940).TransformInverse (sk42GeocentricCoord [0], sk42GeocentricCoord [1], sk42GeocentricCoord [2]);

            Assert.AreEqual (sk42GeographCoord [0], 30.235928834504723);
            Assert.AreEqual (sk42GeographCoord [1], 59.956824272975773);
        }

        [TestMethod]
        public void GeographicTransformationTest ()
        {
            var wgs84Lon = 30.2336722612381;
            var wgs84Lat = 59.9567963082358;

            // ГОСТ 2008 СК42 -> WGS84
            var fromSk42ToWGS84Parameters = new DatumShiftParameters
                                                {
                                                    Dx = 23.57,
                                                    Dy = -140.95,
                                                    Dz = -79.8,
                                                    Ex = 0,
                                                    Ey = -0.35,
                                                    Ez = -0.79,
                                                    Ppm = -0.22
                                                };

            var geographicTransformation = new GeographicTransformation (EllipsoidRegistry.Instance.Krassowsky1940, EllipsoidRegistry.Instance.WG1984, fromSk42ToWGS84Parameters);
            var sk42Coordinate = geographicTransformation.TransformInverse (wgs84Lon, wgs84Lat, 0);
            Assert.AreEqual (sk42Coordinate [0], 30.235928834504723);
            Assert.AreEqual (sk42Coordinate [1], 59.956824272975773);

            var geographicTransformation1 = new GeographicTransformation (EllipsoidRegistry.Instance.Krassowsky1940, EllipsoidRegistry.Instance.WG1984, fromSk42ToWGS84Parameters);
            var wgsCoord = geographicTransformation1.Transform (sk42Coordinate [0], sk42Coordinate [1], 0);
            Assert.AreEqual (Math.Round (wgs84Lon,6), Math.Round (wgsCoord[0],6));
            Assert.AreEqual (Math.Round (wgs84Lat, 6), Math.Round (wgsCoord[1], 6));
        }

        [TestMethod]
        public void InverseGeographicTransformationTest ()
        {
            var wgs84Lon = 30.2336722612381;
            var wgs84Lat = 59.9567963082358;

            var sk4284Lon = 30.235928834504723;
            var sk4284Lat = 59.956824272975773;

            // ГОСТ 2008 WGS84 -> СК42
           var fromSk42ToWGS84Parameters = new DatumShiftParameters
                                                {
                                                    Dx = -23.57,
                                                    Dy = +140.95,
                                                    Dz = +79.8,
                                                    Ex = -0,
                                                    Ey = +0.35,
                                                    Ez = +0.79,
                                                    Ppm = +0.22
                                                };

           var geographicTransformation1 = new GeographicTransformation (EllipsoidRegistry.Instance.WG1984, EllipsoidRegistry.Instance.Krassowsky1940, fromSk42ToWGS84Parameters, DatumTransformationType.CoordinateFrameRotation);
           var resultCoordinate = geographicTransformation1.Transform (wgs84Lon, wgs84Lat, 0);
           Assert.AreEqual (Math.Round (resultCoordinate[0], 6), Math.Round (sk4284Lon, 6));
           Assert.AreEqual (Math.Round (resultCoordinate[1], 6), Math.Round (sk4284Lat, 6));
        }

        private Coordinate CreateSourcePoint ()
        {
            return new Coordinate (3657660.66, 255768.55, 5201382.11);
        }

        private Coordinate CreateTargetPoint ()
        {
            return new Coordinate (3657660.7740670228, 255778.43000842954, 5201387.7491026819);
        }
    }
}