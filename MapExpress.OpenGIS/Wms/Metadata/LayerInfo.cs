using System.Collections.Generic;

namespace MapExpress.OpenGIS.Wms.Metadata
{
    public struct LayerInfo
    {
        public string Abstract;
        public string Attribution;
        public List <BoundingBox> BoundingBox;
        public List <LayerInfo> ChildLayersInfo;
        public uint FixedHeight;
        public uint FixedWidth;
        public string[] Keywords;
        public LatLonBoundingBox LatLonBoundingBox;
        public double MaxScaleDenominator;
        public List <Metadata> Metadata;
        public double MinScaleDenominator;
        public string Name;
        public bool NoSubsets;
        public bool Opaque;
        public bool Queryable;
        public List <LayerStyle> Styles;
        public string[] SupportedCRS;
        public string Title;
    }
}