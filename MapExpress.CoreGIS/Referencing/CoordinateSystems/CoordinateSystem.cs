#region

using System.Collections.Generic;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateSystems
{
    public class CoordinateSystem : ICoordinateSystem
    {
        private IList <ICoordinateSystemAxis> axisList = new List <ICoordinateSystemAxis> ();

        public CoordinateSystem (IEnumerable <ICoordinateSystemAxis> axis, string name)
        {
            Name = name;
            foreach (var iterAxis in axis)
            {
                axisList.Add (iterAxis);
            }
        }

        public IUnit Unit { get; set; }

        public string Name { get; set; }

        public int Dimension
        {
            get { return axisList.Count; }
        }

        public IList <ICoordinateSystemAxis> AxisList { get; set; }

        public ICoordinateSystemAxis Axis (int dimension)
        {
            return axisList [dimension];
        }

        public bool Equals (ICoordinateSystem other)
        {
            if (ReferenceEquals (null, other)) return false;
            if (ReferenceEquals (this, other)) return true;
            return Equals (other.Name, Name) && Equals (other.AxisList, AxisList);
        }

        public override bool Equals (object obj)
        {
            if (ReferenceEquals (null, obj)) return false;
            if (ReferenceEquals (this, obj)) return true;
            if (!(obj is ICoordinateSystem))
            {
                return false;
            }
            return Equals ((ICoordinateSystem) obj);
        }

        public override int GetHashCode ()
        {
            unchecked
            {
                int result = (Name != null ? Name.GetHashCode () : 0);
                result = (result * 397) ^ (Unit != null ? Unit.GetHashCode () : 0);
                result = (result * 397) ^ (AxisList != null ? AxisList.GetHashCode () : 0);
                return result;
            }
        }
    }
}