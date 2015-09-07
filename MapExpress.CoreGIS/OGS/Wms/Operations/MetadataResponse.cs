using MapExpress.CoreGIS.OGS.Wms.Metadata;

namespace MapExpress.CoreGIS.OGS.Wms.Operations
{
    public struct MetadataResponse : IWmsResponse
    {
        public WmsServiceMetadata WmsServiceMetadata { get; set; }
    }
}