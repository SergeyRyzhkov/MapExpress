#region

using System.IO;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.Converters
{
    public interface ICoordinateSystemWriter
    {
        string WriteCoordinateSystem (ICoordinateReferenceSystem coordSys);

        void WriteCoordinateSystem (ICoordinateReferenceSystem coordSys, Stream stream);

        string WriteGeocentricCRS (IGeocentricCRS geocentricCRS);

        void WriteGeocentricCRS (IGeocentricCRS geocentricCRS, Stream stream);

        string WriteGeographicCRS (IGeographicCRS geographicCRS);

        void WriteGeographicCRS (IGeographicCRS geographicCRS, Stream stream);

        string WriteProjectedCRS (IProjectedCRS projectedCRS);

        void WriteProjectedCRS (IProjectedCRS projectedCRS, Stream stream);

        string WriteProjection (IProjection projection);

        void WriteProjection (IProjection projection, Stream stream);

        string WriteDatum (IDatum datum);

        void WriteDatum (IDatum datum, Stream stream);

        string WriteEllipsoid (IEllipsoid ellipsoid);

        void WriteEllipsoid (IEllipsoid ellipsoid, Stream stream);

        string WritePrimeMeridian (IPrimeMeridian primeMeridian);

        void WritePrimeMeridian (IPrimeMeridian primeMeridian, Stream stream);

        string WriteAxis (ICoordinateSystemAxis axis);

        void WriteAxis (ICoordinateSystemAxis axis, Stream stream);

        string WriteUnit (IUnit unit);

        void WriteUnit (IUnit unit, Stream stream);
    }
}