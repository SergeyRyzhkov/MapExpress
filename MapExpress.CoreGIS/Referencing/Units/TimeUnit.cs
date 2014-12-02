namespace MapExpress.CoreGIS.Referencing.Units
{
    public class TimeUnit : Unit
    {
        public static readonly TimeUnit Second = new TimeUnit ("second", "sec", 1);

        public TimeUnit (string name, string abbreviation, double baseValue) : base (name, abbreviation, baseValue)
        {
        }
    }
}