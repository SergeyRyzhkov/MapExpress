namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct MetadataRequest : IWmsRequest
    {
        public string Format { get; set; }


        public string UpdateSequence { get; set; }

        public string Service
        {
            get { return "WMS"; }
        }

        #region IWmsRequest Members

        public string Version { get; set; }

        #endregion
    }
}