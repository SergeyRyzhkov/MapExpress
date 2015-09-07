namespace MapExpress.CoreGIS.OGS.Tms
{
    public delegate void TileImageLoadEventHandler (TileImageLoadEventArgs args);

    public class TileImageLoadEventArgs
    {
      
        public TileImageLoadEventArgs (TileIndex tileIndex)
        {
            TileIndex = tileIndex;
        }

        public TileIndex TileIndex { get; private set; }
    }
}