using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct MapResponse : IWmsResponse
    {
        public byte[] MapImage { get; set; }

        public MimeType MimeType { get; set; }
    }
}