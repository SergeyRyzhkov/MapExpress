#region

#endregion

#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Parameters
{
    public interface IParameterValueGroup
    {
        IParameterDescriptorGroup DescriptorGroup { get; }

        ICollection <IParameterValue> Values { get; }

        IParameterValue this [string name] { get; }
    }
}