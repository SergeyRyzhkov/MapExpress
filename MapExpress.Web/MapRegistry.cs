using System.Configuration;
using System.Drawing;
using System.IO;
using System.Web;
using MapInfo.Data;
using MapInfo.Engine;
using MapInfo.Mapping;

namespace MapExpress.Web
{
    public class MapRegistry
    {
        public static string mapAlias = "MapExpressWebWmsMap";

        public static Map GetWmsServiceMap ()
        {
            var map = (Map) HttpContext.Current.Application [mapAlias];
            //var map = Session.Current.MapFactory [mapAlias];
            return (map ?? CreateMap ());
        }


        private static Map CreateMap ()
        {
            var connectionName = ConfigurationManager.AppSettings ["MIConnectionName"];
            if (!Session.Current.Catalog.NamedConnections.Contains (connectionName))
            {
                var nci = new NamedConnectionInfo (connectionName, ConnectionMethod.FilePath, ConfigurationManager.AppSettings ["MIDataFolder"]);
                Session.Current.Catalog.NamedConnections.Add (connectionName, nci);
            }

            var map = Session.Current.MapFactory.CreateEmptyMap (mapAlias, mapAlias, new Size (100, 100));
            map.Alias = mapAlias;
            map.Name = mapAlias;
            map.ResizeMethod = ResizeMethod.PreserveZoom;
            map.DrawingAttributes.EnableTranslucency = true;
            map.DrawingAttributes.SmoothingMode = SmoothingMode.AntiAlias;

            var path = Path.Combine (ConfigurationManager.AppSettings ["MIDataFolder"], ConfigurationManager.AppSettings ["StartMWS"]);
            var loader = new MapWorkSpaceLoader (path, false);
            loader.Load (map);

            map.BackgroundBrush = new SolidBrush (Color.FromArgb (0, Color.White));
          
            HttpContext.Current.Application [mapAlias] = map;
            return map;
        }
    }
}