using System;
using System.Collections.Generic;
using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct MapRequest : IWmsRequest
    {
        public BoundingBox BoundingBox { get; set; }

        public MimeType ExceptionFormat { get; set; }

        public string[] Layers { get; set; }

        public MapAttributes MapAttributes { get; set; }

        public string[] Styles { get; set; }

        public CRSAuthority CRSAuthority
        {
            get;
            set;
        }

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