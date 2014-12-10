using MapExpress.CoreGIS.Referencing;
using MapExpress.CoreGIS.Referencing.Operations;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.CoreGIS.Referencing.Operations.Transfomations;
using MapExpress.CoreGIS.Referencing.Registry;
using MapInfo.Geometry;

namespace MapExpress.Web.Wms
{
    public class Tracformer
    {
        public DPoint Geogr2Geogr (GeographicCoordinate coordinate)
        {
            var wgsGeocentTrans = new GeographicGeocentricConversion (EllipsoidRegistry.Instance.WG1984);
            var wgsGeocGeogrCoordinate = wgsGeocentTrans.Transform (coordinate);

            // ГОСТ 2008
            var toSk42Parameters = new DatumShiftParameters
            {
                Dx = 23.57,
                Dy = -140.95,
                Dz = -79.8,
                Ex = 0,
                Ey = -0.35,
                Ez = -0.79,
                Ppm = -0.22
            };


            //var datumTransform3 = new PositionVector (toSk42Parameters);
            var datumTransform3 = new CoordinateFrameRotation (toSk42Parameters);
            var sk42GeocentCoord2 = datumTransform3.TransformInverse (wgsGeocGeogrCoordinate);
            var sk42GeographCoord2 = new GeographicGeocentricConversion (EllipsoidRegistry.Instance.Krassowsky1940).TransformInverse (sk42GeocentCoord2);
            
          
            var utm = ProjectionRegistry.Instance.TransverseMercator;
            var projectionParameters = new ProjectionParameters (EllipsoidRegistry.Instance.Krassovsky1940)
                                           {
                                               ScaleFactor = 1,
                                               CentralMeridian = 30,
                                               FalseEasting = 95942.17,
                                               FalseNorthing = -6552810.0
                                           };
            utm.Parameters = projectionParameters;
            utm.InitializeConstants ();
            var projectedCoord = utm.Transform (sk42GeographCoord2);

            
            var res = new Wgs84ToPlanTransformer ().ToLocal (coordinate.Lon, coordinate.Lat);

            return new DPoint (projectedCoord.X, projectedCoord.Y);

            //return new DPoint (projectedCoord.X, projectedCoord.Y);
        }
    }
}