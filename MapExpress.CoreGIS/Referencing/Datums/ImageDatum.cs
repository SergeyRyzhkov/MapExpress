#region

#endregion

using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

namespace MapExpress.CoreGIS.Referencing.Datums
{
    public class ImageDatum : Datum, IImageDatum
    {
        public ImageDatum (PixelInCellType pixelInCell) : this (null, pixelInCell)
        {
            PixelInCell = pixelInCell;
        }

        public ImageDatum (string name, PixelInCellType pixelInCell)
        {
            PixelInCell = pixelInCell;
            Name = name;
        }

        public PixelInCellType PixelInCell { get; set; }
    }
}