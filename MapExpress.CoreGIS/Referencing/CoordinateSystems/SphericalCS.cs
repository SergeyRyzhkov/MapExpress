#region

using System.Collections.Generic;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateSystems
{
    public class SphericalCS : CoordinateSystem, ISphericalCS
    {
        public SphericalCS (IEnumerable <ICoordinateSystemAxis> axis, string name) : base (axis, name)
        {
        }
    }
}