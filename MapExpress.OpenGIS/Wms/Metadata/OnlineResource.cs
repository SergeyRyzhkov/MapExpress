#region

using System;
using System.Xml.Serialization;

#endregion

namespace MapExpress.OpenGIS.Wms.Metadata
{
    [Serializable]
    public struct OnlineResource
    {
        public OnlineResource (string url) : this ()
        {
            URL = url;
        }

        public OnlineResource (string onlineResourceType, string url) : this ()
        {
            OnlineResourceType = onlineResourceType;
            URL = url;
        }

        [XmlAttribute (Namespace = "http://www.w3.org/1999/xlink", AttributeName = "type")]
        public string OnlineResourceType { get; set; }


        [XmlAttribute (Namespace = "http://www.w3.org/1999/xlink", AttributeName = "href")]
        public string URL { get; set; }
    }
}