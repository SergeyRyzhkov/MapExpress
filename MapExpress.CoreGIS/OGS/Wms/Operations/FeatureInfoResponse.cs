namespace MapExpress.CoreGIS.OGS.Wms.Operations
{
    public struct FeatureInfoResponse : IWmsResponse
    {
        public string Format { get; set; }

        public string FeatureInformation { get; set; }
    }
}