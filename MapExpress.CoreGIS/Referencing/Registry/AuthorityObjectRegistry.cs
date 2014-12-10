using System;
using System.Collections.Generic;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Authority;

namespace MapExpress.CoreGIS.Referencing.Registry
{
    public abstract class AuthorityObjectRegistry <T> where T : class, IAuthorityObject
    {
        public abstract IList <T> All { get; }

        public virtual void RegisterRange (IList <T> authorityObjects)
        {
            foreach (var iterObject in authorityObjects)
            {
                Register (iterObject);
            }
        }

        // TODO:!!! 
        //1. Что-то не понятно как тут работает.
        //2. Может для IAuthorityObject сделать обязательным InitAuthorityAliases ?
        //3. Если да то при  Register (T authorityObject) вызывать этот метод
        //3.1. И тогда в регитсри классах сделать не add, а  Register и убрать public abstract IList <T> All { get; } - сделать его здесь
        public virtual void Register (T authorityObject)
        {
            T first = null;
            foreach (var iter in All)
            {
                if (iter.Equals (authorityObject))
                {
                    first = iter;
                    break;
                }
            }
            if (first == null)
            {
                All.Add (authorityObject);
                first = authorityObject;
            }

            first.AuthorityAliases.AddRange (authorityObject.AuthorityAliases.All ());
        }

        public virtual T GetByEpsgCode (uint epsgCode)
        {
            return GetByAuthority (AuthorityType.EPSG, epsgCode);
        }

        public virtual T GetByAuthority (AuthorityType type, uint code)
        {
            foreach (var iterObject in All.Where (iterObject => iterObject.AuthorityAliases.Contains (type, code)))
            {
                return iterObject;
            }
            throw new MapExpressException (string.Format ("Object not found"));
        }

        // TODO: Если не используется - убрать. Опасный метл
        public virtual T GetByAuthority (string authorityString)
        {
            AuthorityType type;
            uint authorityCode;

            var splitauthority = authorityString.Split (':');

            if (splitauthority.Length == 2)
            {
                if (!Enum.TryParse (splitauthority [0].Trim (), true, out type))
                {
                    throw new MapExpressException ("Invalid authority name:" + splitauthority [0]);
                }
                if (!uint.TryParse (splitauthority [1].Trim (), out authorityCode))
                {
                    throw new MapExpressException ("Invalid authority code:" + splitauthority [1]);
                }
            }
            else
            {
                throw new MapExpressException ("Invalid authority format:" + authorityString + ". Example 'EPSG:3857'");
            }

            return GetByAuthority (type, authorityCode);
        }

        public virtual T GetByAuthority (AuthorityType type, string name)
        {
            foreach (T iterObject in All)
            {
                if (iterObject.AuthorityAliases.Contains (type, name))
                {
                    return iterObject;
                }
            }
            throw new MapExpressException (string.Format ("Object not found: {0}:'{1}'", type.ToString (), name));
        }
    }
}