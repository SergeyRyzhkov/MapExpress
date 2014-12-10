using System;
using System.Collections.Generic;
using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct MetadataRequest : IWmsRequest
    {
        public MimeType Format { get; set; }

        public string UpdateSequence { get; set; }

        public string Service { get; set; }

        #region IWmsRequest Members

        public string RequestName { get; set; }


        public string Version { get; set; }

        public bool ValidateParameters (out IList <WmsException> exceptions)
        {
            throw new NotImplementedException ();
        }

        #endregion
    }
}