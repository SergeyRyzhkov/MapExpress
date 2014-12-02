#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Geometries
{
    // TODO: Implements IMultiCurve ?
    public interface IMultiLineString : IGeometry
    {
        ICollection <ILineString> LineStrings { get; set; }
    }
}