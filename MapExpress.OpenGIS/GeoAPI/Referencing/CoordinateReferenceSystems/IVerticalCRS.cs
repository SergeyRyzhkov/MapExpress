#region

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface IVerticalCRS : ISingleCRS
    {
        new IVerticalCS CoordinateSystem { get; }

        IVerticalDatum Datum { get; }
    }
}