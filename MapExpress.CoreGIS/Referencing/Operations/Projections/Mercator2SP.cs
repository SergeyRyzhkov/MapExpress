#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using nRsn.Core.Util;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class Mercator2SP : Mercator1SP
    {
        public Mercator2SP (ProjectionParameters parameters) : base (parameters)
        {
        }

        public Mercator2SP (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }

        protected override double CorrectScaleFactor ()
        {
            var stPar1Radian = MathUtil.DegToRad (Parameters.StandardParallel1);
            return Math.Cos (stPar1Radian) / Math.Pow (1 - Parameters.Ellipsoid.EccentricitySquared * Math.Pow (Math.Sin (stPar1Radian), 2), 0.5);
        }
    }
}