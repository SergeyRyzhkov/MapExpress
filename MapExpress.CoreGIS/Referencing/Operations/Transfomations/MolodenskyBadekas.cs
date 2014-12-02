#region

using System;
using MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    public class MolodenskyBadekas : DatumTransform
    {
        public MolodenskyBadekas (DatumShiftParameters parameters) : this (null, null, parameters)
        {
        }

        public MolodenskyBadekas (GeocentricCRS sourceCRS, GeocentricCRS targetCRS, DatumShiftParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override ICoordinate Transform (ICoordinate sourceCoord)
        {
            var correctedPoint = new Coordinate (sourceCoord.X, sourceCoord.Y, sourceCoord.Z);
            correctedPoint.X = correctedPoint.X - Parameters.Px;
            correctedPoint.Y = correctedPoint.Y - Parameters.Py;
            correctedPoint.Z = correctedPoint.Z - Parameters.Pz;
            return base.Transform (correctedPoint);
        }

        protected override Matrix InitRotationMatrix ()
        {
            Parameters.Ex = Parameters.Ex * -1.0;
            Parameters.Ey = Parameters.Ey * -1.0;
            Parameters.Ez = Parameters.Ez * -1.0;
            return base.InitRotationMatrix ();
        }

        public override IMathTransform Inverse ()
        {
            throw new NotSupportedException ();
        }
    }
}