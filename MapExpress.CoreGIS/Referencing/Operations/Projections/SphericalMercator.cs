#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    // TODO: Вынести в Mercator1sp там делать через иф сферикал
    public class SphericalMercator : Projection
    {
        //public SphericalMercator ()
        //{
        //}

        public SphericalMercator (ProjectionParameters parameters) : base (parameters)
        {
        }

        public SphericalMercator (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);
            var sphereRadius = Parameters.SemiMajor;

            var x = Parameters.FalseEasting + sphereRadius * (lonRad - MathUtil.DegToRad (Parameters.CentralMeridian));
            var y = Parameters.FalseNorthing + sphereRadius * Math.Log (Math.Tan (Math.PI / 4 + latRad / 2.0));

            return new Coordinate (x, y);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var sphereRadius = Parameters.SemiMajor;
            var d = (Parameters.FalseNorthing - projectedCordinate.Y) / sphereRadius;
            var latRad = Math.PI / 2.0 - 2.0 * Math.Atan (Math.Pow (Math.E, d));
            var lonRad = (projectedCordinate.X - Parameters.FalseEasting) / sphereRadius + MathUtil.DegToRad (Parameters.CentralMeridian);
            return new GeographicCoordinate (lonRad, latRad).ToDegree ();
        }
    }
}