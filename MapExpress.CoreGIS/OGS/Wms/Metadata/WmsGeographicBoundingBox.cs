using System;
using System.Xml.Serialization;

namespace MapExpress.CoreGIS.OGS.Wms.Metadata
{
    [Serializable]
    public struct WmsGeographicBoundingBox
    {

        [XmlElement ("southBoundLatitude")]
        public double SouthBoundLatitude;

        [XmlElement ("northBoundLatitude")]
        public double NorthBoundLatitude;

        [XmlElement ("westBoundLongitude")]
        public double WestBoundLongitude;

        [XmlElement ("eastBoundLongitude")]
        public double EastBoundLongitude;
     
    }
}