using System.Xml.Serialization;

namespace MapExpress.OpenGIS.Wms.Metadata
{
    public class OnlineResource
    {
        private string onlineResourceType;

        public OnlineResource ()
        {
        }

        public OnlineResource (string url)
        {
            URL = url;
        }

        public OnlineResource (string onlineResourceType, string url)
        {
            this.onlineResourceType = onlineResourceType;
            URL = url;
        }

        [XmlAttribute (Namespace = "http://www.w3.org/1999/xlink", AttributeName = "type")]
        public string OnlineResourceType
        {
            get { return onlineResourceType ?? "simple"; }
            set { onlineResourceType = value; }
        }

        [XmlAttribute (Namespace = "http://www.w3.org/1999/xlink", AttributeName = "href")]
        public string URL { get; set; }
    }
}