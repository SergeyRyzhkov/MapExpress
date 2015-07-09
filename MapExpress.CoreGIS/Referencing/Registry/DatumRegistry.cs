#region

using System.Collections.Generic;
using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.Registry
{
    public class DatumRegistry : AuthorityObjectRegistry <IGeodeticDatum>
    {
        private static readonly List <IGeodeticDatum> datums = new List <IGeodeticDatum> ();
        private static DatumRegistry instance;
        public IGeodeticDatum ATF = new GeodeticDatum {Name = "D_ATF", Ellipsoid = EllipsoidRegistry.Instance.Plessis1817, PrimeMeridian = PrimeMeridianRegistry.Instance.ParisRGS};
        public IGeodeticDatum ATS1977 = new GeodeticDatum {Name = "D_ATS_1977", Ellipsoid = EllipsoidRegistry.Instance.ATS1977, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum Abidjan1987 = new GeodeticDatum {Name = "Abidjan 1987", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Accra = new GeodeticDatum {Name = "Accra", Ellipsoid = EllipsoidRegistry.Instance.WarOffice, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Adindan = new GeodeticDatum {Name = "Adindan", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Afgooye = new GeodeticDatum {Name = "Afgooye", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Agadez = new GeodeticDatum {Name = "Agadez", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AinelAbd1970 = new GeodeticDatum {Name = "Ain el Abd 1970", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Airy1830 = new GeodeticDatum {Name = "D_Airy_1830", Ellipsoid = EllipsoidRegistry.Instance.Airy1830, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AiryModified = new GeodeticDatum {Name = "D_Airy_Modified", Ellipsoid = EllipsoidRegistry.Instance.AiryModified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AlaskanIslands = new GeodeticDatum {Name = "D_Alaskan_Islands", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Albanian1987 = new GeodeticDatum {Name = "Albanian 1987", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AmericanSamoa1962 = new GeodeticDatum {Name = "American Samoa 1962", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Amersfoort = new GeodeticDatum {Name = "Amersfoort", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Ammassalik1958 = new GeodeticDatum {Name = "Ammassalik 1958", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AncienneTriangulationFrancaiseParis = new GeodeticDatum {Name = "Ancienne Triangulation Francaise (Paris)", Ellipsoid = EllipsoidRegistry.Instance.Plessis1817, PrimeMeridian = PrimeMeridianRegistry.Instance.ParisRGS};
        public IGeodeticDatum Anguilla1957 = new GeodeticDatum {Name = "Anguilla 1957", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Anna11965 = new GeodeticDatum {Name = "D_Anna_1_1965", Ellipsoid = EllipsoidRegistry.Instance.Australian, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Antigua1943 = new GeodeticDatum {Name = "Antigua 1943", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Aratu = new GeodeticDatum {Name = "Aratu", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Arc1950 = new GeodeticDatum {Name = "Arc 1950", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880Arc, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Arc1960 = new GeodeticDatum {Name = "Arc 1960", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AscensionIsland1958 = new GeodeticDatum {Name = "Ascension Island 1958", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Astro1952 = new GeodeticDatum {Name = "D_Astro_1952", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Australian = new GeodeticDatum {Name = "D_Australian", Ellipsoid = EllipsoidRegistry.Instance.Australian, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Australian1966 = new GeodeticDatum {Name = "D_Australian_1966", Ellipsoid = EllipsoidRegistry.Instance.Australian, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Australian1984 = new GeodeticDatum {Name = "D_Australian_1984", Ellipsoid = EllipsoidRegistry.Instance.Australian, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AustralianAntarctic1998 = new GeodeticDatum {Name = "D_Australian_Antarctic_1998", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AustralianAntarcticGeodeticDatum1998 = new GeodeticDatum {Name = "Australian Antarctic GeodeticDatum 1998", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AustralianGeodeticGeodeticDatum1966 = new GeodeticDatum {Name = "Australian Geodetic GeodeticDatum 1966", Ellipsoid = EllipsoidRegistry.Instance.AustralianNationalSpheroid, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AustralianGeodeticGeodeticDatum1984 = new GeodeticDatum {Name = "Australian Geodetic GeodeticDatum 1984", Ellipsoid = EllipsoidRegistry.Instance.AustralianNationalSpheroid, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AutonomousRegionsofPortugal2008 = new GeodeticDatum {Name = "Autonomous Regions of Portugal 2008", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AverageTerrestrialSystem1977 = new GeodeticDatum {Name = "Average Terrestrial System 1977", Ellipsoid = EllipsoidRegistry.Instance.AverageTerrestrialSystem1977, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Ayabelle = new GeodeticDatum {Name = "D_Ayabelle", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AyabelleLighthouse = new GeodeticDatum {Name = "Ayabelle Lighthouse", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AzoresCentralIslands1948 = new GeodeticDatum {Name = "Azores Central Islands 1948", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AzoresCentralIslands1995 = new GeodeticDatum {Name = "Azores Central Islands 1995", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AzoresOccidentalIslands1939 = new GeodeticDatum {Name = "Azores Occidental Islands 1939", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AzoresOrientalIslands1940 = new GeodeticDatum {Name = "Azores Oriental Islands 1940", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum AzoresOrientalIslands1995 = new GeodeticDatum {Name = "Azores Oriental Islands 1995", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum BabSouth = new GeodeticDatum {Name = "D_Bab_South", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Barbados1938 = new GeodeticDatum {Name = "Barbados 1938", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Batavia = new GeodeticDatum {Name = "Batavia", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum BataviaJakarta = new GeodeticDatum {Name = "Batavia (Jakarta)", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Jakarta};
        public IGeodeticDatum BeaconE1945 = new GeodeticDatum {Name = "D_Beacon_E_1945", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Beduaram = new GeodeticDatum {Name = "Beduaram", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Beijing1954 = new GeodeticDatum {Name = "Beijing 1954", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Belge1950 = new GeodeticDatum {Name = "D_Belge_1950", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Belge1972 = new GeodeticDatum {Name = "D_Belge_1972", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Bellevue = new GeodeticDatum {Name = "Bellevue", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum BellevueIGN = new GeodeticDatum {Name = "D_Bellevue_IGN", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Bermuda1957 = new GeodeticDatum {Name = "Bermuda 1957", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Bermuda2000 = new GeodeticDatum {Name = "Bermuda 2000", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Bern1898 = new GeodeticDatum {Name = "D_Bern_1898", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Bern};
        public IGeodeticDatum Bern1938 = new GeodeticDatum {Name = "Bern 1938", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Bessel1841 = new GeodeticDatum {Name = "D_Bessel_1841", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum BesselModified = new GeodeticDatum {Name = "D_Bessel_Modified", Ellipsoid = EllipsoidRegistry.Instance.BesselModified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum BesselNamibia = new GeodeticDatum {Name = "D_Bessel_Namibia", Ellipsoid = EllipsoidRegistry.Instance.BesselNamibia, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum BhutanNationalGeodeticDatum = new GeodeticDatum {Name = "D_Bhutan_National_Geodetic_Datum", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum BhutanNationalGeodeticGeodeticDatum = new GeodeticDatum {Name = "Bhutan National Geodetic GeodeticDatum", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Bissau = new GeodeticDatum {Name = "Bissau", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Bogota = new GeodeticDatum {Name = "D_Bogota", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Bogota1975 = new GeodeticDatum {Name = "Bogota 1975", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Bogota1975Bogota = new GeodeticDatum {Name = "Bogota 1975 (Bogota)", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Bogota};
        public IGeodeticDatum BukitRimpah = new GeodeticDatum {Name = "Bukit Rimpah", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CH1903 = new GeodeticDatum {Name = "CH1903", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CH1903Bern = new GeodeticDatum {Name = "CH1903 (Bern)", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Bern};
        public IGeodeticDatum CH1903Plus = new GeodeticDatum {Name = "CH1903+", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CSG1967 = new GeodeticDatum {Name = "D_CSG_1967", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Cadastre1997 = new GeodeticDatum {Name = "Cadastre 1997", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Camacupa = new GeodeticDatum {Name = "Camacupa", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CampArea = new GeodeticDatum {Name = "D_Camp_Area", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CampAreaAstro = new GeodeticDatum {Name = "Camp Area Astro", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CampoInchauspe = new GeodeticDatum {Name = "Campo Inchauspe", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Canton1966 = new GeodeticDatum {Name = "D_Canton_1966", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Cape = new GeodeticDatum {Name = "Cape", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880Arc, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CapeCanaveral = new GeodeticDatum {Name = "Cape Canaveral", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Carthage = new GeodeticDatum {Name = "Carthage", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CarthageParis = new GeodeticDatum {Name = "Carthage (Paris)", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Paris};
        public IGeodeticDatum CaymanIslandsGeodeticGeodeticDatum2011 = new GeodeticDatum {Name = "Cayman Islands Geodetic GeodeticDatum 2011", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CentreSpatialGuyanais1967 = new GeodeticDatum {Name = "Centre Spatial Guyanais 1967", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ChathamIsland1971 = new GeodeticDatum {Name = "D_Chatham_Island_1971", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ChathamIslands1979 = new GeodeticDatum {Name = "D_Chatham_Islands_1979", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ChathamIslandsGeodeticDatum1971 = new GeodeticDatum {Name = "Chatham Islands GeodeticDatum 1971", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ChathamIslandsGeodeticDatum1979 = new GeodeticDatum {Name = "Chatham Islands GeodeticDatum 1979", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum China2000 = new GeodeticDatum {Name = "China 2000", Ellipsoid = EllipsoidRegistry.Instance.CGCS2000, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ChosMalal1914 = new GeodeticDatum {Name = "Chos Malal 1914", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Chua = new GeodeticDatum {Name = "Chua", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Clarke1858 = new GeodeticDatum {Name = "D_Clarke_1858", Ellipsoid = EllipsoidRegistry.Instance.Clarke1858, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Clarke1866 = new GeodeticDatum {Name = "D_Clarke_1866", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Clarke1866Michigan = new GeodeticDatum {Name = "D_Clarke_1866_Michigan", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866Michigan, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Clarke1880 = new GeodeticDatum {Name = "D_Clarke_1880", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Clarke1880Arc = new GeodeticDatum {Name = "D_Clarke_1880_Arc", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880Arc, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Clarke1880Benoit = new GeodeticDatum {Name = "D_Clarke_1880_Benoit", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880Benoit, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Clarke1880IGN = new GeodeticDatum {Name = "D_Clarke_1880_IGN", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Clarke1880RGS = new GeodeticDatum {Name = "D_Clarke_1880_RGS", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Clarke1880SGA = new GeodeticDatum {Name = "D_Clarke_1880_SGA", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880SGA, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CocosIslands1965 = new GeodeticDatum {Name = "Cocos Islands 1965", Ellipsoid = EllipsoidRegistry.Instance.AustralianNationalSpheroid, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Combani1950 = new GeodeticDatum {Name = "Combani 1950", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Conakry1905 = new GeodeticDatum {Name = "Conakry 1905", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Congo1960PointeNoire = new GeodeticDatum {Name = "Congo 1960 Pointe Noire", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CorregoAlegre = new GeodeticDatum {Name = "D_Corrego_Alegre", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CorregoAlegre1961 = new GeodeticDatum {Name = "Corrego Alegre 1961", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CorregoAlegre197072 = new GeodeticDatum {Name = "Corrego Alegre 1970-72", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CostaRica2005 = new GeodeticDatum {Name = "Costa Rica 2005", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CotedIvoire = new GeodeticDatum {Name = "D_Cote_d_Ivoire", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum CroatianTerrestrialReferenceSystem = new GeodeticDatum {Name = "Croatian Terrestrial Reference System", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum CyprusGeodeticReferenceSystem1993 = new GeodeticDatum
                                                                      {
                                                                          Name = "D_Cyprus_Geodetic_Reference_System_1993",
                                                                          Ellipsoid = EllipsoidRegistry.Instance.WGS84,
                                                                          PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich
                                                                      };

        public IGeodeticDatum D48 = new GeodeticDatum {Name = "D_D48", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum DOS1968 = new GeodeticDatum {Name = "D_DOS_1968", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum DOS714 = new GeodeticDatum {Name = "D_DOS_71_4", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Dabola1981 = new GeodeticDatum {Name = "Dabola 1981", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Datum73 = new GeodeticDatum {Name = "D_Datum_73", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum DatumGeodesiNasional1995 = new GeodeticDatum {Name = "D_Datum_Geodesi_Nasional_1995", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum DatumLisboaBessel = new GeodeticDatum {Name = "D_Datum_Lisboa_Bessel", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum DatumLisboaHayford = new GeodeticDatum {Name = "D_Datum_Lisboa_Hayford", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum DealulPiscului1930 = new GeodeticDatum {Name = "Dealul Piscului 1930", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum DealulPiscului1933 = new GeodeticDatum {Name = "D_Dealul_Piscului_1933", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum DeceptionIsland = new GeodeticDatum {Name = "Deception Island", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum DeirezZor = new GeodeticDatum {Name = "Deir ez Zor", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum DeutscheBahnReferenceSystem = new GeodeticDatum {Name = "Deutsche Bahn Reference System", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum DeutschesHauptdreiecksnetz = new GeodeticDatum {Name = "Deutsches Hauptdreiecksnetz", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum DiegoGarcia1969 = new GeodeticDatum {Name = "Diego Garcia 1969", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Dominica1945 = new GeodeticDatum {Name = "Dominica 1945", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Douala = new GeodeticDatum {Name = "D_Douala", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Douala1948 = new GeodeticDatum {Name = "Douala 1948", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum ETRF1989 = new GeodeticDatum
                                             {
                                                 Name = "D_ETRF_1989",
                                                 Ellipsoid = EllipsoidRegistry.Instance.WGS84,
                                                 PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich
                                             };

        public IGeodeticDatum ETRS1989 = new GeodeticDatum {Name = "D_ETRS_1989", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EasterIsland1967 = new GeodeticDatum {Name = "Easter Island 1967", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum Egypt1907 = new GeodeticDatum {Name = "Egypt 1907", Ellipsoid = EllipsoidRegistry.Instance.Helmert1906, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Egypt1930 = new GeodeticDatum {Name = "Egypt 1930", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EgyptGulfofSuezS650TL = new GeodeticDatum {Name = "Egypt Gulf of Suez S-650 TL", Ellipsoid = EllipsoidRegistry.Instance.Helmert1906, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Estonia1937 = new GeodeticDatum {Name = "D_Estonia_1937", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Estonia1992 = new GeodeticDatum {Name = "Estonia 1992", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Estonia1997 = new GeodeticDatum {Name = "Estonia 1997", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum European1950 = new GeodeticDatum {Name = "D_European_1950", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum European1950ED77 = new GeodeticDatum {Name = "D_European_1950_ED77", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum European1979 = new GeodeticDatum {Name = "D_European_1979", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum European1987 = new GeodeticDatum {Name = "D_European_1987", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EuropeanGeodeticDatum1950 = new GeodeticDatum {Name = "European GeodeticDatum 1950", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EuropeanGeodeticDatum19501977 = new GeodeticDatum {Name = "European GeodeticDatum 1950(1977)", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EuropeanGeodeticDatum1979 = new GeodeticDatum {Name = "European GeodeticDatum 1979", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EuropeanGeodeticDatum1987 = new GeodeticDatum {Name = "European GeodeticDatum 1987", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EuropeanLibyan1979 = new GeodeticDatum {Name = "D_European_Libyan_1979", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EuropeanLibyanGeodeticDatum1979 = new GeodeticDatum {Name = "European Libyan GeodeticDatum 1979", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EuropeanTerrestrialReferenceSystem1989 = new GeodeticDatum {Name = "European Terrestrial Reference System 1989", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Everest1830 = new GeodeticDatum {Name = "D_Everest_1830", Ellipsoid = EllipsoidRegistry.Instance.Everest1830, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EverestAdj1937 = new GeodeticDatum {Name = "D_Everest_Adj_1937", Ellipsoid = EllipsoidRegistry.Instance.EverestAdjustment1937, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EverestBangladesh = new GeodeticDatum {Name = "D_Everest_Bangladesh", Ellipsoid = EllipsoidRegistry.Instance.EverestAdjustment1937, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EverestDef1962 = new GeodeticDatum {Name = "D_Everest_Def_1962", Ellipsoid = EllipsoidRegistry.Instance.EverestDefinition1962, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EverestDef1967 = new GeodeticDatum {Name = "D_Everest_Def_1967", Ellipsoid = EllipsoidRegistry.Instance.EverestDefinition1967, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EverestDef1975 = new GeodeticDatum {Name = "D_Everest_Def_1975", Ellipsoid = EllipsoidRegistry.Instance.EverestDefinition1975, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EverestIndiaNepal = new GeodeticDatum {Name = "D_Everest_India_Nepal", Ellipsoid = EllipsoidRegistry.Instance.EverestDefinition1962, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EverestModified = new GeodeticDatum {Name = "D_Everest_Modified", Ellipsoid = EllipsoidRegistry.Instance.Everest1830Modified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum EverestModified1969 = new GeodeticDatum {Name = "D_Everest_Modified_1969", Ellipsoid = EllipsoidRegistry.Instance.EverestModified1969, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FD1958 = new GeodeticDatum {Name = "D_FD_1958", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Fahud = new GeodeticDatum {Name = "Fahud", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FaroeDatum1954 = new GeodeticDatum {Name = "D_Faroe_Datum_1954", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FaroeGeodeticDatum1954 = new GeodeticDatum {Name = "Faroe GeodeticDatum 1954", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FatuIva1972 = new GeodeticDatum {Name = "D_Fatu_Iva_1972", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FatuIva72 = new GeodeticDatum {Name = "Fatu Iva 72", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FehmarnbeltDatum2010 = new GeodeticDatum {Name = "D_Fehmarnbelt_Datum_2010", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FehmarnbeltGeodeticDatum2010 = new GeodeticDatum {Name = "Fehmarnbelt GeodeticDatum 2010", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Fiji1956 = new GeodeticDatum {Name = "Fiji 1956", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Fiji1986 = new GeodeticDatum {Name = "D_Fiji_1986", Ellipsoid = EllipsoidRegistry.Instance.WGS72, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FijiGeodeticGeodeticDatum1986 = new GeodeticDatum {Name = "Fiji Geodetic GeodeticDatum 1986", Ellipsoid = EllipsoidRegistry.Instance.WGS72, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FinalGeodeticDatum1958 = new GeodeticDatum {Name = "Final GeodeticDatum 1958", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Fischer1960 = new GeodeticDatum {Name = "D_Fischer_1960", Ellipsoid = EllipsoidRegistry.Instance.Fischer1960, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Fischer1968 = new GeodeticDatum {Name = "D_Fischer_1968", Ellipsoid = EllipsoidRegistry.Instance.Fischer1968, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FischerModified = new GeodeticDatum {Name = "D_Fischer_Modified", Ellipsoid = EllipsoidRegistry.Instance.FischerModified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FortDesaix = new GeodeticDatum {Name = "D_Fort_Desaix", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FortMarigot = new GeodeticDatum {Name = "Fort Marigot", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum FortThomas1955 = new GeodeticDatum {Name = "D_Fort_Thomas_1955", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GDA1994 = new GeodeticDatum {Name = "D_GDA_1994", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GDBD2009 = new GeodeticDatum {Name = "D_GDBD2009", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GDM2000 = new GeodeticDatum {Name = "D_GDM_2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GEM10C = new GeodeticDatum {Name = "D_GEM_10C", Ellipsoid = EllipsoidRegistry.Instance.GEM10C, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GGRS1987 = new GeodeticDatum {Name = "D_GGRS_1987", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GRS1967 = new GeodeticDatum {Name = "D_GRS_1967", Ellipsoid = EllipsoidRegistry.Instance.GRS1967, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GRS1980 = new GeodeticDatum {Name = "D_GRS_1980", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GUX1 = new GeodeticDatum {Name = "D_GUX_1", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Gan1970 = new GeodeticDatum {Name = "Gan 1970", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Garoua = new GeodeticDatum {Name = "Garoua", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GeocentricGeodeticDatumBruneiDarussalam2009 = new GeodeticDatum {Name = "Geocentric GeodeticDatum Brunei Darussalam 2009", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GeocentricGeodeticDatumofAustralia1994 = new GeodeticDatum {Name = "Geocentric GeodeticDatum of Australia 1994", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GeocentricGeodeticDatumofKorea = new GeodeticDatum {Name = "Geocentric GeodeticDatum of Korea", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GeodeticDatum73 = new GeodeticDatum {Name = "GeodeticDatum 73", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GeodeticDatumGeodesiNasional1995 = new GeodeticDatum {Name = "GeodeticDatum Geodesi Nasional 1995", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GeodeticGeodeticDatumof1965 = new GeodeticDatum {Name = "Geodetic GeodeticDatum of 1965", Ellipsoid = EllipsoidRegistry.Instance.AiryModified1849, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GeodeticGeodeticDatumofMalaysia2000 = new GeodeticDatum {Name = "Geodetic GeodeticDatum of Malaysia 2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GraciosaBaseSW1948 = new GeodeticDatum {Name = "D_Graciosa_Base_SW_1948", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GrandCayman1959 = new GeodeticDatum {Name = "D_Grand_Cayman_1959", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GrandCaymanGeodeticGeodeticDatum1959 = new GeodeticDatum {Name = "Grand Cayman Geodetic GeodeticDatum 1959", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GrandComoros = new GeodeticDatum {Name = "Grand Comoros", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Greek = new GeodeticDatum {Name = "Greek", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GreekAthens = new GeodeticDatum {Name = "Greek (Athens)", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Athens};
        public IGeodeticDatum GreekGeodeticReferenceSystem1987 = new GeodeticDatum {Name = "Greek Geodetic Reference System 1987", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Greenland1996 = new GeodeticDatum {Name = "Greenland 1996", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Grenada1953 = new GeodeticDatum {Name = "Grenada 1953", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Guadeloupe1948 = new GeodeticDatum {Name = "Guadeloupe 1948", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Guam1963 = new GeodeticDatum {Name = "Guam 1963", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Gulshan303 = new GeodeticDatum {Name = "Gulshan 303", Ellipsoid = EllipsoidRegistry.Instance.Everest18301937Adjustment, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GunungSegara = new GeodeticDatum {Name = "Gunung Segara", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum GunungSegaraJakarta = new GeodeticDatum {Name = "Gunung Segara (Jakarta)", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Jakarta};
        public IGeodeticDatum GuyaneFrancaise = new GeodeticDatum {Name = "D_Guyane_Francaise", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Hanoi1972 = new GeodeticDatum {Name = "Hanoi 1972", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum Hartebeesthoek1994 = new GeodeticDatum
                                                       {
                                                           Name = "D_Hartebeesthoek_1994",
                                                           Ellipsoid = EllipsoidRegistry.Instance.WGS84,
                                                           PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich
                                                       };

        public IGeodeticDatum Hartebeesthoek94 = new GeodeticDatum {Name = "Hartebeesthoek94", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Helle1954 = new GeodeticDatum {Name = "Helle 1954", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Helmert1906 = new GeodeticDatum {Name = "D_Helmert_1906", Ellipsoid = EllipsoidRegistry.Instance.Helmert1906, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum HeratNorth = new GeodeticDatum {Name = "Herat North", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Hermannskogel = new GeodeticDatum {Name = "D_Hermannskogel", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum HitoXVIII1963 = new GeodeticDatum {Name = "Hito XVIII 1963", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Hjorsey1955 = new GeodeticDatum {Name = "Hjorsey 1955", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum HongKong1963 = new GeodeticDatum {Name = "Hong Kong 1963", Ellipsoid = EllipsoidRegistry.Instance.Clarke1858, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum HongKong196367 = new GeodeticDatum {Name = "D_Hong_Kong_1963_67", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum HongKong1980 = new GeodeticDatum {Name = "Hong Kong 1980", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Hough1960 = new GeodeticDatum {Name = "D_Hough_1960", Ellipsoid = EllipsoidRegistry.Instance.Hough1960, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum HuTzuShan = new GeodeticDatum {Name = "D_Hu_Tzu_Shan", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum HuTzuShan1950 = new GeodeticDatum {Name = "Hu Tzu Shan 1950", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Hughes1980 = new GeodeticDatum {Name = "D_Hughes_1980", Ellipsoid = EllipsoidRegistry.Instance.Hughes1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Hungarian1972 = new GeodeticDatum {Name = "D_Hungarian_1972", Ellipsoid = EllipsoidRegistry.Instance.GRS1967, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum HungarianDatum1909 = new GeodeticDatum {Name = "D_Hungarian_Datum_1909", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum HungarianGeodeticDatum1909 = new GeodeticDatum {Name = "Hungarian GeodeticDatum 1909", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum HungarianGeodeticDatum1972 = new GeodeticDatum {Name = "Hungarian GeodeticDatum 1972", Ellipsoid = EllipsoidRegistry.Instance.GRS1967, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IGC1962Arcofthe6thParallelSouth = new GeodeticDatum {Name = "IGC 1962 Arc of the 6th Parallel South", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IGM1995 = new GeodeticDatum {Name = "D_IGM_1995", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IGN1962Kerguelen = new GeodeticDatum {Name = "IGN 1962 Kerguelen", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IGN53Mare = new GeodeticDatum {Name = "IGN53 Mare", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum IGN56Lifou = new GeodeticDatum {Name = "IGN56 Lifou", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IGN63HivaOa = new GeodeticDatum {Name = "IGN63 Hiva Oa", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IGN72GrandeTerre = new GeodeticDatum {Name = "IGN72 Grande Terre", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IGN72NukuHiva = new GeodeticDatum {Name = "IGN72 Nuku Hiva", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IGNAstro1960 = new GeodeticDatum {Name = "IGN Astro 1960", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IRENET95 = new GeodeticDatum {Name = "IRENET95", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ISTS0611968 = new GeodeticDatum {Name = "D_ISTS_061_1968", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ISTS0731969 = new GeodeticDatum {Name = "D_ISTS_073_1969", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF1988 = new GeodeticDatum {Name = "D_ITRF_1988", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF1989 = new GeodeticDatum {Name = "D_ITRF_1989", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF1990 = new GeodeticDatum {Name = "D_ITRF_1990", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF1991 = new GeodeticDatum {Name = "D_ITRF_1991", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF1992 = new GeodeticDatum {Name = "D_ITRF_1992", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF1993 = new GeodeticDatum {Name = "D_ITRF_1993", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF1994 = new GeodeticDatum {Name = "D_ITRF_1994", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF1996 = new GeodeticDatum {Name = "D_ITRF_1996", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF1997 = new GeodeticDatum {Name = "D_ITRF_1997", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF2000 = new GeodeticDatum {Name = "D_ITRF_2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF2005 = new GeodeticDatum {Name = "D_ITRF_2005", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ITRF2008 = new GeodeticDatum {Name = "D_ITRF_2008", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Indian1954 = new GeodeticDatum {Name = "Indian 1954", Ellipsoid = EllipsoidRegistry.Instance.Everest18301937Adjustment, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Indian1960 = new GeodeticDatum {Name = "Indian 1960", Ellipsoid = EllipsoidRegistry.Instance.Everest18301937Adjustment, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Indian1975 = new GeodeticDatum {Name = "Indian 1975", Ellipsoid = EllipsoidRegistry.Instance.Everest18301937Adjustment, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Indonesian = new GeodeticDatum {Name = "D_Indonesian", Ellipsoid = EllipsoidRegistry.Instance.Indonesian, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Indonesian1974 = new GeodeticDatum {Name = "D_Indonesian_1974", Ellipsoid = EllipsoidRegistry.Instance.Indonesian, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IndonesianGeodeticDatum1974 = new GeodeticDatum {Name = "Indonesian GeodeticDatum 1974", Ellipsoid = EllipsoidRegistry.Instance.IndonesianNationalSpheroid, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InstitutGeographiqueduCongoBelge1955 = new GeodeticDatum {Name = "Institut Geographique du Congo Belge 1955", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum International1924 = new GeodeticDatum {Name = "D_International_1924", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame1988 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 1988", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame1989 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 1989", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame1990 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 1990", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame1991 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 1991", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame1992 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 1992", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame1993 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 1993", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame1994 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 1994", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame1996 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 1996", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame1997 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 1997", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame2000 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame2005 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 2005", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum InternationalTerrestrialReferenceFrame2008 = new GeodeticDatum {Name = "International Terrestrial Reference Frame 2008", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IraqKuwaitBoundary1992 = new GeodeticDatum {Name = "D_Iraq_Kuwait_Boundary_1992", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IraqKuwaitBoundaryGeodeticDatum1992 = new GeodeticDatum {Name = "Iraq-Kuwait Boundary GeodeticDatum 1992", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IraqiGeospatialReferenceSystem = new GeodeticDatum {Name = "Iraqi Geospatial Reference System", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IslandsNet1993 = new GeodeticDatum {Name = "Islands Net 1993", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IslandsNet2004 = new GeodeticDatum {Name = "Islands Net 2004", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IslandsNetwork1993 = new GeodeticDatum {Name = "D_Islands_Network_1993", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IslandsNetwork2004 = new GeodeticDatum {Name = "D_Islands_Network_2004", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Israel = new GeodeticDatum {Name = "Israel", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IstitutoGeograficoMilitaire1995 = new GeodeticDatum {Name = "Istituto Geografico Militaire 1995", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum IwoJima1945 = new GeodeticDatum {Name = "Iwo Jima 1945", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum JGD2000 = new GeodeticDatum {Name = "D_JGD_2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum JGD2011 = new GeodeticDatum {Name = "D_JGD_2011", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Jamaica1969 = new GeodeticDatum {Name = "Jamaica 1969", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Jamaica2001 = new GeodeticDatum {Name = "Jamaica 2001", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum JapaneseGeodeticGeodeticDatum2000 = new GeodeticDatum {Name = "Japanese Geodetic GeodeticDatum 2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum JohnstonIsland1961 = new GeodeticDatum {Name = "Johnston Island 1961", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Jordan = new GeodeticDatum {Name = "D_Jordan", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Jouik1961 = new GeodeticDatum {Name = "Jouik 1961", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum KKJ = new GeodeticDatum {Name = "D_KKJ", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Kalianpur1937 = new GeodeticDatum {Name = "Kalianpur 1937", Ellipsoid = EllipsoidRegistry.Instance.Everest18301937Adjustment, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Kalianpur1962 = new GeodeticDatum {Name = "Kalianpur 1962", Ellipsoid = EllipsoidRegistry.Instance.Everest18301962Definition, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Kalianpur1975 = new GeodeticDatum {Name = "Kalianpur 1975", Ellipsoid = EllipsoidRegistry.Instance.Everest18301975Definition, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Kandawala = new GeodeticDatum {Name = "Kandawala", Ellipsoid = EllipsoidRegistry.Instance.Everest18301937Adjustment, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Karbala1979 = new GeodeticDatum {Name = "Karbala 1979", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Karbala1979Polservice = new GeodeticDatum {Name = "D_Karbala_1979_Polservice", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Kartastokoordinaattijarjestelma1966 = new GeodeticDatum {Name = "Kartastokoordinaattijarjestelma (1966)", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Kasai1953 = new GeodeticDatum {Name = "Kasai 1953", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Katanga1955 = new GeodeticDatum {Name = "Katanga 1955", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum KerguelenIsland1949 = new GeodeticDatum {Name = "D_Kerguelen_Island_1949", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Kertau = new GeodeticDatum {Name = "D_Kertau", Ellipsoid = EllipsoidRegistry.Instance.Everest1830Modified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Kertau1968 = new GeodeticDatum {Name = "Kertau 1968", Ellipsoid = EllipsoidRegistry.Instance.Everest1830Modified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum KertauRSO = new GeodeticDatum {Name = "Kertau (RSO)", Ellipsoid = EllipsoidRegistry.Instance.Everest1830RSO1969, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Korea2000 = new GeodeticDatum {Name = "D_Korea_2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum KoreanDatum1985 = new GeodeticDatum {Name = "D_Korean_Datum_1985", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum KoreanDatum1995 = new GeodeticDatum
                                                    {
                                                        Name = "D_Korean_Datum_1995",
                                                        Ellipsoid = EllipsoidRegistry.Instance.WGS84,
                                                        PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich
                                                    };

        public IGeodeticDatum KoreanGeodeticDatum1985 = new GeodeticDatum {Name = "Korean GeodeticDatum 1985", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum KoreanGeodeticDatum1995 = new GeodeticDatum {Name = "Korean GeodeticDatum 1995", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Kousseri = new GeodeticDatum {Name = "Kousseri", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Krassovsky1940 = new GeodeticDatum {Name = "D_Krassovsky_1940", Ellipsoid = EllipsoidRegistry.Instance.Krassovsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Kusaie1951 = new GeodeticDatum {Name = "Kusaie 1951", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum KuwaitOilCompany = new GeodeticDatum {Name = "Kuwait Oil Company", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum KuwaitUtility = new GeodeticDatum {Name = "Kuwait Utility", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum LC51961 = new GeodeticDatum {Name = "D_LC5_1961", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum LaCanoa = new GeodeticDatum {Name = "La Canoa", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Lake = new GeodeticDatum {Name = "Lake", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Lao1993 = new GeodeticDatum {Name = "Lao 1993", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum LaoNationalGeodeticDatum1997 = new GeodeticDatum {Name = "Lao National GeodeticDatum 1997", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Latvia1992 = new GeodeticDatum {Name = "Latvia 1992", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum LePouce1934 = new GeodeticDatum {Name = "Le Pouce 1934", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Leigon = new GeodeticDatum {Name = "Leigon", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Liberia1964 = new GeodeticDatum {Name = "Liberia 1964", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum LibyanGeodeticDatum2006 = new GeodeticDatum {Name = "D_Libyan_Geodetic_Datum_2006", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum LibyanGeodeticGeodeticDatum2006 = new GeodeticDatum {Name = "Libyan Geodetic GeodeticDatum 2006", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Lisbon = new GeodeticDatum {Name = "D_Lisbon", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Lisbon1890 = new GeodeticDatum {Name = "Lisbon 1890", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Lisbon1890Lisbon = new GeodeticDatum {Name = "Lisbon 1890 (Lisbon)", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Lisbon};
        public IGeodeticDatum Lisbon1937 = new GeodeticDatum {Name = "Lisbon 1937", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Lisbon1937Lisbon = new GeodeticDatum {Name = "Lisbon 1937 (Lisbon)", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Lisbon};
        public IGeodeticDatum Lithuania1994 = new GeodeticDatum {Name = "D_Lithuania_1994", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Lithuania1994ETRS89 = new GeodeticDatum {Name = "Lithuania 1994 (ETRS89)", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum LittleCayman1961 = new GeodeticDatum {Name = "D_Little_Cayman_1961", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Locodjo1965 = new GeodeticDatum {Name = "Locodjo 1965", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum LomaQuintana = new GeodeticDatum {Name = "Loma Quintana", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Lome = new GeodeticDatum {Name = "Lome", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Luxembourg1930 = new GeodeticDatum {Name = "Luxembourg 1930", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Luzon1911 = new GeodeticDatum {Name = "Luzon 1911", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MAGNA = new GeodeticDatum {Name = "D_MAGNA", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MGI = new GeodeticDatum {Name = "D_MGI", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MGI1901 = new GeodeticDatum {Name = "MGI 1901", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MOLDREF99 = new GeodeticDatum {Name = "MOLDREF99", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MOP78 = new GeodeticDatum {Name = "MOP78", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Madeira1936 = new GeodeticDatum {Name = "D_Madeira_1936", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Madrid1870 = new GeodeticDatum {Name = "D_Madrid_1870", Ellipsoid = EllipsoidRegistry.Instance.Struve1860, PrimeMeridian = PrimeMeridianRegistry.Instance.Madrid};
        public IGeodeticDatum Madrid1870Madrid = new GeodeticDatum {Name = "Madrid 1870 (Madrid)", Ellipsoid = EllipsoidRegistry.Instance.Struve1860, PrimeMeridian = PrimeMeridianRegistry.Instance.Madrid};
        public IGeodeticDatum Madzansua = new GeodeticDatum {Name = "Madzansua", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Mahe1971 = new GeodeticDatum {Name = "Mahe 1971", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Majuro = new GeodeticDatum {Name = "D_Majuro", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Makassar = new GeodeticDatum {Name = "Makassar", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MakassarJakarta = new GeodeticDatum {Name = "Makassar (Jakarta)", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Jakarta};
        public IGeodeticDatum Malongo1987 = new GeodeticDatum {Name = "Malongo 1987", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Manoca = new GeodeticDatum {Name = "D_Manoca", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Manoca1962 = new GeodeticDatum {Name = "Manoca 1962", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MarcoGeocentricoNacionaldeReferencia = new GeodeticDatum {Name = "Marco Geocentrico Nacional de Referencia", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MarcoGeodesicoNacional = new GeodeticDatum {Name = "Marco Geodesico Nacional", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MarcusIsland1952 = new GeodeticDatum {Name = "Marcus Island 1952", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MarshallIslands1960 = new GeodeticDatum {Name = "Marshall Islands 1960", Ellipsoid = EllipsoidRegistry.Instance.Hough1960, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Martinique1938 = new GeodeticDatum {Name = "Martinique 1938", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Massawa = new GeodeticDatum {Name = "Massawa", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Maupiti1983 = new GeodeticDatum {Name = "D_Maupiti_1983", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Maupiti83 = new GeodeticDatum {Name = "Maupiti 83", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Mauritania1999 = new GeodeticDatum {Name = "Mauritania 1999", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Merchich = new GeodeticDatum {Name = "Merchich", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MexicanDatumof1993 = new GeodeticDatum {Name = "D_Mexican_Datum_of_1993", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MexicanGeodeticDatumof1993 = new GeodeticDatum {Name = "Mexican GeodeticDatum of 1993", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Mhast1951 = new GeodeticDatum {Name = "D_Mhast_1951", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Mhastoffshore = new GeodeticDatum {Name = "Mhast (offshore)", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Mhastonshore = new GeodeticDatum {Name = "Mhast (onshore)", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Midway1961 = new GeodeticDatum {Name = "Midway 1961", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MilitarGeographischeInstitut = new GeodeticDatum {Name = "Militar-Geographische Institut", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MilitarGeographischeInstitutFerro = new GeodeticDatum {Name = "Militar-Geographische Institut (Ferro)", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Ferro};
        public IGeodeticDatum Minna = new GeodeticDatum {Name = "Minna", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MissaoHidrograficoAngolaySaoTome1951 = new GeodeticDatum {Name = "Missao Hidrografico Angola y Sao Tome 1951", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MonteMario = new GeodeticDatum {Name = "Monte Mario", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MonteMarioRome = new GeodeticDatum {Name = "Monte Mario (Rome)", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Rome};
        public IGeodeticDatum Montserrat1958 = new GeodeticDatum {Name = "Montserrat 1958", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Moorea1987 = new GeodeticDatum {Name = "D_Moorea_1987", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Moorea87 = new GeodeticDatum {Name = "Moorea 87", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MountDillon = new GeodeticDatum {Name = "Mount Dillon", Ellipsoid = EllipsoidRegistry.Instance.Clarke1858, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Moznet = new GeodeticDatum {Name = "D_Moznet", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum MoznetITRF94 = new GeodeticDatum {Name = "Moznet (ITRF94)", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Mporaloko = new GeodeticDatum {Name = "D_Mporaloko", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1927CGQ77 = new GeodeticDatum {Name = "D_NAD_1927_CGQ77", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1927Definition1976 = new GeodeticDatum {Name = "D_NAD_1927_Definition_1976", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum NAD19832011 = new GeodeticDatum {Name = "D_NAD_1983_2011", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983CORS96 = new GeodeticDatum {Name = "D_NAD_1983_CORS96", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNAnoka = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Anoka", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNAnoka, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNBecker = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Becker", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNBecker, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNBeltramiNorth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Beltrami_North", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNBeltramiNorth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNBeltramiSouth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Beltrami_South", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNBeltramiSouth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNBenton = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Benton", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNBenton, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNBigStone = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Big_Stone", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNBigStone, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNBlueEarth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Blue_Earth", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNBlueEarth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNBrown = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Brown", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNBrown, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNCarlton = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Carlton", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNCarlton, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNCarver = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Carver", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNCarver, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNCassNorth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Cass_North", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNCassNorth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNCassSouth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Cass_South", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNCassSouth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNChippewa = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Chippewa", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNChippewa, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNChisago = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Chisago", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNChisago, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNCookNorth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Cook_North", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNCookNorth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNCookSouth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Cook_South", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNCookSouth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNCottonwood = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Cottonwood", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNCottonwood, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNCrowWing = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Crow_Wing", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNCrowWing, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNDakota = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Dakota", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNDakota, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNDodge = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Dodge", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNDodge, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNDouglas = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Douglas", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNDouglas, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNFaribault = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Faribault", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNFaribault, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNFillmore = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Fillmore", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNFillmore, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNFreeborn = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Freeborn", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNFreeborn, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNGoodhue = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Goodhue", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNGoodhue, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNGrant = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Grant", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNGrant, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNHennepin = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Hennepin", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNHennepin, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNHouston = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Houston", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNHouston, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNIsanti = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Isanti", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNIsanti, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNItascaNorth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Itasca_North", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNItascaNorth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNItascaSouth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Itasca_South", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNItascaSouth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNJackson = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Jackson", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNJackson, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNKanabec = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Kanabec", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNKanabec, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNKandiyohi = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Kandiyohi", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNKandiyohi, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNKittson = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Kittson", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNKittson, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNKoochiching = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Koochiching", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNKoochiching, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNLacQuiParle = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Lac_Qui_Parle", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNLacQuiParle, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNLakeoftheWoodsNorth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Lake_of_the_Woods_North", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNLakeoftheWoodsNorth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNLakeoftheWoodsSouth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Lake_of_the_Woods_South", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNLakeoftheWoodsSouth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNLeSueur = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Le_Sueur", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNLeSueur, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNLincoln = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Lincoln", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNLincoln, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNLyon = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Lyon", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNLyon, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNMahnomen = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Mahnomen", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNMahnomen, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNMarshall = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Marshall", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNMarshall, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNMartin = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Martin", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNMartin, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNMcLeod = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_McLeod", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNMcLeod, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNMeeker = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Meeker", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNMeeker, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNMorrison = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Morrison", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNMorrison, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNMower = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Mower", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNMower, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNMurray = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Murray", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNMurray, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNNicollet = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Nicollet", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNNicollet, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNNobles = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Nobles", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNNobles, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNNorman = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Norman", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNNorman, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNOlmsted = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Olmsted", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNOlmsted, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNOttertail = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Ottertail", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNOttertail, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNPennington = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Pennington", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNPennington, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNPine = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Pine", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNPine, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNPipestone = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Pipestone", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNPipestone, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNPolk = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Polk", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNPolk, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNPope = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Pope", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNPope, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNRamsey = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Ramsey", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNRamsey, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNRedLake = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Red_Lake", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNRedLake, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNRedwood = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Redwood", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNRedwood, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNRenville = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Renville", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNRenville, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNRice = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Rice", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNRice, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNRock = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Rock", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNRock, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNRoseau = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Roseau", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNRoseau, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNScott = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Scott", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNScott, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNSherburne = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Sherburne", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNSherburne, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNSibley = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Sibley", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNSibley, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNStLouis = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_St_Louis", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNStLouis, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNStLouisCentral = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_St_Louis_Central", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNStLouisCentral, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNStLouisNorth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_St_Louis_North", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNStLouisNorth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNStLouisSouth = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_St_Louis_South", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNStLouisSouth, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNStearns = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Stearns", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNStearns, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNSteele = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Steele", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNSteele, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNStevens = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Stevens", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNStevens, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNSwift = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Swift", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNSwift, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNTodd = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Todd", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNTodd, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNTraverse = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Traverse", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNTraverse, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNWabasha = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Wabasha", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNWabasha, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNWadena = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Wadena", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNWadena, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNWaseca = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Waseca", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNWaseca, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNWatonwan = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Watonwan", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNWatonwan, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNWinona = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Winona", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNWinona, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNWright = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Wright", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNWright, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983HARNAdjMNYellowMedicine = new GeodeticDatum {Name = "D_NAD_1983_HARN_Adj_MN_Yellow_Medicine", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AdjMNYellowMedicine, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983MA11 = new GeodeticDatum {Name = "D_NAD_1983_MA11", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983MARP00 = new GeodeticDatum {Name = "D_NAD_1983_MARP00", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983NSRS2007 = new GeodeticDatum {Name = "D_NAD_1983_NSRS2007", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983PA11 = new GeodeticDatum {Name = "D_NAD_1983_PA11", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD1983PACP00 = new GeodeticDatum {Name = "D_NAD_1983_PACP00", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD83CanadianSpatialReferenceSystem = new GeodeticDatum {Name = "NAD83 Canadian Spatial Reference System", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD83HighAccuracyReferenceNetwork = new GeodeticDatum {Name = "NAD83 (High Accuracy Reference Network)", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NAD83NationalSpatialReferenceSystem2007 = new GeodeticDatum {Name = "NAD83 (National Spatial Reference System 2007)", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NEA74Noumea = new GeodeticDatum {Name = "NEA74 Noumea", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum NGN = new GeodeticDatum
                                        {
                                            Name = "D_NGN",
                                            Ellipsoid = EllipsoidRegistry.Instance.WGS84,
                                            PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich
                                        };

        public IGeodeticDatum NGO1948 = new GeodeticDatum {Name = "NGO 1948", Ellipsoid = EllipsoidRegistry.Instance.BesselModified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NGO1948Oslo = new GeodeticDatum {Name = "NGO 1948 (Oslo)", Ellipsoid = EllipsoidRegistry.Instance.BesselModified, PrimeMeridian = PrimeMeridianRegistry.Instance.Oslo};
        public IGeodeticDatum NSWC9Z2 = new GeodeticDatum {Name = "D_NSWC_9Z_2", Ellipsoid = EllipsoidRegistry.Instance.NWL9D, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NTF = new GeodeticDatum {Name = "D_NTF", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NWL9D = new GeodeticDatum {Name = "D_NWL_9D", Ellipsoid = EllipsoidRegistry.Instance.NWL9D, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NZGD2000 = new GeodeticDatum {Name = "D_NZGD_2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Nahrwan1934 = new GeodeticDatum {Name = "Nahrwan 1934", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Nahrwan1967 = new GeodeticDatum {Name = "Nahrwan 1967", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NakhleGhanem = new GeodeticDatum {Name = "Nakhl-e Ghanem", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Naparima1955 = new GeodeticDatum {Name = "Naparima 1955", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Naparima1972 = new GeodeticDatum {Name = "Naparima 1972", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NationalGeodeticNetwork = new GeodeticDatum {Name = "National Geodetic Network", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NepalNagarkot = new GeodeticDatum {Name = "D_Nepal_Nagarkot", Ellipsoid = EllipsoidRegistry.Instance.EverestAdjustment1937, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NewBeijing = new GeodeticDatum {Name = "New Beijing", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NewZealand1949 = new GeodeticDatum {Name = "D_New_Zealand_1949", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NewZealandGeodeticGeodeticDatum1949 = new GeodeticDatum {Name = "New Zealand Geodetic GeodeticDatum 1949", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NewZealandGeodeticGeodeticDatum2000 = new GeodeticDatum {Name = "New Zealand Geodetic GeodeticDatum 2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NordSahara1959 = new GeodeticDatum {Name = "Nord Sahara 1959", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NorddeGuerre = new GeodeticDatum {Name = "D_Nord_de_Guerre", Ellipsoid = EllipsoidRegistry.Instance.Plessis1817, PrimeMeridian = PrimeMeridianRegistry.Instance.Paris};
        public IGeodeticDatum NorthAmerican1927 = new GeodeticDatum {Name = "D_North_American_1927", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NorthAmerican1983 = new GeodeticDatum {Name = "D_North_American_1983", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NorthAmerican1983CSRS = new GeodeticDatum {Name = "D_North_American_1983_CSRS", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NorthAmerican1983HARN = new GeodeticDatum {Name = "D_North_American_1983_HARN", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NorthAmericanGeodeticDatum1927 = new GeodeticDatum {Name = "North American GeodeticDatum 1927", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NorthAmericanGeodeticDatum19271976 = new GeodeticDatum {Name = "North American GeodeticDatum 1927 (1976)", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NorthAmericanGeodeticDatum1927CGQ77 = new GeodeticDatum {Name = "North American GeodeticDatum 1927 (CGQ77)", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NorthAmericanGeodeticDatum1983 = new GeodeticDatum {Name = "North American GeodeticDatum 1983", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedAiry1830 = new GeodeticDatum {Name = "Not specified (based on Airy 1830 )", Ellipsoid = EllipsoidRegistry.Instance.Airy1830, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedAiryModified1849 = new GeodeticDatum {Name = "Not specified (based on Airy Modified 1849 )", Ellipsoid = EllipsoidRegistry.Instance.AiryModified1849, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedAustralianNationalSpheroid = new GeodeticDatum {Name = "Not specified (based on Australian National Spheroid)", Ellipsoid = EllipsoidRegistry.Instance.AustralianNationalSpheroid, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedBessel1841 = new GeodeticDatum {Name = "Not specified (based on Bessel 1841 )", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedBesselModified = new GeodeticDatum {Name = "Not specified (based on Bessel Modified )", Ellipsoid = EllipsoidRegistry.Instance.BesselModified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedBesselNamibia = new GeodeticDatum {Name = "Not specified (based on Bessel Namibia )", Ellipsoid = EllipsoidRegistry.Instance.BesselNamibiaGLM, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedClarke1858 = new GeodeticDatum {Name = "Not specified (based on Clarke 1858 )", Ellipsoid = EllipsoidRegistry.Instance.Clarke1858, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedClarke1866 = new GeodeticDatum {Name = "Not specified (based on Clarke 1866 )", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedClarke1866AuthalicSphere = new GeodeticDatum {Name = "Not specified (based on Clarke 1866 Authalic Sphere)", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866AuthalicSphere, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedClarke1880Arc = new GeodeticDatum {Name = "Not specified (based on Clarke 1880 (Arc) )", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880Arc, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedClarke1880Benoit = new GeodeticDatum {Name = "Not specified (based on Clarke 1880 (Benoit) )", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880Benoit, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedClarke1880IGN = new GeodeticDatum {Name = "Not specified (based on Clarke 1880 (IGN) )", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedClarke1880RGS = new GeodeticDatum {Name = "Not specified (based on Clarke 1880 (RGS) )", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedClarke1880SGA1922 = new GeodeticDatum {Name = "Not specified (based on Clarke 1880 (SGA 1922) )", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880SGA1922, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedEverest18301937Adjustment = new GeodeticDatum {Name = "Not specified (based on Everest 1830 (1937 Adjustment) )", Ellipsoid = EllipsoidRegistry.Instance.Everest18301937Adjustment, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedEverest18301962Definition = new GeodeticDatum {Name = "Not specified (based on Everest 1830 (1962 Definition) )", Ellipsoid = EllipsoidRegistry.Instance.Everest18301962Definition, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedEverest18301967Definition = new GeodeticDatum {Name = "Not specified (based on Everest 1830 (1967 Definition) )", Ellipsoid = EllipsoidRegistry.Instance.Everest18301967Definition, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedEverest18301975Definition = new GeodeticDatum {Name = "Not specified (based on Everest 1830 (1975 Definition) )", Ellipsoid = EllipsoidRegistry.Instance.Everest18301975Definition, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedEverest1830Modified = new GeodeticDatum {Name = "Not specified (based on Everest 1830 Modified )", Ellipsoid = EllipsoidRegistry.Instance.Everest1830Modified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedGEM10C = new GeodeticDatum {Name = "Not specified (based on GEM 10C )", Ellipsoid = EllipsoidRegistry.Instance.GEM10C, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedGRS1967 = new GeodeticDatum {Name = "Not specified (based on GRS 1967 )", Ellipsoid = EllipsoidRegistry.Instance.GRS1967, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedGRS1980 = new GeodeticDatum {Name = "Not specified (based on GRS 1980 )", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedGRS1980AuthalicSphere = new GeodeticDatum {Name = "Not specified (based on GRS 1980 Authalic Sphere)", Ellipsoid = EllipsoidRegistry.Instance.GRS1980AuthalicSphere, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedHelmert1906 = new GeodeticDatum {Name = "Not specified (based on Helmert 1906 )", Ellipsoid = EllipsoidRegistry.Instance.Helmert1906, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedHughes1980 = new GeodeticDatum {Name = "Not specified (based on Hughes 1980 )", Ellipsoid = EllipsoidRegistry.Instance.Hughes1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedIndonesianNationalSpheroid = new GeodeticDatum {Name = "Not specified (based on Indonesian National Spheroid)", Ellipsoid = EllipsoidRegistry.Instance.IndonesianNationalSpheroid, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedInternational1924 = new GeodeticDatum {Name = "Not specified (based on International 1924 )", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedInternational1924AuthalicSphere = new GeodeticDatum {Name = "Not specified (based on International 1924 Authalic Sphere)", Ellipsoid = EllipsoidRegistry.Instance.International1924AuthalicSphere, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedKrassowsky1940 = new GeodeticDatum {Name = "Not specified (based on Krassowsky 1940 )", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedNWL9D = new GeodeticDatum {Name = "Not specified (based on NWL 9D )", Ellipsoid = EllipsoidRegistry.Instance.NWL9D, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedOSU86F = new GeodeticDatum {Name = "Not specified (based on OSU86F )", Ellipsoid = EllipsoidRegistry.Instance.OSU86F, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedOSU91A = new GeodeticDatum {Name = "Not specified (based on OSU91A )", Ellipsoid = EllipsoidRegistry.Instance.OSU91A, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedPlessis1817 = new GeodeticDatum {Name = "Not specified (based on Plessis 1817 )", Ellipsoid = EllipsoidRegistry.Instance.Plessis1817, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedStruve1860 = new GeodeticDatum {Name = "Not specified (based on Struve 1860 )", Ellipsoid = EllipsoidRegistry.Instance.Struve1860, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedWGS72 = new GeodeticDatum {Name = "Not specified (based on WGS 72 )", Ellipsoid = EllipsoidRegistry.Instance.WGS72, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedWGS84 = new GeodeticDatum {Name = "Not specified (based on WGS 84 )", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NotSpecifiedWarOffice = new GeodeticDatum {Name = "Not specified (based on War Office )", Ellipsoid = EllipsoidRegistry.Instance.WarOffice, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Nouakchott1965 = new GeodeticDatum {Name = "Nouakchott 1965", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NouvelleTriangulationFrancaise = new GeodeticDatum {Name = "Nouvelle Triangulation Francaise", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum NouvelleTriangulationFrancaiseParis = new GeodeticDatum {Name = "Nouvelle Triangulation Francaise (Paris)", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Paris};
        public IGeodeticDatum OSGB1936 = new GeodeticDatum {Name = "OSGB 1936", Ellipsoid = EllipsoidRegistry.Instance.Airy1830, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum OSGB1970SN = new GeodeticDatum {Name = "OSGB 1970 (SN)", Ellipsoid = EllipsoidRegistry.Instance.Airy1830, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum OSNI1952 = new GeodeticDatum {Name = "OSNI 1952", Ellipsoid = EllipsoidRegistry.Instance.Airy1830, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum OSSN1980 = new GeodeticDatum {Name = "OS (SN) 1980", Ellipsoid = EllipsoidRegistry.Instance.Airy1830, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum OSU86F = new GeodeticDatum {Name = "D_OSU_86F", Ellipsoid = EllipsoidRegistry.Instance.OSU86F, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum OSU91A = new GeodeticDatum {Name = "D_OSU_91A", Ellipsoid = EllipsoidRegistry.Instance.OSU91A, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Observatario = new GeodeticDatum {Name = "Observatario", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ObservatorioMeteorologico1939 = new GeodeticDatum {Name = "D_Observatorio_Meteorologico_1939", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ObservatorioMeteorologico1965 = new GeodeticDatum {Name = "D_Observatorio_Meteorologico_1965", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Ocotepeque1935 = new GeodeticDatum {Name = "Ocotepeque 1935", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum OldHawaiian = new GeodeticDatum {Name = "Old Hawaiian", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum OldHawaiianIntl1924 = new GeodeticDatum {Name = "D_Old_Hawaiian_Intl_1924", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Oman = new GeodeticDatum {Name = "D_Oman", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PDO1993 = new GeodeticDatum {Name = "D_PDO_1993", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PDOSurveyGeodeticDatum1993 = new GeodeticDatum {Name = "PDO Survey GeodeticDatum 1993", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum POSGAR = new GeodeticDatum {Name = "D_POSGAR", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum POSGAR1994 = new GeodeticDatum {Name = "D_POSGAR_1994", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum POSGAR1998 = new GeodeticDatum {Name = "D_POSGAR_1998", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum POSGAR2007 = new GeodeticDatum {Name = "D_POSGAR_2007", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PTRA08 = new GeodeticDatum {Name = "D_PTRA08", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Padang1884 = new GeodeticDatum {Name = "Padang 1884", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Padang1884Jakarta = new GeodeticDatum {Name = "Padang 1884 (Jakarta)", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Jakarta};
        public IGeodeticDatum Palestine1923 = new GeodeticDatum {Name = "Palestine 1923", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880Benoit, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PampadelCastillo = new GeodeticDatum {Name = "Pampa del Castillo", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PanamaColon1911 = new GeodeticDatum {Name = "D_Panama-Colon-1911", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PapuaNewGuineaGeodeticDatum1994 = new GeodeticDatum {Name = "D_Papua_New_Guinea_Geodetic_Datum_1994", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PapuaNewGuineaGeodeticGeodeticDatum1994 = new GeodeticDatum {Name = "Papua New Guinea Geodetic GeodeticDatum 1994", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ParametropZemp1990 = new GeodeticDatum {Name = "Parametrop Zemp 1990", Ellipsoid = EllipsoidRegistry.Instance.PZ90, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Peru96 = new GeodeticDatum {Name = "Peru96", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Petrels1972 = new GeodeticDatum {Name = "Petrels 1972", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PhilippineReferenceSystem1992 = new GeodeticDatum {Name = "Philippine Reference System 1992", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PhoenixIslands1966 = new GeodeticDatum {Name = "Phoenix Islands 1966", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PicodeLasNieves = new GeodeticDatum {Name = "D_Pico_de_Las_Nieves", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PicodelasNieves1984 = new GeodeticDatum {Name = "Pico de las Nieves 1984", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Pitcairn1967 = new GeodeticDatum {Name = "Pitcairn 1967", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Pitcairn2006 = new GeodeticDatum {Name = "Pitcairn 2006", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Plessis1817 = new GeodeticDatum {Name = "D_Plessis_1817", Ellipsoid = EllipsoidRegistry.Instance.Plessis1817, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Pohnpei = new GeodeticDatum {Name = "D_Pohnpei", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Point58 = new GeodeticDatum {Name = "Point 58", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PointeGeologiePerroud1950 = new GeodeticDatum {Name = "Pointe Geologie Perroud 1950", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PointeNoire = new GeodeticDatum {Name = "D_Pointe_Noire", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PortoSanto1936 = new GeodeticDatum {Name = "Porto Santo 1936", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PortoSanto1995 = new GeodeticDatum {Name = "D_Porto_Santo_1995", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PosicionesGeodesicasArgentinas1994 = new GeodeticDatum {Name = "Posiciones Geodesicas Argentinas 1994", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PosicionesGeodesicasArgentinas1998 = new GeodeticDatum {Name = "Posiciones Geodesicas Argentinas 1998", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PosicionesGeodesicasArgentinas2007 = new GeodeticDatum {Name = "Posiciones Geodesicas Argentinas 2007", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Potsdam1983 = new GeodeticDatum {Name = "D_Potsdam_1983", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum PotsdamGeodeticDatum83 = new GeodeticDatum
                                                           {
                                                               Name = "Potsdam GeodeticDatum/83",
                                                               Ellipsoid = EllipsoidRegistry.Instance.Bessel1841,
                                                               PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich
                                                           };

        public IGeodeticDatum Principe = new GeodeticDatum {Name = "Principe", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ProvisionalSAmerican1956 = new GeodeticDatum {Name = "D_Provisional_S_American_1956", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ProvisionalSouthAmericanGeodeticDatum1956 = new GeodeticDatum {Name = "Provisional South American GeodeticDatum 1956", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum PuertoRico = new GeodeticDatum {Name = "Puerto Rico", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Pulkovo1942 = new GeodeticDatum {Name = "Pulkovo 1942", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Pulkovo194258 = new GeodeticDatum {Name = "Pulkovo 1942(58)", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Pulkovo194283 = new GeodeticDatum {Name = "Pulkovo 1942(83)", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Pulkovo1995 = new GeodeticDatum {Name = "Pulkovo 1995", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum QND1995 = new GeodeticDatum {Name = "D_QND_1995", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Qatar = new GeodeticDatum {Name = "D_Qatar", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Qatar1948 = new GeodeticDatum {Name = "Qatar 1948", Ellipsoid = EllipsoidRegistry.Instance.Helmert1906, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Qatar1974 = new GeodeticDatum {Name = "Qatar 1974", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum QatarNationalGeodeticDatum1995 = new GeodeticDatum {Name = "Qatar National GeodeticDatum 1995", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Qornoq1927 = new GeodeticDatum {Name = "Qornoq 1927", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum REGVEN = new GeodeticDatum {Name = "D_REGVEN", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum RGF1993 = new GeodeticDatum {Name = "D_RGF_1993", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum RGFG1995 = new GeodeticDatum {Name = "D_RGFG_1995", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum RGNC1991 = new GeodeticDatum {Name = "D_RGNC_1991", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum RGR1992 = new GeodeticDatum {Name = "D_RGR_1992", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum RRAF1991 = new GeodeticDatum {Name = "D_RRAF_1991", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum RT1990 = new GeodeticDatum {Name = "D_RT_1990", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Rassadiran = new GeodeticDatum {Name = "Rassadiran", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Rauenberg1983 = new GeodeticDatum {Name = "D_Rauenberg_1983", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum RauenbergGeodeticDatum83 = new GeodeticDatum
                                                             {
                                                                 Name = "Rauenberg GeodeticDatum/83",
                                                                 Ellipsoid = EllipsoidRegistry.Instance.Bessel1841,
                                                                 PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich
                                                             };

        public IGeodeticDatum RedGeodesicaVenezolana = new GeodeticDatum {Name = "Red Geodesica Venezolana", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum RedGeodesicadeCanarias1995 = new GeodeticDatum {Name = "Red Geodesica de Canarias 1995", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauGeodesiqueFrancais1993 = new GeodeticDatum {Name = "Reseau Geodesique Francais 1993", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauGeodesiqueFrancaisGuyane1995 = new GeodeticDatum {Name = "Reseau Geodesique Francais Guyane 1995", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauGeodesiquedeMayotte2004 = new GeodeticDatum {Name = "Reseau Geodesique de Mayotte 2004", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauGeodesiquedeNouvelleCaledonie199193 = new GeodeticDatum {Name = "D_Reseau_Geodesique_de_Nouvelle_Caledonie_1991-93", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauGeodesiquedeNouvelleCaledonie9193 = new GeodeticDatum {Name = "Reseau Geodesique de Nouvelle Caledonie 91-93", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauGeodesiquedeSaintPierreetMiquelon2006 = new GeodeticDatum {Name = "Reseau Geodesique de Saint Pierre et Miquelon 2006", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauGeodesiquedeStPierreetMiquelon2006 = new GeodeticDatum {Name = "D_Reseau_Geodesique_de_St_Pierre_et_Miquelon_2006", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauGeodesiquedelaPolynesieFrancaise = new GeodeticDatum {Name = "Reseau Geodesique de la Polynesie Francaise", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauGeodesiquedelaRDC2005 = new GeodeticDatum {Name = "Reseau Geodesique de la RDC 2005", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauGeodesiquedelaReunion1992 = new GeodeticDatum {Name = "Reseau Geodesique de la Reunion 1992", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauGeodesiquedesAntillesFrancaises2009 = new GeodeticDatum {Name = "Reseau Geodesique des Antilles Francaises 2009", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauNationalBelge1950 = new GeodeticDatum {Name = "Reseau National Belge 1950", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseauNationalBelge1950Brussels = new GeodeticDatum {Name = "Reseau National Belge 1950 (Brussels)", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Brussels};
        public IGeodeticDatum ReseauNationalBelge1972 = new GeodeticDatum {Name = "Reseau National Belge 1972", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ReseaudeReferencedesAntillesFrancaises1991 = new GeodeticDatum {Name = "Reseau de Reference des Antilles Francaises 1991", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Reunion1947 = new GeodeticDatum {Name = "Reunion 1947", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Reykjavik1900 = new GeodeticDatum {Name = "Reykjavik 1900", Ellipsoid = EllipsoidRegistry.Instance.Danish1876, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Riketskoordinatsystem1990 = new GeodeticDatum {Name = "Rikets koordinatsystem 1990", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Roma1940 = new GeodeticDatum {Name = "D_Roma_1940", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum RossSeaRegionGeodeticDatum2000 = new GeodeticDatum {Name = "D_Ross_Sea_Region_Geodetic_Datum_2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum RossSeaRegionGeodeticGeodeticDatum2000 = new GeodeticDatum {Name = "Ross Sea Region Geodetic GeodeticDatum 2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SGNPMARCARIOSOLIS = new GeodeticDatum {Name = "D_SGNP_MARCARIO_SOLIS", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SIRGAS = new GeodeticDatum {Name = "D_SIRGAS", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SIRGAS2000 = new GeodeticDatum {Name = "D_SIRGAS_2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SIRGASChile = new GeodeticDatum {Name = "SIRGAS-Chile", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SIRGASES20078 = new GeodeticDatum {Name = "SIRGAS_ES2007.8", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SIRGASROU98 = new GeodeticDatum {Name = "SIRGAS-ROU98", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SJTSK = new GeodeticDatum {Name = "D_S_JTSK", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SJTSK05 = new GeodeticDatum {Name = "D_S_JTSK_05", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ST71Belep = new GeodeticDatum {Name = "ST71 Belep", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ST84IledesPins = new GeodeticDatum {Name = "ST84 Ile des Pins", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum ST87Ouvea = new GeodeticDatum {Name = "ST87 Ouvea", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SVY21 = new GeodeticDatum {Name = "SVY21", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SWEREF99 = new GeodeticDatum {Name = "SWEREF99", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SaintPierreetMiquelon1950 = new GeodeticDatum {Name = "Saint Pierre et Miquelon 1950", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SainteAnne = new GeodeticDatum {Name = "D_Sainte_Anne", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Samboja = new GeodeticDatum {Name = "D_Samboja", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Santo1965 = new GeodeticDatum {Name = "Santo 1965", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SantoDOS1965 = new GeodeticDatum {Name = "D_Santo_DOS_1965", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SaoBraz = new GeodeticDatum {Name = "D_Sao_Braz", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SaoTome = new GeodeticDatum {Name = "Sao Tome", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SapperHill1943 = new GeodeticDatum {Name = "Sapper Hill 1943", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Schwarzeck = new GeodeticDatum {Name = "Schwarzeck", Ellipsoid = EllipsoidRegistry.Instance.BesselNamibiaGLM, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Scoresbysund1952 = new GeodeticDatum {Name = "Scoresbysund 1952", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Segora = new GeodeticDatum {Name = "D_Segora", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SelvagemGrande = new GeodeticDatum {Name = "Selvagem Grande", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SelvagemGrande1938 = new GeodeticDatum {Name = "D_Selvagem_Grande_1938", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SerbianReferenceNetwork1998 = new GeodeticDatum {Name = "Serbian Reference Network 1998", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Serindung = new GeodeticDatum {Name = "Serindung", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SibunGorge1922 = new GeodeticDatum {Name = "Sibun Gorge 1922", Ellipsoid = EllipsoidRegistry.Instance.Clarke1858, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SierraLeone1924 = new GeodeticDatum {Name = "D_Sierra_Leone_1924", Ellipsoid = EllipsoidRegistry.Instance.WarOffice, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SierraLeone1960 = new GeodeticDatum {Name = "D_Sierra_Leone_1960", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SierraLeone1968 = new GeodeticDatum {Name = "Sierra Leone 1968", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SierraLeoneColony1924 = new GeodeticDatum {Name = "Sierra Leone Colony 1924", Ellipsoid = EllipsoidRegistry.Instance.WarOffice, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SistemaGeodesicoNacionaldePanamaMACARIOSOLIS = new GeodeticDatum {Name = "Sistema Geodesico Nacional de Panama MACARIO SOLIS", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SistemadeReferenciaGeocentricoparaAmericadelSur1995 = new GeodeticDatum {Name = "Sistema de Referencia Geocentrico para America del Sur 1995", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SistemadeReferenciaGeocentricoparalasAmericaS2000 = new GeodeticDatum {Name = "Sistema de Referencia Geocentrico para las AmericaS 2000", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SisterIslandsGeodeticGeodeticDatum1961 = new GeodeticDatum {Name = "Sister Islands Geodetic GeodeticDatum 1961", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SloveniaGeodeticDatum1996 = new GeodeticDatum {Name = "D_Slovenia_Geodetic_Datum_1996", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SloveniaGeodeticGeodeticDatum1996 = new GeodeticDatum {Name = "Slovenia Geodetic GeodeticDatum 1996", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Solomon1968 = new GeodeticDatum {Name = "Solomon 1968", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SouthAmerican1969 = new GeodeticDatum {Name = "D_South_American_1969", Ellipsoid = EllipsoidRegistry.Instance.GRS1967Truncated, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SouthAmericanDatum196996 = new GeodeticDatum {Name = "D_South_American_Datum_1969_96", Ellipsoid = EllipsoidRegistry.Instance.GRS1967Truncated, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SouthAmericanGeodeticDatum1969 = new GeodeticDatum {Name = "South American GeodeticDatum 1969", Ellipsoid = EllipsoidRegistry.Instance.GRS1967Modified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SouthAmericanGeodeticDatum196996 = new GeodeticDatum {Name = "South American GeodeticDatum 1969(96)", Ellipsoid = EllipsoidRegistry.Instance.GRS1967Modified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SouthAsiaSingapore = new GeodeticDatum {Name = "D_South_Asia_Singapore", Ellipsoid = EllipsoidRegistry.Instance.FischerModified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SouthGeorgia1968 = new GeodeticDatum {Name = "South Georgia 1968", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SouthYemen = new GeodeticDatum {Name = "South Yemen", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Sphere = new GeodeticDatum {Name = "D_Sphere", Ellipsoid = EllipsoidRegistry.Instance.Sphere, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SphereARCINFO = new GeodeticDatum {Name = "D_Sphere_ARC_INFO", Ellipsoid = EllipsoidRegistry.Instance.SphereARCINFO, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SphereClarke1866Authalic = new GeodeticDatum {Name = "D_Sphere_Clarke_1866_Authalic", Ellipsoid = EllipsoidRegistry.Instance.SphereClarke1866Authalic, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SphereEMEP = new GeodeticDatum {Name = "D_Sphere_EMEP", Ellipsoid = EllipsoidRegistry.Instance.SphereEMEP, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SphereGRS1980Authalic = new GeodeticDatum {Name = "D_Sphere_GRS_1980_Authalic", Ellipsoid = EllipsoidRegistry.Instance.SphereGRS1980Authalic, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SphereInternational1924Authalic = new GeodeticDatum {Name = "D_Sphere_International_1924_Authalic", Ellipsoid = EllipsoidRegistry.Instance.SphereInternational1924Authalic, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SriLankaDatum1999 = new GeodeticDatum {Name = "D_Sri_Lanka_Datum_1999", Ellipsoid = EllipsoidRegistry.Instance.EverestAdjustment1937, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SriLankaGeodeticDatum1999 = new GeodeticDatum {Name = "Sri Lanka GeodeticDatum 1999", Ellipsoid = EllipsoidRegistry.Instance.Everest18301937Adjustment, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum StGeorgeIsland = new GeodeticDatum {Name = "D_St_George_Island", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum StHelena1971 = new GeodeticDatum {Name = "St. Helena 1971", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum StKitts1955 = new GeodeticDatum {Name = "D_St_Kitts_1955", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum StLawrenceIsland = new GeodeticDatum {Name = "D_St_Lawrence_Island", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum StLucia1955 = new GeodeticDatum {Name = "D_St_Lucia_1955", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum StPaulIsland = new GeodeticDatum {Name = "D_St_Paul_Island", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum StVincent1945 = new GeodeticDatum {Name = "D_St_Vincent_1945", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Stockholm1938 = new GeodeticDatum {Name = "Stockholm 1938", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Stockholm1938Stockholm = new GeodeticDatum {Name = "Stockholm 1938 (Stockholm)", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Stockholm};
        public IGeodeticDatum Struve1860 = new GeodeticDatum {Name = "D_Struve_1860", Ellipsoid = EllipsoidRegistry.Instance.Struve1860, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Sudan = new GeodeticDatum {Name = "D_Sudan", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SwissTRF1995 = new GeodeticDatum {Name = "D_Swiss_TRF_1995", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SwissTerrestrialReferenceFrame1995 = new GeodeticDatum {Name = "Swiss Terrestrial Reference Frame 1995", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SystemJednotneTrigonometrickeSiteKatastralni = new GeodeticDatum {Name = "System Jednotne Trigonometricke Site Katastralni", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SystemJednotneTrigonometrickeSiteKatastralni05 = new GeodeticDatum {Name = "System Jednotne Trigonometricke Site Katastralni/05", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum SystemJednotneTrigonometrickeSiteKatastralni05Ferro = new GeodeticDatum {Name = "System Jednotne Trigonometricke Site Katastralni/05 (Ferro)", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Ferro};
        public IGeodeticDatum SystemJednotneTrigonometrickeSiteKatastralniFerro = new GeodeticDatum {Name = "System Jednotne Trigonometricke Site Katastralni (Ferro)", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Ferro};
        public IGeodeticDatum TM65 = new GeodeticDatum {Name = "TM65", Ellipsoid = EllipsoidRegistry.Instance.AiryModified1849, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum TM75 = new GeodeticDatum {Name = "D_TM75", Ellipsoid = EllipsoidRegistry.Instance.AiryModified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum TWD1967 = new GeodeticDatum {Name = "D_TWD_1967", Ellipsoid = EllipsoidRegistry.Instance.GRS1967, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum TWD1997 = new GeodeticDatum {Name = "D_TWD_1997", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tahaa1954 = new GeodeticDatum {Name = "D_Tahaa_1954", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tahaa54 = new GeodeticDatum {Name = "Tahaa 54", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tahiti1952 = new GeodeticDatum {Name = "D_Tahiti_1952", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tahiti1979 = new GeodeticDatum {Name = "D_Tahiti_1979", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tahiti52 = new GeodeticDatum {Name = "Tahiti 52", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tahiti79 = new GeodeticDatum {Name = "Tahiti 79", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum TaiwanGeodeticDatum1967 = new GeodeticDatum {Name = "Taiwan GeodeticDatum 1967", Ellipsoid = EllipsoidRegistry.Instance.GRS1967Modified, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum TaiwanGeodeticDatum1997 = new GeodeticDatum {Name = "Taiwan GeodeticDatum 1997", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tananarive1925 = new GeodeticDatum {Name = "Tananarive 1925", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tananarive1925Paris = new GeodeticDatum {Name = "Tananarive 1925 (Paris)", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Paris};
        public IGeodeticDatum TernIsland1961 = new GeodeticDatum {Name = "Tern Island 1961", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tete = new GeodeticDatum {Name = "Tete", Ellipsoid = EllipsoidRegistry.Instance.Clarke1866, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Timbalai1948 = new GeodeticDatum {Name = "Timbalai 1948", Ellipsoid = EllipsoidRegistry.Instance.Everest18301967Definition, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tokyo = new GeodeticDatum {Name = "Tokyo", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tokyo1892 = new GeodeticDatum {Name = "Tokyo 1892", Ellipsoid = EllipsoidRegistry.Instance.Bessel1841, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum TongaGeodeticDatum2005 = new GeodeticDatum {Name = "D_Tonga_Geodetic_Datum_2005", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum TongaGeodeticGeodeticDatum2005 = new GeodeticDatum {Name = "Tonga Geodetic GeodeticDatum 2005", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Trinidad1903 = new GeodeticDatum {Name = "Trinidad 1903", Ellipsoid = EllipsoidRegistry.Instance.Clarke1858, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Tristan1968 = new GeodeticDatum {Name = "Tristan 1968", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum TrucialCoast1948 = new GeodeticDatum {Name = "Trucial Coast 1948", Ellipsoid = EllipsoidRegistry.Instance.Helmert1906, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum TurkishNationalReferenceFrame = new GeodeticDatum {Name = "Turkish National Reference Frame", Ellipsoid = EllipsoidRegistry.Instance.GRS1980, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Ukraine2000 = new GeodeticDatum {Name = "Ukraine 2000", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum VanuaLevu1915 = new GeodeticDatum {Name = "Vanua Levu 1915", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880internationalfoot, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum Venus1985 = new GeodeticDatum
                                              {
                                                  Name = "D_Venus_1985",
                                                  Ellipsoid = EllipsoidRegistry.Instance.Venus1985IAUIAGCOSPAR,
                                                  PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich
                                              };

        public IGeodeticDatum Venus2000 = new GeodeticDatum
                                              {
                                                  Name = "D_Venus_2000",
                                                  Ellipsoid = EllipsoidRegistry.Instance.Venus2000IAUIAG,
                                                  PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich
                                              };

        public IGeodeticDatum Vientiane1982 = new GeodeticDatum {Name = "Vientiane 1982", Ellipsoid = EllipsoidRegistry.Instance.Krassowsky1940, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Vietnam2000 = new GeodeticDatum {Name = "Vietnam 2000", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum VitiLevu1912 = new GeodeticDatum {Name = "Viti Levu 1912", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880internationalfoot, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum VitiLevu1916 = new GeodeticDatum {Name = "D_Viti_Levu_1916", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Voirol1875 = new GeodeticDatum {Name = "Voirol 1875", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Voirol1875Paris = new GeodeticDatum {Name = "Voirol 1875 (Paris)", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Paris};
        public IGeodeticDatum Voirol1879 = new GeodeticDatum {Name = "Voirol 1879", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Voirol1879Paris = new GeodeticDatum {Name = "Voirol 1879 (Paris)", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Paris};
        public IGeodeticDatum VoirolUnifie1960 = new GeodeticDatum {Name = "D_Voirol_Unifie_1960", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880RGS, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum WGS1966 = new GeodeticDatum {Name = "D_WGS_1966", Ellipsoid = EllipsoidRegistry.Instance.WGS66, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum WGS1972 = new GeodeticDatum {Name = "D_WGS_1972", Ellipsoid = EllipsoidRegistry.Instance.WGS72, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum WGS1972BE = new GeodeticDatum {Name = "D_WGS_1972_BE", Ellipsoid = EllipsoidRegistry.Instance.WGS72, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum WGS1984 = new GeodeticDatum {Name = "D_WGS_1984", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum WGS72TransitBroadcastEphemeris = new GeodeticDatum {Name = "WGS 72 Transit Broadcast Ephemeris", Ellipsoid = EllipsoidRegistry.Instance.WGS72, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum WGS84 = new GeodeticDatum {Name = "WGS84", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum WakeEniwetok1960 = new GeodeticDatum {Name = "D_Wake_Eniwetok_1960", Ellipsoid = EllipsoidRegistry.Instance.Hough1960, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum WakeIsland1952 = new GeodeticDatum {Name = "Wake Island 1952", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Walbeck = new GeodeticDatum {Name = "D_Walbeck", Ellipsoid = EllipsoidRegistry.Instance.Walbeck, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum WarOffice = new GeodeticDatum {Name = "D_War_Office", Ellipsoid = EllipsoidRegistry.Instance.WarOffice, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum WorldGeodeticSystem1966 = new GeodeticDatum {Name = "World Geodetic System 1966", Ellipsoid = EllipsoidRegistry.Instance.NWL9D, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum WorldGeodeticSystem1972 = new GeodeticDatum {Name = "World Geodetic System 1972", Ellipsoid = EllipsoidRegistry.Instance.WGS72, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum WorldGeodeticSystem1984 = new GeodeticDatum {Name = "World Geodetic System 1984", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Xian1980 = new GeodeticDatum {Name = "Xian 1980", Ellipsoid = EllipsoidRegistry.Instance.IAG1975, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Yacare = new GeodeticDatum {Name = "Yacare", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        public IGeodeticDatum YemenNGN1996 = new GeodeticDatum
                                                 {
                                                     Name = "D_Yemen_NGN_1996",
                                                     Ellipsoid = EllipsoidRegistry.Instance.WGS84,
                                                     PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich
                                                 };

        public IGeodeticDatum YemenNationalGeodeticNetwork1996 = new GeodeticDatum {Name = "Yemen National Geodetic Network 1996", Ellipsoid = EllipsoidRegistry.Instance.WGS84, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Yoff = new GeodeticDatum {Name = "Yoff", Ellipsoid = EllipsoidRegistry.Instance.Clarke1880IGN, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum Zanderij = new GeodeticDatum {Name = "Zanderij", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};
        public IGeodeticDatum fk89 = new GeodeticDatum {Name = "fk89", Ellipsoid = EllipsoidRegistry.Instance.International1924, PrimeMeridian = PrimeMeridianRegistry.Instance.Greenwich};

        private DatumRegistry ()
        {
            datums.Add (HungarianGeodeticDatum1909);
            HungarianGeodeticDatum1909.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hungarian GeodeticDatum 1909", 1024));

            datums.Add (TaiwanGeodeticDatum1967);
            TaiwanGeodeticDatum1967.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Taiwan GeodeticDatum 1967", 1025));

            datums.Add (TaiwanGeodeticDatum1997);
            TaiwanGeodeticDatum1997.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Taiwan GeodeticDatum 1997", 1026));

            datums.Add (IraqiGeospatialReferenceSystem);
            IraqiGeospatialReferenceSystem.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Iraqi Geospatial Reference System", 1029));
            IraqiGeospatialReferenceSystem.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Iraqi_Geospatial_Reference_System", 0));

            datums.Add (MGI1901);
            MGI1901.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "MGI 1901", 1031));
            MGI1901.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_MGI_1901", 0));

            datums.Add (MOLDREF99);
            MOLDREF99.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "MOLDREF99", 1032));
            MOLDREF99.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_MOLDREF99", 0));

            datums.Add (ReseauGeodesiquedelaRDC2005);
            ReseauGeodesiquedelaRDC2005.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau Geodesique de la RDC 2005", 1033));
            ReseauGeodesiquedelaRDC2005.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Reseau_Geodesique_de_la_RDC_2005", 0));

            datums.Add (SerbianReferenceNetwork1998);
            SerbianReferenceNetwork1998.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Serbian Reference Network 1998", 1034));
            SerbianReferenceNetwork1998.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Serbian_Reference_Network_1998", 0));

            datums.Add (RedGeodesicadeCanarias1995);
            RedGeodesicadeCanarias1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Red Geodesica de Canarias 1995", 1035));
            RedGeodesicadeCanarias1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Red_Geodesica_de_Canarias_1995", 0));

            datums.Add (ReseauGeodesiquedeMayotte2004);
            ReseauGeodesiquedeMayotte2004.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau Geodesique de Mayotte 2004", 1036));
            ReseauGeodesiquedeMayotte2004.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Reseau_Geodesique_de_Mayotte_2004", 0));

            datums.Add (Cadastre1997);
            Cadastre1997.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Cadastre 1997", 1037));
            Cadastre1997.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Cadastre_1997", 0));

            datums.Add (ReseauGeodesiquedeSaintPierreetMiquelon2006);
            ReseauGeodesiquedeSaintPierreetMiquelon2006.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau Geodesique de Saint Pierre et Miquelon 2006", 1038));

            datums.Add (AutonomousRegionsofPortugal2008);
            AutonomousRegionsofPortugal2008.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Autonomous Regions of Portugal 2008", 1041));

            datums.Add (MexicanGeodeticDatumof1993);
            MexicanGeodeticDatumof1993.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mexican GeodeticDatum of 1993", 1042));

            datums.Add (China2000);
            China2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "China 2000", 1043));
            China2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_China_2000", 0));

            datums.Add (SaoTome);
            SaoTome.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sao Tome", 1044));
            SaoTome.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sao_Tome", 0));

            datums.Add (NewBeijing);
            NewBeijing.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "New Beijing", 1045));
            NewBeijing.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_New_Beijing", 0));

            datums.Add (Principe);
            Principe.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Principe", 1046));
            Principe.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Principe", 0));

            datums.Add (ReseaudeReferencedesAntillesFrancaises1991);
            ReseaudeReferencedesAntillesFrancaises1991.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau de Reference des Antilles Francaises 1991", 1047));

            datums.Add (Tokyo1892);
            Tokyo1892.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tokyo 1892", 1048));

            datums.Add (SystemJednotneTrigonometrickeSiteKatastralni05);
            SystemJednotneTrigonometrickeSiteKatastralni05.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "System Jednotne Trigonometricke Site Katastralni/05", 1052));

            datums.Add (SriLankaGeodeticDatum1999);
            SriLankaGeodeticDatum1999.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sri Lanka GeodeticDatum 1999", 1053));

            datums.Add (SystemJednotneTrigonometrickeSiteKatastralni05Ferro);
            SystemJednotneTrigonometrickeSiteKatastralni05Ferro.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "System Jednotne Trigonometricke Site Katastralni/05 (Ferro)", 1055));

            datums.Add (GeocentricGeodeticDatumBruneiDarussalam2009);
            GeocentricGeodeticDatumBruneiDarussalam2009.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Geocentric GeodeticDatum Brunei Darussalam 2009", 1056));

            datums.Add (TurkishNationalReferenceFrame);
            TurkishNationalReferenceFrame.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Turkish National Reference Frame", 1057));
            TurkishNationalReferenceFrame.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Turkish_National_Reference_Frame", 0));

            datums.Add (BhutanNationalGeodeticGeodeticDatum);
            BhutanNationalGeodeticGeodeticDatum.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bhutan National Geodetic GeodeticDatum", 1058));

            datums.Add (IslandsNet2004);
            IslandsNet2004.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Islands Net 2004", 1060));

            datums.Add (InternationalTerrestrialReferenceFrame2008);
            InternationalTerrestrialReferenceFrame2008.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 2008", 1061));

            datums.Add (PosicionesGeodesicasArgentinas2007);
            PosicionesGeodesicasArgentinas2007.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Posiciones Geodesicas Argentinas 2007", 1062));

            datums.Add (MarcoGeodesicoNacional);
            MarcoGeodesicoNacional.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Marco Geodesico Nacional", 1063));
            MarcoGeodesicoNacional.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Marco_Geodesico_Nacional", 0));

            datums.Add (SIRGASChile);
            SIRGASChile.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SIRGAS-Chile", 1064));
            SIRGASChile.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_SIRGAS-Chile", 0));

            datums.Add (CostaRica2005);
            CostaRica2005.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Costa Rica 2005", 1065));
            CostaRica2005.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Costa_Rica_2005", 0));

            datums.Add (SistemaGeodesicoNacionaldePanamaMACARIOSOLIS);
            SistemaGeodesicoNacionaldePanamaMACARIOSOLIS.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sistema Geodesico Nacional de Panama MACARIO SOLIS", 1066));

            datums.Add (Peru96);
            Peru96.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Peru96", 1067));
            Peru96.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Peru96", 0));

            datums.Add (SIRGASROU98);
            SIRGASROU98.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SIRGAS-ROU98", 1068));
            SIRGASROU98.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_SIRGAS-ROU98", 0));

            datums.Add (SIRGASES20078);
            SIRGASES20078.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SIRGAS_ES2007.8", 1069));
            SIRGASES20078.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_SIRGAS_ES2007.8", 0));

            datums.Add (Ocotepeque1935);
            Ocotepeque1935.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ocotepeque 1935", 1070));
            Ocotepeque1935.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Ocotepeque_1935", 0));

            datums.Add (SibunGorge1922);
            SibunGorge1922.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sibun Gorge 1922", 1071));
            SibunGorge1922.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sibun_Gorge_1922", 0));

            datums.Add (PanamaColon1911);
            PanamaColon1911.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Panama-Colon 1911", 1072));

            datums.Add (ReseauGeodesiquedesAntillesFrancaises2009);
            ReseauGeodesiquedesAntillesFrancaises2009.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau Geodesique des Antilles Francaises 2009", 1073));
            ReseauGeodesiquedesAntillesFrancaises2009.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Reseau_Geodesique_des_Antilles_Francaises_2009", 0));

            datums.Add (CorregoAlegre1961);
            CorregoAlegre1961.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Corrego Alegre 1961", 1074));
            CorregoAlegre1961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Corrego_Alegre_1961", 0));

            datums.Add (SouthAmericanGeodeticDatum196996);
            SouthAmericanGeodeticDatum196996.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "South American GeodeticDatum 1969(96)", 1075));

            datums.Add (PapuaNewGuineaGeodeticGeodeticDatum1994);
            PapuaNewGuineaGeodeticGeodeticDatum1994.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Papua New Guinea Geodetic GeodeticDatum 1994", 1076));

            datums.Add (Ukraine2000);
            Ukraine2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ukraine 2000", 1077));
            Ukraine2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Ukraine_2000", 0));

            datums.Add (FehmarnbeltGeodeticDatum2010);
            FehmarnbeltGeodeticDatum2010.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Fehmarnbelt GeodeticDatum 2010", 1078));

            datums.Add (DeutscheBahnReferenceSystem);
            DeutscheBahnReferenceSystem.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Deutsche Bahn Reference System", 1081));
            DeutscheBahnReferenceSystem.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Deutsche_Bahn_Reference_System", 0));

            datums.Add (TongaGeodeticGeodeticDatum2005);
            TongaGeodeticGeodeticDatum2005.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tonga Geodetic GeodeticDatum 2005", 1095));

            datums.Add (CaymanIslandsGeodeticGeodeticDatum2011);
            CaymanIslandsGeodeticGeodeticDatum2011.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Cayman Islands Geodetic GeodeticDatum 2011", 1100));

            datums.Add (NotSpecifiedAiry1830);
            NotSpecifiedAiry1830.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Airy 1830 )", 6001));

            datums.Add (NotSpecifiedAiryModified1849);
            NotSpecifiedAiryModified1849.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Airy Modified 1849 )", 6002));

            datums.Add (NotSpecifiedAustralianNationalSpheroid);
            NotSpecifiedAustralianNationalSpheroid.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Australian National Spheroid)", 6003));

            datums.Add (NotSpecifiedBessel1841);
            NotSpecifiedBessel1841.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Bessel 1841 )", 6004));

            datums.Add (NotSpecifiedBesselModified);
            NotSpecifiedBesselModified.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Bessel Modified )", 6005));

            datums.Add (NotSpecifiedBesselNamibia);
            NotSpecifiedBesselNamibia.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Bessel Namibia )", 6006));

            datums.Add (NotSpecifiedClarke1858);
            NotSpecifiedClarke1858.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Clarke 1858 )", 6007));

            datums.Add (NotSpecifiedClarke1866);
            NotSpecifiedClarke1866.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Clarke 1866 )", 6008));

            datums.Add (NotSpecifiedClarke1880Benoit);
            NotSpecifiedClarke1880Benoit.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Clarke 1880 (Benoit) )", 6010));

            datums.Add (NotSpecifiedClarke1880IGN);
            NotSpecifiedClarke1880IGN.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Clarke 1880 (IGN) )", 6011));

            datums.Add (NotSpecifiedClarke1880RGS);
            NotSpecifiedClarke1880RGS.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Clarke 1880 (RGS) )", 6012));

            datums.Add (NotSpecifiedClarke1880Arc);
            NotSpecifiedClarke1880Arc.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Clarke 1880 (Arc) )", 6013));

            datums.Add (NotSpecifiedClarke1880SGA1922);
            NotSpecifiedClarke1880SGA1922.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Clarke 1880 (SGA 1922) )", 6014));

            datums.Add (NotSpecifiedEverest18301937Adjustment);
            NotSpecifiedEverest18301937Adjustment.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Everest 1830 (1937 Adjustment) )", 6015));

            datums.Add (NotSpecifiedEverest18301967Definition);
            NotSpecifiedEverest18301967Definition.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Everest 1830 (1967 Definition) )", 6016));

            datums.Add (NotSpecifiedEverest1830Modified);
            NotSpecifiedEverest1830Modified.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Everest 1830 Modified )", 6018));

            datums.Add (NotSpecifiedGRS1980);
            NotSpecifiedGRS1980.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on GRS 1980 )", 6019));

            datums.Add (NotSpecifiedHelmert1906);
            NotSpecifiedHelmert1906.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Helmert 1906 )", 6020));

            datums.Add (NotSpecifiedIndonesianNationalSpheroid);
            NotSpecifiedIndonesianNationalSpheroid.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Indonesian National Spheroid)", 6021));

            datums.Add (NotSpecifiedInternational1924);
            NotSpecifiedInternational1924.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on International 1924 )", 6022));

            datums.Add (NotSpecifiedKrassowsky1940);
            NotSpecifiedKrassowsky1940.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Krassowsky 1940 )", 6024));

            datums.Add (NotSpecifiedNWL9D);
            NotSpecifiedNWL9D.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on NWL 9D )", 6025));

            datums.Add (NotSpecifiedPlessis1817);
            NotSpecifiedPlessis1817.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Plessis 1817 )", 6027));

            datums.Add (NotSpecifiedStruve1860);
            NotSpecifiedStruve1860.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Struve 1860 )", 6028));

            datums.Add (NotSpecifiedWarOffice);
            NotSpecifiedWarOffice.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on War Office )", 6029));

            datums.Add (NotSpecifiedWGS84);
            NotSpecifiedWGS84.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on WGS 84 )", 6030));

            datums.Add (NotSpecifiedGEM10C);
            NotSpecifiedGEM10C.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on GEM 10C )", 6031));

            datums.Add (NotSpecifiedOSU86F);
            NotSpecifiedOSU86F.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on OSU86F )", 6032));

            datums.Add (NotSpecifiedOSU91A);
            NotSpecifiedOSU91A.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on OSU91A )", 6033));

            datums.Add (NotSpecifiedGRS1967);
            NotSpecifiedGRS1967.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on GRS 1967 )", 6036));

            datums.Add (AverageTerrestrialSystem1977);
            AverageTerrestrialSystem1977.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Average Terrestrial System 1977", 6122));

            datums.Add (NotSpecifiedWGS72);
            NotSpecifiedWGS72.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on WGS 72 )", 6043));

            datums.Add (NotSpecifiedEverest18301962Definition);
            NotSpecifiedEverest18301962Definition.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Everest 1830 (1962 Definition) )", 6044));

            datums.Add (NotSpecifiedEverest18301975Definition);
            NotSpecifiedEverest18301975Definition.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Everest 1830 (1975 Definition) )", 6045));

            datums.Add (NotSpecifiedGRS1980AuthalicSphere);
            NotSpecifiedGRS1980AuthalicSphere.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on GRS 1980 Authalic Sphere)", 6047));

            datums.Add (NotSpecifiedClarke1866AuthalicSphere);
            NotSpecifiedClarke1866AuthalicSphere.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Clarke 1866 Authalic Sphere)", 6052));

            datums.Add (NotSpecifiedInternational1924AuthalicSphere);
            NotSpecifiedInternational1924AuthalicSphere.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on International 1924 Authalic Sphere)", 6053));

            datums.Add (NotSpecifiedHughes1980);
            NotSpecifiedHughes1980.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Not specified (based on Hughes 1980 )", 6054));

            datums.Add (Greek);
            Greek.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Greek", 6120));
            Greek.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Greek", 0));

            datums.Add (GreekGeodeticReferenceSystem1987);
            GreekGeodeticReferenceSystem1987.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Greek Geodetic Reference System 1987", 6121));

            datums.Add (Kartastokoordinaattijarjestelma1966);
            Kartastokoordinaattijarjestelma1966.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kartastokoordinaattijarjestelma (1966)", 6123));

            datums.Add (Riketskoordinatsystem1990);
            Riketskoordinatsystem1990.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Rikets koordinatsystem 1990", 6124));

            datums.Add (Lithuania1994ETRS89);
            Lithuania1994ETRS89.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lithuania 1994 (ETRS89)", 6126));

            datums.Add (Tete);
            Tete.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tete", 6127));
            Tete.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Tete", 0));

            datums.Add (Madzansua);
            Madzansua.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Madzansua", 6128));
            Madzansua.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Madzansua", 0));

            datums.Add (Observatario);
            Observatario.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Observatario", 6129));
            Observatario.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Observatario", 0));

            datums.Add (MoznetITRF94);
            MoznetITRF94.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Moznet (ITRF94)", 6130));

            datums.Add (Indian1960);
            Indian1960.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Indian 1960", 6131));
            Indian1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Indian_1960", 0));

            datums.Add (FinalGeodeticDatum1958);
            FinalGeodeticDatum1958.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Final GeodeticDatum 1958", 6132));

            datums.Add (Estonia1992);
            Estonia1992.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Estonia 1992", 6133));
            Estonia1992.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Estonia_1992", 0));

            datums.Add (PDOSurveyGeodeticDatum1993);
            PDOSurveyGeodeticDatum1993.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "PDO Survey GeodeticDatum 1993", 6134));

            datums.Add (OldHawaiian);
            OldHawaiian.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Old Hawaiian", 6135));
            OldHawaiian.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Old_Hawaiian", 0));

            datums.Add (StLawrenceIsland);
            StLawrenceIsland.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Lawrence Island", 6136));

            datums.Add (StPaulIsland);
            StPaulIsland.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Paul Island", 6137));

            datums.Add (StGeorgeIsland);
            StGeorgeIsland.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. George Island", 6138));

            datums.Add (PuertoRico);
            PuertoRico.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Puerto Rico", 6139));
            PuertoRico.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Puerto_Rico", 0));

            datums.Add (NAD83CanadianSpatialReferenceSystem);
            NAD83CanadianSpatialReferenceSystem.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NAD83 Canadian Spatial Reference System", 6140));

            datums.Add (Israel);
            Israel.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Israel", 6141));
            Israel.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Israel", 0));

            datums.Add (Locodjo1965);
            Locodjo1965.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Locodjo 1965", 6142));
            Locodjo1965.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Locodjo_1965", 0));

            datums.Add (Abidjan1987);
            Abidjan1987.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Abidjan 1987", 6143));
            Abidjan1987.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Abidjan_1987", 0));

            datums.Add (Kalianpur1937);
            Kalianpur1937.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kalianpur 1937", 6144));
            Kalianpur1937.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kalianpur_1937", 0));

            datums.Add (Kalianpur1962);
            Kalianpur1962.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kalianpur 1962", 6145));
            Kalianpur1962.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kalianpur_1962", 0));

            datums.Add (Kalianpur1975);
            Kalianpur1975.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kalianpur 1975", 6146));
            Kalianpur1975.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kalianpur_1975", 0));

            datums.Add (Hanoi1972);
            Hanoi1972.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hanoi 1972", 6147));
            Hanoi1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hanoi_1972", 0));

            datums.Add (Hartebeesthoek94);
            Hartebeesthoek94.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hartebeesthoek94", 6148));

            datums.Add (CH1903);
            CH1903.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "CH1903", 6149));
            CH1903.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_CH1903", 0));

            datums.Add (CH1903Plus);
            CH1903Plus.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "CH1903+", 6150));
            CH1903Plus.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_CH1903+", 0));

            datums.Add (SwissTerrestrialReferenceFrame1995);
            SwissTerrestrialReferenceFrame1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Swiss Terrestrial Reference Frame 1995", 6151));

            datums.Add (NAD83HighAccuracyReferenceNetwork);
            NAD83HighAccuracyReferenceNetwork.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NAD83 (High Accuracy Reference Network)", 6152));

            datums.Add (Rassadiran);
            Rassadiran.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Rassadiran", 6153));
            Rassadiran.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Rassadiran", 0));

            datums.Add (EuropeanGeodeticDatum19501977);
            EuropeanGeodeticDatum19501977.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "European GeodeticDatum 1950(1977)", 6154));

            datums.Add (Dabola1981);
            Dabola1981.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Dabola 1981", 6155));
            Dabola1981.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Dabola_1981", 0));

            datums.Add (SystemJednotneTrigonometrickeSiteKatastralni);
            SystemJednotneTrigonometrickeSiteKatastralni.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "System Jednotne Trigonometricke Site Katastralni", 6156));

            datums.Add (MountDillon);
            MountDillon.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mount Dillon", 6157));
            MountDillon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Mount_Dillon", 0));

            datums.Add (Naparima1955);
            Naparima1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Naparima 1955", 6158));
            Naparima1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Naparima_1955", 0));

            datums.Add (EuropeanLibyanGeodeticDatum1979);
            EuropeanLibyanGeodeticDatum1979.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "European Libyan GeodeticDatum 1979", 6159));

            datums.Add (ChosMalal1914);
            ChosMalal1914.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Chos Malal 1914", 6160));
            ChosMalal1914.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Chos_Malal_1914", 0));

            datums.Add (PampadelCastillo);
            PampadelCastillo.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pampa del Castillo", 6161));
            PampadelCastillo.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Pampa_del_Castillo", 0));

            datums.Add (KoreanGeodeticDatum1985);
            KoreanGeodeticDatum1985.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Korean GeodeticDatum 1985", 6162));

            datums.Add (YemenNationalGeodeticNetwork1996);
            YemenNationalGeodeticNetwork1996.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Yemen National Geodetic Network 1996", 6163));

            datums.Add (SouthYemen);
            SouthYemen.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "South Yemen", 6164));
            SouthYemen.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_South_Yemen", 0));

            datums.Add (Bissau);
            Bissau.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bissau", 6165));
            Bissau.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bissau", 0));

            datums.Add (KoreanGeodeticDatum1995);
            KoreanGeodeticDatum1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Korean GeodeticDatum 1995", 6166));

            datums.Add (NewZealandGeodeticGeodeticDatum2000);
            NewZealandGeodeticGeodeticDatum2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "New Zealand Geodetic GeodeticDatum 2000", 6167));

            datums.Add (Accra);
            Accra.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Accra", 6168));
            Accra.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Accra", 0));

            datums.Add (AmericanSamoa1962);
            AmericanSamoa1962.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "American Samoa 1962", 6169));
            AmericanSamoa1962.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_American_Samoa_1962", 0));

            datums.Add (SistemadeReferenciaGeocentricoparaAmericadelSur1995);
            SistemadeReferenciaGeocentricoparaAmericadelSur1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sistema de Referencia Geocentrico para America del Sur 1995", 6170));

            datums.Add (ReseauGeodesiqueFrancais1993);
            ReseauGeodesiqueFrancais1993.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau Geodesique Francais 1993", 6171));

            datums.Add (IRENET95);
            IRENET95.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IRENET95", 6173));
            IRENET95.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_IRENET95", 0));

            datums.Add (SierraLeoneColony1924);
            SierraLeoneColony1924.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sierra Leone Colony 1924", 6174));

            datums.Add (SierraLeone1968);
            SierraLeone1968.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sierra Leone 1968", 6175));
            SierraLeone1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sierra_Leone_1968", 0));

            datums.Add (AustralianAntarcticGeodeticDatum1998);
            AustralianAntarcticGeodeticDatum1998.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Australian Antarctic GeodeticDatum 1998", 6176));

            datums.Add (Pulkovo194283);
            Pulkovo194283.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pulkovo 1942(83)", 6178));

            datums.Add (Pulkovo194258);
            Pulkovo194258.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pulkovo 1942(58)", 6179));

            datums.Add (Estonia1997);
            Estonia1997.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Estonia 1997", 6180));
            Estonia1997.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Estonia_1997", 0));

            datums.Add (Luxembourg1930);
            Luxembourg1930.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Luxembourg 1930", 6181));
            Luxembourg1930.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Luxembourg_1930", 0));

            datums.Add (AzoresOccidentalIslands1939);
            AzoresOccidentalIslands1939.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Azores Occidental Islands 1939", 6182));
            AzoresOccidentalIslands1939.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Azores_Occidental_Islands_1939", 0));

            datums.Add (AzoresCentralIslands1948);
            AzoresCentralIslands1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Azores Central Islands 1948", 6183));
            AzoresCentralIslands1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Azores_Central_Islands_1948", 0));

            datums.Add (AzoresOrientalIslands1940);
            AzoresOrientalIslands1940.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Azores Oriental Islands 1940", 6184));
            AzoresOrientalIslands1940.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Azores_Oriental_Islands_1940", 0));

            datums.Add (OSNI1952);
            OSNI1952.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "OSNI 1952", 6188));
            OSNI1952.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_OSNI_1952", 0));

            datums.Add (RedGeodesicaVenezolana);
            RedGeodesicaVenezolana.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Red Geodesica Venezolana", 6189));

            datums.Add (PosicionesGeodesicasArgentinas1998);
            PosicionesGeodesicasArgentinas1998.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Posiciones Geodesicas Argentinas 1998", 6190));

            datums.Add (Albanian1987);
            Albanian1987.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Albanian 1987", 6191));
            Albanian1987.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Albanian_1987", 0));

            datums.Add (Douala1948);
            Douala1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Douala 1948", 6192));
            Douala1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Douala_1948", 0));

            datums.Add (Manoca1962);
            Manoca1962.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Manoca 1962", 6193));
            Manoca1962.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Manoca_1962", 0));

            datums.Add (Qornoq1927);
            Qornoq1927.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Qornoq 1927", 6194));
            Qornoq1927.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Qornoq_1927", 0));

            datums.Add (Scoresbysund1952);
            Scoresbysund1952.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Scoresbysund 1952", 6195));
            Scoresbysund1952.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Scoresbysund_1952", 0));

            datums.Add (Ammassalik1958);
            Ammassalik1958.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ammassalik 1958", 6196));
            Ammassalik1958.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Ammassalik_1958", 0));

            datums.Add (Garoua);
            Garoua.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Garoua", 6197));
            Garoua.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Garoua", 0));

            datums.Add (Kousseri);
            Kousseri.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kousseri", 6198));
            Kousseri.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kousseri", 0));

            datums.Add (Egypt1930);
            Egypt1930.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Egypt 1930", 6199));
            Egypt1930.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Egypt_1930", 0));

            datums.Add (Pulkovo1995);
            Pulkovo1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pulkovo 1995", 6200));
            Pulkovo1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Pulkovo_1995", 0));

            datums.Add (Adindan);
            Adindan.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Adindan", 6201));
            Adindan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Adindan", 0));

            datums.Add (AustralianGeodeticGeodeticDatum1966);
            AustralianGeodeticGeodeticDatum1966.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Australian Geodetic GeodeticDatum 1966", 6202));

            datums.Add (AustralianGeodeticGeodeticDatum1984);
            AustralianGeodeticGeodeticDatum1984.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Australian Geodetic GeodeticDatum 1984", 6203));

            datums.Add (AinelAbd1970);
            AinelAbd1970.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ain el Abd 1970", 6204));
            AinelAbd1970.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Ain_el_Abd_1970", 0));

            datums.Add (Afgooye);
            Afgooye.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Afgooye", 6205));
            Afgooye.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Afgooye", 0));

            datums.Add (Agadez);
            Agadez.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Agadez", 6206));
            Agadez.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Agadez", 0));

            datums.Add (Lisbon1937);
            Lisbon1937.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lisbon 1937", 6207));

            datums.Add (Aratu);
            Aratu.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Aratu", 6208));
            Aratu.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Aratu", 0));

            datums.Add (Arc1950);
            Arc1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Arc 1950", 6209));
            Arc1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Arc_1950", 0));

            datums.Add (Arc1960);
            Arc1960.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Arc 1960", 6210));
            Arc1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Arc_1960", 0));

            datums.Add (Batavia);
            Batavia.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Batavia", 6211));
            Batavia.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Batavia", 0));

            datums.Add (Barbados1938);
            Barbados1938.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Barbados 1938", 6212));
            Barbados1938.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Barbados_1938", 0));

            datums.Add (Beduaram);
            Beduaram.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Beduaram", 6213));
            Beduaram.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Beduaram", 0));

            datums.Add (Beijing1954);
            Beijing1954.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Beijing 1954", 6214));
            Beijing1954.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Beijing_1954", 0));

            datums.Add (ReseauNationalBelge1950);
            ReseauNationalBelge1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau National Belge 1950", 6215));

            datums.Add (Bermuda1957);
            Bermuda1957.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bermuda 1957", 6216));
            Bermuda1957.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bermuda_1957", 0));

            datums.Add (Bogota1975);
            Bogota1975.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bogota 1975", 6218));

            datums.Add (BukitRimpah);
            BukitRimpah.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bukit Rimpah", 6219));
            BukitRimpah.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bukit_Rimpah", 0));

            datums.Add (Camacupa);
            Camacupa.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Camacupa", 6220));
            Camacupa.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Camacupa", 0));

            datums.Add (CampoInchauspe);
            CampoInchauspe.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Campo Inchauspe", 6221));
            CampoInchauspe.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Campo_Inchauspe", 0));

            datums.Add (Cape);
            Cape.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Cape", 6222));
            Cape.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Cape", 0));

            datums.Add (Carthage);
            Carthage.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Carthage", 6223));
            Carthage.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Carthage", 0));

            datums.Add (Chua);
            Chua.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Chua", 6224));
            Chua.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Chua", 0));

            datums.Add (CorregoAlegre197072);
            CorregoAlegre197072.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Corrego Alegre 1970-72", 6225));

            datums.Add (DeirezZor);
            DeirezZor.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Deir ez Zor", 6227));
            DeirezZor.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Deir_ez_Zor", 0));

            datums.Add (Egypt1907);
            Egypt1907.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Egypt 1907", 6229));
            Egypt1907.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Egypt_1907", 0));

            datums.Add (EuropeanGeodeticDatum1950);
            EuropeanGeodeticDatum1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "European GeodeticDatum 1950", 6230));

            datums.Add (EuropeanGeodeticDatum1987);
            EuropeanGeodeticDatum1987.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "European GeodeticDatum 1987", 6231));

            datums.Add (Fahud);
            Fahud.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Fahud", 6232));
            Fahud.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Fahud", 0));

            datums.Add (HuTzuShan1950);
            HuTzuShan1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hu Tzu Shan 1950", 6236));

            datums.Add (HungarianGeodeticDatum1972);
            HungarianGeodeticDatum1972.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hungarian GeodeticDatum 1972", 6237));

            datums.Add (IndonesianGeodeticDatum1974);
            IndonesianGeodeticDatum1974.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Indonesian GeodeticDatum 1974", 6238));

            datums.Add (Indian1954);
            Indian1954.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Indian 1954", 6239));
            Indian1954.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Indian_1954", 0));

            datums.Add (Indian1975);
            Indian1975.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Indian 1975", 6240));
            Indian1975.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Indian_1975", 0));

            datums.Add (Jamaica1969);
            Jamaica1969.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Jamaica 1969", 6242));
            Jamaica1969.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Jamaica_1969", 0));

            datums.Add (Kandawala);
            Kandawala.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kandawala", 6244));
            Kandawala.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kandawala", 0));

            datums.Add (Kertau1968);
            Kertau1968.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kertau 1968", 6245));

            datums.Add (KuwaitOilCompany);
            KuwaitOilCompany.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kuwait Oil Company", 6246));
            KuwaitOilCompany.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kuwait_Oil_Company", 0));

            datums.Add (LaCanoa);
            LaCanoa.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "La Canoa", 6247));
            LaCanoa.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_La_Canoa", 0));

            datums.Add (ProvisionalSouthAmericanGeodeticDatum1956);
            ProvisionalSouthAmericanGeodeticDatum1956.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Provisional South American GeodeticDatum 1956", 6248));

            datums.Add (Lake);
            Lake.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lake", 6249));
            Lake.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Lake", 0));

            datums.Add (Leigon);
            Leigon.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Leigon", 6250));
            Leigon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Leigon", 0));

            datums.Add (Liberia1964);
            Liberia1964.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Liberia 1964", 6251));
            Liberia1964.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Liberia_1964", 0));

            datums.Add (Lome);
            Lome.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lome", 6252));
            Lome.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Lome", 0));

            datums.Add (Luzon1911);
            Luzon1911.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Luzon 1911", 6253));
            Luzon1911.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Luzon_1911", 0));

            datums.Add (HitoXVIII1963);
            HitoXVIII1963.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hito XVIII 1963", 6254));
            HitoXVIII1963.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hito_XVIII_1963", 0));

            datums.Add (HeratNorth);
            HeratNorth.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Herat North", 6255));
            HeratNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Herat_North", 0));

            datums.Add (Mahe1971);
            Mahe1971.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mahe 1971", 6256));
            Mahe1971.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Mahe_1971", 0));

            datums.Add (Makassar);
            Makassar.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Makassar", 6257));
            Makassar.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Makassar", 0));

            datums.Add (EuropeanTerrestrialReferenceSystem1989);
            EuropeanTerrestrialReferenceSystem1989.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "European Terrestrial Reference System 1989", 6258));

            datums.Add (Malongo1987);
            Malongo1987.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Malongo 1987", 6259));
            Malongo1987.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Malongo_1987", 0));

            datums.Add (Merchich);
            Merchich.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Merchich", 6261));
            Merchich.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Merchich", 0));

            datums.Add (Massawa);
            Massawa.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Massawa", 6262));
            Massawa.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Massawa", 0));

            datums.Add (Minna);
            Minna.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Minna", 6263));
            Minna.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Minna", 0));

            datums.Add (MonteMario);
            MonteMario.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Monte Mario", 6265));
            MonteMario.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Monte_Mario", 0));

            datums.Add (Mporaloko);
            Mporaloko.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "M'poraloko", 6266));

            datums.Add (NorthAmericanGeodeticDatum1927);
            NorthAmericanGeodeticDatum1927.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "North American GeodeticDatum 1927", 6267));

            datums.Add (NorthAmericanGeodeticDatum1983);
            NorthAmericanGeodeticDatum1983.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "North American GeodeticDatum 1983", 6269));

            datums.Add (Nahrwan1967);
            Nahrwan1967.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nahrwan 1967", 6270));
            Nahrwan1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Nahrwan_1967", 0));

            datums.Add (Naparima1972);
            Naparima1972.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Naparima 1972", 6271));
            Naparima1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Naparima_1972", 0));

            datums.Add (NewZealandGeodeticGeodeticDatum1949);
            NewZealandGeodeticGeodeticDatum1949.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "New Zealand Geodetic GeodeticDatum 1949", 6272));

            datums.Add (NGO1948);
            NGO1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NGO 1948", 6273));
            NGO1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NGO_1948", 0));

            datums.Add (GeodeticDatum73);
            GeodeticDatum73.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GeodeticDatum 73", 6274));

            datums.Add (NouvelleTriangulationFrancaise);
            NouvelleTriangulationFrancaise.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nouvelle Triangulation Francaise", 6275));

            datums.Add (NSWC9Z2);
            NSWC9Z2.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NSWC 9Z-2", 6276));

            datums.Add (OSGB1936);
            OSGB1936.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "OSGB 1936", 6277));
            OSGB1936.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_OSGB_1936", 0));

            datums.Add (OSGB1970SN);
            OSGB1970SN.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "OSGB 1970 (SN)", 6278));
            OSGB1970SN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_OSGB_1970_SN", 0));

            datums.Add (OSSN1980);
            OSSN1980.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "OS (SN) 1980", 6279));
            OSSN1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_OS_SN_1980", 0));

            datums.Add (Padang1884);
            Padang1884.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Padang 1884", 6280));
            Padang1884.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Padang_1884", 0));

            datums.Add (Palestine1923);
            Palestine1923.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Palestine 1923", 6281));
            Palestine1923.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Palestine_1923", 0));

            datums.Add (Congo1960PointeNoire);
            Congo1960PointeNoire.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Congo 1960 Pointe Noire", 6282));

            datums.Add (GeocentricGeodeticDatumofAustralia1994);
            GeocentricGeodeticDatumofAustralia1994.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Geocentric GeodeticDatum of Australia 1994", 6283));

            datums.Add (Pulkovo1942);
            Pulkovo1942.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pulkovo 1942", 6284));
            Pulkovo1942.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Pulkovo_1942", 0));

            datums.Add (Qatar1974);
            Qatar1974.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Qatar 1974", 6285));

            datums.Add (Qatar1948);
            Qatar1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Qatar 1948", 6286));
            Qatar1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Qatar_1948", 0));

            datums.Add (LomaQuintana);
            LomaQuintana.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Loma Quintana", 6288));
            LomaQuintana.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Loma_Quintana", 0));

            datums.Add (Amersfoort);
            Amersfoort.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Amersfoort", 6289));
            Amersfoort.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Amersfoort", 0));

            datums.Add (SapperHill1943);
            SapperHill1943.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sapper Hill 1943", 6292));
            SapperHill1943.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sapper_Hill_1943", 0));

            datums.Add (Schwarzeck);
            Schwarzeck.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Schwarzeck", 6293));
            Schwarzeck.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Schwarzeck", 0));

            datums.Add (Serindung);
            Serindung.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Serindung", 6295));
            Serindung.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Serindung", 0));

            datums.Add (Tananarive1925);
            Tananarive1925.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tananarive 1925", 6297));
            Tananarive1925.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Tananarive_1925", 0));

            datums.Add (Timbalai1948);
            Timbalai1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Timbalai 1948", 6298));
            Timbalai1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Timbalai_1948", 0));

            datums.Add (TM65);
            TM65.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "TM65", 6299));
            TM65.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_TM65", 0));

            datums.Add (GeodeticGeodeticDatumof1965);
            GeodeticGeodeticDatumof1965.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Geodetic GeodeticDatum of 1965", 6300));

            datums.Add (Tokyo);
            Tokyo.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tokyo", 6301));
            Tokyo.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Tokyo", 0));

            datums.Add (Trinidad1903);
            Trinidad1903.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Trinidad 1903", 6302));
            Trinidad1903.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Trinidad_1903", 0));

            datums.Add (TrucialCoast1948);
            TrucialCoast1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Trucial Coast 1948", 6303));
            TrucialCoast1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Trucial_Coast_1948", 0));

            datums.Add (Voirol1875);
            Voirol1875.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Voirol 1875", 6304));
            Voirol1875.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Voirol_1875", 0));

            datums.Add (Bern1938);
            Bern1938.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bern 1938", 6306));
            Bern1938.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bern_1938", 0));

            datums.Add (NordSahara1959);
            NordSahara1959.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nord Sahara 1959", 6307));
            NordSahara1959.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Nord_Sahara_1959", 0));

            datums.Add (Stockholm1938);
            Stockholm1938.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Stockholm 1938", 6308));
            Stockholm1938.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Stockholm_1938", 0));

            datums.Add (Yacare);
            Yacare.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Yacare", 6309));
            Yacare.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Yacare", 0));

            datums.Add (Yoff);
            Yoff.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Yoff", 6310));
            Yoff.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Yoff", 0));

            datums.Add (Zanderij);
            Zanderij.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Zanderij", 6311));
            Zanderij.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Zanderij", 0));

            datums.Add (MilitarGeographischeInstitut);
            MilitarGeographischeInstitut.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Militar-Geographische Institut", 6312));

            datums.Add (ReseauNationalBelge1972);
            ReseauNationalBelge1972.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau National Belge 1972", 6313));

            datums.Add (DeutschesHauptdreiecksnetz);
            DeutschesHauptdreiecksnetz.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Deutsches Hauptdreiecksnetz", 6314));
            DeutschesHauptdreiecksnetz.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Deutsches_Hauptdreiecksnetz", 0));

            datums.Add (Conakry1905);
            Conakry1905.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Conakry 1905", 6315));
            Conakry1905.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Conakry_1905", 0));

            datums.Add (DealulPiscului1930);
            DealulPiscului1930.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Dealul Piscului 1930", 6316));

            datums.Add (NationalGeodeticNetwork);
            NationalGeodeticNetwork.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "National Geodetic Network", 6318));

            datums.Add (KuwaitUtility);
            KuwaitUtility.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kuwait Utility", 6319));
            KuwaitUtility.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kuwait_Utility", 0));

            datums.Add (WorldGeodeticSystem1972);
            WorldGeodeticSystem1972.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "World Geodetic System 1972", 6322));

            datums.Add (WGS72TransitBroadcastEphemeris);
            WGS72TransitBroadcastEphemeris.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "WGS 72 Transit Broadcast Ephemeris", 6324));

            datums.Add (WorldGeodeticSystem1984);
            WorldGeodeticSystem1984.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "World Geodetic System 1984", 6326));

            datums.Add (Anguilla1957);
            Anguilla1957.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Anguilla 1957", 6600));
            Anguilla1957.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Anguilla_1957", 0));

            datums.Add (Antigua1943);
            Antigua1943.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Antigua 1943", 6601));
            Antigua1943.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Antigua_1943", 0));

            datums.Add (Dominica1945);
            Dominica1945.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Dominica 1945", 6602));
            Dominica1945.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Dominica_1945", 0));

            datums.Add (Grenada1953);
            Grenada1953.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Grenada 1953", 6603));
            Grenada1953.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Grenada_1953", 0));

            datums.Add (Montserrat1958);
            Montserrat1958.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Montserrat 1958", 6604));
            Montserrat1958.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Montserrat_1958", 0));

            datums.Add (StKitts1955);
            StKitts1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Kitts 1955", 6605));

            datums.Add (StLucia1955);
            StLucia1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Lucia 1955", 6606));

            datums.Add (StVincent1945);
            StVincent1945.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Vincent 1945", 6607));

            datums.Add (NorthAmericanGeodeticDatum19271976);
            NorthAmericanGeodeticDatum19271976.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "North American GeodeticDatum 1927 (1976)", 6608));

            datums.Add (NorthAmericanGeodeticDatum1927CGQ77);
            NorthAmericanGeodeticDatum1927CGQ77.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "North American GeodeticDatum 1927 (CGQ77)", 6609));

            datums.Add (Xian1980);
            Xian1980.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Xian 1980", 6610));
            Xian1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Xian_1980", 0));

            datums.Add (HongKong1980);
            HongKong1980.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hong Kong 1980", 6611));
            HongKong1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hong_Kong_1980", 0));

            datums.Add (JapaneseGeodeticGeodeticDatum2000);
            JapaneseGeodeticGeodeticDatum2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Japanese Geodetic GeodeticDatum 2000", 6612));

            datums.Add (GunungSegara);
            GunungSegara.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Gunung Segara", 6613));
            GunungSegara.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Gunung_Segara", 0));

            datums.Add (QatarNationalGeodeticDatum1995);
            QatarNationalGeodeticDatum1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Qatar National GeodeticDatum 1995", 6614));

            datums.Add (PortoSanto1936);
            PortoSanto1936.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Porto Santo 1936", 6615));
            PortoSanto1936.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Porto_Santo_1936", 0));

            datums.Add (SelvagemGrande);
            SelvagemGrande.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Selvagem Grande", 6616));

            datums.Add (SouthAmericanGeodeticDatum1969);
            SouthAmericanGeodeticDatum1969.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "South American GeodeticDatum 1969", 6618));

            datums.Add (SWEREF99);
            SWEREF99.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SWEREF99", 6619));
            SWEREF99.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_SWEREF99", 0));

            datums.Add (Point58);
            Point58.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Point 58", 6620));
            Point58.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Point_58", 0));

            datums.Add (FortMarigot);
            FortMarigot.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Fort Marigot", 6621));
            FortMarigot.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Fort_Marigot", 0));

            datums.Add (Guadeloupe1948);
            Guadeloupe1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Guadeloupe 1948", 6622));

            datums.Add (CentreSpatialGuyanais1967);
            CentreSpatialGuyanais1967.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Centre Spatial Guyanais 1967", 6623));

            datums.Add (ReseauGeodesiqueFrancaisGuyane1995);
            ReseauGeodesiqueFrancaisGuyane1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau Geodesique Francais Guyane 1995", 6624));

            datums.Add (Martinique1938);
            Martinique1938.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Martinique 1938", 6625));

            datums.Add (Reunion1947);
            Reunion1947.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reunion 1947", 6626));
            Reunion1947.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Reunion_1947", 0));

            datums.Add (ReseauGeodesiquedelaReunion1992);
            ReseauGeodesiquedelaReunion1992.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau Geodesique de la Reunion 1992", 6627));

            datums.Add (Tahiti52);
            Tahiti52.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tahiti 52", 6628));

            datums.Add (Tahaa54);
            Tahaa54.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tahaa 54", 6629));

            datums.Add (IGN72NukuHiva);
            IGN72NukuHiva.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN72 Nuku Hiva", 6630));
            IGN72NukuHiva.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_IGN72_Nuku_Hiva", 0));

            datums.Add (Combani1950);
            Combani1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Combani 1950", 6632));
            Combani1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Combani_1950", 0));

            datums.Add (IGN56Lifou);
            IGN56Lifou.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN56 Lifou", 6633));
            IGN56Lifou.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_IGN56_Lifou", 0));

            datums.Add (IGN72GrandeTerre);
            IGN72GrandeTerre.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN72 Grande Terre", 6634));
            IGN72GrandeTerre.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_IGN72_Grande_Terre", 0));

            datums.Add (Petrels1972);
            Petrels1972.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Petrels 1972", 6636));
            Petrels1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Petrels_1972", 0));

            datums.Add (PointeGeologiePerroud1950);
            PointeGeologiePerroud1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pointe Geologie Perroud 1950", 6637));
            PointeGeologiePerroud1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Pointe_Geologie_Perroud_1950", 0));

            datums.Add (SaintPierreetMiquelon1950);
            SaintPierreetMiquelon1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Saint Pierre et Miquelon 1950", 6638));
            SaintPierreetMiquelon1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Saint_Pierre_et_Miquelon_1950", 0));

            datums.Add (MOP78);
            MOP78.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "MOP78", 6639));
            MOP78.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_MOP78", 0));

            datums.Add (IGN53Mare);
            IGN53Mare.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN53 Mare", 6641));
            IGN53Mare.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_IGN53_Mare", 0));

            datums.Add (ST84IledesPins);
            ST84IledesPins.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ST84 Ile des Pins", 6642));
            ST84IledesPins.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ST84_Ile_des_Pins", 0));

            datums.Add (ST71Belep);
            ST71Belep.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ST71 Belep", 6643));
            ST71Belep.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ST71_Belep", 0));

            datums.Add (NEA74Noumea);
            NEA74Noumea.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NEA74 Noumea", 6644));
            NEA74Noumea.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NEA74_Noumea", 0));

            datums.Add (GrandComoros);
            GrandComoros.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Grand Comoros", 6646));
            GrandComoros.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Grand_Comoros", 0));

            datums.Add (InternationalTerrestrialReferenceFrame1988);
            InternationalTerrestrialReferenceFrame1988.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 1988", 6647));

            datums.Add (InternationalTerrestrialReferenceFrame1989);
            InternationalTerrestrialReferenceFrame1989.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 1989", 6648));

            datums.Add (InternationalTerrestrialReferenceFrame1990);
            InternationalTerrestrialReferenceFrame1990.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 1990", 6649));

            datums.Add (InternationalTerrestrialReferenceFrame1991);
            InternationalTerrestrialReferenceFrame1991.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 1991", 6650));

            datums.Add (InternationalTerrestrialReferenceFrame1992);
            InternationalTerrestrialReferenceFrame1992.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 1992", 6651));

            datums.Add (InternationalTerrestrialReferenceFrame1993);
            InternationalTerrestrialReferenceFrame1993.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 1993", 6652));

            datums.Add (InternationalTerrestrialReferenceFrame1994);
            InternationalTerrestrialReferenceFrame1994.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 1994", 6653));

            datums.Add (InternationalTerrestrialReferenceFrame1996);
            InternationalTerrestrialReferenceFrame1996.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 1996", 6654));

            datums.Add (InternationalTerrestrialReferenceFrame1997);
            InternationalTerrestrialReferenceFrame1997.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 1997", 6655));

            datums.Add (InternationalTerrestrialReferenceFrame2000);
            InternationalTerrestrialReferenceFrame2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 2000", 6656));

            datums.Add (Reykjavik1900);
            Reykjavik1900.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reykjavik 1900", 6657));
            Reykjavik1900.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Reykjavik_1900", 0));

            datums.Add (Hjorsey1955);
            Hjorsey1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hjorsey 1955", 6658));
            Hjorsey1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hjorsey_1955", 0));

            datums.Add (IslandsNet1993);
            IslandsNet1993.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Islands Net 1993", 6659));

            datums.Add (Helle1954);
            Helle1954.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Helle 1954", 6660));
            Helle1954.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Helle_1954", 0));

            datums.Add (Latvia1992);
            Latvia1992.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Latvia 1992", 6661));
            Latvia1992.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Latvia_1992", 0));

            datums.Add (AzoresOrientalIslands1995);
            AzoresOrientalIslands1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Azores Oriental Islands 1995", 6664));
            AzoresOrientalIslands1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Azores_Oriental_Islands_1995", 0));

            datums.Add (AzoresCentralIslands1995);
            AzoresCentralIslands1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Azores Central Islands 1995", 6665));
            AzoresCentralIslands1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Azores_Central_Islands_1995", 0));

            datums.Add (Lisbon1890);
            Lisbon1890.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lisbon 1890", 6666));
            Lisbon1890.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Lisbon_1890", 0));

            datums.Add (IraqKuwaitBoundaryGeodeticDatum1992);
            IraqKuwaitBoundaryGeodeticDatum1992.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Iraq-Kuwait Boundary GeodeticDatum 1992", 6667));

            datums.Add (EuropeanGeodeticDatum1979);
            EuropeanGeodeticDatum1979.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "European GeodeticDatum 1979", 6668));

            datums.Add (IstitutoGeograficoMilitaire1995);
            IstitutoGeograficoMilitaire1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Istituto Geografico Militaire 1995", 6670));

            datums.Add (Voirol1879);
            Voirol1879.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Voirol 1879", 6671));
            Voirol1879.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Voirol_1879", 0));

            datums.Add (ChathamIslandsGeodeticDatum1971);
            ChathamIslandsGeodeticDatum1971.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Chatham Islands GeodeticDatum 1971", 6672));

            datums.Add (ChathamIslandsGeodeticDatum1979);
            ChathamIslandsGeodeticDatum1979.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Chatham Islands GeodeticDatum 1979", 6673));

            datums.Add (SistemadeReferenciaGeocentricoparalasAmericaS2000);
            SistemadeReferenciaGeocentricoparalasAmericaS2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sistema de Referencia Geocentrico para las AmericaS 2000", 6674));

            datums.Add (Guam1963);
            Guam1963.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Guam 1963", 6675));
            Guam1963.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Guam_1963", 0));

            datums.Add (Vientiane1982);
            Vientiane1982.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Vientiane 1982", 6676));
            Vientiane1982.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Vientiane_1982", 0));

            datums.Add (Lao1993);
            Lao1993.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lao 1993", 6677));
            Lao1993.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Lao_1993", 0));

            datums.Add (LaoNationalGeodeticDatum1997);
            LaoNationalGeodeticDatum1997.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lao National GeodeticDatum 1997", 6678));

            datums.Add (Jouik1961);
            Jouik1961.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Jouik 1961", 6679));
            Jouik1961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Jouik_1961", 0));

            datums.Add (Nouakchott1965);
            Nouakchott1965.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nouakchott 1965", 6680));
            Nouakchott1965.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Nouakchott_1965", 0));

            datums.Add (Gulshan303);
            Gulshan303.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Gulshan 303", 6682));
            Gulshan303.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Gulshan_303", 0));

            datums.Add (PhilippineReferenceSystem1992);
            PhilippineReferenceSystem1992.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Philippine Reference System 1992", 6683));
            PhilippineReferenceSystem1992.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Philippine_Reference_System_1992", 0));

            datums.Add (Gan1970);
            Gan1970.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Gan 1970", 6684));
            Gan1970.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Gan_1970", 0));

            datums.Add (MarcoGeocentricoNacionaldeReferencia);
            MarcoGeocentricoNacionaldeReferencia.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Marco Geocentrico Nacional de Referencia", 6686));

            datums.Add (ReseauGeodesiquedelaPolynesieFrancaise);
            ReseauGeodesiquedelaPolynesieFrancaise.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau Geodesique de la Polynesie Francaise", 6687));
            ReseauGeodesiquedelaPolynesieFrancaise.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Reseau_Geodesique_de_la_Polynesie_Francaise", 0));

            datums.Add (FatuIva72);
            FatuIva72.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Fatu Iva 72", 6688));

            datums.Add (IGN63HivaOa);
            IGN63HivaOa.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN63 Hiva Oa", 6689));
            IGN63HivaOa.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_IGN63_Hiva_Oa", 0));

            datums.Add (Tahiti79);
            Tahiti79.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tahiti 79", 6690));

            datums.Add (Moorea87);
            Moorea87.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Moorea 87", 6691));

            datums.Add (Maupiti83);
            Maupiti83.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Maupiti 83", 6692));

            datums.Add (NakhleGhanem);
            NakhleGhanem.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nakhl-e Ghanem", 6693));
            NakhleGhanem.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Nakhl-e_Ghanem", 0));

            datums.Add (PosicionesGeodesicasArgentinas1994);
            PosicionesGeodesicasArgentinas1994.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Posiciones Geodesicas Argentinas 1994", 6694));

            datums.Add (Katanga1955);
            Katanga1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Katanga 1955", 6695));
            Katanga1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Katanga_1955", 0));

            datums.Add (Kasai1953);
            Kasai1953.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kasai 1953", 6696));
            Kasai1953.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kasai_1953", 0));

            datums.Add (IGC1962Arcofthe6thParallelSouth);
            IGC1962Arcofthe6thParallelSouth.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGC 1962 Arc of the 6th Parallel South", 6697));
            IGC1962Arcofthe6thParallelSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_IGC_1962_Arc_of_the_6th_Parallel_South", 0));

            datums.Add (IGN1962Kerguelen);
            IGN1962Kerguelen.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN 1962 Kerguelen", 6698));

            datums.Add (LePouce1934);
            LePouce1934.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Le Pouce 1934", 6699));
            LePouce1934.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Le_Pouce_1934", 0));

            datums.Add (IGNAstro1960);
            IGNAstro1960.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN Astro 1960", 6700));
            IGNAstro1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_IGN_Astro_1960", 0));

            datums.Add (InstitutGeographiqueduCongoBelge1955);
            InstitutGeographiqueduCongoBelge1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Institut Geographique du Congo Belge 1955", 6701));
            InstitutGeographiqueduCongoBelge1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Institut_Geographique_du_Congo_Belge_1955", 0));

            datums.Add (Mauritania1999);
            Mauritania1999.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mauritania 1999", 6702));
            Mauritania1999.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Mauritania_1999", 0));

            datums.Add (MissaoHidrograficoAngolaySaoTome1951);
            MissaoHidrograficoAngolaySaoTome1951.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Missao Hidrografico Angola y Sao Tome 1951", 6703));

            datums.Add (Mhastonshore);
            Mhastonshore.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mhast (onshore)", 6704));
            Mhastonshore.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Mhast_Onshore", 0));

            datums.Add (Mhastoffshore);
            Mhastoffshore.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mhast (offshore)", 6705));
            Mhastoffshore.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Mhast_Offshore", 0));

            datums.Add (EgyptGulfofSuezS650TL);
            EgyptGulfofSuezS650TL.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Egypt Gulf of Suez S-650 TL", 6706));
            EgyptGulfofSuezS650TL.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Egypt_Gulf_of_Suez_S-650_TL", 0));

            datums.Add (TernIsland1961);
            TernIsland1961.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tern Island 1961", 6707));
            TernIsland1961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Tern_Island_1961", 0));

            datums.Add (CocosIslands1965);
            CocosIslands1965.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Cocos Islands 1965", 6708));

            datums.Add (IwoJima1945);
            IwoJima1945.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Iwo Jima 1945", 6709));

            datums.Add (StHelena1971);
            StHelena1971.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Helena 1971", 6710));

            datums.Add (MarcusIsland1952);
            MarcusIsland1952.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Marcus Island 1952", 6711));

            datums.Add (AscensionIsland1958);
            AscensionIsland1958.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ascension Island 1958", 6712));
            AscensionIsland1958.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Ascension_Island_1958", 0));

            datums.Add (AyabelleLighthouse);
            AyabelleLighthouse.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ayabelle Lighthouse", 6713));

            datums.Add (Bellevue);
            Bellevue.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bellevue", 6714));

            datums.Add (CampAreaAstro);
            CampAreaAstro.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Camp Area Astro", 6715));

            datums.Add (PhoenixIslands1966);
            PhoenixIslands1966.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Phoenix Islands 1966", 6716));

            datums.Add (CapeCanaveral);
            CapeCanaveral.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Cape Canaveral", 6717));
            CapeCanaveral.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Cape_Canaveral", 0));

            datums.Add (Solomon1968);
            Solomon1968.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Solomon 1968", 6718));
            Solomon1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Solomon_1968", 0));

            datums.Add (EasterIsland1967);
            EasterIsland1967.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Easter Island 1967", 6719));
            EasterIsland1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Easter_Island_1967", 0));

            datums.Add (FijiGeodeticGeodeticDatum1986);
            FijiGeodeticGeodeticDatum1986.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Fiji Geodetic GeodeticDatum 1986", 6720));

            datums.Add (Fiji1956);
            Fiji1956.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Fiji 1956", 6721));
            Fiji1956.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Fiji_1956", 0));

            datums.Add (SouthGeorgia1968);
            SouthGeorgia1968.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "South Georgia 1968", 6722));

            datums.Add (GrandCaymanGeodeticGeodeticDatum1959);
            GrandCaymanGeodeticGeodeticDatum1959.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Grand Cayman Geodetic GeodeticDatum 1959", 6723));

            datums.Add (DiegoGarcia1969);
            DiegoGarcia1969.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Diego Garcia 1969", 6724));

            datums.Add (JohnstonIsland1961);
            JohnstonIsland1961.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Johnston Island 1961", 6725));
            JohnstonIsland1961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Johnston_Island_1961", 0));

            datums.Add (SisterIslandsGeodeticGeodeticDatum1961);
            SisterIslandsGeodeticGeodeticDatum1961.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sister Islands Geodetic GeodeticDatum 1961", 6726));

            datums.Add (Midway1961);
            Midway1961.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Midway 1961", 6727));
            Midway1961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Midway_1961", 0));

            datums.Add (PicodelasNieves1984);
            PicodelasNieves1984.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pico de las Nieves 1984", 6728));

            datums.Add (Pitcairn1967);
            Pitcairn1967.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pitcairn 1967", 6729));
            Pitcairn1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Pitcairn_1967", 0));

            datums.Add (Santo1965);
            Santo1965.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Santo 1965", 6730));

            datums.Add (MarshallIslands1960);
            MarshallIslands1960.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Marshall Islands 1960", 6732));

            datums.Add (WakeIsland1952);
            WakeIsland1952.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Wake Island 1952", 6733));
            WakeIsland1952.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Wake_Island_1952", 0));

            datums.Add (Tristan1968);
            Tristan1968.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tristan 1968", 6734));
            Tristan1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Tristan_1968", 0));

            datums.Add (Kusaie1951);
            Kusaie1951.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kusaie 1951", 6735));
            Kusaie1951.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kusaie_1951", 0));

            datums.Add (DeceptionIsland);
            DeceptionIsland.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Deception Island", 6736));
            DeceptionIsland.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Deception_Island", 0));

            datums.Add (GeocentricGeodeticDatumofKorea);
            GeocentricGeodeticDatumofKorea.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Geocentric GeodeticDatum of Korea", 6737));

            datums.Add (HongKong1963);
            HongKong1963.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hong Kong 1963", 6738));
            HongKong1963.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hong_Kong_1963", 0));

            datums.Add (HongKong196367);
            HongKong196367.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hong Kong 1963(67)", 6739));

            datums.Add (ParametropZemp1990);
            ParametropZemp1990.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Parametrop Zemp 1990", 6740));
            ParametropZemp1990.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Parametrop_Zemp_1990", 0));

            datums.Add (FaroeGeodeticDatum1954);
            FaroeGeodeticDatum1954.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Faroe GeodeticDatum 1954", 6741));

            datums.Add (GeodeticGeodeticDatumofMalaysia2000);
            GeodeticGeodeticDatumofMalaysia2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Geodetic GeodeticDatum of Malaysia 2000", 6742));

            datums.Add (Karbala1979);
            Karbala1979.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Karbala 1979", 6743));

            datums.Add (Nahrwan1934);
            Nahrwan1934.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nahrwan 1934", 6744));
            Nahrwan1934.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Nahrwan_1934", 0));

            datums.Add (RauenbergGeodeticDatum83);
            RauenbergGeodeticDatum83.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Rauenberg GeodeticDatum/83", 6745));

            datums.Add (PotsdamGeodeticDatum83);
            PotsdamGeodeticDatum83.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Potsdam GeodeticDatum/83", 6746));

            datums.Add (Greenland1996);
            Greenland1996.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Greenland 1996", 6747));
            Greenland1996.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Greenland_1996", 0));

            datums.Add (VanuaLevu1915);
            VanuaLevu1915.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Vanua Levu 1915", 6748));
            VanuaLevu1915.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Vanua_Levu_1915", 0));

            datums.Add (ReseauGeodesiquedeNouvelleCaledonie9193);
            ReseauGeodesiquedeNouvelleCaledonie9193.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau Geodesique de Nouvelle Caledonie 91-93", 6749));

            datums.Add (ST87Ouvea);
            ST87Ouvea.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ST87 Ouvea", 6750));
            ST87Ouvea.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ST87_Ouvea", 0));

            datums.Add (KertauRSO);
            KertauRSO.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kertau (RSO)", 6751));
            KertauRSO.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kertau_RSO", 0));

            datums.Add (VitiLevu1912);
            VitiLevu1912.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Viti Levu 1912", 6752));
            VitiLevu1912.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Viti_Levu_1912", 0));

            datums.Add (fk89);
            fk89.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "fk89", 6753));
            fk89.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_fk89", 0));

            datums.Add (LibyanGeodeticGeodeticDatum2006);
            LibyanGeodeticGeodeticDatum2006.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Libyan Geodetic GeodeticDatum 2006", 6754));

            datums.Add (GeodeticDatumGeodesiNasional1995);
            GeodeticDatumGeodesiNasional1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GeodeticDatum Geodesi Nasional 1995", 6755));

            datums.Add (Vietnam2000);
            Vietnam2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Vietnam 2000", 6756));
            Vietnam2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Vietnam_2000", 0));

            datums.Add (SVY21);
            SVY21.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SVY21", 6757));
            SVY21.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_SVY21", 0));

            datums.Add (Jamaica2001);
            Jamaica2001.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Jamaica 2001", 6758));
            Jamaica2001.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Jamaica_2001", 0));

            datums.Add (NAD83NationalSpatialReferenceSystem2007);
            NAD83NationalSpatialReferenceSystem2007.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NAD83 (National Spatial Reference System 2007)", 6759));

            datums.Add (WorldGeodeticSystem1966);
            WorldGeodeticSystem1966.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "World Geodetic System 1966", 6760));

            datums.Add (CroatianTerrestrialReferenceSystem);
            CroatianTerrestrialReferenceSystem.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Croatian Terrestrial Reference System", 6761));
            CroatianTerrestrialReferenceSystem.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Croatian_Terrestrial_Reference_System", 0));

            datums.Add (Bermuda2000);
            Bermuda2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bermuda 2000", 6762));
            Bermuda2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bermuda_2000", 0));

            datums.Add (Pitcairn2006);
            Pitcairn2006.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pitcairn 2006", 6763));
            Pitcairn2006.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Pitcairn_2006", 0));

            datums.Add (RossSeaRegionGeodeticGeodeticDatum2000);
            RossSeaRegionGeodeticGeodeticDatum2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ross Sea Region Geodetic GeodeticDatum 2000", 6764));

            datums.Add (SloveniaGeodeticGeodeticDatum1996);
            SloveniaGeodeticGeodeticDatum1996.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Slovenia Geodetic GeodeticDatum 1996", 6765));

            datums.Add (CH1903Bern);
            CH1903Bern.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "CH1903 (Bern)", 6801));

            datums.Add (Bogota1975Bogota);
            Bogota1975Bogota.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bogota 1975 (Bogota)", 6802));

            datums.Add (Lisbon1937Lisbon);
            Lisbon1937Lisbon.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lisbon 1937 (Lisbon)", 6803));

            datums.Add (MakassarJakarta);
            MakassarJakarta.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Makassar (Jakarta)", 6804));

            datums.Add (MilitarGeographischeInstitutFerro);
            MilitarGeographischeInstitutFerro.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Militar-Geographische Institut (Ferro)", 6805));

            datums.Add (MonteMarioRome);
            MonteMarioRome.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Monte Mario (Rome)", 6806));

            datums.Add (NouvelleTriangulationFrancaiseParis);
            NouvelleTriangulationFrancaiseParis.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nouvelle Triangulation Francaise (Paris)", 6807));

            datums.Add (Padang1884Jakarta);
            Padang1884Jakarta.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Padang 1884 (Jakarta)", 6808));

            datums.Add (ReseauNationalBelge1950Brussels);
            ReseauNationalBelge1950Brussels.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reseau National Belge 1950 (Brussels)", 6809));

            datums.Add (Tananarive1925Paris);
            Tananarive1925Paris.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tananarive 1925 (Paris)", 6810));

            datums.Add (Voirol1875Paris);
            Voirol1875Paris.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Voirol 1875 (Paris)", 6811));

            datums.Add (BataviaJakarta);
            BataviaJakarta.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Batavia (Jakarta)", 6813));

            datums.Add (Stockholm1938Stockholm);
            Stockholm1938Stockholm.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Stockholm 1938 (Stockholm)", 6814));

            datums.Add (GreekAthens);
            GreekAthens.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Greek (Athens)", 6815));

            datums.Add (CarthageParis);
            CarthageParis.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Carthage (Paris)", 6816));

            datums.Add (NGO1948Oslo);
            NGO1948Oslo.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NGO 1948 (Oslo)", 6817));

            datums.Add (SystemJednotneTrigonometrickeSiteKatastralniFerro);
            SystemJednotneTrigonometrickeSiteKatastralniFerro.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "System Jednotne Trigonometricke Site Katastralni (Ferro)", 6818));

            datums.Add (GunungSegaraJakarta);
            GunungSegaraJakarta.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Gunung Segara (Jakarta)", 6820));

            datums.Add (Voirol1879Paris);
            Voirol1879Paris.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Voirol 1879 (Paris)", 6821));

            datums.Add (InternationalTerrestrialReferenceFrame2005);
            InternationalTerrestrialReferenceFrame2005.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International Terrestrial Reference Frame 2005", 6896));

            datums.Add (AncienneTriangulationFrancaiseParis);
            AncienneTriangulationFrancaiseParis.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ancienne Triangulation Francaise (Paris)", 6901));

            datums.Add (Madrid1870Madrid);
            Madrid1870Madrid.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Madrid 1870 (Madrid)", 6903));

            datums.Add (Lisbon1890Lisbon);
            Lisbon1890Lisbon.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lisbon 1890 (Lisbon)", 6904));

            datums.Add (HungarianDatum1909);
            HungarianDatum1909.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hungarian_Datum_1909", 0));

            datums.Add (TWD1967);
            TWD1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_TWD_1967", 0));

            datums.Add (TWD1997);
            TWD1997.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_TWD_1997", 0));

            datums.Add (Airy1830);
            Airy1830.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Airy_1830", 0));

            datums.Add (AiryModified);
            AiryModified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Airy_Modified", 0));

            datums.Add (Australian);
            Australian.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Australian", 0));

            datums.Add (Bessel1841);
            Bessel1841.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bessel_1841", 0));

            datums.Add (BesselModified);
            BesselModified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bessel_Modified", 0));

            datums.Add (BesselNamibia);
            BesselNamibia.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bessel_Namibia", 0));

            datums.Add (Clarke1858);
            Clarke1858.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Clarke_1858", 0));

            datums.Add (Clarke1866);
            Clarke1866.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Clarke_1866", 0));

            datums.Add (Clarke1866Michigan);
            Clarke1866Michigan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Clarke_1866_Michigan", 0));

            datums.Add (Clarke1880Benoit);
            Clarke1880Benoit.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Clarke_1880_Benoit", 0));

            datums.Add (Clarke1880IGN);
            Clarke1880IGN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Clarke_1880_IGN", 0));

            datums.Add (Clarke1880RGS);
            Clarke1880RGS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Clarke_1880_RGS", 0));

            datums.Add (Clarke1880Arc);
            Clarke1880Arc.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Clarke_1880_Arc", 0));

            datums.Add (Clarke1880SGA);
            Clarke1880SGA.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Clarke_1880_SGA", 0));

            datums.Add (EverestAdj1937);
            EverestAdj1937.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Everest_Adj_1937", 0));

            datums.Add (EverestDef1967);
            EverestDef1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Everest_Def_1967", 0));

            datums.Add (EverestModified);
            EverestModified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Everest_Modified", 0));

            datums.Add (GRS1980);
            GRS1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_GRS_1980", 0));

            datums.Add (Helmert1906);
            Helmert1906.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Helmert_1906", 0));

            datums.Add (Indonesian);
            Indonesian.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Indonesian", 0));

            datums.Add (International1924);
            International1924.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_International_1924", 0));

            datums.Add (Krassovsky1940);
            Krassovsky1940.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Krassovsky_1940", 0));

            datums.Add (NWL9D);
            NWL9D.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NWL_9D", 0));

            datums.Add (Plessis1817);
            Plessis1817.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Plessis_1817", 0));

            datums.Add (Struve1860);
            Struve1860.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Struve_1860", 0));

            datums.Add (WarOffice);
            WarOffice.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_War_Office", 0));

            datums.Add (GEM10C);
            GEM10C.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_GEM_10C", 0));

            datums.Add (OSU86F);
            OSU86F.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_OSU_86F", 0));

            datums.Add (OSU91A);
            OSU91A.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_OSU_91A", 0));

            datums.Add (Clarke1880);
            Clarke1880.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Clarke_1880", 0));

            datums.Add (Sphere);
            Sphere.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sphere", 0));

            datums.Add (GRS1967);
            GRS1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_GRS_1967", 0));

            datums.Add (Everest1830);
            Everest1830.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Everest_1830", 0));

            datums.Add (EverestDef1962);
            EverestDef1962.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Everest_Def_1962", 0));

            datums.Add (EverestDef1975);
            EverestDef1975.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Everest_Def_1975", 0));

            datums.Add (SphereGRS1980Authalic);
            SphereGRS1980Authalic.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sphere_GRS_1980_Authalic", 0));

            datums.Add (SphereClarke1866Authalic);
            SphereClarke1866Authalic.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sphere_Clarke_1866_Authalic", 0));

            datums.Add (SphereInternational1924Authalic);
            SphereInternational1924Authalic.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sphere_International_1924_Authalic", 0));

            datums.Add (Hughes1980);
            Hughes1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hughes_1980", 0));

            datums.Add (GGRS1987);
            GGRS1987.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_GGRS_1987", 0));

            datums.Add (ATS1977);
            ATS1977.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ATS_1977", 0));

            datums.Add (KKJ);
            KKJ.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_KKJ", 0));

            datums.Add (RT1990);
            RT1990.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_RT_1990", 0));

            datums.Add (Samboja);
            Samboja.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Samboja", 0));

            datums.Add (Moznet);
            Moznet.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Moznet", 0));

            datums.Add (FD1958);
            FD1958.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_FD_1958", 0));

            datums.Add (PDO1993);
            PDO1993.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_PDO_1993", 0));

            datums.Add (StLawrenceIsland);
            StLawrenceIsland.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_St_Lawrence_Island", 0));

            datums.Add (StPaulIsland);
            StPaulIsland.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_St_Paul_Island", 0));

            datums.Add (StGeorgeIsland);
            StGeorgeIsland.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_St_George_Island", 0));

            datums.Add (Hartebeesthoek1994);
            Hartebeesthoek1994.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hartebeesthoek_1994", 0));

            datums.Add (SwissTRF1995);
            SwissTRF1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Swiss_TRF_1995", 0));

            datums.Add (NorthAmerican1983HARN);
            NorthAmerican1983HARN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_North_American_1983_HARN", 0));

            datums.Add (European1950ED77);
            European1950ED77.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_European_1950_ED77", 0));

            datums.Add (SJTSK);
            SJTSK.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_S_JTSK", 0));

            datums.Add (EuropeanLibyan1979);
            EuropeanLibyan1979.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_European_Libyan_1979", 0));

            datums.Add (KoreanDatum1985);
            KoreanDatum1985.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Korean_Datum_1985", 0));

            datums.Add (YemenNGN1996);
            YemenNGN1996.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Yemen_NGN_1996", 0));

            datums.Add (KoreanDatum1995);
            KoreanDatum1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Korean_Datum_1995", 0));

            datums.Add (NZGD2000);
            NZGD2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NZGD_2000", 0));

            datums.Add (SIRGAS);
            SIRGAS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_SIRGAS", 0));

            datums.Add (RGF1993);
            RGF1993.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_RGF_1993", 0));

            datums.Add (POSGAR);
            POSGAR.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_POSGAR", 0));

            datums.Add (SierraLeone1924);
            SierraLeone1924.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sierra_Leone_1924", 0));

            datums.Add (AustralianAntarctic1998);
            AustralianAntarctic1998.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Australian_Antarctic_1998", 0));

            datums.Add (Madeira1936);
            Madeira1936.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Madeira_1936", 0));

            datums.Add (REGVEN);
            REGVEN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_REGVEN", 0));

            datums.Add (POSGAR1998);
            POSGAR1998.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_POSGAR_1998", 0));

            datums.Add (Australian1966);
            Australian1966.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Australian_1966", 0));

            datums.Add (Australian1984);
            Australian1984.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Australian_1984", 0));

            datums.Add (Lisbon);
            Lisbon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Lisbon", 0));

            datums.Add (Belge1950);
            Belge1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Belge_1950", 0));

            datums.Add (Bogota);
            Bogota.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bogota", 0));

            datums.Add (CorregoAlegre);
            CorregoAlegre.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Corrego_Alegre", 0));

            datums.Add (CotedIvoire);
            CotedIvoire.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Cote_d_Ivoire", 0));

            datums.Add (Douala);
            Douala.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Douala", 0));

            datums.Add (European1950);
            European1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_European_1950", 0));

            datums.Add (European1987);
            European1987.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_European_1987", 0));

            datums.Add (GuyaneFrancaise);
            GuyaneFrancaise.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Guyane_Francaise", 0));

            datums.Add (HuTzuShan);
            HuTzuShan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hu_Tzu_Shan", 0));

            datums.Add (Hungarian1972);
            Hungarian1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hungarian_1972", 0));

            datums.Add (Indonesian1974);
            Indonesian1974.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Indonesian_1974", 0));

            datums.Add (Kertau);
            Kertau.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kertau", 0));

            datums.Add (ProvisionalSAmerican1956);
            ProvisionalSAmerican1956.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Provisional_S_American_1956", 0));

            datums.Add (ETRS1989);
            ETRS1989.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ETRS_1989", 0));

            datums.Add (Manoca);
            Manoca.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Manoca", 0));

            datums.Add (Mporaloko);
            Mporaloko.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Mporaloko", 0));

            datums.Add (NorthAmerican1927);
            NorthAmerican1927.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_North_American_1927", 0));

            datums.Add (NorthAmerican1983);
            NorthAmerican1983.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_North_American_1983", 0));

            datums.Add (NewZealand1949);
            NewZealand1949.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_New_Zealand_1949", 0));

            datums.Add (Datum73);
            Datum73.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Datum_73", 0));

            datums.Add (NTF);
            NTF.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NTF", 0));

            datums.Add (NSWC9Z2);
            NSWC9Z2.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NSWC_9Z_2", 0));

            datums.Add (PointeNoire);
            PointeNoire.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Pointe_Noire", 0));

            datums.Add (GDA1994);
            GDA1994.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_GDA_1994", 0));

            datums.Add (Qatar);
            Qatar.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Qatar", 0));

            datums.Add (Segora);
            Segora.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Segora", 0));

            datums.Add (Sudan);
            Sudan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sudan", 0));

            datums.Add (TM75);
            TM75.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_TM75", 0));

            datums.Add (VoirolUnifie1960);
            VoirolUnifie1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Voirol_Unifie_1960", 0));

            datums.Add (MGI);
            MGI.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_MGI", 0));

            datums.Add (Belge1972);
            Belge1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Belge_1972", 0));

            datums.Add (DealulPiscului1933);
            DealulPiscului1933.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Dealul_Piscului_1933", 0));

            datums.Add (NGN);
            NGN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NGN", 0));

            datums.Add (WGS1972);
            WGS1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_WGS_1972", 0));

            datums.Add (WGS1972BE);
            WGS1972BE.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_WGS_1972_BE", 0));

            datums.Add (WGS1984);
            WGS1984.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_WGS_1984", 0));

            datums.Add (ReseauGeodesiquedeStPierreetMiquelon2006);
            ReseauGeodesiquedeStPierreetMiquelon2006.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Reseau_Geodesique_de_St_Pierre_et_Miquelon_2006", 0));

            datums.Add (MexicanDatumof1993);
            MexicanDatumof1993.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Mexican_Datum_of_1993", 0));

            datums.Add (RRAF1991);
            RRAF1991.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_RRAF_1991", 0));

            datums.Add (StKitts1955);
            StKitts1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_St_Kitts_1955", 0));

            datums.Add (StLucia1955);
            StLucia1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_St_Lucia_1955", 0));

            datums.Add (StVincent1945);
            StVincent1945.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_St_Vincent_1945", 0));

            datums.Add (NAD1927Definition1976);
            NAD1927Definition1976.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1927_Definition_1976", 0));

            datums.Add (NAD1927CGQ77);
            NAD1927CGQ77.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1927_CGQ77", 0));

            datums.Add (JGD2000);
            JGD2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_JGD_2000", 0));

            datums.Add (QND1995);
            QND1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_QND_1995", 0));

            datums.Add (SelvagemGrande1938);
            SelvagemGrande1938.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Selvagem_Grande_1938", 0));

            datums.Add (NorthAmerican1983CSRS);
            NorthAmerican1983CSRS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_North_American_1983_CSRS", 0));

            datums.Add (SouthAmerican1969);
            SouthAmerican1969.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_South_American_1969", 0));

            datums.Add (SainteAnne);
            SainteAnne.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sainte_Anne", 0));

            datums.Add (CSG1967);
            CSG1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_CSG_1967", 0));

            datums.Add (RGFG1995);
            RGFG1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_RGFG_1995", 0));

            datums.Add (FortDesaix);
            FortDesaix.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Fort_Desaix", 0));

            datums.Add (RGR1992);
            RGR1992.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_RGR_1992", 0));

            datums.Add (Tahiti1952);
            Tahiti1952.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Tahiti_1952", 0));

            datums.Add (Tahaa1954);
            Tahaa1954.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Tahaa_1954", 0));

            datums.Add (RGNC1991);
            RGNC1991.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_RGNC_1991", 0));

            datums.Add (IslandsNetwork1993);
            IslandsNetwork1993.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Islands_Network_1993", 0));

            datums.Add (PortoSanto1995);
            PortoSanto1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Porto_Santo_1995", 0));

            datums.Add (IraqKuwaitBoundary1992);
            IraqKuwaitBoundary1992.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Iraq_Kuwait_Boundary_1992", 0));

            datums.Add (European1979);
            European1979.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_European_1979", 0));

            datums.Add (Lithuania1994);
            Lithuania1994.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Lithuania_1994", 0));

            datums.Add (IGM1995);
            IGM1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_IGM_1995", 0));

            datums.Add (ChathamIsland1971);
            ChathamIsland1971.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Chatham_Island_1971", 0));

            datums.Add (ChathamIslands1979);
            ChathamIslands1979.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Chatham_Islands_1979", 0));

            datums.Add (SIRGAS2000);
            SIRGAS2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_SIRGAS_2000", 0));

            datums.Add (MAGNA);
            MAGNA.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_MAGNA", 0));

            datums.Add (FatuIva1972);
            FatuIva1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Fatu_Iva_1972", 0));

            datums.Add (Tahiti1979);
            Tahiti1979.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Tahiti_1979", 0));

            datums.Add (Moorea1987);
            Moorea1987.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Moorea_1987", 0));

            datums.Add (Maupiti1983);
            Maupiti1983.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Maupiti_1983", 0));

            datums.Add (POSGAR1994);
            POSGAR1994.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_POSGAR_1994", 0));

            datums.Add (KerguelenIsland1949);
            KerguelenIsland1949.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Kerguelen_Island_1949", 0));

            datums.Add (Mhast1951);
            Mhast1951.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Mhast_1951", 0));

            datums.Add (Anna11965);
            Anna11965.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Anna_1_1965", 0));

            datums.Add (BeaconE1945);
            BeaconE1945.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Beacon_E_1945", 0));

            datums.Add (DOS714);
            DOS714.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_DOS_71_4", 0));

            datums.Add (Astro1952);
            Astro1952.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Astro_1952", 0));

            datums.Add (Ayabelle);
            Ayabelle.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Ayabelle", 0));

            datums.Add (BellevueIGN);
            BellevueIGN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bellevue_IGN", 0));

            datums.Add (CampArea);
            CampArea.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Camp_Area", 0));

            datums.Add (Canton1966);
            Canton1966.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Canton_1966", 0));

            datums.Add (Fiji1986);
            Fiji1986.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Fiji_1986", 0));

            datums.Add (ISTS0611968);
            ISTS0611968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ISTS_061_1968", 0));

            datums.Add (GrandCayman1959);
            GrandCayman1959.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Grand_Cayman_1959", 0));

            datums.Add (ISTS0731969);
            ISTS0731969.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ISTS_073_1969", 0));

            datums.Add (LittleCayman1961);
            LittleCayman1961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Little_Cayman_1961", 0));

            datums.Add (PicodeLasNieves);
            PicodeLasNieves.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Pico_de_Las_Nieves", 0));

            datums.Add (SantoDOS1965);
            SantoDOS1965.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Santo_DOS_1965", 0));

            datums.Add (VitiLevu1916);
            VitiLevu1916.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Viti_Levu_1916", 0));

            datums.Add (WakeEniwetok1960);
            WakeEniwetok1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Wake_Eniwetok_1960", 0));

            datums.Add (Korea2000);
            Korea2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Korea_2000", 0));

            datums.Add (HongKong196367);
            HongKong196367.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hong_Kong_1963_67", 0));

            datums.Add (FaroeDatum1954);
            FaroeDatum1954.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Faroe_Datum_1954", 0));

            datums.Add (GDM2000);
            GDM2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_GDM_2000", 0));

            datums.Add (Karbala1979Polservice);
            Karbala1979Polservice.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Karbala_1979_Polservice", 0));

            datums.Add (Rauenberg1983);
            Rauenberg1983.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Rauenberg_1983", 0));

            datums.Add (Potsdam1983);
            Potsdam1983.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Potsdam_1983", 0));

            datums.Add (ReseauGeodesiquedeNouvelleCaledonie199193);
            ReseauGeodesiquedeNouvelleCaledonie199193.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Reseau_Geodesique_de_Nouvelle_Caledonie_1991-93", 0));

            datums.Add (LibyanGeodeticDatum2006);
            LibyanGeodeticDatum2006.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Libyan_Geodetic_Datum_2006", 0));

            datums.Add (DatumGeodesiNasional1995);
            DatumGeodesiNasional1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Datum_Geodesi_Nasional_1995", 0));

            datums.Add (NAD1983NSRS2007);
            NAD1983NSRS2007.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_NSRS2007", 0));

            datums.Add (WGS1966);
            WGS1966.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_WGS_1966", 0));

            datums.Add (RossSeaRegionGeodeticDatum2000);
            RossSeaRegionGeodeticDatum2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Ross_Sea_Region_Geodetic_Datum_2000", 0));

            datums.Add (SloveniaGeodeticDatum1996);
            SloveniaGeodeticDatum1996.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Slovenia_Geodetic_Datum_1996", 0));

            datums.Add (Bern1898);
            Bern1898.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bern_1898", 0));

            datums.Add (ATF);
            ATF.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ATF", 0));

            datums.Add (NorddeGuerre);
            NorddeGuerre.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Nord_de_Guerre", 0));

            datums.Add (Madrid1870);
            Madrid1870.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Madrid_1870", 0));

            datums.Add (PTRA08);
            PTRA08.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_PTRA08", 0));

            datums.Add (SJTSK05);
            SJTSK05.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_S_JTSK_05", 0));

            datums.Add (SriLankaDatum1999);
            SriLankaDatum1999.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sri_Lanka_Datum_1999", 0));

            datums.Add (GDBD2009);
            GDBD2009.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_GDBD2009", 0));

            datums.Add (BhutanNationalGeodeticDatum);
            BhutanNationalGeodeticDatum.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bhutan_National_Geodetic_Datum", 0));

            datums.Add (IslandsNetwork2004);
            IslandsNetwork2004.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Islands_Network_2004", 0));

            datums.Add (POSGAR2007);
            POSGAR2007.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_POSGAR_2007", 0));

            datums.Add (SGNPMARCARIOSOLIS);
            SGNPMARCARIOSOLIS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_SGNP_MARCARIO_SOLIS", 0));

            datums.Add (PanamaColon1911);
            PanamaColon1911.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Panama-Colon-1911", 0));

            datums.Add (SouthAmericanDatum196996);
            SouthAmericanDatum196996.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_South_American_Datum_1969_96", 0));

            datums.Add (PapuaNewGuineaGeodeticDatum1994);
            PapuaNewGuineaGeodeticDatum1994.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Papua_New_Guinea_Geodetic_Datum_1994", 0));

            datums.Add (FehmarnbeltDatum2010);
            FehmarnbeltDatum2010.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Fehmarnbelt_Datum_2010", 0));

            datums.Add (TongaGeodeticDatum2005);
            TongaGeodeticDatum2005.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Tonga_Geodetic_Datum_2005", 0));

            datums.Add (Fischer1960);
            Fischer1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Fischer_1960", 0));

            datums.Add (Fischer1968);
            Fischer1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Fischer_1968", 0));

            datums.Add (FischerModified);
            FischerModified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Fischer_Modified", 0));

            datums.Add (Hough1960);
            Hough1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hough_1960", 0));

            datums.Add (EverestModified1969);
            EverestModified1969.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Everest_Modified_1969", 0));

            datums.Add (Walbeck);
            Walbeck.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Walbeck", 0));

            datums.Add (SphereARCINFO);
            SphereARCINFO.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sphere_ARC_INFO", 0));

            datums.Add (EverestBangladesh);
            EverestBangladesh.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Everest_Bangladesh", 0));

            datums.Add (EverestIndiaNepal);
            EverestIndiaNepal.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Everest_India_Nepal", 0));

            datums.Add (Oman);
            Oman.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Oman", 0));

            datums.Add (SouthAsiaSingapore);
            SouthAsiaSingapore.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_South_Asia_Singapore", 0));

            datums.Add (DOS1968);
            DOS1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_DOS_1968", 0));

            datums.Add (GUX1);
            GUX1.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_GUX_1", 0));

            datums.Add (FortThomas1955);
            FortThomas1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Fort_Thomas_1955", 0));

            datums.Add (GraciosaBaseSW1948);
            GraciosaBaseSW1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Graciosa_Base_SW_1948", 0));

            datums.Add (LC51961);
            LC51961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_LC5_1961", 0));

            datums.Add (ObservatorioMeteorologico1939);
            ObservatorioMeteorologico1939.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Observatorio_Meteorologico_1939", 0));

            datums.Add (SaoBraz);
            SaoBraz.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sao_Braz", 0));

            datums.Add (AlaskanIslands);
            AlaskanIslands.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Alaskan_Islands", 0));

            datums.Add (JGD2011);
            JGD2011.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_JGD_2011", 0));

            datums.Add (Estonia1937);
            Estonia1937.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Estonia_1937", 0));

            datums.Add (Hermannskogel);
            Hermannskogel.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Hermannskogel", 0));

            datums.Add (SierraLeone1960);
            SierraLeone1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sierra_Leone_1960", 0));

            datums.Add (DatumLisboaBessel);
            DatumLisboaBessel.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Datum_Lisboa_Bessel", 0));

            datums.Add (DatumLisboaHayford);
            DatumLisboaHayford.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Datum_Lisboa_Hayford", 0));

            datums.Add (Pohnpei);
            Pohnpei.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Pohnpei", 0));

            datums.Add (BabSouth);
            BabSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Bab_South", 0));

            datums.Add (Majuro);
            Majuro.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Majuro", 0));

            datums.Add (ITRF1988);
            ITRF1988.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_1988", 0));

            datums.Add (ITRF1989);
            ITRF1989.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_1989", 0));

            datums.Add (ITRF1990);
            ITRF1990.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_1990", 0));

            datums.Add (ITRF1991);
            ITRF1991.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_1991", 0));

            datums.Add (ITRF1992);
            ITRF1992.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_1992", 0));

            datums.Add (ITRF1993);
            ITRF1993.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_1993", 0));

            datums.Add (ITRF1994);
            ITRF1994.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_1994", 0));

            datums.Add (ITRF1996);
            ITRF1996.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_1996", 0));

            datums.Add (ITRF1997);
            ITRF1997.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_1997", 0));

            datums.Add (ITRF2000);
            ITRF2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_2000", 0));

            datums.Add (ObservatorioMeteorologico1965);
            ObservatorioMeteorologico1965.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Observatorio_Meteorologico_1965", 0));

            datums.Add (Roma1940);
            Roma1940.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Roma_1940", 0));

            datums.Add (SphereEMEP);
            SphereEMEP.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Sphere_EMEP", 0));

            datums.Add (Jordan);
            Jordan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Jordan", 0));

            datums.Add (D48);
            D48.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_D48", 0));

            datums.Add (OldHawaiianIntl1924);
            OldHawaiianIntl1924.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Old_Hawaiian_Intl_1924", 0));

            datums.Add (CyprusGeodeticReferenceSystem1993);
            CyprusGeodeticReferenceSystem1993.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Cyprus_Geodetic_Reference_System_1993", 0));

            datums.Add (NAD19832011);
            NAD19832011.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_2011", 0));

            datums.Add (NAD1983CORS96);
            NAD1983CORS96.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_CORS96", 0));

            datums.Add (NepalNagarkot);
            NepalNagarkot.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Nepal_Nagarkot", 0));

            datums.Add (ITRF2008);
            ITRF2008.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_2008", 0));

            datums.Add (ETRF1989);
            ETRF1989.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ETRF_1989", 0));

            datums.Add (NAD1983PACP00);
            NAD1983PACP00.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_PACP00", 0));

            datums.Add (NAD1983MARP00);
            NAD1983MARP00.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_MARP00", 0));

            datums.Add (NAD1983MA11);
            NAD1983MA11.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_MA11", 0));

            datums.Add (NAD1983PA11);
            NAD1983PA11.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_PA11", 0));

            datums.Add (NAD1983HARNAdjMNAnoka);
            NAD1983HARNAdjMNAnoka.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Anoka", 0));

            datums.Add (NAD1983HARNAdjMNBecker);
            NAD1983HARNAdjMNBecker.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Becker", 0));

            datums.Add (NAD1983HARNAdjMNBeltramiNorth);
            NAD1983HARNAdjMNBeltramiNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Beltrami_North", 0));

            datums.Add (NAD1983HARNAdjMNBeltramiSouth);
            NAD1983HARNAdjMNBeltramiSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Beltrami_South", 0));

            datums.Add (NAD1983HARNAdjMNBenton);
            NAD1983HARNAdjMNBenton.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Benton", 0));

            datums.Add (NAD1983HARNAdjMNBigStone);
            NAD1983HARNAdjMNBigStone.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Big_Stone", 0));

            datums.Add (NAD1983HARNAdjMNBlueEarth);
            NAD1983HARNAdjMNBlueEarth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Blue_Earth", 0));

            datums.Add (NAD1983HARNAdjMNBrown);
            NAD1983HARNAdjMNBrown.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Brown", 0));

            datums.Add (NAD1983HARNAdjMNCarlton);
            NAD1983HARNAdjMNCarlton.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Carlton", 0));

            datums.Add (NAD1983HARNAdjMNCarver);
            NAD1983HARNAdjMNCarver.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Carver", 0));

            datums.Add (NAD1983HARNAdjMNCassNorth);
            NAD1983HARNAdjMNCassNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Cass_North", 0));

            datums.Add (NAD1983HARNAdjMNCassSouth);
            NAD1983HARNAdjMNCassSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Cass_South", 0));

            datums.Add (NAD1983HARNAdjMNChippewa);
            NAD1983HARNAdjMNChippewa.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Chippewa", 0));

            datums.Add (NAD1983HARNAdjMNChisago);
            NAD1983HARNAdjMNChisago.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Chisago", 0));

            datums.Add (NAD1983HARNAdjMNCookNorth);
            NAD1983HARNAdjMNCookNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Cook_North", 0));

            datums.Add (NAD1983HARNAdjMNCookSouth);
            NAD1983HARNAdjMNCookSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Cook_South", 0));

            datums.Add (NAD1983HARNAdjMNCottonwood);
            NAD1983HARNAdjMNCottonwood.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Cottonwood", 0));

            datums.Add (NAD1983HARNAdjMNCrowWing);
            NAD1983HARNAdjMNCrowWing.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Crow_Wing", 0));

            datums.Add (NAD1983HARNAdjMNDakota);
            NAD1983HARNAdjMNDakota.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Dakota", 0));

            datums.Add (NAD1983HARNAdjMNDodge);
            NAD1983HARNAdjMNDodge.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Dodge", 0));

            datums.Add (NAD1983HARNAdjMNDouglas);
            NAD1983HARNAdjMNDouglas.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Douglas", 0));

            datums.Add (NAD1983HARNAdjMNFaribault);
            NAD1983HARNAdjMNFaribault.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Faribault", 0));

            datums.Add (NAD1983HARNAdjMNFillmore);
            NAD1983HARNAdjMNFillmore.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Fillmore", 0));

            datums.Add (NAD1983HARNAdjMNFreeborn);
            NAD1983HARNAdjMNFreeborn.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Freeborn", 0));

            datums.Add (NAD1983HARNAdjMNGoodhue);
            NAD1983HARNAdjMNGoodhue.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Goodhue", 0));

            datums.Add (NAD1983HARNAdjMNGrant);
            NAD1983HARNAdjMNGrant.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Grant", 0));

            datums.Add (NAD1983HARNAdjMNHennepin);
            NAD1983HARNAdjMNHennepin.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Hennepin", 0));

            datums.Add (NAD1983HARNAdjMNHouston);
            NAD1983HARNAdjMNHouston.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Houston", 0));

            datums.Add (NAD1983HARNAdjMNIsanti);
            NAD1983HARNAdjMNIsanti.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Isanti", 0));

            datums.Add (NAD1983HARNAdjMNItascaNorth);
            NAD1983HARNAdjMNItascaNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Itasca_North", 0));

            datums.Add (NAD1983HARNAdjMNItascaSouth);
            NAD1983HARNAdjMNItascaSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Itasca_South", 0));

            datums.Add (NAD1983HARNAdjMNJackson);
            NAD1983HARNAdjMNJackson.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Jackson", 0));

            datums.Add (NAD1983HARNAdjMNKanabec);
            NAD1983HARNAdjMNKanabec.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Kanabec", 0));

            datums.Add (NAD1983HARNAdjMNKandiyohi);
            NAD1983HARNAdjMNKandiyohi.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Kandiyohi", 0));

            datums.Add (NAD1983HARNAdjMNKittson);
            NAD1983HARNAdjMNKittson.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Kittson", 0));

            datums.Add (NAD1983HARNAdjMNKoochiching);
            NAD1983HARNAdjMNKoochiching.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Koochiching", 0));

            datums.Add (NAD1983HARNAdjMNLacQuiParle);
            NAD1983HARNAdjMNLacQuiParle.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Lac_Qui_Parle", 0));

            datums.Add (NAD1983HARNAdjMNLakeoftheWoodsNorth);
            NAD1983HARNAdjMNLakeoftheWoodsNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Lake_of_the_Woods_North", 0));

            datums.Add (NAD1983HARNAdjMNLakeoftheWoodsSouth);
            NAD1983HARNAdjMNLakeoftheWoodsSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Lake_of_the_Woods_South", 0));

            datums.Add (NAD1983HARNAdjMNLeSueur);
            NAD1983HARNAdjMNLeSueur.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Le_Sueur", 0));

            datums.Add (NAD1983HARNAdjMNLincoln);
            NAD1983HARNAdjMNLincoln.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Lincoln", 0));

            datums.Add (NAD1983HARNAdjMNLyon);
            NAD1983HARNAdjMNLyon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Lyon", 0));

            datums.Add (NAD1983HARNAdjMNMcLeod);
            NAD1983HARNAdjMNMcLeod.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_McLeod", 0));

            datums.Add (NAD1983HARNAdjMNMahnomen);
            NAD1983HARNAdjMNMahnomen.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Mahnomen", 0));

            datums.Add (NAD1983HARNAdjMNMarshall);
            NAD1983HARNAdjMNMarshall.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Marshall", 0));

            datums.Add (NAD1983HARNAdjMNMartin);
            NAD1983HARNAdjMNMartin.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Martin", 0));

            datums.Add (NAD1983HARNAdjMNMeeker);
            NAD1983HARNAdjMNMeeker.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Meeker", 0));

            datums.Add (NAD1983HARNAdjMNMorrison);
            NAD1983HARNAdjMNMorrison.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Morrison", 0));

            datums.Add (NAD1983HARNAdjMNMower);
            NAD1983HARNAdjMNMower.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Mower", 0));

            datums.Add (NAD1983HARNAdjMNMurray);
            NAD1983HARNAdjMNMurray.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Murray", 0));

            datums.Add (NAD1983HARNAdjMNNicollet);
            NAD1983HARNAdjMNNicollet.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Nicollet", 0));

            datums.Add (NAD1983HARNAdjMNNobles);
            NAD1983HARNAdjMNNobles.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Nobles", 0));

            datums.Add (NAD1983HARNAdjMNNorman);
            NAD1983HARNAdjMNNorman.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Norman", 0));

            datums.Add (NAD1983HARNAdjMNOlmsted);
            NAD1983HARNAdjMNOlmsted.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Olmsted", 0));

            datums.Add (NAD1983HARNAdjMNOttertail);
            NAD1983HARNAdjMNOttertail.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Ottertail", 0));

            datums.Add (NAD1983HARNAdjMNPennington);
            NAD1983HARNAdjMNPennington.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Pennington", 0));

            datums.Add (NAD1983HARNAdjMNPine);
            NAD1983HARNAdjMNPine.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Pine", 0));

            datums.Add (NAD1983HARNAdjMNPipestone);
            NAD1983HARNAdjMNPipestone.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Pipestone", 0));

            datums.Add (NAD1983HARNAdjMNPolk);
            NAD1983HARNAdjMNPolk.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Polk", 0));

            datums.Add (NAD1983HARNAdjMNPope);
            NAD1983HARNAdjMNPope.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Pope", 0));

            datums.Add (NAD1983HARNAdjMNRamsey);
            NAD1983HARNAdjMNRamsey.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Ramsey", 0));

            datums.Add (NAD1983HARNAdjMNRedLake);
            NAD1983HARNAdjMNRedLake.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Red_Lake", 0));

            datums.Add (NAD1983HARNAdjMNRedwood);
            NAD1983HARNAdjMNRedwood.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Redwood", 0));

            datums.Add (NAD1983HARNAdjMNRenville);
            NAD1983HARNAdjMNRenville.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Renville", 0));

            datums.Add (NAD1983HARNAdjMNRice);
            NAD1983HARNAdjMNRice.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Rice", 0));

            datums.Add (NAD1983HARNAdjMNRock);
            NAD1983HARNAdjMNRock.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Rock", 0));

            datums.Add (NAD1983HARNAdjMNRoseau);
            NAD1983HARNAdjMNRoseau.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Roseau", 0));

            datums.Add (NAD1983HARNAdjMNStLouisNorth);
            NAD1983HARNAdjMNStLouisNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_St_Louis_North", 0));

            datums.Add (NAD1983HARNAdjMNStLouisCentral);
            NAD1983HARNAdjMNStLouisCentral.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_St_Louis_Central", 0));

            datums.Add (NAD1983HARNAdjMNStLouisSouth);
            NAD1983HARNAdjMNStLouisSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_St_Louis_South", 0));

            datums.Add (NAD1983HARNAdjMNScott);
            NAD1983HARNAdjMNScott.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Scott", 0));

            datums.Add (NAD1983HARNAdjMNSherburne);
            NAD1983HARNAdjMNSherburne.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Sherburne", 0));

            datums.Add (NAD1983HARNAdjMNSibley);
            NAD1983HARNAdjMNSibley.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Sibley", 0));

            datums.Add (NAD1983HARNAdjMNStearns);
            NAD1983HARNAdjMNStearns.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Stearns", 0));

            datums.Add (NAD1983HARNAdjMNSteele);
            NAD1983HARNAdjMNSteele.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Steele", 0));

            datums.Add (NAD1983HARNAdjMNStevens);
            NAD1983HARNAdjMNStevens.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Stevens", 0));

            datums.Add (NAD1983HARNAdjMNSwift);
            NAD1983HARNAdjMNSwift.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Swift", 0));

            datums.Add (NAD1983HARNAdjMNTodd);
            NAD1983HARNAdjMNTodd.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Todd", 0));

            datums.Add (NAD1983HARNAdjMNTraverse);
            NAD1983HARNAdjMNTraverse.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Traverse", 0));

            datums.Add (NAD1983HARNAdjMNWabasha);
            NAD1983HARNAdjMNWabasha.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Wabasha", 0));

            datums.Add (NAD1983HARNAdjMNWadena);
            NAD1983HARNAdjMNWadena.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Wadena", 0));

            datums.Add (NAD1983HARNAdjMNWaseca);
            NAD1983HARNAdjMNWaseca.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Waseca", 0));

            datums.Add (NAD1983HARNAdjMNWatonwan);
            NAD1983HARNAdjMNWatonwan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Watonwan", 0));

            datums.Add (NAD1983HARNAdjMNWinona);
            NAD1983HARNAdjMNWinona.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Winona", 0));

            datums.Add (NAD1983HARNAdjMNWright);
            NAD1983HARNAdjMNWright.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Wright", 0));

            datums.Add (NAD1983HARNAdjMNYellowMedicine);
            NAD1983HARNAdjMNYellowMedicine.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_Yellow_Medicine", 0));

            datums.Add (NAD1983HARNAdjMNStLouis);
            NAD1983HARNAdjMNStLouis.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_NAD_1983_HARN_Adj_MN_St_Louis", 0));

            datums.Add (ITRF2005);
            ITRF2005.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_ITRF_2005", 0));

            datums.Add (Venus1985);
            Venus1985.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Venus_1985", 0));

            datums.Add (Venus2000);
            Venus2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "D_Venus_2000", 0));

            datums.Add (WGS84);
            WGS84.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "WGS84", 0));
        }


        public static DatumRegistry Instance
        {
            get { return instance ?? (instance = new DatumRegistry ()); }
        }

        public override IList <IGeodeticDatum> All
        {
            get { return datums; }
        }
    }
}