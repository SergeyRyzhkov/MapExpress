using System;

namespace MapExpress.CoreGIS.OGS.Wms.Metadata
{
    [Serializable]
    public struct WmsLayerStyle
    {
        public string Name;
        public string Title;
        public WmsLegend WmsLegend;
    }
}