namespace MapExpress.OpenGIS.GeoAPI.Authority
{
    public class Authority
    {
        public static Authority Unknown = new Authority (AuthorityType.User, "UNKNOWN", 0);

        public Authority (AuthorityType authorityType, string name, uint code)
        {
            Name = name;
            Code = code;
            AuthorityType = authorityType;
        }

        public string Name { get; set; }

        public uint Code { get; set; }

        public AuthorityType AuthorityType { get; set; }

        public override string ToString ()
        {
            return string.Format ("Name: {0}, Code: {1}, AuthorityType: {2}", Name, Code, AuthorityType);
        }

        public bool Equals (Authority other)
        {
            return Equals (other.Name, Name) && other.Code == Code && Equals (other.AuthorityType, AuthorityType);
        }

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (obj.GetType () != typeof (Authority)) return false;
            return Equals ((Authority) obj);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                int result = (Name != null ? Name.GetHashCode () : 0);
                result = (result * 397) ^ Code.GetHashCode ();
                result = (result * 397) ^ AuthorityType.GetHashCode ();
                return result;
            }
        }
    }
}