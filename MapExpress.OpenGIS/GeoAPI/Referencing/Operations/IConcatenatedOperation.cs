#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Operations
{
    public interface IConcatenatedOperation : ICoordinateOperation
    {
        ICollection <ISingleOperation> Operations { get; }
    }
}