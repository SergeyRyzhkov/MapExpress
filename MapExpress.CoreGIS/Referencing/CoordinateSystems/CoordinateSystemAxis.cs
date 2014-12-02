#region

using MapExpress.CoreGIS.Referencing.Converters;
using MapExpress.CoreGIS.Referencing.Units;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateSystems
{
    public class CoordinateSystemAxis : ICoordinateSystemAxis
    {
        public static ICoordinateSystemAxis Easting = new CoordinateSystemAxis ("X", AxisDirectionType.EAST, LinearUnit.Meter);

        public static ICoordinateSystemAxis Northing = new CoordinateSystemAxis ("Y", AxisDirectionType.NORTH, LinearUnit.Meter);

        public static ICoordinateSystemAxis GeocentricX = new CoordinateSystemAxis ("Geocentric X", AxisDirectionType.GEOCENTRIC_X, LinearUnit.Meter);

        public static ICoordinateSystemAxis GeocentricY = new CoordinateSystemAxis ("Geocentric Y", AxisDirectionType.GEOCENTRIC_Y, LinearUnit.Meter);

        public static ICoordinateSystemAxis GeocentricZ = new CoordinateSystemAxis ("Geocentric Z", AxisDirectionType.GEOCENTRIC_Z, LinearUnit.Meter);

        public static ICoordinateSystemAxis OriginDistance = new CoordinateSystemAxis (AxisDirectionType.GEOCENTRIC_X, LinearUnit.Meter);

        public static ICoordinateSystemAxis EllipsoidalHeight = new CoordinateSystemAxis (AxisDirectionType.GEOCENTRIC_X, LinearUnit.Meter);

        public static ICoordinateSystemAxis Lon = new CoordinateSystemAxis ("Geodetic longitude", AxisDirectionType.EAST, AngularUnit.Degree);

        public static ICoordinateSystemAxis Lat = new CoordinateSystemAxis ("Geodetic latitude", AxisDirectionType.NORTH, AngularUnit.Degree);

        public static ICoordinateSystemAxis Future = new CoordinateSystemAxis (AxisDirectionType.FUTURE, TimeUnit.Second);

        public static ICoordinateSystemAxis Depth = new CoordinateSystemAxis (AxisDirectionType.DOWN, LinearUnit.Meter);

        public static ICoordinateSystemAxis Row = new CoordinateSystemAxis (AxisDirectionType.ROW_POSITIVE, Units.Unit.Unitless);

        public static ICoordinateSystemAxis Column = new CoordinateSystemAxis (AxisDirectionType.ROW_POSITIVE, Units.Unit.Unitless);

        public CoordinateSystemAxis ()
        {
        }

        public CoordinateSystemAxis (AxisDirectionType direction, IUnit unit)
        {
            Direction = direction;
            Unit = unit;
        }

        public CoordinateSystemAxis (string abbreviation, AxisDirectionType direction, IUnit unit)
        {
            Abbreviation = abbreviation;
            Direction = direction;
            Unit = unit;
        }

        #region ICoordinateSystemAxis Members

        public string Abbreviation { get; set; }

        public AxisDirectionType Direction { get; set; }

        public double MinimumValue { get; set; }

        public double MaximumValue { get; set; }

        public IUnit Unit { get; set; }

        public string ExportToWKT ()
        {
            return WKTCoordinateSystemWriter.Instance.WriteAxis (this);
        }

        public bool Equals (ICoordinateSystemAxis other)
        {
            if (ReferenceEquals (null, other)) return false;
            if (ReferenceEquals (this, other)) return true;
            return Equals (other.Abbreviation, Abbreviation) && Equals (other.Direction, Direction) && other.MinimumValue.Equals (MinimumValue) && other.MaximumValue.Equals (MaximumValue) && Equals (other.Unit, Unit);
        }

        #endregion

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (ReferenceEquals (this, obj)) return true;
            if (!(obj is ICoordinateSystemAxis))
            {
                return false;
            }
            return Equals ((ICoordinateSystemAxis) obj);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                int result = (Abbreviation != null ? Abbreviation.GetHashCode () : 0);
                result = (result * 397) ^ Direction.GetHashCode ();
                result = (result * 397) ^ MinimumValue.GetHashCode ();
                result = (result * 397) ^ MaximumValue.GetHashCode ();
                result = (result * 397) ^ (Unit != null ? Unit.GetHashCode () : 0);
                return result;
            }
        }

        public override string ToString ()
        {
            return ExportToWKT ();
        }
    }
}