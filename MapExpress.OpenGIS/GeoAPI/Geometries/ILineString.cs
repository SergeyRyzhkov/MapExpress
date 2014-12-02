#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Geometries
{
    public interface ILineString : ICurve
    {
        ICollection <IPoint> Vertices { get; set; }
    }
}