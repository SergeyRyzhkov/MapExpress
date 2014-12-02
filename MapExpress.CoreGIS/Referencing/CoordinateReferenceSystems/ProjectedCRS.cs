#region

using MapExpress.CoreGIS.Referencing.Units;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    // TODO: Сделать fromWKT, fromESRI, fromProj4  
    public class ProjectedCRS : DerivedCRS, IProjectedCRS
    {
        private IGeographicCRS baseCRS;
        private ILinearUnit linearUnit;

        public ProjectedCRS (string name, ICartesianCS coordinateSystem, IGeographicCRS baseCRS, IProjection projection) : base (name, coordinateSystem, baseCRS, projection)
        {
            ConversionFromBase = projection;
            CoordinateSystem = coordinateSystem;
            this.baseCRS = baseCRS;
        }

        #region IProjectedCRS Members

        public new ILinearUnit Unit
        {
            get { return linearUnit ?? LinearUnit.Meter; }
            set
            {
                linearUnit = value;
                base.Unit = value;
            }
        }

        public new IGeographicCRS BaseCRS
        {
            get { return baseCRS; }
            set
            {
                baseCRS = value;
                base.BaseCRS = value;
            }
        }

        public new IProjection ConversionFromBase { get; set; }

        public new ICartesianCS CoordinateSystem { get; set; }

        public new IGeodeticDatum Datum
        {
            get { return BaseCRS != null ? BaseCRS.Datum : null; }
        }

        #endregion
    }
}