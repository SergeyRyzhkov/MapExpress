using System;

namespace MapExpress.CoreGIS.OGS.Wms.Metadata
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