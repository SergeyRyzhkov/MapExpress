using System.Xml.Serialization;

namespace MapExpress.OpenGIS.Wms.Metadata
{
    public struct MimeType
    {
        public static MimeType XML = new MimeType (string.Empty, "XML");
        public static MimeType TextXML = new MimeType ("text", "xml");
        public static MimeType Application_WMS_XML = new MimeType ("application", "vnd.ogc.wms_xml");
        public static MimeType ApplicationExceptionXML = new MimeType ("application", "vnd.ogc.se_xml");
        public static MimeType ApplicationExceptionInimage = new MimeType ("application", "vnd.ogc.se_inimage");
        public static MimeType ApplicationExceptionBlank = new MimeType ("application", "vnd.ogc.se_blank");

        // TODO:
        //public static MimeType image/bmp</Format>
        //public static MimeType image/jpeg</Format>
        //<Format>image/tiff</Format>
        //<Format>image/png</Format>
        //<Format>image/png8</Format>
        //<Format>image/png24</Format>
        //<Format>image/png32</Format>
        //<Format>image/gif</Format>
        //<Format>image/svg+xml</Format>

        private MimeType (string type, string subType) : this ()
        {
            Type = type;
            SubType = subType;
        }

        [XmlIgnore]
        public string Type { get; set; }

        [XmlIgnore]
        public string SubType { get; set; }

        [XmlText]
        public string Format
        {
            get { return Type == string.Empty ? SubType : Type + @"/" + SubType; }
            set { }
        }

        
    }
}