using System;
using System.Collections.Generic;
using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct MetadataRequest : IWmsRequest
    {
        public MetadataRequest (string version = "1.3.0"): this ()
        {
            Version = version;
        }

        public string Format { get; set; }

        public string UpdateSequence { get; set; }

        public string Service { get; set; }

        #region IWmsRequest Members

        public string RequestName
        {
            get
            {
                return "GetCapabilities";
            }
        }

        public string Version { get; set; }

        public bool ValidateParameters (out IList <WmsException> exceptions)
        {
            throw new NotImplementedException ();
        }

        #endregion
    }
}