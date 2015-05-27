#region
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using MapExpress.OpenGIS.Wms.Metadata;
using MapExpress.OpenGIS.Wms.Operations;
using nRsn.Core.Util;

#endregion

// TODO:Весь проект перенести в MapExpress.OpenGIS.OGS
// TODO: в MapResponse текст ошибки
// TODO: Сделать методы получения URI

namespace MapExpress.OpenGIS.Wms
{
    public class WmsClient
    {
        private MetadataResponse currentMetadataResponse;
        private bool currentMetadataResponseInitialized;

        private readonly string serviceUrl;

        private const string GetCapabilitiesTemplate = "VERSION={0}&REQUEST=GetCapabilities&SERVICE=WMS";
        private const string GetMapTemplate = "VERSION={0}&REQUEST=GetMap&SERVICE=WMS&LAYERS={1}&STYLES={2}&CRS={3}&BBOX={4}&WIDTH={5}&HEIGHT={6}&FORMAT={7}&TRANSPARENT={8}&BGCOLOR={9}";
        private const string GetFeatureInfoTemplate = "VERSION={0}&REQUEST=GetFeatureInfo&SERVICE=WMS&LAYERS={1}&STYLES={2}&CRS={3}&BBOX={4}&WIDTH={5}&HEIGHT={6}&query_layers={7}&info_format={8}&feature_count={9}&i={10}&j={11}";

        public WmsClient (string serviceUrl)
        {
            this.serviceUrl = serviceUrl;
            if (!this.serviceUrl.EndsWith ("?"))
            {
                this.serviceUrl = this.serviceUrl + "?";
            }
        }

        public string GetCapabilitiesUrl (MetadataRequest request)
        {
            return serviceUrl + string.Format (GetCapabilitiesTemplate, string.IsNullOrEmpty (request.Version) ? "1.3.0" : request.Version);
        }

        public MetadataResponse GetCapabilities ()
        {
            var request = new MetadataRequest {Version = "1.3.0"};
            return GetCapabilities (request);
        }

        public MetadataResponse GetCapabilities (MetadataRequest request)
        {
            var xml = HttpUtil.GetText (GetCapabilitiesUrl (request), Encoding.UTF8);
            var ser = new XmlSerializer (typeof (WmsServiceMetadata));
            var meta = (WmsServiceMetadata) ser.Deserialize (StringUtil.GetStream (xml));
            var result = new MetadataResponse {WmsServiceMetadata = meta};
            return result;
        }

        public string GetMapUrl (MapRequest mapRequest)
        {
            NormalizeMapRequest (mapRequest);

            var layers = string.Join (",", mapRequest.Layers);
            var styles = string.Join (",", mapRequest.Styles);
            var bboxSb = new StringBuilder ();
            bboxSb.Append (mapRequest.BoundingBox.MinX.ToString ().Replace (",", ".")).Append (",").Append (mapRequest.BoundingBox.MinY.ToString ().Replace (",", ".")).Append (",").Append (mapRequest.BoundingBox.MaxX.ToString ().Replace (",", ".")).Append (",").Append (
                mapRequest.BoundingBox.MaxY.ToString ().Replace (",", "."));

            return serviceUrl + string.Format (GetMapTemplate, mapRequest.Version, layers, styles, mapRequest.CRS, bboxSb, mapRequest.MapAttributes.Width, mapRequest.MapAttributes.Height, mapRequest.MapAttributes.Format, mapRequest.MapAttributes.Transparent, mapRequest.MapAttributes.Transparent ? "" : mapRequest.MapAttributes.BgColorRRGGBB);
        }

        public string GetMapUrl (WmsBoundingBox boundingBox)
        {
            return GetMapUrl (null, boundingBox);
        }

        public string GetMapUrl (List <string> layers, WmsBoundingBox boundingBox)
        {
            var mapRequest = new MapRequest
                                 {
                                     BoundingBox = boundingBox,
                                     Layers = layers,
                                     CRS = boundingBox.CRS
                                 };

            return GetMapUrl (mapRequest);
        }

        public MapResponse GetMap (WmsBoundingBox boundingBox)
        {
            return GetMap (null, boundingBox);
        }

        public MapResponse GetMap (List <string> layers, WmsBoundingBox boundingBox)
        {
            var mapRequest = new MapRequest
                                 {
                                     BoundingBox = boundingBox,
                                     Layers = layers,
                                     CRS = boundingBox.CRS
                                 };

            return GetMap (mapRequest);
        }

        public MapResponse GetMap (MapRequest mapRequest)
        {
            var b = HttpUtil.FetchImage (GetMapUrl (mapRequest));
            return new MapResponse
                       {
                           Image = b,
                           Format = mapRequest.MapAttributes.Format
                       };
        }

        public string GetFeatureInfoUrl (FeatureInfoRequest featureInfoRequest)
        {
            NormalizeFeatureInfoRequest (featureInfoRequest);

            var layers = string.Join (",", featureInfoRequest.Layers);
            var styles = string.Join (",", featureInfoRequest.Styles);
            var bboxSb = new StringBuilder ();
            bboxSb.Append (featureInfoRequest.BoundingBox.MinX.ToString ().Replace (",", ".")).Append (",").Append (featureInfoRequest.BoundingBox.MinY.ToString ().Replace (",", ".")).Append (",").Append (featureInfoRequest.BoundingBox.MaxX.ToString ().Replace (",", ".")).Append (",").Append (
                featureInfoRequest.BoundingBox.MaxY.ToString ().Replace (",", "."));

            return serviceUrl + string.Format (GetFeatureInfoTemplate, featureInfoRequest.Version, layers, styles, featureInfoRequest.CRS, bboxSb, featureInfoRequest.MapAttributes.Width, featureInfoRequest.MapAttributes.Height, layers, featureInfoRequest.InfoFormat, featureInfoRequest.FeatureCount,
                                               featureInfoRequest.QueryPoint.X, featureInfoRequest.QueryPoint.Y);
        }

        public FeatureInfoResponse GetFeatureInfo (FeatureInfoRequest featureInfoRequest)
        {
            var text = HttpUtil.GetText (GetFeatureInfoUrl (featureInfoRequest), Encoding.UTF8);
            return new FeatureInfoResponse {Format = featureInfoRequest.InfoFormat, FeatureInformation = text};
        }

        public MetadataResponse CurrentMetadataResponse
        {
            get
            {
                if (!currentMetadataResponseInitialized)
                {
                    currentMetadataResponse = GetCapabilities ();
                    currentMetadataResponseInitialized = true;
                }
                return currentMetadataResponse;
            }
        }

        public FeatureInfoRequest NormalizeFeatureInfoRequest (FeatureInfoRequest request)
        {
            NormalizeMapRequest (request);

            if (string.IsNullOrEmpty (request.InfoFormat))
            {
                request.InfoFormat = GetFirstFeatureInfoFormat ();
            }

            if (request.QueryPoint.X == 0 || request.QueryPoint.Y == 0)
            {
                var newQueryPoint = new PixelPoint {X = request.MapAttributes.Width / 2, Y = request.MapAttributes.Height / 2};
                request.QueryPoint = newQueryPoint;
            }

            return request;
        }

        public MapRequest NormalizeMapRequest (MapRequest request)
        {
            if (string.IsNullOrEmpty (request.CRS))
            {
                request.CRS = !string.IsNullOrEmpty (request.BoundingBox.CRS) ? request.BoundingBox.CRS : GetFirstMapCRS ();
            }

            if (request.Layers == null || !request.Layers.Any ())
            {
                request.Layers = GetQueryableLayerNames ();
            }

            if (request.BoundingBox.Empty)
            {
                request.BoundingBox = GetFirstMapBoundingBox ();
            }

            if (string.IsNullOrEmpty (request.MapAttributes.Format))
            {
                request.MapAttributes.Format = GetFirstMapFormat ();
            }

            if (request.MapAttributes.Width == 0)
            {
                request.MapAttributes.Width = CurrentMetadataResponse.WmsServiceMetadata.ServiceDescription.MaxWidth;
            }

            if (request.MapAttributes.Height == 0)
            {
                request.MapAttributes.Height = CurrentMetadataResponse.WmsServiceMetadata.ServiceDescription.MaxHeight;
            }

            return request;
        }


        public string GetFirstFeatureInfoFormat ()
        {
            //var oper = GetFeatureInfoOperationInfo ();
            //if (oper != null)
            //{
            //    return oper.FormatList[0];
            //}
            return "text/html";
        }

        public string GetFirstMapFormat ()
        {
            var getMapOper = CurrentMetadataResponse.WmsServiceMetadata.ServiceCapability.GetMapOperationInfo ();
            if (getMapOper != null)
            {
                return getMapOper.FormatList [0];
            }
            return "image/png";
        }

        public string GetFirstMapCRS ()
        {
            return CurrentMetadataResponse.WmsServiceMetadata.ServiceCapability.Map.SupportedCRS [0];
        }

        public WmsBoundingBox GetFirstMapBoundingBox ()
        {
            return CurrentMetadataResponse.WmsServiceMetadata.ServiceCapability.Map.BoundingBox [0];
        }

        public List <string> GetQueryableLayerNames ()
        {
            var res = GetQueryableLayers ();
            return res.Select (wmsLayerInfo => wmsLayerInfo.Name).ToList ();
        }

        public List <WmsLayerInfo> GetQueryableLayers ()
        {
            var result = new List <WmsLayerInfo> ();
            var metadataResponce = CurrentMetadataResponse;
            ProcessGetQueryableLayers (metadataResponce.WmsServiceMetadata.ServiceCapability.Map, result);
            return result;
        }

        private void ProcessGetQueryableLayers (WmsLayerInfo parent, List <WmsLayerInfo> result)
        {
            foreach (var wmsLayerInfo in parent.ChildLayers)
            {
                if (wmsLayerInfo.Queryable && !string.IsNullOrEmpty (wmsLayerInfo.Name))
                {
                    result.Add (wmsLayerInfo);
                }
                ProcessGetQueryableLayers (wmsLayerInfo, result);
            }
        }
    }
}