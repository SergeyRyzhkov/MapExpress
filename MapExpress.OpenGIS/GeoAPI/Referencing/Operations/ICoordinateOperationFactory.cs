#region

using System.Collections.Generic;
using MapExpress.OpenGIS.GeoAPI.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Operations
{
	// TODO: реализовано?
    public interface ICoordinateOperationFactory
    {
        ICoordinateOperation CreateOperation (ICoordinateReferenceSystem sourceCRS, ICoordinateReferenceSystem targetCRS);

        ICoordinateOperation CreateOperation (ICoordinateReferenceSystem sourceCRS, ICoordinateReferenceSystem targetCRS, IOperationMethod method);

        ICoordinateOperation CreateConcatenatedOperation (IEnumerable <ICoordinateOperation> operations);

        IConversion CreateDefiningConversion (IOperationMethod method, IParameterValueGroup parameters);
    }
}