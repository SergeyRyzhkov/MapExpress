using System.Configuration;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.SessionState;
using MapExpress.OpenGIS.Wms.Converters;
using MapExpress.Web.Wms;
using MapInfo.Data;
using MapInfo.Engine;
using MapInfo.Mapping;

namespace MapExpress.Web
{
    public class WmsHttpModule : IHttpHandler, IRequiresSessionState
    {
        private MapExtremeWmsService mapExtremeWmsService = new MapExtremeWmsService ();

        #region IHttpHandler Members

        public void ProcessRequest (HttpContext context)
        {
            Wm k = new Wm();
            var parameters = k.BuildMapRequest (context.Request.Params);
            var result = mapExtremeWmsService.GetMap (parameters);
            context.Response.Clear ();
            context.Response.ContentType = parameters.MapAttributes.Format.Format;
            context.Response.BinaryWrite(result.MapImage);
            //context.Response.End ();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        #endregion

       

       
    }
}