#region

using System;
using System.Net;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.OGS.Tms.TileSources
{
    public class HttpTileSource : ITileSource
    {
        private string tileUriTemplate;
        
        public HttpTileSource (string tileUriTemplate)
        {
            TileUriTemplate = tileUriTemplate;
        }

        
        public string TileUriTemplate
        {
            get
            {
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

        public virtual byte[] GetTile (TileIndex tileIndex)
        {
            return HttpUtil.FetchImage (GetTileUri (tileIndex));
        }

        public virtual bool Mutable { get; set; }

        public virtual void AddTile (TileIndex tileIndex, byte[] image)
        {
            throw new NotImplementedException ();
        }

        public virtual void RemoveTile (TileIndex tileIndex)
        {
            throw new NotImplementedException ();
        }

        public virtual bool TileExists (TileIndex tileIndex)
        {
            return HttpUtil.GetResponseStatus (GetTileUri (tileIndex).AbsoluteUri) == HttpStatusCode.OK;
        }

        public virtual string ImageExtension { get; set; }
    }
}