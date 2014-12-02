#region

using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Parameters
{
    public interface IParameterDescriptor : IGeneralParameterDescriptor
    {
        double DefaultValue { get; }

        double MinimumValue { get; }

        double MaximumValue { get; }

        IUnit Unit { get; }

        new IParameterValue CreateValue ();
    }
}