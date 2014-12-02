namespace MapExpress.CoreGIS.Geometries.Converters
{
    public enum WKBGeometryType : uint
    {
        WKBPoint = 1,

        WKBLineString = 2,

        WKBPolygon = 3,

        WKBMultiPoint = 4,

        WKBMultiLineString = 5,

        WKBMultiPolygon = 6,

        WKBGeometryCollection = 7,

        WKBPointZ = 1001,

        WKBLineStringZ = 1002,

        WKBPolygonZ = 1003,

        WKBMultiPointZ = 1004,

        WKBMultiLineStringZ = 1005,

        WKBMultiPolygonZ = 1006,

        WKBGeometryCollectionZ = 1007,

        WKBPointM = 2001,

        WKBLineStringM = 2002,

        WKBPolygonM = 2003,

        WKBMultiPointM = 2004,

        WKBMultiLineStringM = 2005,

        WKBMultiPolygonM = 2006,

        WKBGeometryCollectionM = 2007,

        WKBPointZM = 3001,

        WKBLineStringZM = 3002,

        WKBPolygonZM = 3003,

        WKBMultiPointZM = 3004,

        WKBMultiLineStringZM = 3005,

        WKBMultiPolygonZM = 3006,

        WKBGeometryCollectionZM = 3007
    }
}