#region

#endregion

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    public class EngineeringCRS : SingleCRS, IEngineeringCRS
    {
        public EngineeringCRS (ICoordinateSystem coordinateSystem, IEngineeringDatum datum) : base (coordinateSystem)
        {
            base.Datum = datum;
            Datum = datum;
        }


        public EngineeringCRS (string name, ICoordinateSystem coordinateSystem, IEngineeringDatum datum) : base (name, coordinateSystem)
        {
            base.Datum = datum;
            Datum = datum;
        }

        public new IEngineeringDatum Datum { get; set; }
    }
}