using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
using MapExpress.OpenGIS.Wms.Metadata;
using MapExpress.OpenGIS.Wms.Operations;

namespace MapExpress.OpenGIS.Wms.Converters
{
    public class Wm
    {
        public IWmsRequest BuildWmsRequest (NameValueCollection queryParameters)
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
                //return BuildFeatureInfoRequest (queryParameters);
            }

            if (String.Compare (queryParameters ["REQUEST"], "GetMap", ignoreCase) != 0)
            {
                return BuildMapRequest (queryParameters);
            }
            return null;
        }

        public MetadataRequest BuildMetadataRequest (NameValueCollection queryParameters)
        {
            return new MetadataRequest {Version = queryParameters ["VERSION"], Service = queryParameters ["SERVICE"], RequestName = queryParameters ["REQUEST"], Format = MimeType.Create (queryParameters ["FORMAT"])};
        }

        public MapRequest BuildMapRequest (NameValueCollection queryParameters)
        {
            var mapRequest = new MapRequest {Version = queryParameters ["VERSION"], RequestName = queryParameters ["REQUEST"]};

            var layersParam = queryParameters ["LAYERS"];
            if (!string.IsNullOrEmpty(layersParam))
            {
                mapRequest.Layers = layersParam.Split (',');
            }

            var stylesParam = queryParameters ["STYLES"];
            if (!string.IsNullOrEmpty (stylesParam))
            {
                mapRequest.Styles = stylesParam.Split (',');
            }

            mapRequest.CRSAuthority = CRSAuthority.Create (queryParameters["CRS"]);
            mapRequest.BoundingBox = BoundingBox.Create(queryParameters ["BBOX"]);
            mapRequest.ExceptionFormat = MimeType.Create(queryParameters ["EXCEPTIONS"]);

            var mapAttributes = new MapAttributes
                                    {
                                        Width = GetIntValueOrZero (queryParameters["WIDTH"]),
                                        Height = GetIntValueOrZero (queryParameters["HEIGHT"]),
                                        Format = MimeType.Create (queryParameters ["FORMAT"]),
                                        Transparent = GetBooleanValueOrFalse (queryParameters ["TRANSPARENT"]),
                                        BackgroundColor = GetColorValueOrWhite (queryParameters ["BGCOLOR"])
                                    };

            mapRequest.MapAttributes = mapAttributes;

            return mapRequest;
        }

        //public FeatureInfoRequest BuildFeatureInfoRequest (NameValueCollection queryParameters)
        //{

        //}

        //public BoundingBox CreateBoundingBox (string bboxParameters)
        //{
            
        //}

        private int GetIntValueOrZero (string parameter)
        {
            int result = 0;
            if (!string.IsNullOrEmpty (parameter))
            {
                int.TryParse (parameter.Trim (), NumberStyles.Any, CultureInfo.InvariantCulture, out result);
            }
            return result;
        }

        private bool GetBooleanValueOrFalse (string parameter)
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

        private Color GetColorValueOrWhite (string parameter)
        {
            try
            {
                return ColorTranslator.FromHtml (parameter);
            }catch
            {
                return Color.White;
            }
        } 


        //var serializer = new XmlSerializer (typeof (WmsService));
        //   var ns = new XmlSerializerNamespaces ();
        //   ns.Add ("xlink", "http://www.w3.org/1999/xlink");

        //   var rr = new WmsServiceMetadata ();
        //   rr.ServiceDescription.OnlineResource.URL = "http:\\dfdsf.ru";
        //   rr.ServiceDescription.Keywords.Add ("Рыжков");
        //   rr.ServiceDescription.Keywords.Add ("Сергей");
        //   rr.ServiceCapability.SupportedOperations.Add (new GetFeatureInfoOperationInfo ());
        //   var mww = new LayerInfo ();
        //   rr.ServiceCapability.Layers.Add (mww);
        //   using (FileStream fs = File.Create (@"C:\_Work\test.xml"))
        //   {
        //       serializer.Serialize (fs, rr, ns);
        //   }
    }
}