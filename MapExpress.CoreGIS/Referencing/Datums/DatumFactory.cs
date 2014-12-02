#region

using System;
using MapExpress.CoreGIS.Referencing.Registry;
using MapExpress.CoreGIS.Referencing.Units;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.Datums
{
    public class DatumFactory : IDatumFactory
    {
        #region IDatumFactory Members

        public IEngineeringDatum CreateEngineeringDatum ()
        {
            return new EngineeringDatum ();
        }


        public IGeodeticDatum CreateGeodeticDatum (IEllipsoid ellipsoid, IPrimeMeridian primeMeridian)
        {
            return new GeodeticDatum (ellipsoid, primeMeridian);
        }

        public IImageDatum CreateImageDatum (PixelInCellType pixelInCell)
        {
            return new ImageDatum (pixelInCell);
        }

        public ITemporalDatum CreateTemporalDatum (DateTime origin)
        {
            return new TemporalDatum (origin);
        }


        public IVerticalDatum CreateVerticalDatum (VerticalDatumType type)
        {
            return new VerticalDatum (type);
        }

        public IEllipsoid CreateEllipsoid (double semiMajorAxis, double semiMinorAxis, IAngularUnit unit)
        {
            return new Ellipsoid (semiMajorAxis, semiMinorAxis, unit);
        }

        public IEllipsoid CreateFlattenedSphere (double semiMajorAxis, double inverseFlattening, IAngularUnit unit)
        {
            var newEllipsoid = new Ellipsoid
                                   {
                                       SemiMajorAxis = semiMajorAxis,
                                       InverseFlattening = inverseFlattening,
                                       AxisUnit = unit
                                   };
            return newEllipsoid;
        }

        public IPrimeMeridian CreatePrimeMeridian (double longitude, IAngularUnit unit)
        {
            return new PrimeMeridian (longitude, unit);
        }

        #endregion

        public IGeodeticDatum CreateGeodeticDatum (IEllipsoid ellipsoid)
        {
            return new GeodeticDatum (ellipsoid, CreateGreenvich ());
        }

        public IEllipsoid CreateEllipsoid (double semiMajorAxis, double semiMinorAxis)
        {
            return new Ellipsoid (semiMajorAxis, semiMinorAxis, AngularUnit.Degree);
        }

        public IEllipsoid CreateFlattenedSphere (double semiMajorAxis, double inverseFlattening)
        {
            return CreateFlattenedSphere (semiMajorAxis, inverseFlattening, AngularUnit.Degree);
        }


        public IPrimeMeridian CreatePrimeMeridian (double longitude)
        {
            return CreatePrimeMeridian (longitude, AngularUnit.Degree);
        }

        public IPrimeMeridian CreateGreenvich ()
        {
            return PrimeMeridianRegistry.Instance.Greenwich;
        }

        public IImageDatum CreateImageDatum ()
        {
            return CreateImageDatum (PixelInCellType.CELL_CENTER);
        }

        public IVerticalDatum CreateVerticalDatum ()
        {
            return CreateVerticalDatum (VerticalDatumType.OTHER_SURFACE);
        }
    }
}