namespace MapExpress.OpenGIS.Wms.Metadata
{
    public struct LatLonBoundingBox
    {
        public double MaxX;
        public double MaxY;
        public double MinX;
        public double MinY;

        public LatLonBoundingBox (double minX, double minY, double maxX, double maxY)
        {
            MinX = minX;
            MinY = minY;
            MaxX = maxX;
            MaxY = maxY;
        }
    }
}