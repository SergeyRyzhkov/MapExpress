namespace MapExpress.OpenGIS.GeoAPI.Parameters
{
    public interface IGeneralParameterDescriptor
    {
        string Name { get; }

        string Description { get; }

        IGeneralParameterValue CreateValue ();
    }
}