using System;

namespace MapExpress.OpenGIS.Wms.Metadata
{
    [Serializable]
    public struct WmsLegend
    {
        public string Format;
        public uint Height;
        public string LegendURL;
        public OnlineResource OnlineResource;
        public uint Width;
    }
}