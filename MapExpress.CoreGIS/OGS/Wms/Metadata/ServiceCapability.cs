using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace MapExpress.CoreGIS.OGS.Wms.Metadata
{
    [Serializable]
    public struct ServiceCapability
    {
        public ServiceCapability (List<WmsOperationInfo> supportedOperations): this ()
        {
            SupportedOperations = supportedOperations ?? new List <WmsOperationInfo> ();
        }

        [XmlArray ("Request")]
        [XmlArrayItem (ElementName = "GetCapabilities", Type = typeof (GetCapabilitiesOperationInfo))]
        [XmlArrayItem (ElementName = "GetMap", Type = typeof (GetMapOperationInfo))]
        [XmlArrayItem (ElementName = "GetFeatureInfo", Type = typeof (GetFeatureInfoOperationInfo))]
        public List <WmsOperationInfo> SupportedOperations { get; set; }

      
        [XmlArray ("Exception")]
        [XmlArrayItem ("Format", typeof (string))]
        public List <string> ExceptionFormats { get; set; }

        [XmlElement ("Layer")]
        public WmsLayerInfo Map { get; set; }

        public GetMapOperationInfo GetMapOperationInfo ()
        {
            return SupportedOperations.OfType<GetMapOperationInfo> ().FirstOrDefault ();
        }

        public GetCapabilitiesOperationInfo GetCapabilitiesOperationInfo ()
        {
            return SupportedOperations.OfType<GetCapabilitiesOperationInfo> ().FirstOrDefault ();
    
        }

        public GetFeatureInfoOperationInfo GetFeatureInfoOperationInfo ()
        {
            return SupportedOperations.OfType<GetFeatureInfoOperationInfo> ().FirstOrDefault ();
    
        }

    }

    
}