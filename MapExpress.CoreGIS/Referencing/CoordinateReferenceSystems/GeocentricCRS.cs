#region

using MapExpress.CoreGIS.Referencing.Units;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    public class GeocentricCRS : GeodeticCRS, IGeocentricCRS
    {
        private LinearUnit linearUnit;

        public GeocentricCRS (ICoordinateSystem coordinateSystem, IGeodeticDatum datum) : base (coordinateSystem, datum)
        {
        }

        public GeocentricCRS (string name, ICoordinateSystem coordinateSystem, IGeodeticDatum datum) : base (name, coordinateSystem, datum)
        {
        }

        public new LinearUnit Unit
        {
            get { return linearUnit ?? LinearUnit.Meter; }
            set
            {
                linearUnit = value;
                base.Unit = value;
            }
        }
    }
}