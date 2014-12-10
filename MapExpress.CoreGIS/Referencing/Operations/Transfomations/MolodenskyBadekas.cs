#region

using MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    public class MolodenskyBadekas : PositionVector
    {
        public MolodenskyBadekas (DatumShiftParameters parameters) : this (null, null, parameters)
        {
        }

        public MolodenskyBadekas (GeocentricCRS sourceCRS, GeocentricCRS targetCRS, DatumShiftParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        protected override ICoordinate InternalTransform (ICoordinate sourceCoord, bool inverse)
        {
            var correctedPoint = new Coordinate (sourceCoord.X, sourceCoord.Y, sourceCoord.Z);
            correctedPoint.X = correctedPoint.X - Parameters.Px;
            correctedPoint.Y = correctedPoint.Y - Parameters.Py;
            correctedPoint.Z = correctedPoint.Z - Parameters.Pz;
            return base.InternalTransform (correctedPoint, inverse);
        }

        protected override Matrix InitRotationMatrix (bool inverse)
        {
            Parameters.Ex = Parameters.Ex * -1.0;
            Parameters.Ey = Parameters.Ey * -1.0;
            Parameters.Ez = Parameters.Ez * -1.0;
            return base.InitRotationMatrix (inverse);
        }
    }
}