﻿using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Utils;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    // TODO: Везде вроде надо вставить для Eckert... фалсеистинг, фалсенорд
    public class Eckert1 : Projection
    {
        private const double FC = .92131773192356127802;
        private const double RP = .31830988618379067154;

        public Eckert1 (ProjectionParameters parameters) : base (parameters)
        {
        }

        public Eckert1 (IGeographicCRS sourceCRS, IProjectedCRS targetCRS, ProjectionParameters parameters) : base (sourceCRS, targetCRS, parameters)
        {
        }


        public override ICoordinate Project (GeographicCoordinate geographCoordinate)
        {
            var x = FC * MathUtil.DegToRad (geographCoordinate.X) * (1.0 - RP * Math.Abs (MathUtil.DegToRad (geographCoordinate.Y)));
            var y = FC * MathUtil.DegToRad (geographCoordinate.Y);
            return new Coordinate (x, y);
        }

        public override GeographicCoordinate ProjectInverse (ICoordinate projectedCordinate)
        {
            double lat = projectedCordinate.Y / FC;
            double lon = projectedCordinate.X / (FC * (1.0 - RP * Math.Abs (lat)));
            return new GeographicCoordinate (MathUtil.Rad2Deg (lon), MathUtil.Rad2Deg (lat));
        }
    }
}