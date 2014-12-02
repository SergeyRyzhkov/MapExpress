#region

using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    // TODO: Статический метод для создания из WKT и т.д.
    // // TODO: Сделать fromWKT, fromESRI  
    public class GeodeticCRS : SingleCRS, IGeodeticCRS
    {
        private IGeodeticDatum datum;
        private DatumShiftParameters toWGS84Parameters = DatumShiftParameters.ZERO;

        public GeodeticCRS ()
        {
        }

        public GeodeticCRS (ICoordinateSystem coordinateSystem, IGeodeticDatum datum) : base (coordinateSystem)
        {
            base.Datum = datum;
            Datum = datum;
        }


        public GeodeticCRS (string name, ICoordinateSystem coordinateSystem, IGeodeticDatum datum) : base (name, coordinateSystem)
        {
            base.Datum = datum;
            Datum = datum;
        }

        public DatumShiftParameters ToWGS84
        {
            get { return Datum as GeodeticDatum != null ? ((GeodeticDatum) Datum).ToWGS84 : toWGS84Parameters; }
            set
            {
                if (Datum as GeodeticDatum != null)
                {
                    ((GeodeticDatum) Datum).ToWGS84 = value;
                }
                toWGS84Parameters = value;
            }
        }

        public new IGeodeticDatum Datum
        {
            get { return datum; }
            set
            {
                datum = value;
                base.Datum = value;
            }
        }

        public bool Equals (IGeodeticCRS other)
        {
            if (ReferenceEquals (null, other)) return false;
            if (ReferenceEquals (this, other)) return true;
            var result = Equals (other.Datum, datum);
            var gcs = other as GeodeticCRS;
            if (gcs != null)
            {
                return gcs.ToWGS84.Equals (ToWGS84) && result;
            }
            return result;
        }

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (ReferenceEquals (this, obj)) return true;
            if (!(obj is IGeodeticCRS))
            {
                return false;
            }
            return Equals (obj as IGeodeticCRS);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                int result = base.GetHashCode ();
                result = (result * 397) ^ (ToWGS84 != null ? ToWGS84.GetHashCode () : 0);
                result = (result * 397) ^ (Datum != null ? Datum.GetHashCode () : 0);
                return result;
            }
        }

        public static bool operator == (GeodeticCRS left, GeodeticCRS right)
        {
            return Equals (left, right);
        }

        public static bool operator != (GeodeticCRS left, GeodeticCRS right)
        {
            return !Equals (left, right);
        }
    }
}