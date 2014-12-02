#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Geometries
{
    public interface IGeometryCollection : IGeometry, IEnumerable <IGeometry>
    {
        ICollection <IGeometry> Geometries { get; }
    }
}