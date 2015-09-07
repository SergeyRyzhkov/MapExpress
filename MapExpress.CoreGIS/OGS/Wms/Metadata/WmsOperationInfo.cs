#region

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

#endregion

namespace MapExpress.CoreGIS.OGS.Wms.Metadata
{
    [Serializable]
    public class WmsOperationInfo
    {
        public OnlineResource OnlineResource
        {
            get { return DCPType.HTTP.Get.OnlineResource; }
        }

        [XmlElement ("Format")]
        public List <string> FormatList { get; set; }

        [XmlElement ("DCPType")]
        public DCPType DCPType { get; set; }
    }

    public struct DCPType
    {
        [XmlElement ("HTTP")]
        public HTTP HTTP { get; set; }
    }

    public struct HTTP
    {
        [XmlElement ("Get")]
        public Get Get { get; set; }
    }

    public struct Get
    {
        [XmlElement ("OnlineResource")]
        public OnlineResource OnlineResource { get; set; }
    }


    public class GetCapabilitiesOperationInfo : WmsOperationInfo
    {
    }

    public class GetMapOperationInfo : WmsOperationInfo
    {
    }

    public class GetFeatureInfoOperationInfo : WmsOperationInfo
    {
    }
}