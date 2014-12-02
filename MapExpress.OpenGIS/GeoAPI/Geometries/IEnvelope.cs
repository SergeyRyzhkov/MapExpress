#region

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Geometries
{
    public interface IEnvelope : IGeometry
    {
        IPoint BottomLeft { get; set; }

        IPoint TopRight { get; set; }
    }
}