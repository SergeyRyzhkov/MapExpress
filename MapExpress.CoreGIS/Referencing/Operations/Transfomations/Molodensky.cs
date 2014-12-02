#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    // TODO: Оптимизировать. Вынести повт.вычисления в инициализацию
    public class Molodensky : GeographicTransform
    {
        public Molodensky (DatumShiftParameters parameters) : this (null, null, parameters)
        {
        }

        public Molodensky (IGeographicCRS sourceCRS, IGeographicCRS targetCRS, DatumShiftParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override GeographicCoordinate Transform (GeographicCoordinate sourceCoord)
        {
            var sourcePointRad = new GeographicCoordinate (MathUtil.DegToRad (sourceCoord.Lon),
                                                           MathUtil.DegToRad (sourceCoord.Lat), sourceCoord.EllipsoidalH);

            var targetEllipsoid = ((IGeographicCRS) TargetCRS).Datum.Ellipsoid;
            var sourceEllipsoid = ((IGeographicCRS) SourceCRS).Datum.Ellipsoid;

            var deltaA = Parameters.Da != 0.0
                             ? Parameters.Da
                             : targetEllipsoid.SemiMajorAxis - sourceEllipsoid.SemiMajorAxis;
            var vs = sourceEllipsoid.SemiMajorAxis / (Math.Pow (1.0 - sourceEllipsoid.EccentricitySquared * Math.Pow (Math.Sin (sourcePointRad.Lat), 2.0), 0.5));
            var deltaF = Parameters.Df != 0.0 ? Parameters.Df : targetEllipsoid.Flattening - sourceEllipsoid.Flattening;

            var p1 = sourceEllipsoid.SemiMajorAxis * (1 - sourceEllipsoid.EccentricitySquared);
            var p2 = Math.Pow (1.0 - sourceEllipsoid.EccentricitySquared * Math.Pow (Math.Sin (sourcePointRad.Lat), 2), 3.0 / 2.0);
            var ps = p1 / p2;

            var deltaLon1 = -Parameters.Dx * Math.Sin (sourcePointRad.Lon) +
                            Parameters.Dy * Math.Cos (sourcePointRad.Lon);
            var deltaLon2 = (vs + sourcePointRad.EllipsoidalH) * Math.Cos (sourcePointRad.Lat) * MathUtil.Sin1Second;
            var deltaLon = deltaLon1 / deltaLon2;

            var deltaLat1 = -Parameters.Dx * Math.Sin (sourcePointRad.Lat) * Math.Cos (sourcePointRad.Lon) -
                            Parameters.Dy * Math.Sin (sourcePointRad.Lat) * Math.Sin (sourcePointRad.Lon);
            var deltaLat2 = Parameters.Dz * Math.Cos (sourcePointRad.Lat);

            var deltaLat3 = (deltaA * vs * sourceEllipsoid.EccentricitySquared * Math.Sin (sourcePointRad.Lat) *
                             Math.Cos (sourcePointRad.Lat)) / sourceEllipsoid.SemiMajorAxis;
            var deltaLat4 = deltaF *
                            (ps * (sourceEllipsoid.SemiMajorAxis / sourceEllipsoid.SemiMinorAxis) +
                             vs * (sourceEllipsoid.SemiMinorAxis / sourceEllipsoid.SemiMajorAxis)) *
                            Math.Sin (sourcePointRad.Lat) * Math.Cos (sourcePointRad.Lat);
            var deltaLat = (deltaLat1 + deltaLat2 + deltaLat3 + deltaLat4) /
                           ((ps + sourceCoord.EllipsoidalH) * MathUtil.Sin1Second);


            var deltaH = Parameters.Dx * Math.Cos (sourcePointRad.Lat) * Math.Cos (sourcePointRad.Lon) +
                         Parameters.Dy * Math.Cos (sourcePointRad.Lat) * Math.Sin (sourcePointRad.Lon) +
                         Parameters.Dz * Math.Sin (sourcePointRad.Lat) -
                         deltaA * (sourceEllipsoid.SemiMajorAxis / vs) +
                         deltaF * (sourceEllipsoid.SemiMinorAxis / sourceEllipsoid.SemiMajorAxis) * vs *
                         (Math.Pow (Math.Sin (sourcePointRad.Lat), 2.0));

            var result = new GeographicCoordinate
                             {
                                 Lat = sourceCoord.Lat + deltaLat / 3600.0,
                                 Lon = sourceCoord.Lon + deltaLon / 3600.0,
                                 EllipsoidalH = sourcePointRad.EllipsoidalH + deltaH
                             };

            return result;
        }
    }
}