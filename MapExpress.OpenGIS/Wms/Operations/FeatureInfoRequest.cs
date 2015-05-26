#region

using System.Collections.Generic;
using System.ComponentModel;
using MapExpress.OpenGIS.Wms.Metadata;

#endregion

namespace MapExpress.OpenGIS.Wms.Operations
{
    public class FeatureInfoRequest : MapRequest
    {
        public FeatureInfoRequest (string version = "1.3.0")
        {
            FeatureCount = 1;
            Version = version;
        }

        
        public PixelPoint QueryPoint { get; set; }

        public string InfoFormat
        {
            get;
            set;
        }

        public int FeatureCount
        {
            get;
            set;
        }

        public override string RequestName
        {
            get { return "GetFeatureInfo"; }
        }
    }

    public struct PixelPoint
    {
        public PixelPoint (double x, double y) : this ()
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }
    }
}