#region

using System;
using System.Globalization;
using MapExpress.CoreGIS.Referencing.Units;
using MapExpress.OpenGIS.GeoAPI;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS
{
    //TODO: Везде надо сделать первым lat - широту

    public struct GeographicCoordinate : ICoordinate
    {
        public static GeographicCoordinate Empty;

        public GeographicCoordinate (ICoordinate coordinate) : this (coordinate.X, coordinate.Y, coordinate.Z)
        {
        }

        public GeographicCoordinate (double lon, double lat) : this (lon, lat, 0)
        {
        }

        public GeographicCoordinate (double lon, double lat, double ellipsoidalH) : this ()
        {
            Lon = lon;
            Lat = lat;
            EllipsoidalH = ellipsoidalH;
        }

        public double Lon { get; set; }

        public double Lat { get; set; }

        public double EllipsoidalH { get; set; }

        public AngularUnit AngularUnit { get; set; }

        #region ICoordinate Members

        public double X
        {
            get { return Lon; }
            set { Lon = value; }
        }

        public double Y
        {
            get { return Lat; }
            set { Lat = value; }
        }

        public double Z
        {
            get { return EllipsoidalH; }
            set { EllipsoidalH = value; }
        }

        public bool Equals (ICoordinate other)
        {
            return other.X.Equals (Lon) && other.Y.Equals (Lat) && other.Z.Equals (EllipsoidalH);
        }

        public object Clone ()
        {
            return new GeographicCoordinate (Lon, Lat, EllipsoidalH);
        }

        #endregion

        public GeographicCoordinate ToRadian ()
        {
            return new GeographicCoordinate (MathUtil.DegToRad (Lon), MathUtil.DegToRad (Lat), EllipsoidalH);
        }

        public GeographicCoordinate ToDegree ()
        {
            return new GeographicCoordinate (MathUtil.Rad2Deg (Lon), MathUtil.Rad2Deg (Lat), EllipsoidalH);
        }

        public GeographicCoordinate Round (int digits)
        {
            Lon = Math.Round (Lon, digits);
            Lat = Math.Round (Lat, digits);
            return this;
        }


        public static GeographicCoordinate FromDMS (double longDegrees, double longMinutes, double longSeconds,
                                                    double latDegrees, double latMinutes, double latSeconds)
        {
            return new GeographicCoordinate (longDegrees + longMinutes / 60 + longSeconds / 3600,
                                             latDegrees + latMinutes / 60 + latSeconds / 3600);
        }

        public static GeographicCoordinate FromString (string lonString, string latString)
        {
            var result = Empty;
            if (!string.IsNullOrEmpty (lonString))
            {
                result.Lon = LonFromString (lonString);
                result.Lat = LatFromString (latString);
            }
            return result;
        }

        public static double LonFromString (string lonString)
        {
            return LonOrLatFromString (lonString);
        }

        public static double LatFromString (string latString)
        {
            return LonOrLatFromString (latString);
        }

        // TODO: Сделать чтобы можно было необяхательно задавать S или W То есть если нет, брать по умолчанию знак + 
        private static double LonOrLatFromString (string lonOrLatString)
        {
            var result = 0.0;
            if (!string.IsNullOrEmpty (lonOrLatString))
            {
                var pointParts = lonOrLatString.Split (' ');
                if (pointParts.Length == 4)
                {
                    var degreePart = pointParts [0];
                    var minutePart = pointParts [1];
                    var secondsPart = pointParts [2];
                    var lastChar = pointParts [3];

                    double degreePartD;
                    double minutePartD;
                    double secondsPartD;
                    double.TryParse (degreePart, NumberStyles.Number, CultureInfo.InvariantCulture, out degreePartD);
                    double.TryParse (minutePart, NumberStyles.Number, CultureInfo.InvariantCulture, out minutePartD);
                    double.TryParse (secondsPart, NumberStyles.Number, CultureInfo.InvariantCulture, out secondsPartD);

                    result = degreePartD + minutePartD / 60.0 + secondsPartD / 3600.0;
                    result = lastChar.Trim ().ToUpper ().Equals ("S") ? result * -1 : result;
                    result = lastChar.Trim ().ToUpper ().Equals ("W") ? result * -1 : result;
                }
            }
            return result;
        }

        public bool Equals (GeographicCoordinate other)
        {
            return other.Lon.Equals (Lon) && other.Lat.Equals (Lat) && other.EllipsoidalH.Equals (EllipsoidalH);
        }

        public override string ToString ()
        {
            return string.Format ("Lon: {0}, Lat: {1}, EllipsoidalH: {2}", Lon, Lat, EllipsoidalH);
        }

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            return obj is GeographicCoordinate && Equals ((GeographicCoordinate) obj);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                var result = Lon.GetHashCode ();
                result = (result * 397) ^ Lat.GetHashCode ();
                result = (result * 397) ^ EllipsoidalH.GetHashCode ();
                return result;
            }
        }
    }
}