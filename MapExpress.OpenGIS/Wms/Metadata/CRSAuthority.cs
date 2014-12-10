namespace MapExpress.OpenGIS.Wms.Metadata
{
    //CRS=EPSG:4326
    public struct CRSAuthority
    {
        public string Authority { get; set; }

        public uint Code { get; set; }

        public static CRSAuthority Create (string crsParameter)
        {
            var result = new CRSAuthority ();
            if (!string.IsNullOrEmpty (crsParameter))
            {
                var parts = crsParameter.Split (':');
                if (parts.Length == 2)
                {
                    result.Authority = parts [0];
                    result.Code = uint.Parse (parts [1]);
                }
                else
                {
                    result.Code = uint.Parse (crsParameter);
                }
            }
            return result;
        }
    }
}