#region

using System;
using System.Collections.Generic;
using MapExpress.CoreGIS.Referencing.CoordinateSystems;
using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    // TODO : Все на статик? !!!
    // TODO: См. пример параметров
    //var wgs84 = factory.CreateGeographicCoordinateSystem("WGS 84", 
    //            AngularUnit.Degrees, HorizontalDatum.WGS84, PrimeMeridian.Greenwich,
    //            new AxisInfo("north", AxisOrientationEnum.North), new
    //            AxisInfo("east", AxisOrientationEnum.East));

    // TODO: Сделать методы CreateFromWKT, CreateFromAuthoryCode, CreateFromAuthtoryName, CreateFromProj4

    public class CoordinateReferenceSystemFactory : ICoordinateReferenceSystemFactory
    {
        private readonly CoordinateSystemFactory csFactory = new CoordinateSystemFactory ();
        private readonly DatumFactory datumFactory = new DatumFactory ();

        #region ICoordinateReferenceSystemFactory Members

        public IGeocentricCRS CreateGeocentricCRS (string name, IGeodeticDatum datum, ICartesianCS cs)
        {
            return new GeocentricCRS (name, cs, datum);
        }

        public IGeocentricCRS CreateGeocentricCRS (string name, IGeodeticDatum datum, ISphericalCS cs)
        {
            return new GeocentricCRS (name, cs, datum);
        }

        public IGeographicCRS CreateGeographicCRS (string name, IGeodeticDatum datum, IEllipsoidalCS cs)
        {
            return new GeographicCRS (name, cs, datum);
        }

        public IProjectedCRS CreateProjectedCRS (string name, IGeographicCRS baseCRS, IProjection conversionFromBase, ICartesianCS derivedCS)
        {
            return new ProjectedCRS (name, derivedCS, baseCRS, conversionFromBase);
        }


        public IDerivedCRS CreateDerivedCRS (string name, ICoordinateReferenceSystem baseCRS, IConversion conversionFromBase, ICoordinateSystem derivedCS)
        {
            return new DerivedCRS (name, derivedCS, baseCRS, conversionFromBase);
        }

        public ICompoundCRS CreateCompoundCRS (string name, ICollection <ICoordinateReferenceSystem> crs)
        {
            return new CompoundCRS (name, crs);
        }

        public IEngineeringCRS CreateEngineeringCRS (string name, IEngineeringDatum datum, ICoordinateSystem cs)
        {
            return new EngineeringCRS (name, cs, datum);
        }

        public IImageCRS CreateImageCRS (string name, IImageDatum datum, IAffineCS cs)
        {
            return new ImageCRS (name, cs, datum);
        }


        public IVerticalCRS CreateVerticalCRS (string name, IVerticalDatum datum, IVerticalCS cs)
        {
            return new VerticalCRS (name, cs, datum);
        }


        public ITemporalCRS CreateTemporalCRS (string name, ITemporalDatum datum, ITimeCS cs)
        {
            return new TemporalCRS (name, cs, datum);
        }

        #endregion

        public IGeographicCRS CreateGeographicCRS (string name, IGeodeticDatum datum)
        {
            return CreateGeographicCRS (name, datum, csFactory.Create2DEllipsoidalCS ());
        }

        // TODO : ???
        public IGeocentricCRS CreateGeocentricCRSFromCartesianCS (string name, IGeodeticDatum datum)
        {
            return CreateGeocentricCRS (name, datum, csFactory.Create3DCartesianCS ());
        }

        // TODO : ???
        public IGeocentricCRS CreateGeocentricCRSFromSphericalCS (string name, IGeodeticDatum datum)
        {
            return CreateGeocentricCRS (name, datum, csFactory.CreateSphericalCS ());
        }


        public IProjectedCRS CreateProjectedCRS (string name, IGeographicCRS baseCRS, IProjection conversionFromBase)
        {
            var cs = csFactory.CreateCartesianCS (CoordinateSystemAxis.Easting, CoordinateSystemAxis.Northing);
            return CreateProjectedCRS (name, baseCRS, conversionFromBase, cs);
        }

        public IEngineeringCRS CreateEngineeringCRS (string name, ICoordinateSystem cs)
        {
            return CreateEngineeringCRS (name, datumFactory.CreateEngineeringDatum (), cs);
        }

        public IImageCRS CreateImageCRS (string name, ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1)
        {
            return CreateImageCRS (name, datumFactory.CreateImageDatum (), csFactory.CreateAffineCS (axis0, axis1));
        }

        public IImageCRS CreateImageCRS (string name, IAffineCS cs)
        {
            return CreateImageCRS (name, datumFactory.CreateImageDatum (), cs);
        }

        public ITemporalCRS CreateTemporalCRS (string name, DateTime origin)
        {
            return CreateTemporalCRS (name, datumFactory.CreateTemporalDatum (origin), csFactory.CreateTimeCS ());
        }

        public IVerticalCRS CreateVerticalCRS (string name)
        {
            return CreateVerticalCRS (name, datumFactory.CreateVerticalDatum (), csFactory.CreateVerticalCS ());
        }
    }
}