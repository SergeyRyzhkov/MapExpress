#region

using System;
using System.Collections.Generic;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Parameters;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Parameters
{
    public class ParameterGroup : IParameterValueGroup
    {
        public static ParameterGroup Empty = new ParameterGroup ();

        private readonly List <IParameterValue> parameters = new List <IParameterValue> ();

        #region IParameterValueGroup Members

        public IParameterValue this [string name]
        {
            get { return parameters.Where (iterParameter => string.Equals (iterParameter.Descriptor.Name, name, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault (); }
        }

        public IParameterDescriptorGroup DescriptorGroup { get; set; }

        public ICollection <IParameterValue> Values
        {
            get { return parameters; }
        }

        #endregion

        public virtual bool Exists (string name)
        {
            return this [name] != null;
        }

        public virtual bool TryGetByName (string name, out IParameterValue paramValue)
        {
            foreach (var iterParameter in parameters.Where (iterParameter => string.Equals (iterParameter.Descriptor.Name, name, StringComparison.InvariantCultureIgnoreCase)))
            {
                paramValue = iterParameter;
                return true;
            }
            paramValue = null;
            return false;
        }

        public virtual Parameter CreateOrReplaceParameter (string name, double value, bool trySetParamValueThrowProperty)
        {
            IParameterValue paramValue;
            if (TryGetByName (name, out paramValue))
            {
                paramValue.Value = value;
            }
            else
            {
                paramValue = new Parameter (name, value);
                Values.Add (paramValue);
                if (trySetParamValueThrowProperty)
                {
                    TrySetParamValueThrowProperty (name, value);
                }
            }
            return (Parameter) paramValue;
        }

        // TODO: Переделать на кэшировные Expression 
        private void TrySetParamValueThrowProperty (string paramName, double value)
        {
            var propertyName = String.Join (string.Empty, from s in paramName.Split ('_') select s [0].ToString ().ToUpper () + s.Substring (1));
            var pi = GetType ().GetProperty (propertyName);
            if (pi != null)
            {
                pi.SetValue (this, value, null);
            }
        }

        public virtual double GetParameterValue (string name, double defaultValue)
        {
            IParameterValue paramValue;
            return TryGetByName (name, out paramValue) ? paramValue.Value : defaultValue;
        }

        public virtual double GetParameterValue (string name)
        {
            return GetParameterValue (name, 0);
        }
    }
}