using System.Collections.Generic;

namespace MapExpress.OpenGIS.Wms.Operations
{
    public interface IWmsRequest
    {
        string RequestName
        {
            get;
        }

        string Version { get; set; }

        bool ValidateParameters (out IList <WmsException> exceptions);
    }
}