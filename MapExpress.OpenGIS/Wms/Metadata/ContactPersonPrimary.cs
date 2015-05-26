#region

using System;
using System.ComponentModel;

#endregion

namespace MapExpress.OpenGIS.Wms.Metadata
{
    [TypeConverter (typeof (ExpandableObjectConverter))]
    [Serializable]
    public struct ContactPersonPrimary
    {
        [DisplayName ("Организация")]
        public string ContactOrganization
        {
            get;
            set;
        }

         [DisplayName ("Контактное лицо")]
        public string ContactPerson
        {
            get;
            set;
        }

         public override string ToString ()
         {
             return ContactOrganization + " " + ContactPerson;
         }
    }
}