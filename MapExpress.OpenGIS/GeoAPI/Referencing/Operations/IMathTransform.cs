#region

using System.Collections.Generic;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Operations
{
    public interface IMathTransform
    {
        int SourceDimensions { get; }

        int TargetDimensions { get; }

        // TODO: Может добавить?
        //double[] Transform (double x, double y);

        double[] Transform (double x, double y, double z);

        ICoordinate Transform (ICoordinate point);

        ICollection <ICoordinate> Transform (ICollection <ICoordinate> points);

        double[] TransformInverse (double x, double y, double z);

        ICoordinate TransformInverse (ICoordinate point);

        ICollection<ICoordinate> TransformInverse (ICollection<ICoordinate> points);
    }
}