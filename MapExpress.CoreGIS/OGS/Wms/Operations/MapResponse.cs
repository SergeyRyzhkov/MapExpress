namespace MapExpress.CoreGIS.OGS.Wms.Operations
{
    public struct MapResponse : IWmsResponse
    {
        public MapResponse (byte[] mapImage, string format)
            : this ()
        {
            Image = mapImage;
            Format = format;
        }

        public byte[] Image { get; set; }

        public string Format { get; set; }
    }
}