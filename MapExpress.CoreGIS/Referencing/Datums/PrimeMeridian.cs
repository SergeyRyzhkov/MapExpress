#region

using MapExpress.CoreGIS.Referencing.Converters;
using MapExpress.CoreGIS.Referencing.Units;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.Datums
{
    public class PrimeMeridian : IPrimeMeridian
    {
        private IAngularUnit angularUnit;
        private AuthorityList authorityList;


        public PrimeMeridian ()
        {
        }

        public PrimeMeridian (double longitude) : this (string.Empty, longitude, AngularUnit.Degree)
        {
        }

        public PrimeMeridian (double longitude, IAngularUnit unit) : this (string.Empty, longitude, unit)
        {
        }

        public PrimeMeridian (string name, double longitude) : this (name, longitude, AngularUnit.Degree)
        {
        }

        public PrimeMeridian (string name, double longitude, IAngularUnit angularUnit)
        {
            Longitude = longitude;
            Unit = angularUnit;
            Name = name;
        }

        #region IPrimeMeridian Members

        public string Name { get; set; }

        public double Longitude { get; set; }

        public IAngularUnit Unit
        {
            get { return angularUnit ?? AngularUnit.Degree; }
            set { angularUnit = value; }
        }

        public AuthorityList AuthorityAliases
        {
            get { return authorityList ?? (authorityList = new AuthorityList ()); }
            set { authorityList = value; }
        }

        public string ExportToWKT ()
        {
            return WKTCoordinateSystemWriter.Instance.WritePrimeMeridian (this);
        }

        public bool Equals (IPrimeMeridian other)
        {
            if (ReferenceEquals (null, other)) return false;
            if (ReferenceEquals (this, other)) return true;
            return other.Longitude.Equals (Longitude);
        }

        #endregion

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (ReferenceEquals (this, obj)) return true;
            if (!(obj is IPrimeMeridian))
            {
                return false;
            }

            return Equals ((IPrimeMeridian) obj);
        }

        public override int GetHashCode ()
        {
            return Longitude.GetHashCode ();
        }


        public override string ToString ()
        {
            return ExportToWKT ();
        }
    }
}