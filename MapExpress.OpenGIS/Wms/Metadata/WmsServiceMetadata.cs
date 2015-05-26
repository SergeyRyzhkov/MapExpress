using System;
using System.Xml.Serialization;

namespace MapExpress.OpenGIS.Wms.Metadata
{
    [Serializable]
    [XmlRoot (ElementName = "WMS_Capabilities", Namespace = "http://www.opengis.net/wms")]
    public struct WmsServiceMetadata
    {
        
        public WmsServiceMetadata (ServiceDescription serviceDescription, ServiceCapability serviceCapability) : this ()
        {
            ServiceDescription = serviceDescription;
            ServiceCapability = serviceCapability;
        }

        [XmlElement ("Service")]
        public ServiceDescription ServiceDescription { get; set; }

        [XmlElement ("Capability")]
        public ServiceCapability ServiceCapability { get; set; }
    }
}