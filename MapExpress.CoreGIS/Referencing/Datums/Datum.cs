#region

using MapExpress.CoreGIS.Referencing.Converters;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.Datums
{
    public class Datum : IDatum
    {
        private AuthorityList authorityList;
        private Authority defaultAuthority;

        public Datum ()
        {
        }

        public Datum (string name)
        {
            Name = name;
        }

        public Datum (IEllipsoid ellipsoid, IPrimeMeridian primeMeridian)
        {
            Ellipsoid = ellipsoid;
            PrimeMeridian = primeMeridian;
        }

        public Datum (string name, IEllipsoid ellipsoid, IPrimeMeridian primeMeridian)
        {
            Ellipsoid = ellipsoid;
            PrimeMeridian = primeMeridian;
            Name = name;
        }

        public Authority Epsg
        {
            get { return defaultAuthority ?? Authority.Unknown; }
            set { defaultAuthority = value; }
        }

        #region IDatum Members

        public IEllipsoid Ellipsoid { get; set; }

        public IPrimeMeridian PrimeMeridian { get; set; }

        public string Name { get; set; }


        public string AreaOfUse { get; set; }

        public string ExportToWKT ()
        {
            return WKTCoordinateSystemWriter.Instance.WriteDatum (this);
        }


        public AuthorityList AuthorityAliases
        {
            get { return authorityList ?? (authorityList = new AuthorityList ()); }
            set { authorityList = value; }
        }

        public bool Equals (IDatum other)
        {
            if (ReferenceEquals (null, other)) return false;
            if (ReferenceEquals (this, other)) return true;
            return Equals (other.Ellipsoid, Ellipsoid) && Equals (other.PrimeMeridian, PrimeMeridian);
        }

        #endregion

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (ReferenceEquals (this, obj)) return true;
            if (!(obj is IDatum))
            {
                return false;
            }
            return Equals ((IDatum) obj);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                return ((Ellipsoid != null ? Ellipsoid.GetHashCode () : 0) * 397) ^ (PrimeMeridian != null ? PrimeMeridian.GetHashCode () : 0);
            }
        }

        public static bool operator == (Datum left, Datum right)
        {
            return Equals (left, right);
        }

        public static bool operator != (Datum left, Datum right)
        {
            return !Equals (left, right);
        }

        public override string ToString ()
        {
            return ExportToWKT ();
        }
    }
}