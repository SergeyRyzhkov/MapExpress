using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MapExpress.OpenGIS.Wms.Metadata
{
    // TODO: [Serializable] везде
    [Serializable]
    public class ServiceCapability
    {
        public ServiceCapability () : this ((string) null, null)
        {
        }

        public ServiceCapability (string onlineResourceUrl, List <LayerInfo> layers) : this (null, null, layers)
        {
            SupportedOperations.Add (new GetCapabilitiesOperationInfo (onlineResourceUrl));
            SupportedOperations.Add (new GetMapOperationInfo (onlineResourceUrl));
        }

        public ServiceCapability (List <OperationInfo> supportedOperations, List <LayerInfo> layers) : this (supportedOperations, null, layers)
        {
        }

        // TODO: В проперти иф нулл
        public ServiceCapability (List <OperationInfo> supportedOperations, List <MimeType> exceptionFormats, List <LayerInfo> layers)
        {
            SupportedOperations = supportedOperations;
            ExceptionFormats = exceptionFormats ?? new List <MimeType> ();
            Layers = layers ?? new List <LayerInfo> ();

            if (SupportedOperations == null)
            {
                SupportedOperations = new List <OperationInfo> ();
            }
        }

        // TODO: Сделать это просто пропертями и не нужно наследование ?
        [XmlArray ("Request")]
        [XmlArrayItem (ElementName = "GetCapabilities", Type = typeof (GetCapabilitiesOperationInfo))]
        [XmlArrayItem (ElementName = "GetMap", Type = typeof (GetMapOperationInfo))]
        [XmlArrayItem (ElementName = "GetFeatureInfo", Type = typeof (GetFeatureInfoOperationInfo))]
        [XmlArrayItem (typeof (OperationInfo))]
        public List <OperationInfo> SupportedOperations { get; set; }

        [XmlArray ("Exception")]
        [XmlArrayItem ("Format", typeof (MimeType))]
        public List <MimeType> ExceptionFormats { get; set; }

        [XmlElement ("Layer")]
        public List <LayerInfo> Layers { get; set; }
    }
}