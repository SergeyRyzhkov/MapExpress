using System;
using System.Collections.Generic;
using MapExpress.OpenGIS.Wms.Metadata;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public struct FeatureInfoRequest : IWmsRequest
    {
        public MapAttributes MapAttributes { get; set; }

        public BoundingBox BoundingBox { get; set; }

        public string ExceptionFormat { get; set; }

        public string[] Layers { get; set; }

        public string[] QueryLayers { get; set; }

        public string[] Styles { get; set; }

        public PixelPoint QueryPoint { get; set; }

        #region IWmsRequest Members

        public string RequestName { get; set; }

        public string Version { get; set; }

        public bool ValidateParameters (out IList <WmsException> exceptions)
        {
            throw new NotImplementedException ();
        }

        #endregion
    }

    public struct PixelPoint
    {
        public double Column { get; set; }

        public double Row { get; set; }
    }
}