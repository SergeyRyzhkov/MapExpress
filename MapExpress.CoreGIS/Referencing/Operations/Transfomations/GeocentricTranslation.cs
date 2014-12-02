#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    // TODO: А этот класс нужен? Если да, то надо параметры обнулить и тд
    public class GeocentricTranslation : DatumTransform
    {
        public GeocentricTranslation (DatumShiftParameters parameters) : this (null, null, parameters)
        {
        }

        public GeocentricTranslation (IGeocentricCRS sourceCRS, IGeocentricCRS targetCRS, DatumShiftParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override IMathTransform Inverse ()
        {
            throw new NotSupportedException ();
        }
    }
}