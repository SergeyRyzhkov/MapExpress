#region

using System.Collections.Generic;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface ICoordinateReferenceSystemFactory
    {
        ICompoundCRS CreateCompoundCRS (string name, ICollection <ICoordinateReferenceSystem> crs);

        IEngineeringCRS CreateEngineeringCRS (string name, IEngineeringDatum datum, ICoordinateSystem cs);

        IImageCRS CreateImageCRS (string name, IImageDatum datum, IAffineCS cs);

        ITemporalCRS CreateTemporalCRS (string name, ITemporalDatum datum, ITimeCS cs);

        IVerticalCRS CreateVerticalCRS (string name, IVerticalDatum datum, IVerticalCS cs);

        IGeocentricCRS CreateGeocentricCRS (string name, IGeodeticDatum datum, ICartesianCS cs);

        IGeocentricCRS CreateGeocentricCRS (string name, IGeodeticDatum datum, ISphericalCS cs);

        IGeographicCRS CreateGeographicCRS (string name, IGeodeticDatum datum, IEllipsoidalCS cs);

        IDerivedCRS CreateDerivedCRS (string name, ICoordinateReferenceSystem baseCRS, IConversion conversionFromBase, ICoordinateSystem derivedCS);

        IProjectedCRS CreateProjectedCRS (string name, IGeographicCRS baseCRS, IProjection conversionFromBase, ICartesianCS derivedCS);
    }
}