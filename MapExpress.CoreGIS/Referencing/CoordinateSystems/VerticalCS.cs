#region

using System.Collections.Generic;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateSystems
{
    public class VerticalCS : CoordinateSystem, IVerticalCS
    {
        public VerticalCS (IEnumerable <ICoordinateSystemAxis> axis, string name) : base (axis, name)
        {
        }
    }
}