#region

using System.Collections.Generic;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateSystems
{
    public class TimeCS : CoordinateSystem, ITimeCS
    {
        public TimeCS (IEnumerable <ICoordinateSystemAxis> axis, string name) : base (axis, name)
        {
        }
    }
}