#region

using System;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Datum
{
    public interface IDatumFactory
    {
        IEngineeringDatum CreateEngineeringDatum ();

        IGeodeticDatum CreateGeodeticDatum (IEllipsoid ellipsoid, IPrimeMeridian primeMeridian);

        IImageDatum CreateImageDatum (PixelInCellType pixelInCell);

        ITemporalDatum CreateTemporalDatum (DateTime origin);

        IVerticalDatum CreateVerticalDatum (VerticalDatumType type);

        IEllipsoid CreateEllipsoid (double semiMajorAxis, double semiMinorAxis, IAngularUnit unit);

        IEllipsoid CreateFlattenedSphere (double semiMajorAxis, double inverseFlattening, IAngularUnit unit);

        IPrimeMeridian CreatePrimeMeridian (double longitude, IAngularUnit unit);
    }
}