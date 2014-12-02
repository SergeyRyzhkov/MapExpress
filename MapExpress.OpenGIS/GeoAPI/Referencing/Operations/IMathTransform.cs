#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Operations
{
    public interface IMathTransform
    {
        int SourceDimensions { get; }

        int TargetDimensions { get; }

        double[] Transform (double x, double y, double z);

        ICoordinate Transform (ICoordinate point);

        ICollection <ICoordinate> Transform (ICollection <ICoordinate> points);

        IMathTransform Inverse ();
    }
}