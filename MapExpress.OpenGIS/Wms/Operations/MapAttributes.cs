using System.Drawing;
using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct MapAttributes
    {
        public Color BackgroundColor { get; set; }

        public MimeType Format { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public bool Transparent { get; set; }
    }
}