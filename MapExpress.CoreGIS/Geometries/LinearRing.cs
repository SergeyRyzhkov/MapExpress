#region

using System.Collections.Generic;
using System.Linq;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Geometries
{
    public class LinearRing : LineString, ILinearRing
    {
        public LinearRing () : this (null)
        {
        }

        public LinearRing (ICoordinateReferenceSystem coordSys, IEnumerable <IPoint> vertices) : base (coordSys, vertices)
        {
        }

        public LinearRing (ICoordinateReferenceSystem coordSys) : base (coordSys)
        {
        }

        public LinearRing (ICoordinateReferenceSystem coordSys, IEnumerable <ICoordinate> points) : base (coordSys, points)
        {
        }

        public LinearRing (ICoordinateReferenceSystem coordSys, IEnumerable <double[]> verticesXy) : base (coordSys, verticesXy)
        {
        }

        #region ILinearRing Members

        public override GeometryType GeometryType
        {
            get { return GeometryType.LineString; }
        }

        public bool IsCounterClockwise
        {
            get
            {
                int i;
                var nPts = Vertices.Count;

                if (nPts < 4)
                    return false;

                var pointsArray = Vertices.ToArray ();
                var hip = pointsArray [0];
                var hii = 0;
                for (i = 1; i < nPts; i++)
                {
                    var p = pointsArray [i];
                    if (p.Y > hip.Y)
                    {
                        hip = p;
                        hii = i;
                    }
                }
                var iPrev = hii - 1;
                if (iPrev < 0)
                    iPrev = nPts - 2;
                var iNext = hii + 1;
                if (iNext >= nPts)
                    iNext = 1;
                var prev = pointsArray [iPrev];
                var next = pointsArray [iNext];
                var prev2X = prev.X - hip.X;
                var prev2Y = prev.Y - hip.Y;
                var next2X = next.X - hip.X;
                var next2Y = next.Y - hip.Y;
                var disc = next2X * prev2Y - next2Y * prev2X;
                if (disc == 0.0)
                {
                    return (prev.X > next.X);
                }
                return (disc > 0.0);
            }
        }

        #endregion
    }
}