#region

using System;
using MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    public class PositionVector : DatumTransform
    {
        public PositionVector (DatumShiftParameters parameters) : this (null, null, parameters)
        {
        }

        public PositionVector (GeocentricCRS sourceCRS, GeocentricCRS targetCRS, DatumShiftParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        // TODO: А почему нет? Надо проверить. См. ГОСТ пункт 4.4
        public override IMathTransform Inverse ()
        {
            throw new NotImplementedException ();
        }
    }
}