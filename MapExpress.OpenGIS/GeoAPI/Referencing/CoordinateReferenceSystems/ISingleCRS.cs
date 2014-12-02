#region

#endregion

using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface ISingleCRS : ICoordinateReferenceSystem
    {
        IDatum Datum { get; set; }
    }
}