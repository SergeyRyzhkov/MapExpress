#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    // TODO: Сделать реализовать фабрику  ICoordinateOperationFactory 
    //var ctfac = new CoordinateTransformationFactory();
    //           var transformation = ctfac.CreateFromCoordinateSystems(mercator, latlon);
    //           var transform = transformation;
    //           var converted = transform.MathTransform.Transform(values);

    public abstract class Transformation : SingleCoordinateOperation, ITransformation
    {
        protected Transformation (DatumShiftParameters parameters) : this (null, null, parameters)
        {
        }

        protected Transformation (IGeodeticCRS sourceCRS, IGeodeticCRS targetCRS, DatumShiftParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }

        #region ITransformation Members

        public override string ExportToWKT ()
        {
            throw new NotImplementedException ();
        }

        #endregion
    }
}