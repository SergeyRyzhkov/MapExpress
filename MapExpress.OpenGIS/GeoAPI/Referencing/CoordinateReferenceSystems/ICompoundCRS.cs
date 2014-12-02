#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems
{
    public interface ICompoundCRS : ICoordinateReferenceSystem
    {
        ICollection <ICoordinateReferenceSystem> Components { get; }
    }
}