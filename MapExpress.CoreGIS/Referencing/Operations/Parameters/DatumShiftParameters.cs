#region

using System;
using MapExpress.OpenGIS.GeoAPI.Authority;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Parameters
{
    public class DatumShiftParameters : ParameterGroup, IEquatable <DatumShiftParameters>
    {
        public static DatumShiftParameters ZERO = new DatumShiftParameters ();

        public DatumShiftParameters ()
        {
        }

        public DatumShiftParameters (double dx, double dy, double dz) : this (dx, dy, dz, 0.0, 0.0, 0.0, 0.0)
        {
        }

        public DatumShiftParameters (double dx, double dy, double dz, double ex, double ey, double ez, double ppm)
        {
            Dx = dx;
            Dy = dy;
            Dz = dz;
            Ex = ex;
            Ey = ey;
            Ez = ez;
            Ppm = ppm;
        }


        public double Dx
        {
            get { return GetParameterValue ("Dx"); }
            set
            {
                CreateOrReplaceParameter ("Dx", value, false).
                    AddAlias ("X-axis translation", AuthorityType.EPSG).
                    AddAlias ("Dx", AuthorityType.OGC);
            }
        }

        public double Dy
        {
            get { return GetParameterValue ("Dy"); }
            set
            {
                CreateOrReplaceParameter ("Dy", value, false).
                    AddAlias ("Y-axis translation", AuthorityType.EPSG).
                    AddAlias ("Dy", AuthorityType.OGC);
            }
        }

        public double Dz
        {
            get { return GetParameterValue ("Dz"); }
            set
            {
                CreateOrReplaceParameter ("Dz", value, false).
                    AddAlias ("Z-axis translation", AuthorityType.EPSG).
                    AddAlias ("Dz", AuthorityType.OGC);
            }
        }

        public double Ex
        {
            get { return GetParameterValue ("Ex"); }
            set
            {
                CreateOrReplaceParameter ("Ex", value, false).
                    AddAlias ("X-axis rotation", AuthorityType.EPSG).
                    AddAlias ("Ex", AuthorityType.OGC);
            }
        }

        public double Ey
        {
            get { return GetParameterValue ("Ey"); }
            set
            {
                CreateOrReplaceParameter ("Ey", value, false).
                    AddAlias ("Y-axis rotation", AuthorityType.EPSG).
                    AddAlias ("Ey", AuthorityType.OGC);
            }
        }

        public double Ez
        {
            get { return GetParameterValue ("Ez"); }
            set
            {
                CreateOrReplaceParameter ("Ez", value, false).
                    AddAlias ("Z-axis rotation", AuthorityType.EPSG).
                    AddAlias ("Ez", AuthorityType.OGC);
            }
        }

        public double Ppm
        {
            get { return GetParameterValue ("Ppm"); }
            set
            {
                CreateOrReplaceParameter ("Ppm", value, false).
                    AddAlias ("Scale difference", AuthorityType.EPSG).
                    AddAlias ("Ppm", AuthorityType.OGC);
            }
        }

        public double Px
        {
            get { return GetParameterValue ("Px"); }
            set { CreateOrReplaceParameter ("Px", value, false); }
        }

        public double Py
        {
            get { return GetParameterValue ("Py"); }
            set { CreateOrReplaceParameter ("Py", value, false); }
        }

        public double Pz
        {
            get { return GetParameterValue ("Pz"); }
            set { CreateOrReplaceParameter ("Pz", value, false); }
        }

        #region IEquatable<DatumShiftParameters> Members

        public bool Equals (DatumShiftParameters other)
        {
            return Dx == other.Dx && Dy == other.Dy && Dz == other.Dz && Ex == other.Ex && Ey == other.Ey && Ez == other.Ez && Ppm == other.Ppm;
        }

        #endregion

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (ReferenceEquals (this, obj)) return true;
            if (obj.GetType () != typeof (DatumShiftParameters)) return false;
            return Equals ((DatumShiftParameters) obj);
        }

        public override int GetHashCode ()
        {
            return Dx.GetHashCode () + Dy.GetHashCode () + Dz.GetHashCode () + Ex.GetHashCode () + Ey.GetHashCode () + Ez.GetHashCode () + Ppm.GetHashCode ();
        }

        public static bool operator == (DatumShiftParameters left, DatumShiftParameters right)
        {
            return Equals (left, right);
        }

        public static bool operator != (DatumShiftParameters left, DatumShiftParameters right)
        {
            return !Equals (left, right);
        }
    }
}