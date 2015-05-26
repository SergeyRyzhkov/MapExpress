#region

using System;
using System.ComponentModel;
using System.Drawing;

#endregion

namespace MapExpress.OpenGIS.Wms.Operations
{
    public class MapAttributes
    {
        public MapAttributes ()
        {
            Format = "image/png";
            BackgroundColor = Color.White;
        }

        public Color BackgroundColor { get; set; }


        public string BgColorRRGGBB
        {
            get
            {
                var color = BackgroundColor;
                if (color == Color.Empty)
                {
                    return "FFFFFF";
                }
                return HexConverter (color);
            }
        }

        public string Format { get; set; }

        public long Width { get; set; }

        public long Height { get; set; }

        public bool Transparent { get; set; }

        private static String HexConverter (Color c)
        {
            return c.R.ToString ("X2") + c.G.ToString ("X2") + c.B.ToString ("X2");
        }
    }
}