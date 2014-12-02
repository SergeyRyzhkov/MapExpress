#region

using MapExpress.CoreGIS.Referencing.Converters;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.Units
{
    public class Unit : IUnit
    {
        public static IUnit Unitless = new Unit (string.Empty);
        private AuthorityList authorityList;
        private Authority defaultAuthority;

        public Unit (string name)
        {
            Name = name;
        }

        public Unit (string name, string abbreviation, double baseValue)
        {
            Name = name;
            BaseValue = baseValue;
            Abbreviation = abbreviation;
            Epsg = Authority.Unknown;
        }

        public Unit (string name, string abbreviation, double baseValue, uint authorityCode)
        {
            Name = name;
            BaseValue = baseValue;
            Abbreviation = abbreviation;
            Epsg = new Authority (AuthorityType.EPSG, name, authorityCode);
        }

        public Unit ()
        {
        }

        public Authority Epsg
        {
            get { return defaultAuthority ?? Authority.Unknown; }
            set { defaultAuthority = value; }
        }

        #region IUnit Members

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public double BaseValue { get; set; }

        public AuthorityList AuthorityAliases
        {
            get { return authorityList ?? (authorityList = new AuthorityList ()); }
            set { authorityList = value; }
        }

        public string ExportToWKT ()
        {
            return WKTCoordinateSystemWriter.Instance.WriteUnit (this);
        }

        public double ToBase (double value)
        {
            return value * BaseValue;
        }

        public double FromBase (double value)
        {
            return value / BaseValue;
        }

        #endregion

        public override string ToString ()
        {
            return ExportToWKT ();
        }
    }
}