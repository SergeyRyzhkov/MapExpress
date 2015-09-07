using System.Collections.Generic;

namespace MapExpress.CoreGIS.OGS.Wms.Operations
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