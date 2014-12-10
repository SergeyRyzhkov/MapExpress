using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class PolarStereographic : Projection
    {
        private int con;
        private double cons;
        private double cosX0;
        private double coslat0;
        private double e;
        private double k0;
        private double lat0;
        private double latTs;
        private double ms1;
        private double sinX0;
        private double sinlat0;
        private double x0;

        public PolarStereographic (ProjectionParameters parameters) : base (parameters)
        {
        }

        public PolarStereographic (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
            lat0 = MathUtil.DegToRad (Parameters.LatitudeOfOrigin == 0 ? 90 : Parameters.LatitudeOfOrigin);
            lat0 = Parameters.LatitudeOfOrigin == 0 ? lat0 * Math.Sign (Parameters.StandardParallel1) : lat0;
            latTs = MathUtil.DegToRad (Parameters.StandardParallel1);
            k0 = Parameters.ScaleFactor == 0.0 ? 1 : Parameters.ScaleFactor;
            coslat0 = Math.Cos (lat0);
            sinlat0 = Math.Sin (lat0);
            e = Parameters.Ellipsoid.Eccentricity;

            if (IsSpherical)
            {
                if (k0 == 1 && !double.IsNaN (latTs) && Math.Abs (coslat0) <= EPSLN)
                {
                    k0 = 0.5 * (1 + Math.Sign (lat0) * Math.Sin (latTs));
                }
            }
            else
            {
                if (Math.Abs (coslat0) <= EPSLN)
                {
                    con = lat0 > 0 ? 1 : -1;
                }
                cons = Math.Sqrt (Math.Pow (1 + e, 1 + e) * Math.Pow (1 - e, 1 - e));
                if (k0 == 1 && !double.IsNaN (latTs) && Math.Abs (coslat0) <= EPSLN)
                {
                    k0 = 0.5 * cons * Msfnz (e, Math.Sin (latTs), Math.Cos (latTs)) / Tsfnz (e, con * latTs, con * Math.Sin (latTs));
                }
                ms1 = Msfnz (e, sinlat0, coslat0);
                x0 = 2 * Math.Atan (Ssfn (lat0, sinlat0, e)) - MathUtil.PiHalf;
                cosX0 = Math.Cos (x0);
                sinX0 = Math.Sin (x0);
            }
        }

        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            double px = MathUtil.DegToRad (geographCoordinate.X);
            double py = MathUtil.DegToRad (geographCoordinate.Y);
            double long0 = MathUtil.DegToRad (Parameters.CentralMeridian);

            var lon = px;
            var lat = py;
            var sinlat = Math.Sin (lat);
            var coslat = Math.Cos (lat);
            double a;
            var dlon = AdjustLon (lon - long0);

            if (Math.Abs (Math.Abs (lon - long0) - Math.PI) <= EPSLN && Math.Abs (lat + lat0) <= EPSLN)
            {
                return GeographicCoordinate.Empty;
            }
            if (IsSpherical)
            {
                a = 2 * k0 / (1 + sinlat0 * sinlat + coslat0 * coslat * Math.Cos (dlon));
                px = Parameters.SemiMajor * a * coslat * Math.Sin (dlon) + Parameters.FalseEasting;
                py = Parameters.SemiMajor * a * (coslat0 * sinlat - sinlat0 * coslat * Math.Cos (dlon)) + Parameters.FalseNorthing;
                return new Coordinate (px, py);
            }
            double x = 2 * Math.Atan (Ssfn (lat, sinlat, e)) - MathUtil.PiHalf;
            double cosX = Math.Cos (x);
            double sinX = Math.Sin (x);
            if (Math.Abs (coslat0) <= EPSLN)
            {
                double ts = Tsfnz (e, lat * con, con * sinlat);
                double rh = 2 * Parameters.SemiMajor * k0 * ts / cons;
                px = Parameters.FalseEasting + rh * Math.Sin (lon - long0);
                py = Parameters.FalseNorthing - con * rh * Math.Cos (lon - long0);
                return new Coordinate (px, py);
            }
            if (Math.Abs (sinlat0) < EPSLN)
            {
                a = 2 * Parameters.SemiMajor * k0 / (1 + cosX * Math.Cos (dlon));
                py = a * sinX;
            }
            else
            {
                a = 2 * Parameters.SemiMajor * k0 * ms1 / (cosX0 * (1 + sinX0 * sinX + cosX0 * cosX * Math.Cos (dlon)));
                py = a * (cosX0 * sinX - sinX0 * cosX * Math.Cos (dlon)) + Parameters.FalseNorthing;
            }
            px = a * cosX * Math.Sin (dlon) + Parameters.FalseEasting;
            return new Coordinate (px, py);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double px = projectedCordinate.X - Parameters.FalseEasting;
            double py = projectedCordinate.Y - Parameters.FalseNorthing;
            double lon, lat, ts, ce, Chi;
            double long0 = MathUtil.DegToRad (Parameters.CentralMeridian);
            var rh = Math.Sqrt (px * px + py * py);
            if (IsSpherical)
            {
                var c = 2 * Math.Atan (rh / (0.5 * Parameters.SemiMajor * k0));
                lon = long0;
                lat = lat0;
                if (rh <= EPSLN)
                {
                    px = lon;
                    py = lat;
                    return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
                }
                lat = Math.Asin (Math.Cos (c) * sinlat0 + py * Math.Sin (c) * coslat0 / rh);
                if (Math.Abs (coslat0) < EPSLN)
                {
                    if (lat0 > 0)
                    {
                        lon = AdjustLon (long0 + Math.Atan2 (px, -1 * py));
                    }
                    else
                    {
                        lon = AdjustLon (long0 + Math.Atan2 (px, py));
                    }
                }
                else
                {
                    lon = AdjustLon (long0 + Math.Atan2 (px * Math.Sin (c), rh * coslat0 * Math.Cos (c) - py * sinlat0 * Math.Sin (c)));
                }
                px = lon;
                py = lat;
                return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
            }
            else
            {
                if (Math.Abs (coslat0) <= EPSLN)
                {
                    if (rh <= EPSLN)
                    {
                        lat = lat0;
                        lon = long0;
                        px = lon;
                        py = lat;
                        return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
                    }
                    px *= con;
                    py *= con;
                    ts = rh * cons / (2 * Parameters.SemiMajor * k0);
                    lat = con * Phi2Z (e, ts);
                    lon = con * AdjustLon (con * long0 + Math.Atan2 (px, -1 * py));
                }
                else
                {
                    ce = 2 * Math.Atan (rh * cosX0 / (2 * Parameters.SemiMajor * k0 * ms1));
                    lon = long0;
                    if (rh <= EPSLN)
                    {
                        Chi = x0;
                    }
                    else
                    {
                        Chi = Math.Asin (Math.Cos (ce) * sinX0 + py * Math.Sin (ce) * cosX0 / rh);
                        lon = AdjustLon (long0 + Math.Atan2 (px * Math.Sin (ce), rh * cosX0 * Math.Cos (ce) - py * sinX0 * Math.Sin (ce)));
                    }
                    lat = -1 * Phi2Z (e, Math.Tan (0.5 * (MathUtil.PiHalf + Chi)));
                }
            }
            px = lon;
            py = lat;

            return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
        }

        private static double Ssfn (double phit, double sinphi, double eccen)
        {
            sinphi *= eccen;
            return (Math.Tan (0.5 * (MathUtil.PiHalf + phit)) * Math.Pow ((1 - sinphi) / (1 + sinphi), 0.5 * eccen));
        }
    }
}