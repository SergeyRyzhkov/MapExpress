#region

using System;
using MapExpress.OpenGIS.GeoAPI;
using MapExpress.OpenGIS.GeoAPI.Referencing;

#endregion

namespace MapExpress.CoreGIS
{
    //TODO: Может геоцентрик или картезиан ?
    // Или GeographicCoordinate убрать и сделать все в одном классе
    public struct Coordinate : ICoordinate
    {
        public static ICoordinate NullCoordinate = new Coordinate (double.NaN, double.NaN, double.NaN);

        public Coordinate (double x, double y) : this (x, y, 0)
        {
        }

        public Coordinate (double x, double y, double z) : this ()
        {
            X = x;
            Y = y;
            Z = z;
        }

        #region ICoordinate Members

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public bool Equals (ICoordinate other)
        {
            return other.X.Equals (X) && other.Y.Equals (Y) && other.Z.Equals (Z);
        }

        public object Clone ()
        {
            return new Coordinate (X, Y, Z);
        }

        #endregion

        public ICoordinate Round (int digits)
        {
            X = Math.Round (X, digits);
            Y = Math.Round (Y, digits);
            Z = Math.Round (Z, digits);
            return this;
        }


        public override string ToString ()
        {
            return string.Format ("X: {0}, Y: {1}, Z: {2}", X, Y, Z);
        }

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (obj.GetType () != typeof (Coordinate)) return false;
            return Equals ((Coordinate) obj);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                var result = X.GetHashCode ();
                result = (result * 397) ^ Y.GetHashCode ();
                result = (result * 397) ^ Z.GetHashCode ();
                return result;
            }
        }
    }
}