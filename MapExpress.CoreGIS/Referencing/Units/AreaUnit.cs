namespace MapExpress.CoreGIS.Referencing.Units
{
    public class AreaUnit : Unit
    {
        public static readonly AreaUnit SquareMeter = new AreaUnit ("Square Meter", "Square Meter", 1);
        public static readonly AreaUnit SquareKilometer = new AreaUnit ("Square Kilometer", "Square Kilometer", 1000000);
        public static readonly AreaUnit SquareCentimeter = new AreaUnit ("Square Centimeter", "Square Centimeter", 0.0001);

        public AreaUnit (string name, string abbreviation, double baseValue) : base (name, abbreviation, baseValue)
        {
        }
    }
}