#region

using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.Datums
{
    public class GeodeticDatum : Datum, IGeodeticDatum
    {
        private DatumShiftParameters toWGS84;

        public GeodeticDatum (IEllipsoid ellipsoid, IPrimeMeridian primeMeridian) : base (ellipsoid, primeMeridian)
        {
        }

        public GeodeticDatum (string name, IEllipsoid ellipsoid, IPrimeMeridian primeMeridian) : base (name, ellipsoid, primeMeridian)
        {
        }

        public GeodeticDatum ()
        {
        }


        public DatumShiftParameters ToWGS84
        {
            get { return toWGS84 ?? DatumShiftParameters.ZERO; }
            set { toWGS84 = value; }
        }
    }
}