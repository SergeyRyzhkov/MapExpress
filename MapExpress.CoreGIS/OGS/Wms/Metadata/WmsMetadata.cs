using System;

namespace MapExpress.CoreGIS.OGS.Wms.Metadata
{
    [Serializable]
    public struct WmsMetadata
    {
        public string MetadataFormat;
        public string MetadataURL;
        public string OnlineResourceType;
        public string Type;
    }
}