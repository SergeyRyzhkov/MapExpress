#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    // TODO: В потомках оптимизировать и использовать InitializeConstants 
    public abstract class DatumTransform : Transformation
    {
        protected DatumTransform (DatumShiftParameters parameters) : this (null, null, parameters)
        {
        }

        protected DatumTransform (IGeodeticCRS sourceCRS, IGeodeticCRS targetCRS, DatumShiftParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
            Parameters = parameters;
        }

        public new DatumShiftParameters Parameters { get; private set; }

        public override IParameterValueGroup CreateParameters ()
        {
            return new DatumShiftParameters ();
        }

        public override ICoordinate Transform (ICoordinate sourceCoord)
        {
            var m = (1 + Parameters.Ppm * (Math.Pow (10, -6)));

            var sourceMatrix = InitSourceCoordMatrix (sourceCoord);
            var translationVectorMatrix = InitTranslationVectorMatrix ();
            var rotationMatrix = InitRotationMatrix ();
            var frameRotationMatrix = InitFrameRotationMatrix ();

            var resultMatrix = m * rotationMatrix * sourceMatrix + frameRotationMatrix + translationVectorMatrix;

            return new Coordinate (resultMatrix [0, 0], resultMatrix [1, 0], resultMatrix [2, 0]);
        }


        protected virtual Matrix InitSourceCoordMatrix (ICoordinate sourceCoord)
        {
            var matrix = new Matrix (3);
            matrix [0, 0] = sourceCoord.X;
            matrix [1, 0] = sourceCoord.Y;
            matrix [2, 0] = sourceCoord.Z;
            return matrix;
        }

        protected virtual Matrix InitTranslationVectorMatrix ()
        {
            var matrix = new Matrix (3);
            matrix [0, 0] = Parameters.Dx;
            matrix [1, 0] = Parameters.Dy;
            matrix [2, 0] = Parameters.Dz;

            return matrix;
        }

        protected virtual Matrix InitRotationMatrix ()
        {
            var rZRad = Parameters.Ez / 3600.0 * (Math.PI / 180.0);
            var matrix = new Matrix (3, 3);
            matrix [0, 0] = 1.0;
            matrix [0, 1] = -rZRad;
            matrix [0, 2] = Parameters.Ey;
            matrix [1, 0] = rZRad;
            matrix [1, 1] = 1.0;
            matrix [1, 2] = -Parameters.Ex;
            matrix [2, 0] = -Parameters.Ey;
            matrix [2, 1] = Parameters.Ex;
            matrix [2, 2] = 1.0;
            return matrix;
        }

        protected virtual Matrix InitFrameRotationMatrix ()
        {
            var matrix = new Matrix (3);
            matrix [0, 0] = Parameters.Px;
            matrix [1, 0] = Parameters.Py;
            matrix [2, 0] = Parameters.Pz;
            return matrix;
        }
    }
}