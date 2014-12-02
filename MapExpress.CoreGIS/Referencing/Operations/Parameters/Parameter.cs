#region

using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Parameters
{
    public class Parameter : IParameterValue, IParameterDescriptor
    {
        private AuthorityList authorityList;

        private IParameterDescriptor descriptor;

        public Parameter (string name, double value)
        {
            Name = name;
            Value = value;
            AuthorityList = new AuthorityList ();
        }

        public AuthorityList AuthorityList
        {
            get { return authorityList ?? (authorityList = new AuthorityList ()); }
            private set { authorityList = value; }
        }

        public IUnit Unit { get; set; }

        #region IParameterDescriptor Members

        public string Name { get; private set; }

        public string Description { get; set; }

        // TODO: Использовать Clone
        public IParameterValue CreateValue ()
        {
            return this;
        }

        IGeneralParameterValue IGeneralParameterDescriptor.CreateValue ()
        {
            return CreateValue ();
        }

        public double DefaultValue { get; set; }

        public double MinimumValue { get; set; }

        public double MaximumValue { get; set; }

        #endregion

        #region IParameterValue Members

        public IParameterDescriptor Descriptor
        {
            get { return descriptor ?? this; }
            set
            {
                descriptor = value;
                Name = descriptor.Name;
                Unit = descriptor.Unit;
                DefaultValue = descriptor.DefaultValue;
                MinimumValue = descriptor.MinimumValue;
                MaximumValue = descriptor.MaximumValue;
            }
        }

        public double Value { get; set; }

        IGeneralParameterDescriptor IGeneralParameterValue.Descriptor
        {
            get { return this; }
        }

        #endregion

        public Parameter AddAlias (string alias, AuthorityType authorityType)
        {
            AuthorityList.Add (authorityType, alias);
            return this;
        }
    }
}