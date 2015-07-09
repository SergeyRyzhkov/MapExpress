#region

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    public class DerivedCRS : SingleCRS, IDerivedCRS
    {
        public DerivedCRS (ICoordinateSystem coordinateSystem, ICoordinateReferenceSystem baseCRS, IConversion conversionFromBase) : this (null, coordinateSystem, baseCRS, conversionFromBase)
        {
        }

        public DerivedCRS (string name, ICoordinateSystem coordinateSystem, ICoordinateReferenceSystem baseCRS, IConversion conversionFromBase) : base (name, coordinateSystem)
        {
            BaseCRS = baseCRS;
            ConversionFromBase = conversionFromBase;
        }

        #region IDerivedCRS Members

        public ICoordinateReferenceSystem BaseCRS { get; set; }

        public IConversion ConversionFromBase { get; set; }

        #endregion
    }
}