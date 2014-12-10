#region

using System;
using MapExpress.CoreGIS.Referencing.Converters;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    // TODO: ToWKT, TOPROJ4
    // TODO : Equals
    public abstract class Projection : SingleCoordinateOperation, IProjection
    {
        protected const double EPSLN = 1.0e-10;
        private ProjectionParameters projParameters;

        protected Projection () : this (null, null, null)
        {
        }

        protected Projection (ProjectionParameters parameters) : this (null, null, parameters)
        {
        }

        protected Projection (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
            Parameters = parameters;
            // TODO: сделать абстрактным вынести в SingleCoordinateOperation

            // InitializeAliases ();
            if (projParameters != null)
            {
                if (projParameters.Ellipsoid == null)
                {
                    projParameters.Ellipsoid = sourceCRS.Datum.Ellipsoid;
                }
                // TODO:   сделать абстрактным вынести в SingleCoordinateOperation
                InitializeConstants ();
            }
        }

        public new ProjectionParameters Parameters
        {
            get { return projParameters; }
            //TODO : это опсано, надо убрать из базового метода. Или тоды если не эквалс делать переинициализацию констант
            set
            {
                projParameters = value;
                base.Parameters = value;
            }
        }

        public bool IsSpherical
        {
            get { return Parameters.SemiMajor.Equals (Parameters.SemiMinor); }
        }

        #region IProjection Members

        public override string ExportToWKT ()
        {
            return WKTCoordinateSystemWriter.Instance.WriteProjection (this);
        }

        #endregion

        // TODO: Для оптимизации можно один раз на класс инициализировать,а  не каждый раз. То есть первый рази сделали инициализацию, далее не делаем
        // TODO: Но если сменили параметры, то надо флаг сбрасывать
        // TODO: Надо использовать AngularUnit у GeographicCoordinate и в зависимости от него делать или нет преобразование. А метод Project сделать чтобы всегда в радинах был, то есть ProjectRadian

        public override ICoordinate Transform (ICoordinate point)
        {
            InitializeConstants ();
            return Project (new GeographicCoordinate (point));
        }

        public override ICoordinate TransformInverse (ICoordinate point)
        {
            InitializeConstants ();
            return ProjectInverse (point);
        }


        // TODO: А ведь могут дернуть метод и не вызвав InitializeConstants. Надо сделать их protected или internal?
        // TODO: Надо сделать явно Coordinate вместо ICoordinate 
        protected abstract ICoordinate Project (GeographicCoordinate geographCoordinate);

        protected abstract GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate);

        public override IParameterValueGroup CreateParameters ()
        {
            return new ProjectionParameters ();
        }


        protected static double AdjustLon (double lon)
        {
            return (Math.Abs (lon) <= Math.PI) ? lon : (lon - (Math.Sign (lon) * 2 * Math.PI));
        }

        protected static double AdjustLat (double lan)
        {
            return (Math.Abs (lan) < MathUtil.PiHalf) ? lan : (lan - (Math.Sign (lan) * Math.PI));
        }

        protected static double Qsfnz (double eccent, double sinphi)
        {
            if (eccent > 1.0e-7)
            {
                double con = eccent * sinphi;
                return ((1 - eccent * eccent) * (sinphi / (1 - con * con) - (0.5 / eccent) * Math.Log ((1 - con) / (1 + con))));
            }
            return (2 * sinphi);
        }

        protected static double Msfnz (double eccent, double sinphi, double cosphi)
        {
            var con = eccent * sinphi;
            return cosphi / (Math.Sqrt (1 - con * con));
        }

        protected static double Asinz (double x)
        {
            if (Math.Abs (x) > 1)
            {
                x = (x > 1) ? 1 : -1;
            }
            return Math.Asin (x);
        }

        protected static double E0Fn (double x)
        {
            return (1 - 0.25 * x * (1 + x / 16 * (3 + 1.25 * x)));
        }

        protected static double E1Fn (double x)
        {
            return (0.375 * x * (1 + 0.25 * x * (1 + 0.46875 * x)));
        }

        protected static double E2Fn (double x)
        {
            return (0.05859375 * x * x * (1 + 0.75 * x));
        }

        protected static double E3Fn (double x)
        {
            return (x * x * x * (35 / 3072));
        }

        protected static double Mlfn (double e0, double e1, double e2, double e3, double phi)
        {
            return (e0 * phi - e1 * Math.Sin (2 * phi) + e2 * Math.Sin (4 * phi) - e3 * Math.Sin (6 * phi));
        }

        protected static double GN (double a, double e, double sinphi)
        {
            var temp = e * sinphi;
            return a / Math.Sqrt (1 - temp * temp);
        }

        protected static double Imlfn (double ml, double e0, double e1, double e2, double e3)
        {
            var phi = ml / e0;
            for (var i = 0; i < 15; i++)
            {
                var dphi = (ml - (e0 * phi - e1 * Math.Sin (2 * phi) + e2 * Math.Sin (4 * phi) - e3 * Math.Sin (6 * phi))) / (e0 - 2 * e1 * Math.Cos (2 * phi) + 4 * e2 * Math.Cos (4 * phi) - 6 * e3 * Math.Cos (6 * phi));
                phi += dphi;
                if (Math.Abs (dphi) <= 0.0000000001)
                {
                    return phi;
                }
            }
            return double.NaN;
        }

        protected static double Iqsfnz (double eccent, double q)
        {
            var temp = 1 - (1 - eccent * eccent) / (2 * eccent) * Math.Log ((1 - eccent) / (1 + eccent));
            if (Math.Abs (Math.Abs (q) - temp) < 1.0E-6)
            {
                if (q < 0)
                {
                    return (-1 * MathUtil.PiHalf);
                }
                return MathUtil.PiHalf;
            }
            var phi = Math.Asin (0.5 * q);
            for (var i = 0; i < 30; i++)
            {
                var sinPhi = Math.Sin (phi);
                var cosPhi = Math.Cos (phi);
                var con = eccent * sinPhi;
                var dphi = Math.Pow (1 - con * con, 2) / (2 * cosPhi) * (q / (1 - eccent * eccent) - sinPhi / (1 - con * con) + 0.5 / eccent * Math.Log ((1 - con) / (1 + con)));
                phi += dphi;
                if (Math.Abs (dphi) <= 0.0000000001)
                {
                    return phi;
                }
            }
            return double.NaN;
        }

        protected static double Tsfnz (double eccent, double phi, double sinphi)
        {
            var con = eccent * sinphi;
            var com = 0.5 * eccent;
            con = Math.Pow (((1 - con) / (1 + con)), com);
            return (Math.Tan (0.5 * (MathUtil.PiHalf - phi)) / con);
        }

        protected static double Phi2Z (double eccent, double ts)
        {
            var eccnth = 0.5 * eccent;
            var phi = MathUtil.PiHalf - 2 * Math.Atan (ts);
            for (var i = 0; i <= 15; i++)
            {
                var con = eccent * Math.Sin (phi);
                var dphi = MathUtil.PiHalf - 2 * Math.Atan (ts * (Math.Pow (((1 - con) / (1 + con)), eccnth))) - phi;
                phi += dphi;
                if (Math.Abs (dphi) <= 0.0000000001)
                {
                    return phi;
                }
            }
            return -9999;
        }

        protected double Srat (double esinp, double exp)
        {
            return Math.Pow ((1 - esinp) / (1 + esinp), exp);
        }
    }
}