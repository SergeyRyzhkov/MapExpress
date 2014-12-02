using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class EquidistantConic : Projection
    {
        private double e0;
        private double e1;
        private double e2;
        private double e3;
        private double g;
        private double ns;
        private double rh;

        public EquidistantConic (ProjectionParameters parameters) : base (parameters)
        {
            Name = "Equidistant Conic";
        }

        public EquidistantConic (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
            var lat1 = MathUtil.DegToRad (Parameters.StandardParallel1);
            var lat2 = MathUtil.DegToRad (Parameters.StandardParallel2);
            if (Math.Abs (lat1 + lat2) < EPSLN)
            {
                return;
            }
            lat2 = lat2 > 0 ? lat2 : lat1;
            var e = Parameters.Ellipsoid.Eccentricity;
            e0 = E0Fn (Parameters.Ellipsoid.EccentricitySquared);
            e1 = E1Fn (Parameters.Ellipsoid.EccentricitySquared);
            e2 = E2Fn (Parameters.Ellipsoid.EccentricitySquared);
            e3 = E3Fn (Parameters.Ellipsoid.EccentricitySquared);
            var sinphi = Math.Sin (lat1);
            var cosphi = Math.Cos (lat1);
            var ms1 = Msfnz (e, sinphi, cosphi);
            var ml1 = Mlfn (e0, e1, e2, e3, lat1);
            if (Math.Abs (lat1 - lat2) < EPSLN)
            {
                ns = sinphi;
            }
            else
            {
                sinphi = Math.Sin (lat2);
                cosphi = Math.Cos (lat2);
                var ms2 = Msfnz (e, sinphi, cosphi);
                var ml2 = Mlfn (e0, e1, e2, e3, lat2);
                ns = (ms1 - ms2) / (ml2 - ml1);
            }
            g = ml1 + ms1 / ns;
            var ml0 = Mlfn (e0, e1, e2, e3, MathUtil.DegToRad (Parameters.LatitudeOfOrigin));
            rh = Parameters.SemiMajor * (g - ml0);
        }


        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);
            double rh1;
            if (IsSpherical)
            {
                rh1 = Parameters.SemiMajor * (g - latRad);
            }
            else
            {
                var ml = Mlfn (e0, e1, e2, e3, latRad);
                rh1 = Parameters.SemiMajor * (g - ml);
            }
            var theta = ns * AdjustLon (lonRad - MathUtil.DegToRad (Parameters.CentralMeridian));
            var x = Parameters.FalseEasting + rh1 * Math.Sin (theta);
            var y = Parameters.FalseNorthing + rh - rh1 * Math.Cos (theta);
            return new Coordinate (x, y);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var px = projectedCordinate.X - Parameters.FalseEasting;
            var py = rh - projectedCordinate.Y + Parameters.FalseNorthing;
            double con, rh1, lat, lon;
            if (ns >= 0)
            {
                rh1 = Math.Sqrt (px * px + py * py);
                con = 1;
            }
            else
            {
                rh1 = -Math.Sqrt (px * px + py * py);
                con = -1;
            }
            var theta = 0.0;
            if (rh1 != 0)
            {
                theta = Math.Atan2 (con * px, con * py);
            }
            if (IsSpherical)
            {
                lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + theta / ns);
                lat = AdjustLat (g - rh1 / Parameters.SemiMajor);
                return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
            }
            var ml = g - rh1 / Parameters.SemiMajor;
            lat = Imlfn (ml, e0, e1, e2, e3);
            lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + theta / ns);
            return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
        }
    }
}