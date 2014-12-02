#region

using System;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.Datums
{
    public class TemporalDatum : Datum, ITemporalDatum
    {
        public TemporalDatum (DateTime origin)
        {
            Origin = origin;
        }

        public TemporalDatum (string name, DateTime origin) : base (name)
        {
            Origin = origin;
        }

        public DateTime Origin { get; set; }

        public DateTime RealizationEpoch { get; set; }
    }
}