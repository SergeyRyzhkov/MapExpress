using System;

namespace MapExpress.OpenGIS.GeoAPI.Referencing
{
    public interface ICoordinate : ICloneable, IEquatable <ICoordinate>
    {
        double X { get; set; }

        double Y { get; set; }

        double Z { get; }
    }
}