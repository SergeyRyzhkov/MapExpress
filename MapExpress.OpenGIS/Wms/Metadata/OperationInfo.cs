using System.Collections.Generic;
using System.Xml.Serialization;

namespace MapExpress.OpenGIS.Wms.Metadata
{
    public abstract class OperationInfo
    {
        protected OperationInfo ()
        {
        }

        protected OperationInfo (string onlineResourceUrl) : this (new OnlineResource {URL = onlineResourceUrl})
        {
        }

        protected OperationInfo (OnlineResource onlineResource) : this (onlineResource, new List <MimeType> {MimeType.Application_WMS_XML, MimeType.XML})
        {
        }

        protected OperationInfo (OnlineResource onlineResource, List <MimeType> formatList)
        {
            OnlineResource = onlineResource;
            FormatList = formatList;
        }

        public OnlineResource OnlineResource { get; set; }

        [XmlElement ("Format")]
        public List <MimeType> FormatList { get; set; }
    }

    public class GetCapabilitiesOperationInfo : OperationInfo
    {
        public GetCapabilitiesOperationInfo ()
        {
        }

        public GetCapabilitiesOperationInfo (string onlineResourceUrl) : base (onlineResourceUrl)
        {
        }

        public GetCapabilitiesOperationInfo (OnlineResource onlineResource) : base (onlineResource)
        {
        }

        public GetCapabilitiesOperationInfo (OnlineResource onlineResource, List <MimeType> formatList) : base (onlineResource, formatList)
        {
        }
    }

    public class GetMapOperationInfo : OperationInfo
    {
        public GetMapOperationInfo ()
        {
        }

        public GetMapOperationInfo (string onlineResourceUrl) : base (onlineResourceUrl)
        {
        }

        public GetMapOperationInfo (OnlineResource onlineResource) : base (onlineResource)
        {
        }

        public GetMapOperationInfo (OnlineResource onlineResource, List <MimeType> formatList) : base (onlineResource, formatList)
        {
        }
    }

    public class GetFeatureInfoOperationInfo : OperationInfo
    {
        public GetFeatureInfoOperationInfo ()
        {
        }

        public GetFeatureInfoOperationInfo (string onlineResourceUrl) : base (onlineResourceUrl)
        {
        }

        public GetFeatureInfoOperationInfo (OnlineResource onlineResource) : base (onlineResource)
        {
        }

        public GetFeatureInfoOperationInfo (OnlineResource onlineResource, List <MimeType> formatList) : base (onlineResource, formatList)
        {
        }
    }
}