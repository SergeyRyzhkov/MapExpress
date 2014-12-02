#region

using System;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems
{
    public interface ICoordinateSystemAxis : IEquatable <ICoordinateSystemAxis>
    {
        string Abbreviation { get; }

        AxisDirectionType Direction { get; }

        double MinimumValue { get; }

        double MaximumValue { get; }

        IUnit Unit { get; }

        string ExportToWKT ();
    }
}