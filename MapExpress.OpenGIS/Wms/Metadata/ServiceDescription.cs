using System.Collections.Generic;
using System.Xml.Serialization;

namespace MapExpress.OpenGIS.Wms.Metadata
{
    public class ServiceDescription
    {
        public ServiceDescription () : this (string.Empty, string.Empty)
        {
        }


        public ServiceDescription (string title, string onlineResourceURL) : this (title, new OnlineResource
                                                                                              {
                                                                                                  URL = onlineResourceURL
                                                                                              })
        {
        }

        public ServiceDescription (string title, OnlineResource onlineResource)
        {
            Title = title;
            OnlineResource = onlineResource;
            ContactInformation = new ContactInformation ();
            Keywords = new List <string> ();
            OnlineResource = new OnlineResource ();
        }


        public string Abstract { get; set; }

        public string AccessConstraints { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public string Fees { get; set; }

        [XmlArray ("KeywordList")]
        [XmlArrayItem (ElementName = "Keyword", Type = typeof (string))]
        public List <string> Keywords { get; set; }

        public uint LayerLimit { get; set; }

        public uint MaxHeight { get; set; }

        public uint MaxWidth { get; set; }

        public string Name { get; set; }

        public OnlineResource OnlineResource { get; set; }

        public string PublicAccessURL { get; set; }

        public string Title { get; set; }
    }
}