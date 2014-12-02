using System;
using System.Collections.Generic;

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems
{
    public interface ICoordinateSystem : IEquatable <ICoordinateSystem>
    {
        string Name { get; }

        int Dimension { get; }

        IList <ICoordinateSystemAxis> AxisList { get; set; }

        ICoordinateSystemAxis Axis (int dimension);
    }
}