using MapExpress.OpenGIS.Wms.Operations;

namespace MapExpress.OpenGIS.Wms
{
    public abstract class WmsService
    {
        public abstract MetadataResponse GetCapabilities (MetadataRequest metadataRequest);

        public abstract MapResponse GetMap (MapRequest mapRequest);

        public abstract FeatureInfoResponse GetFeatureInfo (FeatureInfoRequest featureInfoRequest);
    }
}