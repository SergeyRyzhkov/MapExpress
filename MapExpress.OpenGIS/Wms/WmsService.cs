#region


using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
using MapExpress.OpenGIS.Wms.Metadata;
using MapExpress.OpenGIS.Wms.Operations;

#endregion

namespace MapExpress.OpenGIS.Wms
{
    public abstract class WmsService
    {
        public abstract MetadataResponse GetCapabilities (MetadataRequest metadataRequest);

        public virtual MetadataResponse GetCapabilities (NameValueCollection queryParameters)
        {
            return GetCapabilities (BuildMetadataRequest (queryParameters));
        }


        public abstract MapResponse GetMap (MapRequest mapRequest);

        public virtual MapResponse GetMap (NameValueCollection queryParameters)
        {
            return GetMap (BuildMapRequest (queryParameters));
        }


        public abstract FeatureInfoResponse GetFeatureInfo (FeatureInfoRequest featureInfoRequest);

        public virtual FeatureInfoResponse GetFeatureInfo (NameValueCollection queryParameters)
        {
            return GetFeatureInfo (BuildFeatureInfoRequest (queryParameters));
        }

        public virtual IWmsResponse GetWmsResponse (NameValueCollection queryParameters)
        {
            var request = GetWmsRequest (queryParameters);

            if (request is MetadataRequest)
            {
                return GetCapabilities ((MetadataRequest) request);
            }

            if (request is MapRequest)
            {
                return GetMap ((MapRequest) request);
            }

            if (request is FeatureInfoRequest)
            {
                return GetFeatureInfo ((FeatureInfoRequest) request);
            }

            return null;
        }

        public static IWmsRequest GetWmsRequest (NameValueCollection queryParameters)
        {
            const bool ignoreCase = true;
            if (queryParameters ["REQUEST"] == null)
            {
                throw new WmsException ("Required parameter REQUEST not specified", WmsExceptionType.OperationNotSupported);
            }

            if (String.Compare (queryParameters ["REQUEST"], "GetCapabilities", ignoreCase) != 0)
            {
                return BuildMetadataRequest (queryParameters);
            }

            if (String.Compare (queryParameters ["REQUEST"], "GetFeatureInfo", ignoreCase) != 0)
            {
                return BuildFeatureInfoRequest (queryParameters);
            }

            if (String.Compare (queryParameters ["REQUEST"], "GetMap", ignoreCase) != 0)
            {
                return BuildMapRequest (queryParameters);
            }
            return null;
        }

        public static MetadataRequest BuildMetadataRequest (NameValueCollection queryParameters)
        {
            return new MetadataRequest
                       {
                           Version = queryParameters ["VERSION"],
                           Service = queryParameters ["SERVICE"],
                           Format = queryParameters ["FORMAT"]
                       };
        }

        public static MapRequest BuildMapRequest (NameValueCollection queryParameters)
        {
            var mapRequest = new MapRequest {Version = queryParameters ["VERSION"]};

            var layersParam = queryParameters ["LAYERS"];
            if (!string.IsNullOrEmpty (layersParam))
            {
                var layersStr = layersParam.Split (',');
                foreach (var iterName in layersStr)
                {
                    mapRequest.Layers.Add (iterName);
                }
            }

            var stylesParam = queryParameters ["STYLES"];
            if (!string.IsNullOrEmpty (stylesParam))
            {
                var styles = stylesParam.Split (',');
                foreach (var styleName in styles)
                {
                    mapRequest.Styles.Add (styleName);
                }
            }

            mapRequest.CRS = queryParameters ["CRS"];
            mapRequest.BoundingBox = GetBoundingBox (queryParameters ["BBOX"]);
            mapRequest.ExceptionFormat = queryParameters ["EXCEPTIONS"];

            var mapAttributes = new MapAttributes
                                    {
                                        Width = GetIntValueOrZero (queryParameters ["WIDTH"]),
                                        Height = GetIntValueOrZero (queryParameters ["HEIGHT"]),
                                        Format = queryParameters ["FORMAT"],
                                        Transparent = GetBooleanValueOrFalse (queryParameters ["TRANSPARENT"]),
                                        BackgroundColor = GetColorValueOrWhite (queryParameters ["BGCOLOR"])
                                    };

            mapRequest.MapAttributes = mapAttributes;

            return mapRequest;
        }


        public static FeatureInfoRequest BuildFeatureInfoRequest (NameValueCollection queryParameters)
        {
            return new FeatureInfoRequest ();
        }

        private static WmsBoundingBox GetBoundingBox (string bboxParameter)
        {
            var result = new WmsBoundingBox ();
            if (!string.IsNullOrEmpty (bboxParameter))
            {
                var parts = bboxParameter.Split (',');
                if (parts.Length == 4)
                {
                    result.MinX = GetDoubleValueOrZero (parts [0]);
                    result.MinY = GetDoubleValueOrZero (parts [1]);
                    result.MaxX = GetDoubleValueOrZero (parts [2]);
                    result.MaxY = GetDoubleValueOrZero (parts [3]);
                }
            }
            return result;
        }

        private static int GetIntValueOrZero (string parameter)
        {
            var result = 0;
            if (!string.IsNullOrEmpty (parameter))
            {
                int.TryParse (parameter.Trim (), NumberStyles.Any, CultureInfo.InvariantCulture, out result);
            }
            return result;
        }

        private static bool GetBooleanValueOrFalse (string parameter)
        {
            if (!string.IsNullOrEmpty (parameter))
            {
                if (string.Equals (parameter.Trim (), "TRUE", StringComparison.InvariantCultureIgnoreCase) || string.Equals (parameter.Trim (), "1", StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private static Color GetColorValueOrWhite (string parameter)
        {
            try
            {
                return ColorTranslator.FromHtml (parameter);
            }
            catch
            {
                return Color.White;
            }
        }


        private static double GetDoubleValueOrZero (string parameter)
        {
            double result = 0;
            if (!string.IsNullOrEmpty (parameter))
            {
                double.TryParse (parameter.Trim ().Replace (",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out result);
            }
            return result;
        }
    }
}