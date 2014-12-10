using System.Drawing.Imaging;
using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    // Можен назвать все классы GetMapResponse итд
    public struct MapResponse : IWmsResponse
    {
        public MapResponse (byte[] mapImage, ImageCodecInfo imageCodecInfo): this ()
        {
            MapImage = mapImage;
            MimeType = imageCodecInfo;
        }

        public byte[] MapImage { get; set; }

        public ImageCodecInfo MimeType
        {
            get;
            set;
        }
    }
}