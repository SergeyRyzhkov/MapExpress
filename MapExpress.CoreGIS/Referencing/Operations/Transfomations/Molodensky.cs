#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    // TODO: Оптимизировать. Вынести повт.вычисления в инициализацию, особенно взятие параметров
    public class Molodensky : GeographicTransformation
    {
        public Molodensky (GeographicTrasformParameters parameters) : base (parameters)
        {
        }

        public Molodensky (IGeographicCRS sourceCRS, IGeographicCRS targetCRS, DatumShiftParameters datumShiftParameters) : base (sourceCRS, targetCRS, datumShiftParameters)
        {
        }

        public Molodensky (IGeographicCRS sourceCRS, IGeographicCRS targetCRS, GeographicTrasformParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }

        public override GeographicCoordinate Transform (GeographicCoordinate sourceCoord)
        {
            var sourcePointRad = new GeographicCoordinate (MathUtil.DegToRad (sourceCoord.Lon), MathUtil.DegToRad (sourceCoord.Lat), sourceCoord.EllipsoidalH);
            var sourceEllipsoid = Parameters.SourceEllipsoid;
            var deltaA = Parameters.TargetEllipsoid.SemiMajorAxis - Parameters.SourceEllipsoid.SemiMajorAxis;
            var vs = sourceEllipsoid.SemiMajorAxis / (Math.Pow (1.0 - sourceEllipsoid.EccentricitySquared * Math.Pow (Math.Sin (sourcePointRad.Lat), 2.0), 0.5));
            var deltaF = Parameters.TargetEllipsoid.Flattening - Parameters.SourceEllipsoid.Flattening;
            var p1 = sourceEllipsoid.SemiMajorAxis * (1 - sourceEllipsoid.EccentricitySquared);
            var p2 = Math.Pow (1.0 - sourceEllipsoid.EccentricitySquared * Math.Pow (Math.Sin (sourcePointRad.Lat), 2), 3.0 / 2.0);
            var ps = p1 / p2;
            var deltaLon1 = -Parameters.DatumShiftParameters.Dx * Math.Sin (sourcePointRad.Lon) + Parameters.DatumShiftParameters.Dy * Math.Cos (sourcePointRad.Lon);
            var deltaLon2 = (vs + sourcePointRad.EllipsoidalH) * Math.Cos (sourcePointRad.Lat) * MathUtil.Sin1Second;
            var deltaLon = deltaLon1 / deltaLon2;
            var deltaLat1 = -Parameters.DatumShiftParameters.Dx * Math.Sin (sourcePointRad.Lat) * Math.Cos (sourcePointRad.Lon) - Parameters.DatumShiftParameters.Dy * Math.Sin (sourcePointRad.Lat) * Math.Sin (sourcePointRad.Lon);
            var deltaLat2 = Parameters.DatumShiftParameters.Dz * Math.Cos (sourcePointRad.Lat);
            var deltaLat3 = (deltaA * vs * sourceEllipsoid.EccentricitySquared * Math.Sin (sourcePointRad.Lat) * Math.Cos (sourcePointRad.Lat)) / sourceEllipsoid.SemiMajorAxis;
            var deltaLat4 = deltaF * (ps * (sourceEllipsoid.SemiMajorAxis / sourceEllipsoid.SemiMinorAxis) + vs * (sourceEllipsoid.SemiMinorAxis / sourceEllipsoid.SemiMajorAxis)) * Math.Sin (sourcePointRad.Lat) * Math.Cos (sourcePointRad.Lat);
            var deltaLat = (deltaLat1 + deltaLat2 + deltaLat3 + deltaLat4) / ((ps + sourceCoord.EllipsoidalH) * MathUtil.Sin1Second);
            var deltaH = Parameters.DatumShiftParameters.Dx * Math.Cos (sourcePointRad.Lat) * Math.Cos (sourcePointRad.Lon) +
                         Parameters.DatumShiftParameters.Dy * Math.Cos (sourcePointRad.Lat) * Math.Sin (sourcePointRad.Lon) +
                         Parameters.DatumShiftParameters.Dz * Math.Sin (sourcePointRad.Lat) -
                         deltaA * (sourceEllipsoid.SemiMajorAxis / vs) +
                         deltaF * (sourceEllipsoid.SemiMinorAxis / sourceEllipsoid.SemiMajorAxis) * vs *
                         (Math.Pow (Math.Sin (sourcePointRad.Lat), 2.0));
            return new GeographicCoordinate
                       {
                           Lat = sourceCoord.Lat + deltaLat / 3600.0,
                           Lon = sourceCoord.Lon + deltaLon / 3600.0,
                           EllipsoidalH = sourcePointRad.EllipsoidalH + deltaH
                       };
        }

        // TODO:Implement! Причем параметры один раз клонировать, чтобы не было на каждую коорд. создание объекта 
        public override GeographicCoordinate TransformInverse (GeographicCoordinate sourceCoord)
        {
            //var reverseParameters = Parameters.Clone ();
            //return Transform (sourceCoord);
            throw new NotImplementedException();
        }
    }
}