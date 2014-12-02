#region

using System.Collections.Generic;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems
{
    public class CompoundCRS : CoordinateReferenceSystem, ICompoundCRS
    {
        public CompoundCRS ()
        {
        }

        public CompoundCRS (string name) : base (name)
        {
        }

        public CompoundCRS (string name, ICollection <ICoordinateReferenceSystem> components) : base (name)
        {
            Components = components;
        }

        public CompoundCRS (ICollection <ICoordinateReferenceSystem> components)
        {
            Components = components;
        }

        #region ICompoundCRS Members

        public ICollection <ICoordinateReferenceSystem> Components { get; set; }

        #endregion
    }
}