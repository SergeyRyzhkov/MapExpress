#region

using System;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Geometries
{
    public interface IGeometry : ICloneable, IEquatable <IGeometry>
    {
        ICoordinateReferenceSystem SpatialReferenceSystem { get; }

        int Dimension { get; }

        IEnvelope Envelope { get; }

        bool IsEmpty { get; }

        GeometryType GeometryType { get; }

        string ExportToWKT ();
    }
}