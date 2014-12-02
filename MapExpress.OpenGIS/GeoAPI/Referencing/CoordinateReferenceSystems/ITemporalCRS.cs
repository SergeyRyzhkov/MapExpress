#region

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface ITemporalCRS : ISingleCRS
    {
        new ITimeCS CoordinateSystem { get; }

        ITemporalDatum Datum { get; }
    }
}