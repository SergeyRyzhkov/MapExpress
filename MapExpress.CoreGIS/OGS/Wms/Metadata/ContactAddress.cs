#region

using System;
using System.ComponentModel;

#endregion

namespace MapExpress.CoreGIS.OGS.Wms.Metadata
{
    [TypeConverter (typeof (ExpandableObjectConverter))]
    [Serializable]
    public struct ContactAddress
    {
        [DisplayName ("Тип адреса")]
        public string AddressType { get; set; }

        [DisplayName ("Адрес")]
        public string Address { get; set; }

        [DisplayName ("Индекс")]
        public string PostCode { get; set; }

        [DisplayName ("Страна")]
        public string Country { get; set; }

        [DisplayName ("Город")]
        public string City { get; set; }

        [DisplayName ("StateOrProvince")]
        public string StateOrProvince { get; set; }

        public override string ToString ()
        {
            return Address;
        }
    }
}