#region

using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface IEngineeringCRS : ISingleCRS
    {
        IEngineeringDatum Datum { get; }
    }
}