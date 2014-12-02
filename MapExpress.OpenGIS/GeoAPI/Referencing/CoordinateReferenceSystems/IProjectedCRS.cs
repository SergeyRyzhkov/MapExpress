#region

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface IProjectedCRS : IDerivedCRS
    {
        new IGeographicCRS BaseCRS { get; set; }

        new IProjection ConversionFromBase { get; set; }

        new ICartesianCS CoordinateSystem { get; }

        new ILinearUnit Unit { get; set; }

        new IGeodeticDatum Datum { get; }
    }
}