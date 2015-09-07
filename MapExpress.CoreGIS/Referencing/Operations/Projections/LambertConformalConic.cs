#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class LambertConformalConic : Projection
    {
        private double centerLon;
        private double e;
        private double f0;
        private double k0;
        private double lat0;
        private double lat1;
        private double lat2;

        private double ns;
        private double rh;

        // TODO: Надо посмотреть на Parameters.LatitudeOfOrigin как в PolarStereographic
        public LambertConformalConic (ProjectionParameters parameters) : base (parameters)
        {
        }

        public LambertConformalConic (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        // TODO: http://gis-lab.info/qa/local-cs.html
        // А если одна ст.парралель и задан К то можно же вычислить вторую? ДАААА, надо во всех проверить!!!!
        public override void InitializeConstants ()
        {
            lat0 = MathUtil.DegToRad (Parameters.LatitudeOfOrigin);
            lat1 = MathUtil.DegToRad (Parameters.StandardParallel1);
            lat2 = MathUtil.DegToRad (Parameters.StandardParallel2);
            centerLon = MathUtil.DegToRad (Parameters.CentralMeridian);
            k0 = Parameters.ScaleFactor != 0 ? Parameters.ScaleFactor : 1;
            if (lat1 == 0)
                lat1 = lat2 = lat0;

            if (Math.Abs (lat1 + lat2) < EPSLN)
            {
                throw new CoordinateOperationException ("Equal latitudes for St. Parallels on opposite sides of equator.");
            }
            e = Parameters.Ellipsoid.Eccentricity;
            var sinPo = Math.Sin (lat1);
            var cosPo = Math.Cos (lat1);
            var con = sinPo;
            var ms1 = Msfnz (e, sinPo, cosPo);
            var ts1 = Tsfnz (e, lat1, sinPo);
            sinPo = Math.Sin (lat2);
            cosPo = Math.Cos (lat2);
            var ms2 = Msfnz (e, sinPo, cosPo);
            var ts2 = Tsfnz (e, lat2, sinPo);
            sinPo = Math.Sin (lat0);
            var ts0 = Tsfnz (e, lat0, sinPo);
            ns = Math.Abs (lat1 - lat2) > EPSLN ? Math.Log (ms1 / ms2) / Math.Log (ts1 / ts2) : con;
            f0 = ms1 / (ns * Math.Pow (ts1, ns));
            rh = Parameters.SemiMajor * f0 * Math.Pow (ts0, ns);
        }


        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            double dLongitude = MathUtil.DegToRad (geographCoordinate.Lon);
            double dLatitude = MathUtil.DegToRad (geographCoordinate.Lat);
            double rh1;
            var con = Math.Abs (Math.Abs (dLatitude) - MathUtil.PiHalf);
            if (con > EPSLN)
            {
                var sinphi = Math.Sin (dLatitude);
                var ts = Tsfnz (e, dLatitude, sinphi);
                rh1 = Parameters.SemiMajor * f0 * Math.Pow (ts, ns);
            }
            else
            {
                con = dLatitude * ns;
                if (con <= 0)
                    throw new ArgumentException ();
                rh1 = 0;
            }

            // TODO: Надо уточнить в этой проекции насчет k0
            var theta = ns * AdjustLon (dLongitude - centerLon);
            // dLongitude = k0 * rh1 * Math.Sin (theta) + Parameters.FalseEasting;
            //dLatitude = k0 * rh - rh1 * Math.Cos (theta) + Parameters.FalseNorthing;
            dLongitude = rh1 * Math.Sin (theta) + Parameters.FalseEasting;
            dLatitude = rh - rh1 * Math.Cos (theta) + Parameters.FalseNorthing;

            return new Coordinate (dLongitude, dLatitude);
        }


        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double dLatitude;
            double rh1;
            double con;

            var dX = projectedCordinate.X - Parameters.FalseEasting;
            var dY = rh - projectedCordinate.Y + Parameters.FalseNorthing;
            if (ns > 0)
            {
                rh1 = Math.Sqrt (dX * dX + dY * dY);
                con = 1.0;
            }
            else
            {
                rh1 = -Math.Sqrt (dX * dX + dY * dY);
                con = -1.0;
            }
            var theta = 0.0;
            if (rh1 != 0)
                theta = Math.Atan2 ((con * dX), (con * dY));
            if ((rh1 != 0) || (ns > 0.0))
            {
                con = 1.0 / ns;
                var ts = Math.Pow ((rh1 / (Parameters.SemiMajor * f0)), con);
                dLatitude = Phi2Z (e, ts);
            }
            else
                dLatitude = -MathUtil.PiHalf;

            var dLongitude = AdjustLon (theta / ns + centerLon);

            return new GeographicCoordinate (MathUtil.Rad2Deg (dLongitude), MathUtil.Rad2Deg (dLatitude));
        }
    }
}