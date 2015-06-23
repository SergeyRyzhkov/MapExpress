#region

using System;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;

#endregion

namespace MapExpress.OpenGIS.Wms.Metadata
{
    [Serializable]
    [TypeConverter (typeof (ExpandableObjectConverter))]
    public struct WmsBoundingBox
    {
        public WmsBoundingBox (double minX, double minY, double maxX, double maxY, string crs = "EPSG:3857")
        {
            MaxX = maxX;
            MaxY = maxY;
            MinX = minX;
            MinY = minY;
            CRS = crs;
        }

        [XmlAttribute ("maxx")] public double MaxX;

        [XmlAttribute ("maxy")] public double MaxY;

        [XmlAttribute ("minx")] public double MinX;

        [XmlAttribute ("miny")] public double MinY;

        [XmlAttribute ("CRS")] public string CRS;

        public bool Empty
        {
            get { return MinX == 0 && MinY == 0 && MaxX == 0 && MaxY == 0; }
        }

        public double Width
        {
            get { return MaxX - MinX; }
        }

        public double Height
        {
            get
            {
                return MaxY - MinY;
            }
        }

        public override string ToString ()
        {
            var bboxSb = new StringBuilder ().Append (CRS).Append ("   ");
            bboxSb.Append (MinX.ToString ().Replace (",", ".")).Append (",").Append (MinY.ToString ().Replace (",", ".")).Append (",").Append (MaxX.ToString ().Replace (",", ".")).Append (",").Append (
                MaxY.ToString ().Replace (",", "."));
            return bboxSb.ToString ();
        }
    }
}