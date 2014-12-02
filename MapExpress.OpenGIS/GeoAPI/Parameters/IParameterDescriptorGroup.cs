#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Parameters
{
    public interface IParameterDescriptorGroup
    {
        ICollection <IParameterDescriptor> Descriptors { get; }

        IParameterValueGroup CreateValueGroup ();
    }
}