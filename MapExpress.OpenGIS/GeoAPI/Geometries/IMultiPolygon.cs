#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Geometries
{
    public interface IMultiPolygon : IGeometry
    {
        ICollection <IPolygon> Polygons { get; set; }
    }
}