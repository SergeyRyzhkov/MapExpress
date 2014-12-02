#region

using System;
using MapExpress.OpenGIS.GeoAPI.Authority;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Datum
{
    public interface IDatum : IEquatable <IDatum>, IAuthorityObject
    {
        string Name { get; set; }

        IEllipsoid Ellipsoid { get; }

        IPrimeMeridian PrimeMeridian { get; set; }

        string AreaOfUse { get; set; }

        string ExportToWKT ();
    }
}