#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    // TODO: Что-то отличий нет от Molodensky
    public class AbridgedMolodensky : GeographicTransform
    {
        public AbridgedMolodensky (IGeographicCRS sourceCRS, IGeographicCRS targetCRS, DatumShiftParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        //public override string AuthorityName
        //{
        //    get { return "EPSG"; }
        //}

        //public override int AuthorityCode
        //{
        //    get { return 9605; }
        //}


        public override GeographicCoordinate Transform (GeographicCoordinate sourceCoord)
        {
            var sourcePoint = new GeographicCoordinate (MathUtil.DegToRad (sourceCoord.Lon),
                                                        MathUtil.DegToRad (sourceCoord.Lat), sourceCoord.EllipsoidalH);
            var sourceEllipsoid = (((IGeographicCRS) SourceCRS).Datum).Ellipsoid;
            var targetEllipsoid = (((IGeographicCRS) TargetCRS).Datum).Ellipsoid;

            var deltaA = Parameters.Da != 0.0
                             ? Parameters.Da
                             : targetEllipsoid.SemiMajorAxis - sourceEllipsoid.SemiMajorAxis;
            var vs = sourceEllipsoid.SemiMajorAxis /
                     (Math.Pow (
                         1.0 -
                         sourceEllipsoid.EccentricitySquared * Math.Pow (Math.Sin (sourcePoint.Lat), 2.0),
                         0.5));
            var deltaF = Parameters.Df != 0.0 ? Parameters.Df : targetEllipsoid.Flattening - sourceEllipsoid.Flattening;

            var p1 = sourceEllipsoid.SemiMajorAxis *
                     (1.0 - sourceEllipsoid.EccentricitySquared);
            var p2 =
                Math.Pow (
                    1 - sourceEllipsoid.EccentricitySquared * Math.Pow (Math.Sin (sourcePoint.Lat), 2),
                    3.0 / 2.0);
            var ps = p1 / p2;
            var deltaLon1 = -Parameters.Dx * Math.Sin (sourcePoint.Lon) + Parameters.Dy * Math.Cos (sourcePoint.Lon);
            var deltaLon2 = (vs + sourcePoint.EllipsoidalH) * Math.Cos (sourcePoint.Lat) * MathUtil.Sin1Second;
            var deltaLon = deltaLon1 / deltaLon2;

            var deltaLat1 = -Parameters.Dx * Math.Sin (sourcePoint.Lat) * Math.Cos (sourcePoint.Lon) -
                            Parameters.Dy * Math.Sin (sourcePoint.Lat) * Math.Sin (sourcePoint.Lon);
            var deltaLat2 = Parameters.Dz * Math.Cos (sourcePoint.Lat);
            var deltaLat4 = Math.Sin (2 * sourcePoint.Lat) *
                            (sourceEllipsoid.SemiMajorAxis * deltaF +
                             sourceEllipsoid.Flattening * deltaA);
            var deltaLat = (deltaLat1 + deltaLat2 + deltaLat4) / (ps * MathUtil.Sin1Second);

            var deltaH = Parameters.Dx * Math.Cos (sourcePoint.Lat) * Math.Cos (sourcePoint.Lon) +
                         Parameters.Dy * Math.Cos (sourcePoint.Lat) * Math.Sin (sourcePoint.Lon) +
                         Parameters.Dz * Math.Sin (sourcePoint.Lat) +
                         Math.Pow (Math.Sin (sourcePoint.Lat), 2) *
                         (sourceEllipsoid.SemiMajorAxis * deltaF +
                          sourceEllipsoid.Flattening * deltaA) -
                         deltaA;

            var result = new GeographicCoordinate
                             {
                                 Lat = sourceCoord.Lat + deltaLat / 3600.0,
                                 Lon = sourceCoord.Lon + deltaLon / 3600.0,
                                 EllipsoidalH = sourcePoint.EllipsoidalH + deltaH
                             };

            return result;
        }
    }
}