#region

using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Operations
{
    public interface ICoordinateOperation
    {
        ICoordinateReferenceSystem SourceCRS { get; }

        ICoordinateReferenceSystem TargetCRS { get; }

        string OperationVersion { get; }

        IEnvelope DomainOfValidity { get; }

        IMathTransform MathTransform { get; }

        
        IOperationMethod OperationMethod { get; }

        // TODO: Убрать бы все эти апарметры и т.д. Толку от них нет 
        IParameterValueGroup Parameters { get; }
    }
}