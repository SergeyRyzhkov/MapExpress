using MapExpress.OpenGIS.Wms.Operations;

namespace MapExpress.OpenGIS.Wms
{
    // TODO: А ведь можно получать Capabilities из XML-файда, надо предусмотреть в Wm-классе
    // TODO: Надо сделать в WEB сборке HttpWmsService - где будет хендлер, контекст передаваться типа как в шарпмапе
    public abstract class WmsService
    {
        public abstract MetadataResponse GetCapabilities (MetadataRequest metadataRequest);

        public abstract MapResponse GetMap (MapRequest mapRequest);

        public abstract FeatureInfoResponse GetFeatureInfo (FeatureInfoRequest featureInfoRequest);
    }
}