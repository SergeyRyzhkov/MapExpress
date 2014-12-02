using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct MapAttributes
    {
        public string BackgroundColor { get; set; }

        public MimeType Format { get; set; }

        public uint Width { get; set; }

        public uint Height { get; set; }

        public bool Transparent { get; set; }
    }
}