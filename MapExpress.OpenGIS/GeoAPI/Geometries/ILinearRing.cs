namespace MapExpress.OpenGIS.GeoAPI.Geometries
{
    public interface ILinearRing : ILineString
    {
        bool IsCounterClockwise { get; }
    }
}