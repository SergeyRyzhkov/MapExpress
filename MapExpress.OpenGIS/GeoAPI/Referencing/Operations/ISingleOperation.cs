#region

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Operations
{
    public interface ISingleOperation : ICoordinateOperation
    {
        string ExportToWKT ();
    }
}