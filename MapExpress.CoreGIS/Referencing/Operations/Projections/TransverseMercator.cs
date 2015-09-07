#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    // TODO: Учесть If the zone is not specified and the latitude is negative, a false northing of 10,000,000 meters is used.
    public class TransverseMercator : Projection
    {
        private Constants constants;
        private double h1;
        private double h2;
        private double h3;
        private double h4;
        private double k0;
        private double m0;

        // TODO:UTM сделать отдельной проекцие. В параметр зону. Потом убрать сдесь алиас.  
        public TransverseMercator ()
        {
            Name = "Transverse Mercator";
        }


        public TransverseMercator (ProjectionParameters parameters) : base (parameters)
        {
            Name = "Transverse Mercator";
        }

        public TransverseMercator (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }

        public override void InitAuthorityAliases ()
        {
            AuthorityAliases.Add (AuthorityType.EPSG, "Transverse Mercator");
            AuthorityAliases.Add (AuthorityType.EPSG, "Gauss-Kruger");
            AuthorityAliases.Add (AuthorityType.EPSG, "Gauss-Boaga");
            AuthorityAliases.Add (AuthorityType.EPSG, "TM");
            AuthorityAliases.Add (AuthorityType.OGC, "Transverse_Mercator");
            AuthorityAliases.Add (AuthorityType.ESRI, "Transverse_Mercator");
            AuthorityAliases.Add (AuthorityType.ESRI, "Gauss_Kruger");
            AuthorityAliases.Add (AuthorityType.PROJ4, "tmerc");
            AuthorityAliases.Add (AuthorityType.PROJ4, "utm");
        }

        public override void InitializeConstants ()
        {
            k0 = Parameters.ScaleFactor == 0 ? 0.9996 : Parameters.ScaleFactor;
            constants = new Constants (Parameters.Ellipsoid.Flattening, Parameters.Ellipsoid.SemiMajorAxis);
            h1 = constants.N / 2.0 - (2.0 / 3.0) * constants.N2 + (5.0 / 16.0) * constants.N3 + (41.0 / 180.0) * constants.N4;
            h2 = (13.0 / 48.0) * constants.N2 - (3.0 / 5.0) * constants.N3 + (557.0 / 1440.0) * constants.N4;
            h3 = (61.0 / 240.0) * constants.N3 - (103.0 / 140.0) * constants.N4;
            h4 = (49561.0 / 161280.0) * constants.N4;
            m0 = MeridionalArcDistance (Parameters.Ellipsoid.Eccentricity, constants.N, constants.N2, constants.N3, constants.N4, constants.B);
        }

        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var sourcePointRad = geographCoordinate.ToRadian ();
            var ξη = CalcξAndη (Parameters.Ellipsoid.Eccentricity, MathUtil.DegToRad (Parameters.CentralMeridian), sourcePointRad.Lon, sourcePointRad.Lat, h1, h2, h3, h4);
            var x = Parameters.FalseEasting + k0 * constants.B * ξη [1];
            var y = Parameters.FalseNorthing + k0 * (constants.B * ξη [0] - m0);

            return new Coordinate (x, y);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var η = (projectedCordinate.X - Parameters.FalseEasting) / (constants.B * k0);
            var ξ = ((projectedCordinate.Y - Parameters.FalseNorthing) + k0 * m0) / (constants.B * k0);
            var ξη = CalcReverceξAndη (ξ, η, h1, h2, h3, h4);
            var β = Math.Asin (Math.Sin (ξη [0]) / Math.Cosh (ξη [1]));
            var q = MathUtil.HArcsin (Math.Tan (β));
            var q2 = q + (Parameters.Ellipsoid.Eccentricity * MathUtil.HArctan (Parameters.Ellipsoid.Eccentricity * Math.Tanh (q)));

            for (var i = 0; i < 15; i++)
            {
                var q2Befor = q2;
                q2 = q + (Parameters.Ellipsoid.Eccentricity * MathUtil.HArctan (Parameters.Ellipsoid.Eccentricity * Math.Tanh (q2)));
                var deltaQ2 = q2 - q2Befor;
                if (deltaQ2.Equals (0.0))
                {
                    break;
                }
            }

            var lat = Math.Atan (Math.Sinh (q2));
            var lon = MathUtil.DegToRad (Parameters.CentralMeridian) + Math.Asin (Math.Tanh (ξη [1]) / Math.Cos (β));
            return new GeographicCoordinate (lon, lat).ToDegree ();
        }


        private double MeridionalArcDistance (double e, double n, double n2, double n3, double n4, double b)
        {
            var originLatitudeRad = MathUtil.DegToRad (Parameters.LatitudeOfOrigin);

            if (originLatitudeRad.Equals (0.0))
            {
                return 0;
            }

            if (originLatitudeRad.Equals (Math.PI / 2))
            {
                return b * Math.PI / 2;
            }

            if (originLatitudeRad.Equals (- Math.PI / 2))
            {
                return b * (- Math.PI / 2);
            }

            var q0 = MathUtil.HArcsin (Math.Tan (originLatitudeRad)) - (e * MathUtil.HArctan (e * Math.Sin (originLatitudeRad)));
            var β = Math.Atan (Math.Sinh (q0));
            var h1 = n / 2.0 - (2.0 / 3.0) * n2 + (5.0 / 16.0) * n3 + (41.0 / 180.0) * n4;
            var h2 = (13.0 / 48.0) * n2 - (3.0 / 5.0) * n3 + (557.0 / 1440.0) * n4;
            var h3 = (61.0 / 240.0) * n3 - (103.0 / 140.0) * n4;
            var h4 = (49561.0 / 161280.0) * n4;

            var ξ00 = Math.Asin (Math.Sin (β));

            var ξ01 = h1 * Math.Sin (2.0 * ξ00);
            var ξ02 = h2 * Math.Sin (4.0 * ξ00);
            var ξ03 = h3 * Math.Sin (6.0 * ξ00);
            var ξ04 = h4 * Math.Sin (8.0 * ξ00);

            return b * (ξ00 + ξ01 + ξ02 + ξ03 + ξ04);
        }

        private double[] CalcξAndη (double e, double lon0, double lonRad, double latRad, double h1, double h2, double h3, double h4)
        {
            var q = MathUtil.HArcsin (Math.Tan (latRad)) - (e * MathUtil.HArctan (e * Math.Sin (latRad)));
            var β = Math.Atan (Math.Sinh (q));
            var η0 = MathUtil.HArctan (Math.Cos (β) * Math.Sin (lonRad - lon0));
            var ξ0 = Math.Asin (Math.Sin (β) * Math.Cosh (η0));

            var ξ1 = h1 * Math.Sin (2.0 * ξ0) * Math.Cosh (2.0 * η0);
            var ξ2 = h2 * Math.Sin (4.0 * ξ0) * Math.Cosh (4.0 * η0);
            var ξ3 = h3 * Math.Sin (6.0 * ξ0) * Math.Cosh (6.0 * η0);
            var ξ4 = h4 * Math.Sin (8.0 * ξ0) * Math.Cosh (8.0 * η0);
            var ξ = ξ0 + ξ1 + ξ2 + ξ3 + ξ4;

            var η1 = h1 * Math.Cos (2.0 * ξ0) * Math.Sinh (2.0 * η0);
            var η2 = h2 * Math.Cos (4.0 * ξ0) * Math.Sinh (4.0 * η0);
            var η3 = h3 * Math.Cos (6.0 * ξ0) * Math.Sinh (6.0 * η0);
            var η4 = h4 * Math.Cos (8.0 * ξ0) * Math.Sinh (8.0 * η0);
            var η = η0 + η1 + η2 + η3 + η4;

            return new[] {ξ, η};
        }

        private double[] CalcReverceξAndη (double ξ, double η, double h1, double h2, double h3, double h4)
        {
            var ξ1 = h1 * Math.Sin (2.0 * ξ) * Math.Cosh (2.0 * η);
            var ξ2 = h2 * Math.Sin (4.0 * ξ) * Math.Cosh (4.0 * η);
            var ξ3 = h3 * Math.Sin (6.0 * ξ) * Math.Cosh (6.0 * η);
            var ξ4 = h4 * Math.Sin (8.0 * ξ) * Math.Cosh (8.0 * η);
            var ξres = ξ - (ξ1 + ξ2 + ξ3 + ξ4);

            var η1 = h1 * Math.Cos (2.0 * ξ) * Math.Sinh (2.0 * η);
            var η2 = h2 * Math.Cos (4.0 * ξ) * Math.Sinh (4.0 * η);
            var η3 = h3 * Math.Cos (6.0 * ξ) * Math.Sinh (6.0 * η);
            var η4 = h4 * Math.Cos (8.0 * ξ) * Math.Sinh (8.0 * η);
            var ηres = η - (η1 + η2 + η3 + η4);

            return new[] {ξres, ηres};
        }

        #region Nested type: Constants

        private struct Constants
        {
            public Constants (double f, double a) : this ()
            {
                N = f / (2 - f);
                N2 = Math.Pow (N, 2);
                N3 = Math.Pow (N, 3);
                N4 = Math.Pow (N, 4);
                B = (a / (1.0 + N)) * (1.0 + N2 / 4.0 + N4 / 64.0);
            }

            public double N { get; private set; }

            public double N2 { get; private set; }

            public double N3 { get; private set; }

            public double N4 { get; private set; }

            public double B { get; private set; }
        }

        #endregion
    }
}