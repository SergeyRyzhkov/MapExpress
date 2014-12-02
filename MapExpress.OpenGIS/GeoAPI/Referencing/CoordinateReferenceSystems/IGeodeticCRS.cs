#region

using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface IGeodeticCRS : ISingleCRS
    {
        new IGeodeticDatum Datum { get; set; }
    }
}