using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class Eckert2 : Projection
    {
        private const double FXC = 0.46065886596178063902;
        private const double FYC = 1.44720250911653531871;
        private const double C13 = 0.33333333333333333333;
        private const double ONEEPS = 1.0000001;

        public Eckert2 (ProjectionParameters parameters) : base (parameters)
        {
        }

        public Eckert2 (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            double y;
            var x = FXC * MathUtil.DegToRad (geographCoordinate.X) * (y = Math.Sqrt (4.0 - 3.0 * Math.Sin (Math.Abs (MathUtil.DegToRad (geographCoordinate.Y)))));
            y = FYC * (2.0 - y);
            if (MathUtil.DegToRad (geographCoordinate.Y) < 0.0)
                y = -y;
            return new Coordinate (x, y);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double y;
            var x = projectedCordinate.X / (FXC * (y = 2.0 - Math.Abs (projectedCordinate.Y) / FYC));
            y = (4.0 - y * y) * C13;
            if (Math.Abs (y) >= 1.0)
            {
                if (Math.Abs (y) > ONEEPS)
                    throw new CoordinateOperationException ("I");
                y = y < 0.0 ? -MathUtil.PiHalf : MathUtil.PiHalf;
            }
            else
                y = Math.Asin (y);
            if (projectedCordinate.Y < 0)
                y = -y;
            return new GeographicCoordinate (MathUtil.Rad2Deg (x), MathUtil.Rad2Deg (y));
        }
    }
}