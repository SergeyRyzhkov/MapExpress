#region

using System;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Datum
{
    public interface IEllipsoid : IEquatable <IEllipsoid>, IAuthorityObject
    {
        string Name { get; }

        IUnit AxisUnit { get; }

        double SemiMajorAxis { get; set; }

        double SemiMinorAxis { get; set; }

        double Flattening { get; set; }

        double InverseFlattening { get; set; }

        double Eccentricity { get; }

        double EccentricitySquared { get; }

        string ExportToWKT ();

        double ConformalSphereRadius (double latRad);

        bool IsSphere ();
    }
}