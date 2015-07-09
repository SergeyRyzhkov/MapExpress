#region

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    public class VerticalCRS : SingleCRS, IVerticalCRS
    {
        public VerticalCRS (IVerticalCS coordinateSystem, IVerticalDatum datum) : base (coordinateSystem)
        {
            CoordinateSystem = coordinateSystem;
            Datum = datum;
            base.Datum = datum;
        }

        public VerticalCRS (string name, IVerticalCS coordinateSystem, IVerticalDatum datum) : base (name, coordinateSystem)
        {
            CoordinateSystem = coordinateSystem;
            Datum = datum;
            base.Datum = datum;
        }

        public new IVerticalCS CoordinateSystem { get; set; }

        public new IVerticalDatum Datum { get; set; }
    }
}