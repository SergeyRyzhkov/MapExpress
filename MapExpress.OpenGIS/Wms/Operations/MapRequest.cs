#region

using System;
using System.Collections.Generic;
using MapExpress.OpenGIS.Wms.Metadata;

#endregion

namespace MapExpress.OpenGIS.Wms.Operations
{
// TODO: Надо как в строке GetMap ит.д.

    public class MapRequest : IWmsRequest
    {
        public MapRequest (string version = "1.3.0")
        {
            Layers = new List <string> ();
            Styles = new List <string> ();
            MapAttributes = new MapAttributes ();
            Version = version;
        }


        public WmsBoundingBox BoundingBox { get; set; }

        public string ExceptionFormat { get; set; }

        public List <string> Layers { get; set; }

        public MapAttributes MapAttributes { get; set; }

        public List <string> Styles { get; set; }

        public string CRS { get; set; }


        public virtual string RequestName
        {
            get { return "GetMap"; }
        }

        public string Version { get; set; }

        public bool ValidateParameters (out IList <WmsException> exceptions)
        {
            throw new NotImplementedException ();
        }
    }
}