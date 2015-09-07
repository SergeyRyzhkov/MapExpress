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
    public class LambertAzimuthalEqualArea : Projection
    {
        private const int SPole = 1;
        private const int NPole = 2;
        private const int EQUIT = 3;
        private const int Obliq = 4;
        private const double P00 = 0.33333333333333333333;
        private const double P01 = 0.17222222222222222222;
        private const double P02 = 0.10257936507936507936;
        private const double P10 = 0.06388888888888888888;
        private const double P11 = 0.06640211640211640211;
        private const double P20 = 0.01641501294219154443;

        private double[] apa;
        private double cosb1;
        private double cosph0;
        private double dd;
        private double e;
        private double es;
        private double lat0;
        private int mode;
        private double qp;
        private double rq;
        private double sinb1;
        private double sinph0;
        //private double sinphi;
        private double xmf;
        private double ymf;

        public LambertAzimuthalEqualArea (ProjectionParameters parameters) : base (parameters)
        {
        }

        public LambertAzimuthalEqualArea (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override void InitializeConstants ()
        {
            lat0 = MathUtil.DegToRad (Parameters.LatitudeOfOrigin);
            e = Parameters.Ellipsoid.Eccentricity;
            es = Parameters.Ellipsoid.EccentricitySquared;
            var t = Math.Abs (lat0);

            if (Math.Abs (t - MathUtil.PiHalf) < EPSLN)
            {
                mode = lat0 < 0 ? SPole : NPole;
            }
            else if (Math.Abs (t) < EPSLN)
            {
                mode = EQUIT;
            }
            else
            {
                mode = Obliq;
            }
            if (es > 0)
            {
                qp = Qsfnz (e, 1);
                //mmf = 0.5 / (1 - es);
                apa = authset (es);
                switch (mode)
                {
                    case NPole:
                        dd = 1;
                        break;
                    case SPole:
                        dd = 1;
                        break;
                    case EQUIT:
                        rq = Math.Sqrt (0.5 * qp);
                        dd = 1 / rq;
                        xmf = 1;
                        ymf = 0.5 * qp;
                        break;
                    case Obliq:
                        rq = Math.Sqrt (0.5 * qp);
                        var sinphi = Math.Sin (lat0);
                        sinb1 = Qsfnz (e, sinphi) / qp;
                        cosb1 = Math.Sqrt (1 - sinb1 * sinb1);
                        dd = Math.Cos (lat0) / (Math.Sqrt (1 - es * sinphi * sinphi) * rq * cosb1);
                        ymf = (xmf = rq) / dd;
                        xmf *= dd;
                        break;
                }
            }
            else
            {
                if (mode == Obliq)
                {
                    sinph0 = Math.Sin (lat0);
                    cosph0 = Math.Cos (lat0);
                }
            }
        }


        protected override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var phi0 = MathUtil.DegToRad (Parameters.LatitudeOfOrigin);
            var latRad = MathUtil.DegToRad (geographCoordinate.Lat);
            var lonRad = MathUtil.DegToRad (geographCoordinate.Lon);
            double x = 0, y = 0, coslam;
            var lam = lonRad;
            var phi = latRad;
            lam = AdjustLon (lam - MathUtil.DegToRad (Parameters.CentralMeridian));

            if (IsSpherical)
            {
                var sinphi1 = Math.Sin (phi);
                var cosphi = Math.Cos (phi);
                coslam = Math.Cos (lam);
                switch (mode)
                {
                    case EQUIT:
                    case Obliq:
                        y = (mode == EQUIT) ? 1 + cosphi * coslam : 1 + sinph0 * sinphi1 + cosph0 * cosphi * coslam;
                        if (y <= EPSLN)
                        {
                            return null;
                        }
                        y = Math.Sqrt (2 / y);
                        x = y * cosphi * Math.Sin (lam);
                        y *= (mode == EQUIT) ? sinphi1 : cosph0 * sinphi1 - sinph0 * cosphi * coslam;
                        break;
                    case SPole:
                    case NPole:
                        if (mode == NPole)
                        {
                            coslam = -coslam;
                        }
                        if (Math.Abs (phi + phi0) < EPSLN)
                        {
                            return null;
                        }
                        y = Math.PI / 4 - phi * 0.5;
                        y = 2 * ((mode == SPole) ? Math.Cos (y) : Math.Sin (y));
                        x = y * Math.Sin (lam);
                        y *= coslam;
                        break;
                }
            }
            else
            {
                double sinb = 0;
                double cosb = 0;
                double b = 0;
                coslam = Math.Cos (lam);
                var sinlam = Math.Sin (lam);
                var sinphi = Math.Sin (phi);
                var q = Qsfnz (e, sinphi);
                if (mode == Obliq || mode == EQUIT)
                {
                    sinb = q / qp;
                    cosb = Math.Sqrt (1 - sinb * sinb);
                }
                switch (mode)
                {
                    case Obliq:
                        b = 1 + sinb1 * sinb + cosb1 * cosb * coslam;
                        break;
                    case EQUIT:
                        b = 1 + cosb * coslam;
                        break;
                    case NPole:
                        b = MathUtil.PiHalf + phi;
                        q = qp - q;
                        break;
                    case SPole:
                        b = phi - MathUtil.PiHalf;
                        q = qp + q;
                        break;
                }
                if (Math.Abs (b) < EPSLN)
                {
                    return null;
                }
                switch (mode)
                {
                    case Obliq:
                    case EQUIT:
                        b = Math.Sqrt (2 / b);
                        if (mode == Obliq)
                        {
                            y = ymf * b * (cosb1 * sinb - sinb1 * cosb * coslam);
                        }
                        else
                        {
                            y = (b = Math.Sqrt (2 / (1 + cosb * coslam))) * sinb * ymf;
                        }
                        x = xmf * b * cosb * sinlam;
                        break;
                    case NPole:
                    case SPole:
                        if (q >= 0)
                        {
                            x = (b = Math.Sqrt (q)) * sinlam;
                            y = coslam * ((mode == SPole) ? b : -b);
                        }
                        else
                        {
                            x = y = 0;
                        }
                        break;
                }
            }

            var px = Parameters.SemiMajor * x + Parameters.FalseEasting;
            var py = Parameters.SemiMajor * y + Parameters.FalseNorthing;
            return new Coordinate (px, py);
        }

        protected override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            var phi0 = MathUtil.DegToRad (Parameters.LatitudeOfOrigin);
            var px = projectedCordinate.X - Parameters.FalseEasting;
            var py = projectedCordinate.Y - Parameters.FalseNorthing;
            var x = px / Parameters.SemiMajor;
            var y = py / Parameters.SemiMajor;
            double lam, phi;

            if (IsSpherical)
            {
                double cosz = 0, sinz = 0;

                var rh = Math.Sqrt (x * x + y * y);
                phi = rh * 0.5;
                if (phi > 1)
                {
                    return GeographicCoordinate.Empty;
                }
                phi = 2 * Math.Asin (phi);
                if (mode == Obliq || mode == EQUIT)
                {
                    sinz = Math.Sin (phi);
                    cosz = Math.Cos (phi);
                }
                switch (mode)
                {
                    case EQUIT:
                        phi = (Math.Abs (rh) <= EPSLN) ? 0 : Math.Asin (y * sinz / rh);
                        x *= sinz;
                        y = cosz * rh;
                        break;
                    case Obliq:
                        phi = (Math.Abs (rh) <= EPSLN) ? phi0 : Math.Asin (cosz * sinph0 + y * sinz * cosph0 / rh);
                        x *= sinz * cosph0;
                        y = (cosz - Math.Sin (phi) * sinph0) * rh;
                        break;
                    case NPole:
                        y = -y;
                        phi = MathUtil.PiHalf - phi;
                        break;
                    case SPole:
                        phi -= MathUtil.PiHalf;
                        break;
                }
                lam = (y == 0 && (mode == EQUIT || mode == Obliq)) ? 0 : Math.Atan2 (x, y);
            }
            else
            {
                double ab = 0;
                switch (mode)
                {
                    case EQUIT:
                    case Obliq:
                        {
                            x /= dd;
                            y *= dd;
                            var rho = Math.Sqrt (x * x + y * y);
                            if (rho < EPSLN)
                            {
                                px = 0;
                                py = phi0;
                                return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
                            }
                            var sCe = 2 * Math.Asin (0.5 * rho / rq);
                            var cCe = Math.Cos (sCe);
                            x *= (sCe = Math.Sin (sCe));
                            if (mode == Obliq)
                            {
                                ab = cCe * sinb1 + y * sCe * cosb1 / rho;
                                var q = qp * ab;
                                y = rho * cosb1 * cCe - y * sinb1 * sCe;
                            }
                            else
                            {
                                ab = y * sCe / rho;
                                var q = qp * ab;
                                y = rho * cCe;
                            }
                        }
                        break;
                    case SPole:
                    case NPole:
                        {
                            if (mode == NPole)
                            {
                                y = -y;
                            }
                            var q = (x * x + y * y);
                            if (q == 0)
                            {
                                px = 0;
                                py = phi0;
                                return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
                            }
                            ab = 1 - q / qp;
                            if (mode == SPole)
                            {
                                ab = -ab;
                            }
                        }
                        break;
                }
                lam = Math.Atan2 (x, y);
                phi = authlat (Math.Asin (ab), apa);
            }


            px = AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + lam);
            py = phi;
            return new GeographicCoordinate (MathUtil.Rad2Deg (px), MathUtil.Rad2Deg (py));
        }


        private double[] authset (double es1)
        {
            var apa1 = new double[3];
            apa1 [0] = es1 * P00;
            var t = es1 * es1;
            apa1 [0] += t * P01;
            apa1 [1] = t * P10;
            t *= es1;
            apa1 [0] += t * P02;
            apa1 [1] += t * P11;
            apa1 [2] = t * P20;
            return apa1;
        }

        private double authlat (double beta, double[] apa1)
        {
            var t = beta + beta;
            return (beta + apa1 [0] * Math.Sin (t) + apa1 [1] * Math.Sin (t + t) + apa1 [2] * Math.Sin (t + t + t));
        }
    }
}