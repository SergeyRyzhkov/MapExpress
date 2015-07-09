#region

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    public abstract class SingleCRS : CoordinateReferenceSystem, ISingleCRS
    {
        protected SingleCRS (ICoordinateSystem coordinateSystem) : base (coordinateSystem)
        {
        }

        protected SingleCRS (string name, ICoordinateSystem coordinateSystem) : base (name, coordinateSystem)
        {
        }

        protected SingleCRS ()
        {
        }

        #region ISingleCRS Members

        public IDatum Datum { get; set; }

        #endregion
    }
}