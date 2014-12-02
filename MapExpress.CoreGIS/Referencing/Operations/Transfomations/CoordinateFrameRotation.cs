#region

using MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    public class CoordinateFrameRotation : PositionVector
    {
        public CoordinateFrameRotation (DatumShiftParameters parameters)
            : this (null, null, parameters)
        {
        }

        public CoordinateFrameRotation (GeocentricCRS sourceCRS, GeocentricCRS targetCRS, DatumShiftParameters parameters)
            : base (sourceCRS, targetCRS, parameters)
        {
        }


        protected override Matrix InitRotationMatrix ()
        {
            Parameters.Ex = Parameters.Ex * -1.0;
            Parameters.Ey = Parameters.Ey * -1.0;
            Parameters.Ez = Parameters.Ez * -1.0;
            return base.InitRotationMatrix ();
        }
    }
}