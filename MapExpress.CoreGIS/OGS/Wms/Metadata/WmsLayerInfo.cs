#region

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

#endregion

namespace MapExpress.CoreGIS.OGS.Wms.Metadata
{
    [Serializable]
    public struct WmsLayerInfo
    {
        public WmsLayerInfo (string name): this ()
        {
            Name = name;
            Styles = new List <WmsLayerStyle> ();
            BoundingBox = new List <WmsBoundingBox> ();
            GeographicBoundingBox = new WmsGeographicBoundingBox ();
            ChildLayers = new List <WmsLayerInfo> ();
            Metadata = new List <WmsMetadata> ();
            SupportedCRS = new List <string> ();
        }

        public string Title;

        public string Abstract;

        public string Attribution;

        [XmlElement ("BoundingBox")] 
        public List <WmsBoundingBox> 
        BoundingBox;

        [XmlElement ("EX_GeographicBoundingBox")] 
        public WmsGeographicBoundingBox 
        GeographicBoundingBox;

        [XmlElement ("Layer")] 
        public List <WmsLayerInfo> 
        ChildLayers;

        public uint FixedHeight;

        public uint FixedWidth;

        public List<string> Keywords;

        public List <WmsMetadata> Metadata;

        [XmlElement ("MaxScaleDenominator")] 
        public double MaxScaleDenominator;

        [XmlElement ("MinScaleDenominator")] 
        public double MinScaleDenominator;

        [XmlElement ("Name")] public string Name;

        public bool NoSubsets;

        public bool Opaque;

        [XmlAttribute ("queryable")] 
        public bool Queryable;

        [XmlElement ("Style")] 
        public List <WmsLayerStyle> Styles;

        [XmlElement ("CRS")]
        public List <string> SupportedCRS;

        
    }
}