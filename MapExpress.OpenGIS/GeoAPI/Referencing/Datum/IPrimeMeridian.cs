#region

using System;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

// TODO: Везде поменять WKT на метод Export и Import

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Datum
{
    public interface IPrimeMeridian : IEquatable <IPrimeMeridian>, IAuthorityObject
    {
        string Name { get; set; }

        double Longitude { get; }

        IAngularUnit Unit { get; }

        string ExportToWKT ();
    }
}