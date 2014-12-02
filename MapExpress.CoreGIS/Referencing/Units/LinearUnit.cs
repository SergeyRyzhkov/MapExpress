#region

#endregion

using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

namespace MapExpress.CoreGIS.Referencing.Units
{
    public class LinearUnit : Unit, ILinearUnit
    {
        public static readonly LinearUnit Meter = new LinearUnit ("metre", "m", 1, 9001);
        public static readonly LinearUnit Feet = new LinearUnit ("foot", "ft", 0.3048, 9002);
        public static readonly LinearUnit NauticalMile = new LinearUnit ("nautical mile", "nmi", 1852.0, 9030);
        public static readonly LinearUnit Kilometer = new LinearUnit ("kilometer", "km", 1000.0);
        public static readonly LinearUnit Decimetr = new LinearUnit ("decimetre", "dm", 0.1);
        public static readonly LinearUnit Centimetr = new LinearUnit ("centimetre", "cm", 0.01);
        public static readonly LinearUnit Millimetr = new LinearUnit ("millimetre", "mm", 0.001);
        public static readonly LinearUnit Mile = new LinearUnit ("mile", "mi", 1609.344);
        public static readonly LinearUnit Chain = new LinearUnit ("chain", "ch", 20.1168);
        public static readonly LinearUnit Yard = new LinearUnit ("yard", "yd", 0.9144);
        public static readonly LinearUnit Inche = new LinearUnit ("inch", "in", 0.0254);

        public LinearUnit (string name, string abbreviation, double baseValue) : base (name, abbreviation, baseValue)
        {
        }

        public LinearUnit (string name, string abbreviation, double baseValue, uint authorityCode) : base (name, abbreviation, baseValue, authorityCode)
        {
        }

        public LinearUnit ()
        {
        }
    }
}