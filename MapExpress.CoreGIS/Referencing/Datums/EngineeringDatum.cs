﻿#region

using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.Datums
{
    public class EngineeringDatum : Datum, IEngineeringDatum
    {
        public EngineeringDatum (string name) : base (name)
        {
        }

        public EngineeringDatum ()
        {
        }
    }
}