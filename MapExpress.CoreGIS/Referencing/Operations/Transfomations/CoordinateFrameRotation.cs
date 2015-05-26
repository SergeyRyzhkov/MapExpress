#region

using MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    public class CoordinateFrameRotation : PositionVector
    {
        public CoordinateFrameRotation (DatumShiftParameters parameters): this (null, null, parameters)
        {
        }

        public CoordinateFrameRotation (GeocentricCRS sourceCRS, GeocentricCRS targetCRS, DatumShiftParameters parameters): base (sourceCRS, targetCRS, parameters)
        {
        }


        protected override Matrix InitRotationMatrix (bool inverse)
        {
            var eXRad = -1 * (Parameters.Ex / 3600.0 * MathUtil.DEG2RAD);
            var eYRad = -1 * (Parameters.Ey / 3600.0 * MathUtil.DEG2RAD);
            var eZRad = -1 * (Parameters.Ez / 3600.0 * MathUtil.DEG2RAD);

            eXRad = inverse ? eXRad * -1.0 : eXRad;
            eYRad = inverse ? eYRad * -1.0 : eYRad;
            eZRad = inverse ? eZRad * -1.0 : eZRad;

            var matrix = new Matrix (3, 3);
            matrix[0, 0] = 1.0;
            matrix[0, 1] = -eZRad;
            matrix[0, 2] = eYRad;
            matrix[1, 0] = eZRad;
            matrix[1, 1] = 1.0;
            matrix[1, 2] = -eXRad;
            matrix[2, 0] = -eYRad;
            matrix[2, 1] = eXRad;
            matrix[2, 2] = 1.0;
            return matrix;
        }
    }
}