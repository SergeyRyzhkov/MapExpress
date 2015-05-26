#region

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

#endregion

namespace MapExpress.OpenGIS.Wms.Metadata
{
    [Serializable]
    public struct ServiceDescription
    {
        public ServiceDescription (string title, string onlineResourceURL) : this (title, new OnlineResource
                                                                                              {
                                                                                                  URL = onlineResourceURL
                                                                                              })
        {
        }

        public ServiceDescription (string title, OnlineResource onlineResource) : this ()
        {
            Title = title;
            OnlineResource = onlineResource;
            ContactInformation = new ContactInformation ();
            Keywords = new List <string> ();
            OnlineResource = new OnlineResource ();
        }


        public string Abstract { get; set; }

        public string AccessConstraints { get; set; }

        [XmlElement ("ContactInformation")]
        public ContactInformation ContactInformation { get; set; }

        public string Fees { get; set; }

        [XmlArray ("KeywordList")]
        [XmlArrayItem (ElementName = "Keyword", Type = typeof (string))]
        public List <string> Keywords { get; set; }

        public long LayerLimit { get; set; }

        public long MaxHeight { get; set; }

        public long MaxWidth { get; set; }

        public string Name { get; set; }

        public OnlineResource OnlineResource { get; set; }

        public string PublicAccessURL { get; set; }

        public string Title { get; set; }
    }
}