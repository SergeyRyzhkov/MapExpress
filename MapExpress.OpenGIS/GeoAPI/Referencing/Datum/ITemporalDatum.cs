#region

using System;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.Datum
{
    public interface ITemporalDatum : IDatum
    {
        DateTime Origin { get; }

        DateTime RealizationEpoch { get; }
    }
}