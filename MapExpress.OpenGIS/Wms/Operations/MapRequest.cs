using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct MapRequest : IWmsRequest
    {
        public BoundingBox BoundingBox { get; set; }

        public MimeType ExceptionFormat { get; set; }

        public string[] Layers { get; set; }

        public MapAttributes MapAttributes { get; set; }

        public string[] Styles { get; set; }

        #region IWmsRequest Members

        public string Version { get; set; }

        #endregion
    }
}