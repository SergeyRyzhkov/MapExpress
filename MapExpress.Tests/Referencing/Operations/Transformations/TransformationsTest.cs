#region

using MapExpress.CoreGIS.Referencing;
using MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems;
using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Referencing.Operations.Transfomations;
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
        }

        [TestMethod]
        public void CoordinateFrameRotationTransformationTest ()
        {
            var parameters = new DatumShiftParameters (0.000, 0.000, 4.5, -0.000, -0.000, -0.554, 0.219);
            var sourcePoint = CreateSourcePoint ();
            var targetPoint = CreateTargetPoint ();
            var transformer = new CoordinateFrameRotation (parameters);

            Assert.AreEqual (transformer.Transform (sourcePoint), targetPoint);
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
        public void GeocentricTranslationTest ()
        {
            var parameter = new DatumShiftParameters (100.000, 200.000, 300.000);
            var sourcePoint = CreateSourcePoint ();
            var targetPoint = new Coordinate (sourcePoint.X + 100.000, sourcePoint.Y + 200.000, sourcePoint.Z + 300.000);
            var transformer = new GeocentricTranslation (parameter);

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
        }

        [TestMethod]
        public void MolodenskyAbridgedTransformationTest ()
        {
            var sourcePoint = new GeographicCoordinate (2.12955, 53.8093944, 73);
            var targetPoint = new GeographicCoordinate (2.130965842857552, 53.810156234789417, 28.090829446042221);

            var centralMeridian = new DatumFactory ().CreatePrimeMeridian (0);

            var sourceEllipsoid = new DatumFactory ().CreateFlattenedSphere (6378137.0, 298.2572236);
            var sourceDatum = new DatumFactory ().CreateGeodeticDatum (sourceEllipsoid, centralMeridian);
            var sourceCS = new CoordinateReferenceSystemFactory ().CreateGeographicCRS (null, sourceDatum);

            var targetEllipsoid = new DatumFactory ().CreateFlattenedSphere (6378388.0, 297.0);
            var targetDatum = new DatumFactory ().CreateGeodeticDatum (targetEllipsoid, centralMeridian);
            var targetCS = new CoordinateReferenceSystemFactory ().CreateGeographicCRS (null, targetDatum);

            var parameters = new DatumShiftParameters (+84.87, +96.49, +116.95);
            var transformer = new AbridgedMolodensky (sourceCS, targetCS, parameters);

            var transformResult = transformer.Transform (sourcePoint);

            Assert.AreEqual (targetPoint, transformResult);
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