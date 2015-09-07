#region

using System;
using System.IO;

#endregion

namespace MapExpress.CoreGIS.OGS.Tms.TileSources
{
    public class SasPlanetsFileTileSource : FileTileSource
    {
        public SasPlanetsFileTileSource (string rootDirectoryName) : base (rootDirectoryName)
        {
        }

        public override Uri GetTileUri (TileIndex tileIndex)
        {
            var tilePathTemplate = @"z{0}{5}{1}{5}x{2}{5}{3}{5}y{4}." + ImageExtension;
            var z = tileIndex.Level + 1;
            var xdiv1024 = tileIndex.X / 1024;
            var x = tileIndex.X;
            var ydiv1024 = tileIndex.Y / 1024;
            var y = tileIndex.Y;
            var relativePath = string.Format (tilePathTemplate, z, xdiv1024, x, ydiv1024, y, Path.DirectorySeparatorChar);
            return new Uri ("file:///" + RootDirectoryName + relativePath);
        }
    }
}