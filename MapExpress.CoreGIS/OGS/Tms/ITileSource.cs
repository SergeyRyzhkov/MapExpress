#region

using System;
using System.Drawing.Imaging;

#endregion

namespace MapExpress.CoreGIS.OGS.Tms
{
    public interface ITileSource
    {
        string TileUriTemplate { get; set; }

        Uri GetTileUri (TileIndex tileIndex);

        byte[] GetTile (TileIndex tileIndex);

        bool Mutable { get; set; }

        void AddTile (TileIndex tileIndex, byte[] image);

        void RemoveTile (TileIndex tileIndex);

        bool TileExists (TileIndex tileIndex);

        string ImageExtension { get; set; }
    }
}