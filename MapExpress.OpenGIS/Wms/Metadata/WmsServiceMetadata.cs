using System.Xml.Serialization;

namespace MapExpress.OpenGIS.Wms.Metadata
{
    [XmlRoot (ElementName = "WMS_Capabilities")]
    public class WmsServiceMetadata
    {
        public WmsServiceMetadata () : this (null, null)
        {
        }

        public WmsServiceMetadata (ServiceDescription serviceDescription, ServiceCapability serviceCapability)
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