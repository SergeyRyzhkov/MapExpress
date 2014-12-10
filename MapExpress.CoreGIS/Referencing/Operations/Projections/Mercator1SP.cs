#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    // TODO: Вынести константы в Initi
    // TODO: В PROJ4 есть +lat_ts 
    // TODO: !!!!!!! A more common formulation for Mercator is to drop the +k_0, and instead to provide a latitude of true scale using the +lat_ts parameter, which is the latitude at which the scale is 1.
    //  if (this.lat_ts) {
    //  if (this.sphere) {
    //    this.k0 = Math.cos(this.lat_ts);
    //  }
    //  else {
    //    this.k0 = msfnz(this.e, Math.sin(this.lat_ts), Math.cos(this.lat_ts));
    //  }
    //}

    public class Mercator1SP : Projection
    {
        public Mercator1SP (ProjectionParameters parameters) : base (parameters)
        {
        }

        public Mercator1SP (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }

        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var radPoint = geographCoordinate.ToRadian ();
            var scaleFactor = CorrectScaleFactor ();
            var a = Parameters.Ellipsoid.Eccentricity;

            var n1 = Math.Tan (Math.PI / 4.0 + radPoint.Lat / 2.0);
            var n2 = (1.0 - a * Math.Sin (radPoint.Lat)) / (1.0 + a * Math.Sin (radPoint.Lat));
            var n3 = Parameters.Ellipsoid.SemiMajorAxis * scaleFactor * Math.Log (n1 * Math.Pow (n2, a / 2.0));

            var x = Parameters.FalseEasting + Parameters.Ellipsoid.SemiMajorAxis * scaleFactor * (radPoint.Lon - MathUtil.DegToRad (Parameters.CentralMeridian));
            var y = Parameters.FalseNorthing + n3;

            return new Coordinate (x, y);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var scaleFactor = CorrectScaleFactor ();
            var a = Parameters.Ellipsoid.Eccentricity;

            var t = Math.Pow (Math.E, (Parameters.FalseNorthing - projectedCordinate.Y) / (Parameters.Ellipsoid.SemiMajorAxis * scaleFactor));
            var xx = Math.PI / 2.0 - 2.0 * Math.Atan (t);
            var e2 = Parameters.Ellipsoid.EccentricitySquared;
            var e4 = Math.Pow (a, 4.0);
            var e6 = Math.Pow (a, 6.0);
            var e8 = Math.Pow (a, 8.0);

            var latRad = xx + (e2 / 2.0 + 5.0 * e4 / 24.0 + e6 / 12.0 + 13.0 * e8 / 36.00) * Math.Sin (2 * xx) +
                         (7 * e4 / 48.0 + 29.0 * e6 / 240.0 + 811.0 * e8 / 11520.0) * Math.Sin (4.0 * xx) +
                         (7 * e6 / 120.0 + 81.0 * e8 / 1120.0) * Math.Sin (6.0 * xx) +
                         (4279.0 * e8 / 161280.0) * Math.Sin (8.0 * xx);

            var lonRad = ((projectedCordinate.X - Parameters.FalseEasting) / (Parameters.Ellipsoid.SemiMajorAxis * scaleFactor)) + MathUtil.DegToRad (Parameters.CentralMeridian);

            return new GeographicCoordinate (lonRad, latRad, 0.0).ToDegree ();
        }

        protected virtual double CorrectScaleFactor ()
        {
            return Parameters.ScaleFactor;
        }
    }
}