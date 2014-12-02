#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Geometries
{
    public interface IMultiPoint : IGeometry
    {
        ICollection <IPoint> Points { get; set; }
    }
}