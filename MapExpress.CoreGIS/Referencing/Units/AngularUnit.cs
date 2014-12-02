#region

using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.Units
{
    public class AngularUnit : Unit, IAngularUnit
    {
        public static readonly AngularUnit Radian = new AngularUnit ("radian", "rad", 1, 9121);
        public static readonly AngularUnit Degree = new AngularUnit ("degree", "\xb0", 0.0174532925199433, 9122);
        public static readonly AngularUnit ArcMinute = new AngularUnit ("arc-minute", "min", 0.000290888208665721);
        public static readonly AngularUnit ArcSecond = new AngularUnit ("arc-second", "sec", 1.0 / 3600.0);
        public static readonly AngularUnit Grad = new AngularUnit ("grad", "grad", 0.015707963267949);

        public AngularUnit (string name, string abbreviation, double baseValue) : base (name, abbreviation, baseValue)
        {
        }

        public AngularUnit (string name, string abbreviation, double baseValue, uint authorityCode) : base (name, abbreviation, baseValue, authorityCode)
        {
        }

        public AngularUnit ()
        {
        }
    }
}