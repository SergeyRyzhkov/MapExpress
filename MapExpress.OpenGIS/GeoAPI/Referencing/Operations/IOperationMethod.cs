#region

using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Parameters;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Operations
{
    public interface IOperationMethod : IAuthorityObject
    {
        string Name { get; }

        int SourceDimensions { get; }

        int TargetDimensions { get; }

        string Formula { get; }

        IParameterValueGroup CreateParameters ();
    }
}