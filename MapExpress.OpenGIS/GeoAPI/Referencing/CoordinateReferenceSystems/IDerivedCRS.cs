#region

using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface IDerivedCRS : ISingleCRS
    {
        ICoordinateReferenceSystem BaseCRS { get; }

        IConversion ConversionFromBase { get; }
    }
}