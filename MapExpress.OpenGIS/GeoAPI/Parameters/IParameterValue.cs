#region

#endregion

#region

using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Parameters
{
    public interface IParameterValue : IGeneralParameterValue
    {
        new IParameterDescriptor Descriptor { get; }

        IUnit Unit { get; }

        double Value { get; set; }
    }
}