#region

using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.Datums
{
    public class VerticalDatum : Datum, IVerticalDatum
    {
        public VerticalDatum (VerticalDatumType type)
        {
            VerticalDatumType = type;
        }

        public VerticalDatum (string name, VerticalDatumType type) : base (name)
        {
            VerticalDatumType = type;
        }

        public VerticalDatumType VerticalDatumType { get; set; }
    }
}