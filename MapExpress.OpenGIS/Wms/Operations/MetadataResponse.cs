using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct MetadataResponse : IWmsResponse
    {
        public WmsServiceMetadata WmsServiceMetadata { get; set; }
    }
}