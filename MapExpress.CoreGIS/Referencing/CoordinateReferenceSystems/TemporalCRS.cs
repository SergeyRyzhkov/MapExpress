#region

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    public class TemporalCRS : SingleCRS, ITemporalCRS
    {
        public TemporalCRS (ITimeCS coordinateSystem, ITemporalDatum datum) : base (coordinateSystem)
        {
            Datum = datum;
            CoordinateSystem = coordinateSystem;
        }

        public TemporalCRS (string name, ITimeCS coordinateSystem, ITemporalDatum datum) : base (name, coordinateSystem)
        {
            Datum = datum;
            CoordinateSystem = coordinateSystem;
        }

        public new ITimeCS CoordinateSystem { get; set; }


        public new ITemporalDatum Datum { get; set; }
    }
}