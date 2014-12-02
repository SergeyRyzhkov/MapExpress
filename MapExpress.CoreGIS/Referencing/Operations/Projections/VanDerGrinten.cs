using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public class VanDerGrinten : Projection
    {
        public VanDerGrinten (ProjectionParameters parameters) : base (parameters)
        {
        }

        public VanDerGrinten (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var lon = MathUtil.DegToRad (geographCoordinate.X);
            var lat = MathUtil.DegToRad (geographCoordinate.Y);

            var dlon = AdjustLon (lon - MathUtil.DegToRad (Parameters.CentralMeridian));
            double y;

            //if (Math.Abs (lat) <= EPSLN)
            //{
            //    x = Parameters.FalseEasting + Parameters.SemiMajor * dlon;
            //    y = Parameters.FalseNorthing;
            //}
            var theta = Asinz (2 * Math.Abs (lat / Math.PI));
            //if ((Math.Abs (dlon) <= EPSLN) || (Math.Abs (Math.Abs (lat) - MathUtil.PiHalf) <= EPSLN))
            //{
            //    x = Parameters.FalseEasting;
            //    if (lat >= 0)
            //    {
            //        y = Parameters.FalseNorthing + Math.PI * Parameters.SemiMajor * Math.Tan (0.5 * theta);
            //    }
            //    else
            //    {
            //        y = Parameters.FalseNorthing + Math.PI * Parameters.SemiMajor * -Math.Tan (0.5 * theta);
            //    }
            //}
            var al = 0.5 * Math.Abs ((Math.PI / dlon) - (dlon / Math.PI));
            var asq = al * al;
            var sinth = Math.Sin (theta);
            var costh = Math.Cos (theta);

            var g = costh / (sinth + costh - 1);
            var gsq = g * g;
            var m = g * (2 / sinth - 1);
            var msq = m * m;
            var con = Math.PI * Parameters.SemiMajor * (al * (g - msq) + Math.Sqrt (asq * (g - msq) * (g - msq) - (msq + asq) * (gsq - msq))) / (msq + asq);
            if (dlon < 0)
            {
                con = -con;
            }
            var x = Parameters.FalseEasting + con;
            var q = asq + g;
            con = Math.PI * Parameters.SemiMajor * (m * q - al * Math.Sqrt ((msq + asq) * (asq + 1) - q * q)) / (msq + asq);
            if (lat >= 0)
            {
                y = Parameters.FalseNorthing + con;
            }
            else
            {
                y = Parameters.FalseNorthing - con;
            }
            return new Coordinate (x, y);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double lat;
            var px = projectedCordinate.X - Parameters.FalseEasting;
            var py = projectedCordinate.Y - Parameters.FalseNorthing;
            var con = Math.PI * Parameters.SemiMajor;
            var xx = px / con;
            var yy = py / con;
            var xys = xx * xx + yy * yy;
            var c1 = -Math.Abs (yy) * (1 + xys);
            var c2 = c1 - 2 * yy * yy + xx * xx;
            var c3 = -2 * c1 + 1 + 2 * yy * yy + xys * xys;
            var d = yy * yy / c3 + (2 * c2 * c2 * c2 / c3 / c3 / c3 - 9 * c1 * c2 / c3 / c3) / 27;
            var a1 = (c1 - c2 * c2 / 3 / c3) / c3;
            var m1 = 2 * Math.Sqrt (-a1 / 3);
            con = ((3 * d) / a1) / m1;
            if (Math.Abs (con) > 1)
            {
                if (con >= 0)
                {
                    con = 1;
                }
                else
                {
                    con = -1;
                }
            }
            var th1 = Math.Acos (con) / 3;
            if (py >= 0)
            {
                lat = (-m1 * Math.Cos (th1 + Math.PI / 3) - c2 / 3 / c3) * Math.PI;
            }
            else
            {
                lat = -(-m1 * Math.Cos (th1 + Math.PI / 3) - c2 / 3 / c3) * Math.PI;
            }
            var lon = Math.Abs (xx) < EPSLN ? MathUtil.DegToRad (Parameters.CentralMeridian) : AdjustLon (MathUtil.DegToRad (Parameters.CentralMeridian) + Math.PI * (xys - 1 + Math.Sqrt (1 + 2 * (xx * xx - yy * yy) + xys * xys)) / 2 / xx);
            return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
        }
    }
}