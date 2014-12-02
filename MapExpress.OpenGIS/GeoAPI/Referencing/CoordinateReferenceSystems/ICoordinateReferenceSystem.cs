#region

using System;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface ICoordinateReferenceSystem : IEquatable <ICoordinateReferenceSystem>, IAuthorityObject
    {
        string Name { get; set; }

        string AreaOfUse { get; }

        ICoordinateSystem CoordinateSystem { get; }

        IEnvelope Extent { get; }

        IUnit Unit { get; set; }

        string ExportToWKT ();
    }
}