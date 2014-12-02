#region

#endregion

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    public class ImageCRS : SingleCRS, IImageCRS
    {
        public ImageCRS (IAffineCS coordinateSystem, IImageDatum datum) : base (coordinateSystem)
        {
            CoordinateSystem = coordinateSystem;
            Datum = datum;
        }

        public ImageCRS (string name, IAffineCS coordinateSystem, IImageDatum datum) : base (name, coordinateSystem)
        {
            CoordinateSystem = coordinateSystem;
            Datum = datum;
        }

        #region IImageCRS Members

        public new IAffineCS CoordinateSystem { get; set; }


        public new IImageDatum Datum { get; set; }

        #endregion
    }
}