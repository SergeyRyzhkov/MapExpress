using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct FeatureInfoResponse
    {
        public MimeType MimeType { get; set; }

        public string FeatureInformation { get; set; }
    }
}