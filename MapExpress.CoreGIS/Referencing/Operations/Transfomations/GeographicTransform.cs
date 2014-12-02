#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    public abstract class GeographicTransform : DatumTransform
    {
        protected GeographicTransform (DatumShiftParameters parameters) : this (null, null, parameters)
        {
        }

        protected GeographicTransform (IGeographicCRS sourceCRS, IGeographicCRS targetCRS, DatumShiftParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        protected GeographicTransform (IGeodeticCRS sourceCRS, IGeodeticCRS targetCRS, DatumShiftParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }

        public override ICoordinate Transform (ICoordinate point)
        {
            return Transform (point is GeographicCoordinate ? (GeographicCoordinate) point : new GeographicCoordinate (point.X, point.Y, point.Z));
        }

        public abstract GeographicCoordinate Transform (GeographicCoordinate sourceCoord);

        public override IMathTransform Inverse ()
        {
            throw new NotSupportedException ();
        }

        public override string ExportToWKT ()
        {
            throw new NotImplementedException ();
        }
    }
}