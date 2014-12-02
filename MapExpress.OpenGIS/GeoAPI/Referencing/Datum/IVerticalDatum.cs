namespace MapExpress.OpenGIS.GeoAPI.Referencing.Datum
{
    public interface IVerticalDatum : IDatum
    {
        VerticalDatumType VerticalDatumType { get; }
    }
}