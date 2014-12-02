using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

namespace MapExpress.CoreGIS.Referencing.Converters
{
    public interface ICoordinateSystemReader
    {
        ICoordinateReferenceSystem ReadCoordinateSystem (string coordSysString);

        IGeocentricCRS ReadGeocentricCRS (string coordSysString);

        IGeographicCRS ReadGeographicCRS (string coordSysString);

        IProjectedCRS ReadProjectedCRS (string projString);

        IProjection ReadProjection (string projString);

        IGeodeticDatum ReadDatum (string datumString);

        IEllipsoid ReadEllipsoid (string ellipsoidString);

        IPrimeMeridian ReadPrimeMeridian (string meridianString);

        IUnit ReadUnit (string unitString);

        ICoordinateSystemAxis ReadAxis (string axisString);
    }
}