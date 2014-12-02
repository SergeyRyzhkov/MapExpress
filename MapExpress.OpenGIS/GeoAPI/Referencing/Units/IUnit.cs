#region

#endregion

using MapExpress.OpenGIS.GeoAPI.Authority;

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Units
{
    public interface IUnit : IAuthorityObject
    {
        string Name { get; set; }

        string Abbreviation { get; }

        double BaseValue { get; set; }

        string ExportToWKT ();

        double ToBase (double value);

        double FromBase (double value);
    }
}