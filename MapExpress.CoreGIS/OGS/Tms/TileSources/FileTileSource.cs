#region

using System;
using System.IO;
using System.Linq;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.OGS.Tms.TileSources
{
    public class FileTileSource : ITileSource
    {
        private string tileUriTemplate;
        private readonly string rootDirectoryName;
        private string imageExtension;

        public FileTileSource (string rootDirectoryName)
        {
            this.rootDirectoryName = rootDirectoryName;
        }

        public string RootDirectoryName
        {
            get { return rootDirectoryName; }
        }

        public virtual string TileUriTemplate
        {
            get
            {
                if (string.IsNullOrEmpty (tileUriTemplate))
                {
                    tileUriTemplate = "file:///" + rootDirectoryName + "/{Z}/{X}/{Y}." + ImageExtension;
                }
                return tileUriTemplate;
            }
            set
            {
                tileUriTemplate = value;
                tileUriTemplate = tileUriTemplate.Replace ("{x}", "{X}").Replace ("{y}", "{Y}").Replace ("{z}", "{Z}");
            }
        }

        public virtual Uri GetTileUri (TileIndex tileIndex)
        {
            var uriStr = TileUriTemplate.Replace ("{X}", tileIndex.X.ToString ()).Replace ("{Y}", tileIndex.Y.ToString ()).Replace ("{Z}", tileIndex.Level.ToString ());
            return new Uri (uriStr);
        }

        public virtual bool Mutable
        {
            get;
            set;
        }


        public virtual string ImageExtension
        {
            get
            {
                if (string.IsNullOrEmpty (imageExtension))
                {
                    var dirInfo = new DirectoryInfo (rootDirectoryName);
                    if (dirInfo != null)
                    {
                        var en = dirInfo.EnumerateFiles ("*.*", SearchOption.AllDirectories);
                        var fi = en.First ();
                        imageExtension = fi.Extension;
                    }
                }

                if (string.IsNullOrEmpty (imageExtension))
                {
                    imageExtension = "png";
                }
                return imageExtension.Replace (".", "");
            }
            set { imageExtension = value; }
        }


        public virtual byte[] GetTile (TileIndex tileIndex)
        {
            FileStream stream = null;
            try
            {
                stream = new FileStream (GetTileUri (tileIndex).LocalPath, FileMode.Open, FileAccess.Read);
                return FileUtil.ReadFully (stream);
            }
            catch (Exception exc)
            {
                //Logger.GetLogger (typeof (FileTileSource)).Error (exc);
            }
            finally
            {
                if (stream != null)
                    stream.Close ();
            }
            return null;
        }


        public virtual void AddTile (TileIndex tileIndex, byte[] image)
        {
            if (Mutable)
            {
                if (image != null)
                {
                    var isContains = TileExists (tileIndex);

                    if (!isContains)
                    {
                        var tileFolderName = Path.GetDirectoryName (rootDirectoryName);
                        if (string.IsNullOrEmpty (tileFolderName) || !Directory.Exists (tileFolderName))
                        {
                            Directory.CreateDirectory (tileFolderName);
                        }
                    }

                    if (isContains)
                    {
                        try
                        {
                            File.WriteAllBytes (GetTileUri (tileIndex).LocalPath, image);
                        }
                        catch (Exception exc)
                        {
                            //Logger.GetLogger (typeof (FileTileSource)).Error (exc);
                        }
                        finally
                        {
                        }
                    }
                }
            }
        }

        public virtual void RemoveTile (TileIndex tileIndex)
        {
            if (Mutable)
            {
                if (TileExists (tileIndex))
                {
                    File.Delete (GetTileUri (tileIndex).LocalPath);
                }
            }
        }

        public virtual bool TileExists (TileIndex tileIndex)
        {
            return File.Exists (GetTileUri (tileIndex).LocalPath);
            //var task = new Task<bool> (() => Directory.Exists (GetTileUri (tileIndex).LocalPath));
            //task.Start ();
            //return task.Wait (timeout) && task.Result;
        }
    }
}