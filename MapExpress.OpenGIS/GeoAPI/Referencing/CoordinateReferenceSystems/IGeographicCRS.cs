#region

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface IGeographicCRS : IGeodeticCRS
    {
        new IEllipsoidalCS CoordinateSystem { get; }

        new IAngularUnit Unit { get; set; }
    }
}