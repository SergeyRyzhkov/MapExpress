#region

using MapExpress.CoreGIS.Referencing.Converters;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

//TODO: учесть что в геоджсон есть СК http://geojson.org/geojson-spec.html#coordinate-reference-system-objects

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    public abstract class CoordinateReferenceSystem : ICoordinateReferenceSystem
    {
        private AuthorityList authorityList;
        private Authority defaultAuthority;

        protected CoordinateReferenceSystem ()
        {
        }

        protected CoordinateReferenceSystem (ICoordinateSystem coordinateSystem)
        {
            CoordinateSystem = coordinateSystem;
        }

        protected CoordinateReferenceSystem (string name)
        {
            Name = name;
        }

        protected CoordinateReferenceSystem (string name, ICoordinateSystem coordinateSystem)
        {
            CoordinateSystem = coordinateSystem;
            Name = name;
        }

        #region ICoordinateReferenceSystem Members

        public string Name { get; set; }

        public string AreaOfUse { get; set; }

        public ICoordinateSystem CoordinateSystem { get; set; }

        public IEnvelope Extent { get; set; }


        public string ExportToWKT ()
        {
            return WKTCoordinateSystemWriter.Instance.WriteCoordinateSystem (this);
        }

        public virtual IUnit Unit { get; set; }


        public AuthorityList AuthorityAliases
        {
            get { return authorityList ?? (authorityList = new AuthorityList ()); }
            set { authorityList = value; }
        }


        public bool Equals (ICoordinateReferenceSystem other)
        {
            if (ReferenceEquals (null, other)) return false;
            if (ReferenceEquals (this, other)) return true;
            return Equals (other.CoordinateSystem, CoordinateSystem) && Equals (other.Name, Name) && Equals (other.Unit, Unit);
        }

        #endregion

        public override string ToString ()
        {
            return ExportToWKT ();
        }

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (ReferenceEquals (this, obj)) return true;
            if (!(obj is ICoordinateReferenceSystem))
            {
                return false;
            }
            return Equals ((ICoordinateReferenceSystem) obj);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                int result = (CoordinateSystem != null ? CoordinateSystem.GetHashCode () : 0);
                result = (result * 397) ^ (Name != null ? Name.GetHashCode () : 0);
                result = (result * 397) ^ (Unit != null ? Unit.GetHashCode () : 0);
                return result;
            }
        }

        public static bool operator == (CoordinateReferenceSystem left, CoordinateReferenceSystem right)
        {
            return Equals (left, right);
        }

        public static bool operator != (CoordinateReferenceSystem left, CoordinateReferenceSystem right)
        {
            return !Equals (left, right);
        }
    }
}