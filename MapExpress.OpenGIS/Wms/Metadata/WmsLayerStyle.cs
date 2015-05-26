using System;

namespace MapExpress.OpenGIS.Wms.Metadata
{
    [Serializable]
    public struct WmsLayerStyle
    {
        public string Name;
        public string Title;
        public WmsLegend WmsLegend;
    }
}