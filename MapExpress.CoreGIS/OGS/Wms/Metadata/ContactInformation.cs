#region

using System;
using System.ComponentModel;

#endregion

namespace MapExpress.CoreGIS.OGS.Wms.Metadata
{
    [TypeConverter (typeof (ExpandableObjectConverter))]
    [Serializable]
    public struct ContactInformation
    {
        [DisplayName ("Адрес")]
        public ContactAddress ContactAddress { get; set; }

        [DisplayName ("Электронная почта")]
        public string ElectronicMailAddress { get; set; }

        [DisplayName ("Факс")]
        public string FacsimileTelephone { get; set; }

        [DisplayName ("Контактное лицо")]
        public ContactPersonPrimary ContactPersonPrimary { get; set; }


        [DisplayName ("ContactPosition")]
        public string ContactPosition { get; set; }

        [DisplayName ("Контактный телефон")]
        public string ContactVoiceTelephone { get; set; }

        [DisplayName ("Контактный адрес электронной почты")]
        public string ContactElectronicMailAddress { get; set; }

        public override string ToString ()
        {
            return string.Empty;
        }
    }
}