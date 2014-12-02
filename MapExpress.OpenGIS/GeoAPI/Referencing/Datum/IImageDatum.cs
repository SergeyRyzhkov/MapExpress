namespace MapExpress.OpenGIS.GeoAPI.Referencing.Datum
{
    public interface IImageDatum : IDatum
    {
        PixelInCellType PixelInCell { get; }
    }
}