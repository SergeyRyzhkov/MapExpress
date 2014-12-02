#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Geometries
{
    public interface IPolygon : IGeometry
    {
        ILinearRing ExteriorRing { get; set; }

        ICollection <ILinearRing> InteriorRings { get; set; }
    }
}