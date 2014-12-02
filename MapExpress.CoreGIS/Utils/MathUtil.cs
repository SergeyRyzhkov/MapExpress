#region

using System;

#endregion

namespace MapExpress.CoreGIS.Utils
{
    public static class MathUtil
    {
        public const double PiFourth = Math.PI / 4.0;
        public const double DEG2RAD = Math.PI / 180.0;
        public const double RAD2Deg = 180.0 / Math.PI;
        public const double PiHalf = Math.PI / 2.0;

        public const double Sin1Second = Math.PI / (180.0 * 60.0 * 60.0);

        public static double DegToRad (double x)
        {
            return DEG2RAD * x;
        }

        public static double Rad2Deg (double x)
        {
            return RAD2Deg * x;
        }

        // Secant 
        public static double Sec (double x)
        {
            return 1 / Math.Cos (x);
        }

        // Cosecant
        public static double Cosec (double x)
        {
            return 1 / Math.Sin (x);
        }

        // Cotangent 
        public static double Cotan (double x)
        {
            return 1 / Math.Tan (x);
        }

        // Inverse Sine 
        public static double Arcsin (double x)
        {
            return Math.Atan (x / Math.Sqrt (-x * x + 1.0));
        }

        // Inverse Cosine 
        public static double Arccos (double x)
        {
            return Math.Atan (-x / Math.Sqrt (-x * x + 1.0)) + 2 * Math.Atan (1.0);
        }


        // Inverse Secant 
        public static double Arcsec (double x)
        {
            return 2 * Math.Atan (1.0) - Math.Atan (Math.Sign (x) / Math.Sqrt (x * x - 1.0));
        }

        // Inverse Cosecant 
        public static double Arccosec (double x)
        {
            return Math.Atan (Math.Sign (x) / Math.Sqrt (x * x - 1.0));
        }

        // Inverse Cotangent 
        public static double Arccotan (double x)
        {
            return 2 * Math.Atan (1.0) - Math.Atan (x);
        }


        // Hyperbolic Secant 
        public static double HSech (double x)
        {
            return 2 / (Math.Exp (x) + Math.Exp (-x));
        }

        // Hyperbolic Cosecant 
        public static double HCosec (double x)
        {
            return 2 / (Math.Exp (x) - Math.Exp (-x));
        }

        // Hyperbolic Cotangent 
        public static double HCotan (double x)
        {
            return (Math.Exp (x) + Math.Exp (-x)) / (Math.Exp (x) - Math.Exp (-x));
        }

        // Inverse Hyperbolic Sine 
        public static double HArcsin (double x)
        {
            return Math.Log (x + Math.Sqrt (x * x + 1.0));
        }

        // Inverse Hyperbolic Cosine 
        public static double HArccos (double x)
        {
            return Math.Log (x + Math.Sqrt (x * x - 1.0));
        }

        // Inverse Hyperbolic Tangent 
        public static double HArctan (double x)
        {
            return Math.Log ((1.0 + x) / (1.0 - x)) / 2.0;
        }

        // Inverse Hyperbolic Secant 
        public static double HArcsec (double x)
        {
            return Math.Log ((Math.Sqrt (-x * x + 1.0) + 1.0) / x);
        }

        // Inverse Hyperbolic Cosecant 
        public static double HArccosec (double x)
        {
            return Math.Log ((Math.Sign (x) * Math.Sqrt (x * x + 1.0) + 1.0) / x);
        }

        // Inverse Hyperbolic Cotangent 
        public static double HArccotan (double x)
        {
            return Math.Log ((x + 1.0) / (x - 1.0)) / 2.0;
        }

        public static double Phi2 (double ts, double e)
        {
            double dphi;

            double eccnth = .5 * e;
            double phi = PiHalf - 2d * Math.Atan (ts);
            int i = 15;
            do
            {
                double con = e * Math.Sin (phi);
                dphi = PiHalf - 2d * Math.Atan (ts * Math.Pow ((1d - con) / (1d + con), eccnth)) - phi;
                phi += dphi;
            } while (Math.Abs (dphi) > 1e-10 && --i != 0);
            if (i <= 0)
                throw new Exception ("Computation of phi2 failed to converage after 15 iterations");
            return phi;
        }

        public static double Distance (double dx, double dy)
        {
            return Math.Sqrt (dx * dx + dy * dy);
        }
    }
}