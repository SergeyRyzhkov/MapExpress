#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    // TODO: В потомках оптимизировать и использовать InitializeConstants 
    public class PositionVector : SingleCoordinateOperation, ITransformation
    {
        public PositionVector (DatumShiftParameters parameters)
            : this (null, null, parameters)
        {
        }

        public PositionVector (IGeodeticCRS sourceCRS, IGeodeticCRS targetCRS, DatumShiftParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
            Parameters = parameters;
        }

        public new DatumShiftParameters Parameters { get; private set; }

        #region ITransformation Members

        public override string ExportToWKT ()
        {
            throw new NotImplementedException ();
        }

        #endregion

        public override IParameterValueGroup CreateParameters ()
        {
            return new DatumShiftParameters ();
        }

        public override ICoordinate Transform (ICoordinate point)
        {
            return InternalTransform (point, false);
        }


        public override ICoordinate TransformInverse (ICoordinate point)
        {
            return InternalTransform (point, true);
        }

        protected virtual ICoordinate InternalTransform (ICoordinate sourceCoord, bool inverse)
        {
            var ppppm = inverse ? Parameters.Ppm * -1.0 : Parameters.Ppm;
            var m = 1.0 + ppppm * (Math.Pow (10.0, -6.0));

            var sourceMatrix = InitSourceCoordMatrix (sourceCoord);
            var translationVectorMatrix = InitTranslationVectorMatrix (inverse);
            var rotationMatrix = InitRotationMatrix (inverse);
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

        protected virtual Matrix InitTranslationVectorMatrix (bool inverse)
        {
            var matrix = new Matrix (3);
            matrix [0, 0] = inverse ? -1 * Parameters.Dx : Parameters.Dx;
            matrix [1, 0] = inverse ? -1 * Parameters.Dy : Parameters.Dy;
            matrix [2, 0] = inverse ? -1 * Parameters.Dz : Parameters.Dz;

            return matrix;
        }

        protected virtual Matrix InitRotationMatrix (bool inverse)
        {
            var eXRad = Parameters.Ex / 3600.0 * MathUtil.DEG2RAD;
            var eYRad = Parameters.Ey / 3600.0 * MathUtil.DEG2RAD;
            var eZRad = Parameters.Ez / 3600.0 * MathUtil.DEG2RAD;

            eXRad = inverse ? eXRad * -1.0 : eXRad;
            eYRad = inverse ? eYRad * -1.0 : eYRad;
            eZRad = inverse ? eZRad * -1.0 : eZRad;

            var matrix = new Matrix (3, 3);
            matrix [0, 0] = 1.0;
            matrix [0, 1] = -eZRad;
            matrix [0, 2] = eYRad;
            matrix [1, 0] = eZRad;
            matrix [1, 1] = 1.0;
            matrix [1, 2] = -eXRad;
            matrix [2, 0] = -eYRad;
            matrix [2, 1] = eXRad;
            matrix [2, 2] = 1.0;
            return matrix;
        }

        // TODO: bool inverse нужен?
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