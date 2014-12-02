using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class AzimuthalEquidistant : Projection
    {
        private double cosp12;
        private double sinp12;

        public AzimuthalEquidistant (ProjectionParameters parameters) : base (parameters)
        {
            Name = "Azimuthal Equidistant";
        }

        public AzimuthalEquidistant (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
            sinp12 = Math.Sin (MathUtil.DegToRad (Parameters.LatitudeOfOrigin));
            cosp12 = Math.Cos (MathUtil.DegToRad (Parameters.LatitudeOfOrigin));
        }

        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            double x;
            double y;

            var e = Parameters.Ellipsoid.Eccentricity;
            var temp = Parameters.SemiMinor / Parameters.SemiMajor;
            var es = 1 - Math.Pow (temp, 2);
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);
            var sinphi = Math.Sin (latRad);
            var cosphi = Math.Cos (latRad);
            var dlon = AdjustLon (lonRad - MathUtil.DegToRad (Parameters.CentralMeridian));
            double mlp, ml, c;
            double s;

            if (IsSpherical)
            {
                if (Math.Abs (sinp12 - 1) <= EPSLN)
                {
                    x = Parameters.FalseEasting + Parameters.SemiMajor * (MathUtil.PiHalf - latRad) * Math.Sin (dlon);
                    y = Parameters.FalseNorthing - Parameters.SemiMajor * (MathUtil.PiHalf - latRad) * Math.Cos (dlon);
                    return new Coordinate (x, y);
                }
                if (Math.Abs (sinp12 + 1) <= EPSLN)
                {
                    x = Parameters.FalseEasting + Parameters.SemiMajor * (MathUtil.PiHalf + latRad) * Math.Sin (dlon);
                    y = Parameters.FalseNorthing + Parameters.SemiMajor * (MathUtil.PiHalf + latRad) * Math.Cos (dlon);
                    return new Coordinate (x, y);
                }
                var cosC = sinp12 * sinphi + cosp12 * cosphi * Math.Cos (dlon);
                c = Math.Acos (cosC);
                var kp = c / Math.Sin (c);
                x = Parameters.FalseEasting + Parameters.SemiMajor * kp * cosphi * Math.Sin (dlon);
                y = Parameters.FalseEasting + Parameters.SemiMajor * kp * (cosp12 * sinphi - sinp12 * cosphi * Math.Cos (dlon));
                return new Coordinate (x, y);
            }
            var e0 = E0Fn (es);
            var e1 = E1Fn (es);
            var e2 = E2Fn (es);
            var e3 = E3Fn (es);
            if (Math.Abs (sinp12 - 1) <= EPSLN)
            {
                mlp = Parameters.SemiMajor * Mlfn (e0, e1, e2, e3, MathUtil.PiHalf);
                ml = Parameters.SemiMajor * Mlfn (e0, e1, e2, e3, latRad);
                x = Parameters.FalseEasting + (mlp - ml) * Math.Sin (dlon);
                y = Parameters.FalseNorthing - (mlp - ml) * Math.Cos (dlon);
                return new Coordinate (x, y);
            }
            if (Math.Abs (sinp12 + 1) <= EPSLN)
            {
                mlp = Parameters.SemiMajor * Mlfn (e0, e1, e2, e3, MathUtil.PiHalf);
                ml = Parameters.SemiMajor * Mlfn (e0, e1, e2, e3, latRad);
                x = Parameters.FalseEasting + (mlp + ml) * Math.Sin (dlon);
                y = Parameters.FalseNorthing + (mlp + ml) * Math.Cos (dlon);
                return new Coordinate (x, y);
            }
            var tanphi = sinphi / cosphi;
            var nl1 = GN (Parameters.SemiMajor, e, sinp12);
            var nl = GN (Parameters.SemiMajor, e, sinphi);
            var psi = Math.Atan ((1 - es) * tanphi + es * nl1 * sinp12 / (nl * cosphi));
            var az = Math.Atan2 (Math.Sin (dlon), cosp12 * Math.Tan (psi) - sinp12 * Math.Cos (dlon));
            if (Math.Abs (az - 0) < double.Epsilon)
            {
                s = Math.Asin (cosp12 * Math.Sin (psi) - sinp12 * Math.Cos (psi));
            }
            else if (Math.Abs (Math.Abs (az) - Math.PI) <= EPSLN)
            {
                s = -Math.Asin (cosp12 * Math.Sin (psi) - sinp12 * Math.Cos (psi));
            }
            else
            {
                s = Math.Asin (Math.Sin (dlon) * Math.Cos (psi) / Math.Sin (az));
            }
            var g = e * sinp12 / Math.Sqrt (1 - es);
            var h = e * cosp12 * Math.Cos (az) / Math.Sqrt (1 - es);
            var gh = g * h;
            var hs = h * h;
            var s2 = s * s;
            var s3 = s2 * s;
            var s4 = s3 * s;
            var s5 = s4 * s;
            c = nl1 * s * (1 - s2 * hs * (1 - hs) / 6 + s3 / 8 * gh * (1 - 2 * hs) + s4 / 120 * (hs * (4 - 7 * hs) - 3 * g * g * (1 - 7 * hs)) - s5 / 48 * gh);
            x = Parameters.FalseEasting + c * Math.Sin (az);
            y = Parameters.FalseNorthing + c * Math.Cos (az);
            return new Coordinate (x, y);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var e = Parameters.Ellipsoid.Eccentricity;
            var temp = Parameters.SemiMinor / Parameters.SemiMajor;
            var es = 1 - Math.Pow (temp, 2);

            var px = projectedCordinate.X - Parameters.FalseEasting;
            var py = projectedCordinate.Y - Parameters.FalseNorthing;
            double rh;
            double lon, lat;
            double mlp, m;

            if (IsSpherical)
            {
                rh = Math.Sqrt (px * px + py * py);
                if (rh > (2 * MathUtil.PiHalf * Parameters.SemiMajor))
                {
                    return GeographicCoordinate.Empty;
                }
                var z = rh / Parameters.SemiMajor;

                var sinz = Math.Sin (z);
                var cosz = Math.Cos (z);

                lon = MathUtil.DegToRad (Parameters.CentralMeridian);
                if (Math.Abs (rh) <= EPSLN)
                {
                    lat = MathUtil.DegToRad (Parameters.LatitudeOfOrigin);
                }
                else
                {
                    lat = Asinz (cosz * sinp12 + (py * sinz * cosp12) / rh);
                    var con = Math.Abs (MathUtil.DegToRad (Parameters.LatitudeOfOrigin)) - MathUtil.PiHalf;
                    if (Math.Abs (con) <= EPSLN)
                    {
                        lon = MathUtil.DegToRad (Parameters.LatitudeOfOrigin) >= 0 ? AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + Math.Atan2 (px, -py)) : AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) - Math.Atan2 (-px, py));
                    }
                    else
                    {
                        lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + Math.Atan2 (px * sinz, rh * cosp12 * cosz - py * sinp12 * sinz));
                    }
                }
                return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
            }
            var e0 = E0Fn (es);
            var e1 = E1Fn (es);
            var e2 = E2Fn (es);
            var e3 = E3Fn (es);
            if (Math.Abs (sinp12 - 1) <= EPSLN)
            {
                mlp = Parameters.SemiMajor * Mlfn (e0, e1, e2, e3, MathUtil.PiHalf);
                rh = Math.Sqrt (px * px + py * py);
                m = mlp - rh;
                lat = Imlfn (m / Parameters.SemiMajor, e0, e1, e2, e3);
                lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + Math.Atan2 (px, -1 * py));
                return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
            }
            if (Math.Abs (sinp12 + 1) <= EPSLN)
            {
                mlp = Parameters.SemiMajor * Mlfn (e0, e1, e2, e3, MathUtil.PiHalf);
                rh = Math.Sqrt (px * px + py * py);
                m = rh - mlp;

                lat = Imlfn (m / Parameters.SemiMajor, e0, e1, e2, e3);
                lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + Math.Atan2 (px, py));
                return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
            }
            //default case
            rh = Math.Sqrt (px * px + py * py);
            double az = Math.Atan2 (px, py);
            var n1 = GN (Parameters.SemiMajor, e, sinp12);
            double cosAz = Math.Cos (az);
            double tmp = e * cosp12 * cosAz;
            var a = -tmp * tmp / (1 - es);
            double b = 3 * es * (1 - a) * sinp12 * cosp12 * cosAz / (1 - es);
            double d = rh / n1;
            double ee = d - a * (1 + a) * Math.Pow (d, 3) / 6 - b * (1 + 3 * a) * Math.Pow (d, 4) / 24;
            double f = 1 - a * ee * ee / 2 - d * ee * ee * ee / 6;
            var psi = Math.Asin (sinp12 * Math.Cos (ee) + cosp12 * Math.Sin (ee) * cosAz);
            lon = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + Math.Asin (Math.Sin (az) * Math.Sin (ee) / Math.Cos (psi)));
            lat = Math.Atan ((1 - es * f * sinp12 / Math.Sin (psi)) * Math.Tan (psi) / (1 - es));
            return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
        }
    }
}