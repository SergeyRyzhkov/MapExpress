#region

using System;
using MapExpress.CoreGIS.Referencing.Converters;
using MapExpress.CoreGIS.Referencing.Units;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.Datums
{
    // TODO: При сэтах надо переустанавливать (сбрасывать) другие вычисляемые значения!
    public class Ellipsoid : IEllipsoid

    {
        private AuthorityList authorityList;
        private double flattening;
        private double inverseFlattening;
        private double semiMinorAxis;

        public Ellipsoid ()
        {
        }

        public Ellipsoid (string name)
        {
            Name = name;
            AxisUnit = AngularUnit.Degree;
        }


        public Ellipsoid (string name, double semiMajorAxis, double semiMinorAxis)
        {
            this.semiMinorAxis = semiMinorAxis;
            Name = name;
            SemiMajorAxis = semiMajorAxis;
            AxisUnit = AngularUnit.Degree;
        }

        public Ellipsoid (string name, double semiMajorAxis, double semiMinorAxis, IAngularUnit axisUnit)
        {
            this.semiMinorAxis = semiMinorAxis;
            Name = name;
            SemiMajorAxis = semiMajorAxis;
            AxisUnit = axisUnit;
        }

        public Ellipsoid (double semiMajorAxis, double semiMinorAxis, IAngularUnit axisUnit)
        {
            this.semiMinorAxis = semiMinorAxis;
            SemiMajorAxis = semiMajorAxis;
            AxisUnit = axisUnit;
        }

        public decimal AuthorityCode { get; set; }

        #region IEllipsoid Members

        public string Name { get; set; }

        public IUnit AxisUnit { get; set; }


        public double SemiMajorAxis { get; set; }

        public double SemiMinorAxis
        {
            get
            {
                semiMinorAxis = semiMinorAxis > 0 ? semiMinorAxis : SemiMajorAxis * (1.0 - Flattening);
                return semiMinorAxis;
            }
            set { semiMinorAxis = value; }
        }

        public double Flattening
        {
            get
            {
                flattening = flattening > 0
                                 ? flattening
                                 : inverseFlattening > 0
                                       ? 1.0 / inverseFlattening
                                       : semiMinorAxis > 0 ? (SemiMajorAxis - semiMinorAxis) / semiMinorAxis : 0;
                return flattening;
            }
            set { flattening = value; }
        }

        public double InverseFlattening
        {
            get
            {
                inverseFlattening = inverseFlattening > 0
                                        ? inverseFlattening
                                        : (flattening > 0 ? 1.0 / flattening : 0);
                return inverseFlattening;
            }
            set { inverseFlattening = value; }
        }

        public double Eccentricity
        {
            get { return Math.Sqrt (2 * Flattening - Math.Pow (Flattening, 2)); }
        }

        public double EccentricitySquared
        {
            get { return Math.Pow (Eccentricity, 2); }
        }

        public AuthorityList AuthorityAliases
        {
            get { return authorityList ?? (authorityList = new AuthorityList ()); }
            set { authorityList = value; }
        }

        public string ExportToWKT ()
        {
            return WKTCoordinateSystemWriter.Instance.WriteEllipsoid (this);
        }

        public double ConformalSphereRadius (double latRad)
        {
            return SemiMajorAxis *
                   Math.Sqrt ((1 - EccentricitySquared) / (1 - EccentricitySquared * Math.Pow (Math.Sin (latRad), 2)));
        }

        public bool IsSphere ()
        {
            return SemiMajorAxis == SemiMinorAxis;
        }


        public bool Equals (IEllipsoid other)
        {
            if (ReferenceEquals (null, other)) return false;
            if (ReferenceEquals (this, other)) return true;
            return other.SemiMajorAxis.Equals (SemiMajorAxis) && other.SemiMinorAxis.Equals (SemiMinorAxis);
        }

        #endregion

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (ReferenceEquals (this, obj)) return true;
            if (!(obj is IEllipsoid))
            {
                return false;
            }
            return Equals ((IEllipsoid) obj);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                return (SemiMajorAxis.GetHashCode () * 397) ^ SemiMinorAxis.GetHashCode ();
            }
        }

        public static bool operator == (Ellipsoid left, Ellipsoid right)
        {
            return Equals (left, right);
        }

        public static bool operator != (Ellipsoid left, Ellipsoid right)
        {
            return !Equals (left, right);
        }

        public override string ToString ()
        {
            return ExportToWKT ();
        }
    }
}