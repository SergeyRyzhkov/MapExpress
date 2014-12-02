namespace MapExpress.CoreGIS.Referencing.Operations.Projections
{
    public static class MercatorGridZoneLocator
    {
        // TODO: Переименовать наименования методов
        public static int ZoneNumber (double lon, double zoneInitialMeridian, double zoneWidth)
        {
            lon = lon < 0.0 ? (lon + 360.0) : lon;
            var zoneNmb = (int) ((lon + zoneInitialMeridian + zoneWidth) / zoneWidth);

            return zoneNmb > 360.0 / zoneWidth ? zoneNmb - (int) (360.0 / zoneWidth) : zoneNmb;
        }

        public static double ZoneCentralMeridian (int zone, double zoneInitialMeridian, double zoneWidth)
        {
            return (zone * zoneWidth) - (zoneInitialMeridian + (zoneWidth / 2.0));
        }


        public static int UTMZoneNumber (double lon)
        {
            return ZoneNumber (lon, 180.0, 6.0);
        }

        public static int GaussKrugerZoneNumber (double lon)
        {
            return ZoneNumber (lon, 0.0, 6.0);
        }

        public static double UTMZoneCentralMeridian (int zone)
        {
            return ZoneCentralMeridian (zone, 180.0, 6.0);
        }

        public static double GaussKrugerCentralMeridian (int zone)
        {
            return ZoneCentralMeridian (zone, 0.0, 6.0);
        }

        public static double GaussKrugerCentralMeridian (int zone, double zoneWidth)
        {
            return ZoneCentralMeridian (zone, 0.0, zoneWidth);
        }
    }
}