using System;
using System.Collections.Generic;
using System.Linq;

namespace MapExpress.OpenGIS.GeoAPI.Authority
{
    public class AuthorityList
    {
        private List <Authority> authorityAliases = new List <Authority> ();


        public List <Authority> All ()
        {
            return authorityAliases;
        }


        public bool Contains (string name)
        {
            return authorityAliases.Any (iterAlias => string.Equals (iterAlias.Name, name, StringComparison.InvariantCultureIgnoreCase));
        }

        public bool Contains (uint code)
        {
            return authorityAliases.Any (iterAlias => iterAlias.Code == code);
        }

        public bool Contains (AuthorityType authorityType, string name)
        {
            return authorityAliases.Any (iterAlias => string.Equals (iterAlias.Name, name, StringComparison.InvariantCultureIgnoreCase) && iterAlias.AuthorityType == authorityType);
        }

        public bool Contains (AuthorityType authorityType, uint code)
        {
            return authorityAliases.Any (iterAlias => iterAlias.Code == code && iterAlias.AuthorityType == authorityType);
        }

        public bool Contains (Authority authority)
        {
            return authorityAliases.Contains (authority);
        }


        public Authority FindFirstByName (string name)
        {
            return authorityAliases.FirstOrDefault (iter => iter.Name.Equals (name, StringComparison.InvariantCultureIgnoreCase));
        }

        public List <Authority> FindAllByName (string name)
        {
            return authorityAliases.Where (iterAlias => string.Equals (iterAlias.Name, name, StringComparison.InvariantCultureIgnoreCase)).ToList ();
        }

        public List <Authority> FindAllByCode (uint code)
        {
            return authorityAliases.Where (iterAlias => iterAlias.Code == code).ToList ();
        }

        public string FindFirstNameByAuthority (AuthorityType authorityType)
        {
            var firstOrDefault = authorityAliases.Where (iterAlias => iterAlias.AuthorityType == authorityType).FirstOrDefault ();
            return firstOrDefault != null ? firstOrDefault.Name : null;
        }

        public uint FindFirstCodeByAuthority (AuthorityType authorityType)
        {
            var firstOrDefault = authorityAliases.Where (iterAlias => iterAlias.AuthorityType == authorityType).FirstOrDefault ();
            return firstOrDefault != null ? firstOrDefault.Code : 0;
        }

        public bool TryConvertName (string fromName, AuthorityType fromAuthorityType, out string name)
        {
            name = null;
            if (Contains (fromAuthorityType, fromName))
            {
                foreach (var iterauthority in authorityAliases.Where (iterauthority => iterauthority.AuthorityType == fromAuthorityType && string.Equals (iterauthority.Name, fromName, StringComparison.InvariantCultureIgnoreCase)))
                {
                    name = iterauthority.Name;
                    return true;
                }
            }
            return false;
        }

        public bool TryConvertCode (uint sourceCode, AuthorityType fromAuthorityType, out uint authorityCode)
        {
            authorityCode = 0;
            if (Contains (fromAuthorityType, sourceCode))
            {
                foreach (var iterauthority in authorityAliases.Where (iterauthority => iterauthority.AuthorityType == fromAuthorityType && iterauthority.Code == sourceCode))
                {
                    authorityCode = iterauthority.Code;
                    return true;
                }
            }
            return false;
        }


        public void Add (AuthorityType authorityType, string name)
        {
            Add (new Authority (authorityType, name, 0));
        }


        public void Add (AuthorityType authorityType, uint authorityCode)
        {
            Add (new Authority (authorityType, string.Empty, authorityCode));
        }

        public void Add (AuthorityType authorityType, string name, uint authorityCode)
        {
            Add (new Authority (authorityType, name, authorityCode));
        }

        public void Add (Authority authority)
        {
            if (!authorityAliases.Contains (authority))
            {
                authorityAliases.Add (authority);
            }
        }

        public void AddRange (IList <Authority> authorities)
        {
            foreach (var authority in authorities)
            {
                Add (authority);
            }
        }
    }
}