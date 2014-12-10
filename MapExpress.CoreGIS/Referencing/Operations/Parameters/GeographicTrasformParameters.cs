using System;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

namespace MapExpress.CoreGIS.Referencing.Operations.Parameters
{
    public class GeographicTrasformParameters : ParameterGroup, IEquatable <GeographicTrasformParameters>
    {
        public GeographicTrasformParameters ()
        {
        }

        public GeographicTrasformParameters (IEllipsoid sourceEllipsoid, IEllipsoid targetEllipsoid, double dx, double dy, double dz) : this (sourceEllipsoid, targetEllipsoid, new DatumShiftParameters (dx, dy, dz))
        {
            SourceEllipsoid = sourceEllipsoid;
            TargetEllipsoid = targetEllipsoid;
        }


        public GeographicTrasformParameters (IEllipsoid sourceEllipsoid, IEllipsoid targetEllipsoid, double dx, double dy, double dz, double ex, double ey, double ez, double ppm): this (sourceEllipsoid, targetEllipsoid, new DatumShiftParameters (dx, dy, dz, ex, ey, ez, ppm))
        {
        }

        public GeographicTrasformParameters (IEllipsoid sourceEllipsoid, IEllipsoid targetEllipsoid, DatumShiftParameters datumShiftParameters)
        {
            SourceEllipsoid = sourceEllipsoid;
            TargetEllipsoid = targetEllipsoid;
            DatumShiftParameters = datumShiftParameters;
        }

        public DatumShiftParameters DatumShiftParameters { get; set; }

        public IEllipsoid SourceEllipsoid { get; set; }

        public IEllipsoid TargetEllipsoid { get; set; }

        public bool Equals (GeographicTrasformParameters other)
        {
            if (ReferenceEquals (null, other)) return false;
            if (ReferenceEquals (this, other)) return true;
            return Equals (other.DatumShiftParameters, DatumShiftParameters) && Equals (other.SourceEllipsoid, SourceEllipsoid) && Equals (other.TargetEllipsoid, TargetEllipsoid);
        }

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (ReferenceEquals (this, obj)) return true;
            if (obj.GetType () != typeof (GeographicTrasformParameters)) return false;
            return Equals ((GeographicTrasformParameters) obj);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                int result = (DatumShiftParameters != null ? DatumShiftParameters.GetHashCode () : 0);
                result = (result * 397) ^ (SourceEllipsoid != null ? SourceEllipsoid.GetHashCode () : 0);
                result = (result * 397) ^ (TargetEllipsoid != null ? TargetEllipsoid.GetHashCode () : 0);
                return result;
            }
        }
    }
}