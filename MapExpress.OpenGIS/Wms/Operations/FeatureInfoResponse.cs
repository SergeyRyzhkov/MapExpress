using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct FeatureInfoResponse : IWmsResponse
    {
        public string Format { get; set; }

        public string FeatureInformation { get; set; }
    }
}