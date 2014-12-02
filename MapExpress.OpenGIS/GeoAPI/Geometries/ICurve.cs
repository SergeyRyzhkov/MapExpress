namespace MapExpress.OpenGIS.GeoAPI.Geometries
{
    public interface ICurve : IGeometry
    {
        IPoint StartPoint { get; set; }

        IPoint EndPoint { get; set; }

        bool IsClosed { get; }

        bool IsRing { get; }
    }
}