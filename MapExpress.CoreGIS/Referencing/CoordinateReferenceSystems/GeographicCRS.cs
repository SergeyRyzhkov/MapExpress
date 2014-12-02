#region

using MapExpress.CoreGIS.Referencing.Units;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    public class GeographicCRS : GeodeticCRS, IGeographicCRS
    {
        public int AuthorityCode;
        private IAngularUnit angularUnit;

        public GeographicCRS (IEllipsoidalCS coordinateSystem, IGeodeticDatum datum) : base (coordinateSystem, datum)
        {
            CoordinateSystem = coordinateSystem;
        }

        public GeographicCRS (string name, IEllipsoidalCS coordinateSystem, IGeodeticDatum datum) : base (name, coordinateSystem, datum)
        {
            CoordinateSystem = coordinateSystem;
        }

        public GeographicCRS ()
        {
        }

        // TODO: Сделать так везде где есть public new 

        #region IGeographicCRS Members

        public new IAngularUnit Unit
        {
            get { return angularUnit ?? AngularUnit.Degree; }
            set
            {
                angularUnit = value;
                base.Unit = value;
            }
        }

        // TODO: Везде где есть new сделать через поле, в сет устанавливать base
        public new IEllipsoidalCS CoordinateSystem { get; set; }

        #endregion
    }
}