#region

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface IImageCRS : ISingleCRS
    {
        new IAffineCS CoordinateSystem { get; }

        IImageDatum Datum { get; }
    }
}