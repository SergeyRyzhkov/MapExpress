#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Geometries
{
    public interface IMultiCurve : IGeometry
    {
        ICollection <ICurve> Curves { get; set; }
    }
}