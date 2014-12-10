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
        //Для картинок использовать 
        //  private ImageCodecInfo GetCodecInfo (string mimeType)
        //{
        //    foreach (ImageCodecInfo encoder in ImageCodecInfo.GetImageEncoders ())
        //    {
        //        if (encoder.MimeType == mimeType)
        //            return encoder;
        //    }
        //    return ImageCodecInfo.GetImageDecoders ().First (c => c.FormatID == ImageFormat.Jpeg.Guid);
        //}

        private MimeType (string type, string subType) : this ()
        {
            Type = type;
            SubType = subType;
        }

        public static MimeType Create (string value)
        {
            var result = new MimeType();
            if (!string.IsNullOrEmpty (value))
            {
                var parts = value.Split ('/');
                if (parts.Length == 2)
                {
                    result.Type = parts[0];
                    result.SubType = parts[1];
                }
                else
                {
                    result.SubType = value;
                }
            }
            return result;
        }

        [XmlIgnore]
        public string Type { get; set; }

        [XmlIgnore]
        public string SubType { get; set; }

        // TODO: Переименовать
        // Также см.ImageCodecInfo
        [XmlText]
        public string Format
        {
            get { return Type == string.Empty ? SubType : Type + @"/" + SubType; }
            set { }
        }

    }
}