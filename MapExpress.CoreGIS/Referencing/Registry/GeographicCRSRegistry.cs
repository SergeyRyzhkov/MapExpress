#region

using System.Collections.Generic;
using MapExpress.CoreGIS.Referencing.CoordinateReferenceSystems;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;

#endregion

namespace MapExpress.CoreGIS.Referencing.Registry
{
    public class GeographicCRSRegistry : AuthorityObjectRegistry <IGeographicCRS>
    {
        private static readonly List <IGeographicCRS> coordSys = new List <IGeographicCRS> ();
        private static GeographicCRSRegistry instance;
        public IGeographicCRS AGD66 = new GeographicCRS {Name = "AGD66", Datum = DatumRegistry.Instance.AustralianGeodeticGeodeticDatum1966, ToWGS84 = new DatumShiftParameters (-117.808, -51.536, 137.784, -0.303, -0.446, -0.234, -0.29)};
        public IGeographicCRS AGD84 = new GeographicCRS {Name = "AGD84", Datum = DatumRegistry.Instance.AustralianGeodeticGeodeticDatum1984, ToWGS84 = new DatumShiftParameters (-134, -48, 149, 0, 0, 0, 0)};
        public IGeographicCRS ATFParis = new GeographicCRS {Name = "ATF (Paris)", Datum = DatumRegistry.Instance.AncienneTriangulationFrancaiseParis, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};

        public IGeographicCRS ATS77 = new GeographicCRS {Name = "ATS77", Datum = DatumRegistry.Instance.AverageTerrestrialSystem1977, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Abidjan1987 = new GeographicCRS {Name = "Abidjan 1987", Datum = DatumRegistry.Instance.Abidjan1987, ToWGS84 = new DatumShiftParameters (-124.76, 53, 466.79, 0, 0, 0, 0)};
        public IGeographicCRS Accra = new GeographicCRS {Name = "Accra", Datum = DatumRegistry.Instance.Accra, ToWGS84 = new DatumShiftParameters (-199, 32, 322, 0, 0, 0, 0)};
        public IGeographicCRS Adindan = new GeographicCRS {Name = "Adindan", Datum = DatumRegistry.Instance.Adindan, ToWGS84 = new DatumShiftParameters (-166, -15, 204, 0, 0, 0, 0)};
        public IGeographicCRS Afgooye = new GeographicCRS {Name = "Afgooye", Datum = DatumRegistry.Instance.Afgooye, ToWGS84 = new DatumShiftParameters (-43, -163, 45, 0, 0, 0, 0)};
        public IGeographicCRS Agadez = new GeographicCRS {Name = "Agadez", Datum = DatumRegistry.Instance.Agadez, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS AinelAbd = new GeographicCRS {Name = "Ain el Abd", Datum = DatumRegistry.Instance.AinelAbd1970, ToWGS84 = new DatumShiftParameters (-143, -236, 7, 0, 0, 0, 0)};
        public IGeographicCRS Airy1830 = new GeographicCRS {Name = "GCS_Airy_1830", Datum = DatumRegistry.Instance.Airy1830, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS AiryModified = new GeographicCRS {Name = "GCS_Airy_Modified", Datum = DatumRegistry.Instance.AiryModified, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS AlaskanIslands = new GeographicCRS {Name = "GCS_Alaskan_Islands", Datum = DatumRegistry.Instance.AlaskanIslands, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Albanian1987 = new GeographicCRS {Name = "Albanian 1987", Datum = DatumRegistry.Instance.Albanian1987, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS AmericanSamoa1962 = new GeographicCRS {Name = "American Samoa 1962", Datum = DatumRegistry.Instance.AmericanSamoa1962, ToWGS84 = new DatumShiftParameters (-115, 118, 426, 0, 0, 0, 0)};
        public IGeographicCRS Amersfoort = new GeographicCRS {Name = "Amersfoort", Datum = DatumRegistry.Instance.Amersfoort, ToWGS84 = new DatumShiftParameters (565.4171, 50.3319, 465.5524, 0.398957388243134, -0.343987817378283, 1.87740163998045, 4.0725)};
        public IGeographicCRS Ammassalik1958 = new GeographicCRS {Name = "Ammassalik 1958", Datum = DatumRegistry.Instance.Ammassalik1958, ToWGS84 = new DatumShiftParameters (-45, 417, -3.5, 0, 0, 0.814, -0.6)};
        public IGeographicCRS Anguilla1957 = new GeographicCRS {Name = "Anguilla 1957", Datum = DatumRegistry.Instance.Anguilla1957, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Antigua1943 = new GeographicCRS {Name = "Antigua 1943", Datum = DatumRegistry.Instance.Antigua1943, ToWGS84 = new DatumShiftParameters (-255, -15, 71, 0, 0, 0, 0)};
        public IGeographicCRS Aratu = new GeographicCRS {Name = "Aratu", Datum = DatumRegistry.Instance.Aratu, ToWGS84 = new DatumShiftParameters (-151.99, 287.04, -147.45, 0, 0, 0, 0)};
        public IGeographicCRS Arc1950 = new GeographicCRS {Name = "Arc 1950", Datum = DatumRegistry.Instance.Arc1950, ToWGS84 = new DatumShiftParameters (-143, -90, -294, 0, 0, 0, 0)};
        public IGeographicCRS Arc1960 = new GeographicCRS {Name = "Arc 1960", Datum = DatumRegistry.Instance.Arc1960, ToWGS84 = new DatumShiftParameters (-160, -6, -302, 0, 0, 0, 0)};
        public IGeographicCRS AscensionIsland1958 = new GeographicCRS {Name = "Ascension Island 1958", Datum = DatumRegistry.Instance.AscensionIsland1958, ToWGS84 = new DatumShiftParameters (-205, 107, 53, 0, 0, 0, 0)};
        public IGeographicCRS Australian = new GeographicCRS {Name = "GCS_Australian", Datum = DatumRegistry.Instance.Australian, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS AustralianAntarctic = new GeographicCRS {Name = "Australian Antarctic", Datum = DatumRegistry.Instance.AustralianAntarcticGeodeticDatum1998, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS AyabelleLighthouse = new GeographicCRS {Name = "Ayabelle Lighthouse", Datum = DatumRegistry.Instance.AyabelleLighthouse, ToWGS84 = new DatumShiftParameters (-79, -129, 145, 0, 0, 0, 0)};
        public IGeographicCRS AzoresCentral1948 = new GeographicCRS {Name = "Azores Central 1948", Datum = DatumRegistry.Instance.AzoresCentralIslands1948, ToWGS84 = new DatumShiftParameters (-104, 167, -38, 0, 0, 0, 0)};
        public IGeographicCRS AzoresCentral1995 = new GeographicCRS {Name = "Azores Central 1995", Datum = DatumRegistry.Instance.AzoresCentralIslands1995, ToWGS84 = new DatumShiftParameters (-106.226, 166.366, -37.893, 0, 0, 0, 0)};
        public IGeographicCRS AzoresOccidental1939 = new GeographicCRS {Name = "Azores Occidental 1939", Datum = DatumRegistry.Instance.AzoresOccidentalIslands1939, ToWGS84 = new DatumShiftParameters (-425, -169, 81, 0, 0, 0, 0)};
        public IGeographicCRS AzoresOriental1940 = new GeographicCRS {Name = "Azores Oriental 1940", Datum = DatumRegistry.Instance.AzoresOrientalIslands1940, ToWGS84 = new DatumShiftParameters (-203, 141, 53, 0, 0, 0, 0)};
        public IGeographicCRS AzoresOriental1995 = new GeographicCRS {Name = "Azores Oriental 1995", Datum = DatumRegistry.Instance.AzoresOrientalIslands1995, ToWGS84 = new DatumShiftParameters (-204.619, 140.176, 55.226, 0, 0, 0, 0)};
        public IGeographicCRS BDA2000 = new GeographicCRS {Name = "BDA2000", Datum = DatumRegistry.Instance.Bermuda2000, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS BabSouth = new GeographicCRS {Name = "GCS_Bab_South", Datum = DatumRegistry.Instance.BabSouth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Barbados1938 = new GeographicCRS {Name = "Barbados 1938", Datum = DatumRegistry.Instance.Barbados1938, ToWGS84 = new DatumShiftParameters (31.95, 300.99, 419.19, 0, 0, 0, 0)};
        public IGeographicCRS Batavia = new GeographicCRS {Name = "Batavia", Datum = DatumRegistry.Instance.Batavia, ToWGS84 = new DatumShiftParameters (-377, 681, -50, 0, 0, 0, 0)};
        public IGeographicCRS BataviaJakarta = new GeographicCRS {Name = "Batavia (Jakarta)", Datum = DatumRegistry.Instance.BataviaJakarta, ToWGS84 = new DatumShiftParameters (-377, 681, -50, 0, 0, 0, 0)};
        public IGeographicCRS Beduaram = new GeographicCRS {Name = "Beduaram", Datum = DatumRegistry.Instance.Beduaram, ToWGS84 = new DatumShiftParameters (-106, -87, 188, 0, 0, 0, 0)};
        public IGeographicCRS Beijing1954 = new GeographicCRS {Name = "Beijing 1954", Datum = DatumRegistry.Instance.Beijing1954, ToWGS84 = new DatumShiftParameters (15.8, -154.4, -82.3, 0, 0, 0, 0)};
        public IGeographicCRS Belge1950 = new GeographicCRS {Name = "Belge 1950", Datum = DatumRegistry.Instance.ReseauNationalBelge1950, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Belge1950Brussels = new GeographicCRS {Name = "Belge 1950 (Brussels)", Datum = DatumRegistry.Instance.ReseauNationalBelge1950Brussels, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Belge1972 = new GeographicCRS {Name = "Belge 1972", Datum = DatumRegistry.Instance.ReseauNationalBelge1972, ToWGS84 = new DatumShiftParameters (-106.8686, 52.2978, -103.7239, -0.3366, 0.457, -1.8422, -1.2747)};
        public IGeographicCRS Bellevue = new GeographicCRS {Name = "Bellevue", Datum = DatumRegistry.Instance.Bellevue, ToWGS84 = new DatumShiftParameters (-127, -769, 472, 0, 0, 0, 0)};
        public IGeographicCRS Bermuda1957 = new GeographicCRS {Name = "Bermuda 1957", Datum = DatumRegistry.Instance.Bermuda1957, ToWGS84 = new DatumShiftParameters (-73, 213, 296, 0, 0, 0, 0)};
        public IGeographicCRS Bern1898Bern = new GeographicCRS {Name = "Bern 1898 (Bern)", Datum = DatumRegistry.Instance.CH1903Bern, ToWGS84 = new DatumShiftParameters (674.4, 15.1, 405.3, 0, 0, 0, 0)};
        public IGeographicCRS Bern1938 = new GeographicCRS {Name = "Bern 1938", Datum = DatumRegistry.Instance.Bern1938, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Bessel1841 = new GeographicCRS {Name = "GCS_Bessel_1841", Datum = DatumRegistry.Instance.Bessel1841, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS BesselModified = new GeographicCRS {Name = "GCS_Bessel_Modified", Datum = DatumRegistry.Instance.BesselModified, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS BesselNamibia = new GeographicCRS {Name = "GCS_Bessel_Namibia", Datum = DatumRegistry.Instance.BesselNamibia, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Bissau = new GeographicCRS {Name = "Bissau", Datum = DatumRegistry.Instance.Bissau, ToWGS84 = new DatumShiftParameters (-173, 253, 27, 0, 0, 0, 0)};
        public IGeographicCRS Bogota1975 = new GeographicCRS {Name = "Bogota 1975", Datum = DatumRegistry.Instance.Bogota1975, ToWGS84 = new DatumShiftParameters (307, 304, -318, 0, 0, 0, 0)};
        public IGeographicCRS Bogota1975Bogota = new GeographicCRS {Name = "Bogota 1975 (Bogota)", Datum = DatumRegistry.Instance.Bogota1975Bogota, ToWGS84 = new DatumShiftParameters (307, 304, -318, 0, 0, 0, 0)};
        public IGeographicCRS BukitRimpah = new GeographicCRS {Name = "Bukit Rimpah", Datum = DatumRegistry.Instance.BukitRimpah, ToWGS84 = new DatumShiftParameters (-384, 664, -48, 0, 0, 0, 0)};
        public IGeographicCRS CGRS1993 = new GeographicCRS {Name = "GCS_CGRS_1993", Datum = DatumRegistry.Instance.CyprusGeodeticReferenceSystem1993, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS CH1903 = new GeographicCRS {Name = "CH1903", Datum = DatumRegistry.Instance.CH1903, ToWGS84 = new DatumShiftParameters (674.4, 15.1, 405.3, 0, 0, 0, 0)};
        public IGeographicCRS CH1903Plus = new GeographicCRS {Name = "CH1903+", Datum = DatumRegistry.Instance.CH1903Plus, ToWGS84 = new DatumShiftParameters (674.374, 15.056, 405.346, 0, 0, 0, 0)};
        public IGeographicCRS CHTRF95 = new GeographicCRS {Name = "CHTRF95", Datum = DatumRegistry.Instance.SwissTerrestrialReferenceFrame1995, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS CIGD11 = new GeographicCRS {Name = "CIGD11", Datum = DatumRegistry.Instance.CaymanIslandsGeodeticGeodeticDatum2011, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS CR05 = new GeographicCRS {Name = "CR05", Datum = DatumRegistry.Instance.CostaRica2005, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS CSG67 = new GeographicCRS {Name = "CSG67", Datum = DatumRegistry.Instance.CentreSpatialGuyanais1967, ToWGS84 = new DatumShiftParameters (-186, 230, 110, 0, 0, 0, 0)};
        public IGeographicCRS Cadastre1997 = new GeographicCRS {Name = "Cadastre 1997", Datum = DatumRegistry.Instance.Cadastre1997, ToWGS84 = new DatumShiftParameters (-381.788, -57.501, -256.673, 0, 0, 0, 0)};
        public IGeographicCRS Camacupa = new GeographicCRS {Name = "Camacupa", Datum = DatumRegistry.Instance.Camacupa, ToWGS84 = new DatumShiftParameters (-50.9, -347.6, -231, 0, 0, 0, 0)};
        public IGeographicCRS CampAreaAstro = new GeographicCRS {Name = "Camp Area Astro", Datum = DatumRegistry.Instance.CampAreaAstro, ToWGS84 = new DatumShiftParameters (-104, -129, 239, 0, 0, 0, 0)};
        public IGeographicCRS CampoInchauspe = new GeographicCRS {Name = "Campo Inchauspe", Datum = DatumRegistry.Instance.CampoInchauspe, ToWGS84 = new DatumShiftParameters (-148, 136, 90, 0, 0, 0, 0)};
        public IGeographicCRS Cape = new GeographicCRS {Name = "Cape", Datum = DatumRegistry.Instance.Cape, ToWGS84 = new DatumShiftParameters (-136, -108, -292, 0, 0, 0, 0)};
        public IGeographicCRS CapeCanaveral = new GeographicCRS {Name = "Cape Canaveral", Datum = DatumRegistry.Instance.CapeCanaveral, ToWGS84 = new DatumShiftParameters (-2, 151, 181, 0, 0, 0, 0)};
        public IGeographicCRS Carthage = new GeographicCRS {Name = "Carthage", Datum = DatumRegistry.Instance.Carthage, ToWGS84 = new DatumShiftParameters (-263, 6, 431, 0, 0, 0, 0)};
        public IGeographicCRS CarthageGrad = new GeographicCRS {Name = "GCS_Carthage_Grad", Datum = DatumRegistry.Instance.Carthage, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS CarthageParis = new GeographicCRS {Name = "Carthage (Paris)", Datum = DatumRegistry.Instance.CarthageParis, ToWGS84 = new DatumShiftParameters (-263, 6, 431, 0, 0, 0, 0)};
        public IGeographicCRS ChathamIslands1971 = new GeographicCRS {Name = "Chatham Islands 1971", Datum = DatumRegistry.Instance.ChathamIslandsGeodeticDatum1971, ToWGS84 = new DatumShiftParameters (175, -38, 113, 0, 0, 0, 0)};
        public IGeographicCRS ChathamIslands1979 = new GeographicCRS {Name = "Chatham Islands 1979", Datum = DatumRegistry.Instance.ChathamIslandsGeodeticDatum1979, ToWGS84 = new DatumShiftParameters (174.05, -25.49, 112.57, 0, 0, -0.554, 0.2263)};
        public IGeographicCRS ChinaGeodeticCoordinateSystem2000 = new GeographicCRS {Name = "China Geodetic Coordinate System 2000", Datum = DatumRegistry.Instance.China2000, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ChosMalal1914 = new GeographicCRS {Name = "Chos Malal 1914", Datum = DatumRegistry.Instance.ChosMalal1914, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Chua = new GeographicCRS {Name = "Chua", Datum = DatumRegistry.Instance.Chua, ToWGS84 = new DatumShiftParameters (-134, 229, -29, 0, 0, 0, 0)};
        public IGeographicCRS Clarke1858 = new GeographicCRS {Name = "GCS_Clarke_1858", Datum = DatumRegistry.Instance.Clarke1858, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Clarke1866 = new GeographicCRS {Name = "GCS_Clarke_1866", Datum = DatumRegistry.Instance.Clarke1866, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Clarke1866Michigan = new GeographicCRS {Name = "GCS_Clarke_1866_Michigan", Datum = DatumRegistry.Instance.Clarke1866Michigan, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Clarke1880 = new GeographicCRS {Name = "GCS_Clarke_1880", Datum = DatumRegistry.Instance.Clarke1880, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Clarke1880Arc = new GeographicCRS {Name = "GCS_Clarke_1880_Arc", Datum = DatumRegistry.Instance.Clarke1880Arc, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Clarke1880Benoit = new GeographicCRS {Name = "GCS_Clarke_1880_Benoit", Datum = DatumRegistry.Instance.Clarke1880Benoit, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Clarke1880IGN = new GeographicCRS {Name = "GCS_Clarke_1880_IGN", Datum = DatumRegistry.Instance.Clarke1880IGN, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Clarke1880RGS = new GeographicCRS {Name = "GCS_Clarke_1880_RGS", Datum = DatumRegistry.Instance.Clarke1880RGS, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Clarke1880SGA = new GeographicCRS {Name = "GCS_Clarke_1880_SGA", Datum = DatumRegistry.Instance.Clarke1880SGA, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS CocosIslands1965 = new GeographicCRS {Name = "Cocos Islands 1965", Datum = DatumRegistry.Instance.CocosIslands1965, ToWGS84 = new DatumShiftParameters (-491, -22, 435, 0, 0, 0, 0)};
        public IGeographicCRS Combani1950 = new GeographicCRS {Name = "Combani 1950", Datum = DatumRegistry.Instance.Combani1950, ToWGS84 = new DatumShiftParameters (-382, -59, -262, 0, 0, 0, 0)};
        public IGeographicCRS Conakry1905 = new GeographicCRS {Name = "Conakry 1905", Datum = DatumRegistry.Instance.Conakry1905, ToWGS84 = new DatumShiftParameters (-23, 259, -9, 0, 0, 0, 0)};
        public IGeographicCRS CorregoAlegre1961 = new GeographicCRS {Name = "Corrego Alegre 1961", Datum = DatumRegistry.Instance.CorregoAlegre1961, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS CorregoAlegre197072 = new GeographicCRS {Name = "Corrego Alegre 1970-72", Datum = DatumRegistry.Instance.CorregoAlegre197072, ToWGS84 = new DatumShiftParameters (-206, 172, -6, 0, 0, 0, 0)};
        public IGeographicCRS CotedIvoire = new GeographicCRS {Name = "GCS_Cote_d_Ivoire", Datum = DatumRegistry.Instance.CotedIvoire, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS D48 = new GeographicCRS {Name = "GCS_D48", Datum = DatumRegistry.Instance.D48, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS DBREF = new GeographicCRS {Name = "DB_REF", Datum = DatumRegistry.Instance.DeutscheBahnReferenceSystem, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS DGN95 = new GeographicCRS {Name = "DGN95", Datum = DatumRegistry.Instance.GeodeticDatumGeodesiNasional1995, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS DHDN = new GeographicCRS {Name = "DHDN", Datum = DatumRegistry.Instance.DeutschesHauptdreiecksnetz, ToWGS84 = new DatumShiftParameters (598.1, 73.7, 418.2, 0.202, 0.045, -2.455, 6.7)};
        public IGeographicCRS DOS1968 = new GeographicCRS {Name = "GCS_DOS_1968", Datum = DatumRegistry.Instance.DOS1968, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS DRUKREF03 = new GeographicCRS {Name = "DRUKREF 03", Datum = DatumRegistry.Instance.BhutanNationalGeodeticGeodeticDatum, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Dabola1981 = new GeographicCRS {Name = "Dabola 1981", Datum = DatumRegistry.Instance.Dabola1981, ToWGS84 = new DatumShiftParameters (-83, 37, 124, 0, 0, 0, 0)};
        public IGeographicCRS Datum73 = new GeographicCRS {Name = "Datum 73", Datum = DatumRegistry.Instance.GeodeticDatum73, ToWGS84 = new DatumShiftParameters (-223.237, 110.193, 36.649, 0, 0, 0, 0)};
        public IGeographicCRS DatumLisboaBessel = new GeographicCRS {Name = "GCS_Datum_Lisboa_Bessel", Datum = DatumRegistry.Instance.DatumLisboaBessel, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS DatumLisboaHayford = new GeographicCRS {Name = "GCS_Datum_Lisboa_Hayford", Datum = DatumRegistry.Instance.DatumLisboaHayford, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS DealulPiscului1930 = new GeographicCRS {Name = "Dealul Piscului 1930", Datum = DatumRegistry.Instance.DealulPiscului1930, ToWGS84 = new DatumShiftParameters (103.25, -100.4, -307.19, 0, 0, 0, 0)};
        public IGeographicCRS DeceptionIsland = new GeographicCRS {Name = "Deception Island", Datum = DatumRegistry.Instance.DeceptionIsland, ToWGS84 = new DatumShiftParameters (260, 12, -147, 0, 0, 0, 0)};
        public IGeographicCRS DeirezZor = new GeographicCRS {Name = "Deir ez Zor", Datum = DatumRegistry.Instance.DeirezZor, ToWGS84 = new DatumShiftParameters (-190.421, 8.532, 238.69, 0, 0, 0, 0)};
        public IGeographicCRS DiegoGarcia1969 = new GeographicCRS {Name = "Diego Garcia 1969", Datum = DatumRegistry.Instance.DiegoGarcia1969, ToWGS84 = new DatumShiftParameters (208, -435, -229, 0, 0, 0, 0)};
        public IGeographicCRS Dominica1945 = new GeographicCRS {Name = "Dominica 1945", Datum = DatumRegistry.Instance.Dominica1945, ToWGS84 = new DatumShiftParameters (725, 685, 536, 0, 0, 0, 0)};
        public IGeographicCRS Douala = new GeographicCRS {Name = "GCS_Douala", Datum = DatumRegistry.Instance.Douala, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Douala1948 = new GeographicCRS {Name = "Douala 1948", Datum = DatumRegistry.Instance.Douala1948, ToWGS84 = new DatumShiftParameters (-206.1, -174.7, -87.7, 0, 0, 0, 0)};
        public IGeographicCRS ED50 = new GeographicCRS {Name = "ED50", Datum = DatumRegistry.Instance.EuropeanGeodeticDatum1950, ToWGS84 = new DatumShiftParameters (-87, -98, -121, 0, 0, 0, 0)};
        public IGeographicCRS ED50ED77 = new GeographicCRS {Name = "ED50(ED77)", Datum = DatumRegistry.Instance.EuropeanGeodeticDatum19501977, ToWGS84 = new DatumShiftParameters (-117, -132, -164, 0, 0, 0, 0)};
        public IGeographicCRS ED79 = new GeographicCRS {Name = "ED79", Datum = DatumRegistry.Instance.EuropeanGeodeticDatum1979, ToWGS84 = new DatumShiftParameters (-86, -98, -119, 0, 0, 0, 0)};
        public IGeographicCRS ED87 = new GeographicCRS {Name = "ED87", Datum = DatumRegistry.Instance.EuropeanGeodeticDatum1987, ToWGS84 = new DatumShiftParameters (-83.11, -97.38, -117.22, 0.00569290865241986, -0.0446975835137458, 0.0442850539012516, 0.1218)};
        public IGeographicCRS ELD79 = new GeographicCRS {Name = "ELD79", Datum = DatumRegistry.Instance.EuropeanLibyanGeodeticDatum1979, ToWGS84 = new DatumShiftParameters (-115.8543, -99.0583, -152.4616, 0, 0, 0, 0)};
        public IGeographicCRS EST92 = new GeographicCRS {Name = "EST92", Datum = DatumRegistry.Instance.Estonia1992, ToWGS84 = new DatumShiftParameters (0.055, -0.541, -0.185, -0.0183, 0.0003, 0.007, -0.014)};
        public IGeographicCRS EST97 = new GeographicCRS {Name = "EST97", Datum = DatumRegistry.Instance.Estonia1997, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ETRF1989 = new GeographicCRS {Name = "GCS_ETRF_1989", Datum = DatumRegistry.Instance.ETRF1989, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ETRS89 = new GeographicCRS {Name = "ETRS89", Datum = DatumRegistry.Instance.EuropeanTerrestrialReferenceSystem1989, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS EUREFFIN = new GeographicCRS {Name = "GCS_EUREF_FIN", Datum = DatumRegistry.Instance.ETRS1989, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS EasterIsland1967 = new GeographicCRS {Name = "Easter Island 1967", Datum = DatumRegistry.Instance.EasterIsland1967, ToWGS84 = new DatumShiftParameters (211, 147, 111, 0, 0, 0, 0)};
        public IGeographicCRS Egypt1907 = new GeographicCRS {Name = "Egypt 1907", Datum = DatumRegistry.Instance.Egypt1907, ToWGS84 = new DatumShiftParameters (-130, 110, -13, 0, 0, 0, 0)};
        public IGeographicCRS Egypt1930 = new GeographicCRS {Name = "Egypt 1930", Datum = DatumRegistry.Instance.Egypt1930, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS EgyptGulfofSuezS650TL = new GeographicCRS {Name = "Egypt Gulf of Suez S-650 TL", Datum = DatumRegistry.Instance.EgyptGulfofSuezS650TL, ToWGS84 = new DatumShiftParameters (-146.21, 112.63, 4.05, 0, 0, 0, 0)};
        public IGeographicCRS Estonia1937 = new GeographicCRS {Name = "GCS_Estonia_1937", Datum = DatumRegistry.Instance.Estonia1937, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Everest1830 = new GeographicCRS {Name = "GCS_Everest_1830", Datum = DatumRegistry.Instance.Everest1830, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS EverestAdj1937 = new GeographicCRS {Name = "GCS_Everest_Adj_1937", Datum = DatumRegistry.Instance.EverestAdj1937, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS EverestBangladesh = new GeographicCRS {Name = "GCS_Everest_Bangladesh", Datum = DatumRegistry.Instance.EverestBangladesh, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS EverestIndiaNepal = new GeographicCRS {Name = "GCS_Everest_India_Nepal", Datum = DatumRegistry.Instance.EverestIndiaNepal, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS EverestModified = new GeographicCRS {Name = "GCS_Everest_Modified", Datum = DatumRegistry.Instance.EverestModified, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS EverestModified1969 = new GeographicCRS {Name = "GCS_Everest_Modified_1969", Datum = DatumRegistry.Instance.EverestModified1969, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Everestdef1962 = new GeographicCRS {Name = "GCS_Everest_def_1962", Datum = DatumRegistry.Instance.EverestDef1962, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Everestdef1967 = new GeographicCRS {Name = "GCS_Everest_def_1967", Datum = DatumRegistry.Instance.EverestDef1967, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Everestdef1975 = new GeographicCRS {Name = "GCS_Everest_def_1975", Datum = DatumRegistry.Instance.EverestDef1975, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS FD54 = new GeographicCRS {Name = "FD54", Datum = DatumRegistry.Instance.FaroeGeodeticDatum1954, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS FD58 = new GeographicCRS {Name = "FD58", Datum = DatumRegistry.Instance.FinalGeodeticDatum1958, ToWGS84 = new DatumShiftParameters (-241.54, -163.64, 396.06, 0, 0, 0, 0)};
        public IGeographicCRS FEH2010 = new GeographicCRS {Name = "FEH2010", Datum = DatumRegistry.Instance.FehmarnbeltGeodeticDatum2010, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Fahud = new GeographicCRS {Name = "Fahud", Datum = DatumRegistry.Instance.Fahud, ToWGS84 = new DatumShiftParameters (-346, -1, 224, 0, 0, 0, 0)};
        public IGeographicCRS FatuIva72 = new GeographicCRS {Name = "Fatu Iva 72", Datum = DatumRegistry.Instance.FatuIva72, ToWGS84 = new DatumShiftParameters (347.103, 1078.125, 2623.922, 33.8875, -70.6773, 9.3943, 186.074)};
        public IGeographicCRS Fiji1956 = new GeographicCRS {Name = "Fiji 1956", Datum = DatumRegistry.Instance.Fiji1956, ToWGS84 = new DatumShiftParameters (265.025, 384.929, -194.046, 0, 0, 0, 0)};
        public IGeographicCRS Fiji1986 = new GeographicCRS {Name = "Fiji 1986", Datum = DatumRegistry.Instance.FijiGeodeticGeodeticDatum1986, ToWGS84 = new DatumShiftParameters (0, 0, 4.5, 0, 0, 0.554, 0.2263)};
        public IGeographicCRS Fischer1960 = new GeographicCRS {Name = "GCS_Fischer_1960", Datum = DatumRegistry.Instance.Fischer1960, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Fischer1968 = new GeographicCRS {Name = "GCS_Fischer_1968", Datum = DatumRegistry.Instance.Fischer1968, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS FischerModified = new GeographicCRS {Name = "GCS_Fischer_Modified", Datum = DatumRegistry.Instance.FischerModified, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS FortMarigot = new GeographicCRS {Name = "Fort Marigot", Datum = DatumRegistry.Instance.FortMarigot, ToWGS84 = new DatumShiftParameters (137, 248, -430, 0, 0, 0, 0)};
        public IGeographicCRS FortThomas1955 = new GeographicCRS {Name = "GCS_Fort_Thomas_1955", Datum = DatumRegistry.Instance.FortThomas1955, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS GCGD59 = new GeographicCRS {Name = "GCGD59", Datum = DatumRegistry.Instance.GrandCaymanGeodeticGeodeticDatum1959, ToWGS84 = new DatumShiftParameters (-179.483, -69.379, -27.584, 7.862, -8.163, -6.042, -13.925)};
        public IGeographicCRS GDA94 = new GeographicCRS {Name = "GDA94", Datum = DatumRegistry.Instance.GeocentricGeodeticDatumofAustralia1994, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS GDBD2009 = new GeographicCRS {Name = "GDBD2009", Datum = DatumRegistry.Instance.GeocentricGeodeticDatumBruneiDarussalam2009, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS GDM2000 = new GeographicCRS {Name = "GDM2000", Datum = DatumRegistry.Instance.GeodeticGeodeticDatumofMalaysia2000, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS GEM10C = new GeographicCRS {Name = "GCS_GEM_10C", Datum = DatumRegistry.Instance.GEM10C, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS GGRS87 = new GeographicCRS {Name = "GGRS87", Datum = DatumRegistry.Instance.GreekGeodeticReferenceSystem1987, ToWGS84 = new DatumShiftParameters (-199.87, 74.79, 246.62, 0, 0, 0, 0)};
        public IGeographicCRS GR96 = new GeographicCRS {Name = "GR96", Datum = DatumRegistry.Instance.Greenland1996, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS GRS1967 = new GeographicCRS {Name = "GCS_GRS_1967", Datum = DatumRegistry.Instance.GRS1967, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS GRS1980 = new GeographicCRS {Name = "GCS_GRS_1980", Datum = DatumRegistry.Instance.GRS1980, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS GUX1 = new GeographicCRS {Name = "GCS_GUX_1", Datum = DatumRegistry.Instance.GUX1, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Gan1970 = new GeographicCRS {Name = "Gan 1970", Datum = DatumRegistry.Instance.Gan1970, ToWGS84 = new DatumShiftParameters (-133, -321, 50, 0, 0, 0, 0)};
        public IGeographicCRS Garoua = new GeographicCRS {Name = "Garoua", Datum = DatumRegistry.Instance.Garoua, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS GraciosaBaseSW1948 = new GeographicCRS {Name = "GCS_Graciosa_Base_SW_1948", Datum = DatumRegistry.Instance.GraciosaBaseSW1948, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS GrandComoros = new GeographicCRS {Name = "Grand Comoros", Datum = DatumRegistry.Instance.GrandComoros, ToWGS84 = new DatumShiftParameters (-963, 510, -359, 0, 0, 0, 0)};
        public IGeographicCRS Greek = new GeographicCRS {Name = "Greek", Datum = DatumRegistry.Instance.Greek, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS GreekAthens = new GeographicCRS {Name = "Greek (Athens)", Datum = DatumRegistry.Instance.GreekAthens, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Grenada1953 = new GeographicCRS {Name = "Grenada 1953", Datum = DatumRegistry.Instance.Grenada1953, ToWGS84 = new DatumShiftParameters (72, 213.7, 93, 0, 0, 0, 0)};
        public IGeographicCRS Guadeloupe1948 = new GeographicCRS {Name = "Guadeloupe 1948", Datum = DatumRegistry.Instance.Guadeloupe1948, ToWGS84 = new DatumShiftParameters (-467, -16, -300, 0, 0, 0, 0)};
        public IGeographicCRS Guam1963 = new GeographicCRS {Name = "Guam 1963", Datum = DatumRegistry.Instance.Guam1963, ToWGS84 = new DatumShiftParameters (-100, -248, 259, 0, 0, 0, 0)};
        public IGeographicCRS Gulshan303 = new GeographicCRS {Name = "Gulshan 303", Datum = DatumRegistry.Instance.Gulshan303, ToWGS84 = new DatumShiftParameters (283.7, 735.9, 261.1, 0, 0, 0, 0)};
        public IGeographicCRS GuyaneFrancaise = new GeographicCRS {Name = "GCS_Guyane_Francaise", Datum = DatumRegistry.Instance.GuyaneFrancaise, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS HD1909 = new GeographicCRS {Name = "HD1909", Datum = DatumRegistry.Instance.HungarianGeodeticDatum1909, ToWGS84 = new DatumShiftParameters (595.48, 121.69, 515.35, -4.115, 2.9383, -0.853, -3.408)};
        public IGeographicCRS HD72 = new GeographicCRS {Name = "HD72", Datum = DatumRegistry.Instance.HungarianGeodeticDatum1972, ToWGS84 = new DatumShiftParameters (52.17, -71.82, -14.9, 0, 0, 0, 0)};
        public IGeographicCRS HTRS96 = new GeographicCRS {Name = "HTRS96", Datum = DatumRegistry.Instance.CroatianTerrestrialReferenceSystem, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Hanoi1972 = new GeographicCRS {Name = "Hanoi 1972", Datum = DatumRegistry.Instance.Hanoi1972, ToWGS84 = new DatumShiftParameters (-17.51, -108.32, -62.39, 0, 0, 0, 0)};
        public IGeographicCRS Hartebeesthoek94 = new GeographicCRS {Name = "Hartebeesthoek94", Datum = DatumRegistry.Instance.Hartebeesthoek94, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Helle1954 = new GeographicCRS {Name = "Helle 1954", Datum = DatumRegistry.Instance.Helle1954, ToWGS84 = new DatumShiftParameters (982.6087, 552.753, -540.873, 6.68162662527694, -31.6114924086422, -19.8481610048168, 16.805)};
        public IGeographicCRS Helmert1906 = new GeographicCRS {Name = "GCS_Helmert_1906", Datum = DatumRegistry.Instance.Helmert1906, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS HeratNorth = new GeographicCRS {Name = "Herat North", Datum = DatumRegistry.Instance.HeratNorth, ToWGS84 = new DatumShiftParameters (-333, -222, 114, 0, 0, 0, 0)};
        public IGeographicCRS Hermannskogel = new GeographicCRS {Name = "GCS_Hermannskogel", Datum = DatumRegistry.Instance.Hermannskogel, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS HitoXVIII1963 = new GeographicCRS {Name = "Hito XVIII 1963", Datum = DatumRegistry.Instance.HitoXVIII1963, ToWGS84 = new DatumShiftParameters (16, 196, 93, 0, 0, 0, 0)};
        public IGeographicCRS Hjorsey1955 = new GeographicCRS {Name = "Hjorsey 1955", Datum = DatumRegistry.Instance.Hjorsey1955, ToWGS84 = new DatumShiftParameters (-73, 46, -86, 0, 0, 0, 0)};
        public IGeographicCRS HongKong1963 = new GeographicCRS {Name = "Hong Kong 1963", Datum = DatumRegistry.Instance.HongKong1963, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS HongKong196367 = new GeographicCRS {Name = "Hong Kong 1963(67)", Datum = DatumRegistry.Instance.HongKong196367, ToWGS84 = new DatumShiftParameters (-156, -271, -189, 0, 0, 0, 0)};
        public IGeographicCRS HongKong1980 = new GeographicCRS {Name = "Hong Kong 1980", Datum = DatumRegistry.Instance.HongKong1980, ToWGS84 = new DatumShiftParameters (-162.619, -276.959, -161.764, 0.067753, -2.243649, -1.158827, -1.094246)};
        public IGeographicCRS Hough1960 = new GeographicCRS {Name = "GCS_Hough_1960", Datum = DatumRegistry.Instance.Hough1960, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS HuTzuShan1950 = new GeographicCRS {Name = "Hu Tzu Shan 1950", Datum = DatumRegistry.Instance.HuTzuShan1950, ToWGS84 = new DatumShiftParameters (-637, -549, -203, 0, 0, 0, 0)};
        public IGeographicCRS Hughes1980 = new GeographicCRS {Name = "GCS_Hughes_1980", Datum = DatumRegistry.Instance.Hughes1980, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ID74 = new GeographicCRS {Name = "ID74", Datum = DatumRegistry.Instance.IndonesianGeodeticDatum1974, ToWGS84 = new DatumShiftParameters (-24, -15, 5, 0, 0, 0, 0)};
        public IGeographicCRS IGC19626thParallelSouth = new GeographicCRS {Name = "IGC 1962 6th Parallel South", Datum = DatumRegistry.Instance.IGC1962Arcofthe6thParallelSouth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS IGCB1955 = new GeographicCRS {Name = "IGCB 1955", Datum = DatumRegistry.Instance.InstitutGeographiqueduCongoBelge1955, ToWGS84 = new DatumShiftParameters (-79.9, -158, -168.9, 0, 0, 0, 0)};
        public IGeographicCRS IGM95 = new GeographicCRS {Name = "IGM95", Datum = DatumRegistry.Instance.IstitutoGeograficoMilitaire1995, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS IGN1962Kerguelen = new GeographicCRS {Name = "IGN 1962 Kerguelen", Datum = DatumRegistry.Instance.IGN1962Kerguelen, ToWGS84 = new DatumShiftParameters (145, -187, 103, 0, 0, 0, 0)};
        public IGeographicCRS IGN53Mare = new GeographicCRS {Name = "IGN53 Mare", Datum = DatumRegistry.Instance.IGN53Mare, ToWGS84 = new DatumShiftParameters (287.58, 177.78, -135.41, 0, 0, 0, 0)};
        public IGeographicCRS IGN56Lifou = new GeographicCRS {Name = "IGN56 Lifou", Datum = DatumRegistry.Instance.IGN56Lifou, ToWGS84 = new DatumShiftParameters (335.47, 222.58, -230.94, 0, 0, 0, 0)};
        public IGeographicCRS IGN63HivaOa = new GeographicCRS {Name = "IGN63 Hiva Oa", Datum = DatumRegistry.Instance.IGN63HivaOa, ToWGS84 = new DatumShiftParameters (410.721, 55.049, 80.746, -2.5779, -2.3514, -0.6664, 17.3311)};
        public IGeographicCRS IGN72GrandeTerre = new GeographicCRS {Name = "IGN72 Grande Terre", Datum = DatumRegistry.Instance.IGN72GrandeTerre, ToWGS84 = new DatumShiftParameters (-11.64, -348.6, 291.98, 0, 0, 0, 0)};
        public IGeographicCRS IGN72NukuHiva = new GeographicCRS {Name = "IGN72 Nuku Hiva", Datum = DatumRegistry.Instance.IGN72NukuHiva, ToWGS84 = new DatumShiftParameters (84, 274, 65, 0, 0, 0, 0)};
        public IGeographicCRS IGNAstro1960 = new GeographicCRS {Name = "IGN Astro 1960", Datum = DatumRegistry.Instance.IGNAstro1960, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS IGRS = new GeographicCRS {Name = "IGRS", Datum = DatumRegistry.Instance.IraqiGeospatialReferenceSystem, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS IKBD92 = new GeographicCRS {Name = "IKBD-92", Datum = DatumRegistry.Instance.IraqKuwaitBoundaryGeodeticDatum1992, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS IRENET95 = new GeographicCRS {Name = "IRENET95", Datum = DatumRegistry.Instance.IRENET95, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ISN2004 = new GeographicCRS {Name = "ISN2004", Datum = DatumRegistry.Instance.IslandsNet2004, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ISN93 = new GeographicCRS {Name = "ISN93", Datum = DatumRegistry.Instance.IslandsNet1993, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF1988 = new GeographicCRS {Name = "GCS_ITRF_1988", Datum = DatumRegistry.Instance.ITRF1988, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF1989 = new GeographicCRS {Name = "GCS_ITRF_1989", Datum = DatumRegistry.Instance.ITRF1989, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF1990 = new GeographicCRS {Name = "GCS_ITRF_1990", Datum = DatumRegistry.Instance.ITRF1990, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF1991 = new GeographicCRS {Name = "GCS_ITRF_1991", Datum = DatumRegistry.Instance.ITRF1991, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF1992 = new GeographicCRS {Name = "GCS_ITRF_1992", Datum = DatumRegistry.Instance.ITRF1992, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF1993 = new GeographicCRS {Name = "GCS_ITRF_1993", Datum = DatumRegistry.Instance.ITRF1993, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF1994 = new GeographicCRS {Name = "GCS_ITRF_1994", Datum = DatumRegistry.Instance.ITRF1994, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF1996 = new GeographicCRS {Name = "GCS_ITRF_1996", Datum = DatumRegistry.Instance.ITRF1996, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF1997 = new GeographicCRS {Name = "GCS_ITRF_1997", Datum = DatumRegistry.Instance.ITRF1997, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF2000 = new GeographicCRS {Name = "GCS_ITRF_2000", Datum = DatumRegistry.Instance.ITRF2000, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF2005 = new GeographicCRS {Name = "GCS_ITRF_2005", Datum = DatumRegistry.Instance.ITRF2005, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ITRF2008 = new GeographicCRS {Name = "GCS_ITRF_2008", Datum = DatumRegistry.Instance.ITRF2008, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Indian1954 = new GeographicCRS {Name = "Indian 1954", Datum = DatumRegistry.Instance.Indian1954, ToWGS84 = new DatumShiftParameters (217, 823, 299, 0, 0, 0, 0)};
        public IGeographicCRS Indian1960 = new GeographicCRS {Name = "Indian 1960", Datum = DatumRegistry.Instance.Indian1960, ToWGS84 = new DatumShiftParameters (198, 881, 317, 0, 0, 0, 0)};
        public IGeographicCRS Indian1975 = new GeographicCRS {Name = "Indian 1975", Datum = DatumRegistry.Instance.Indian1975, ToWGS84 = new DatumShiftParameters (210, 814, 289, 0, 0, 0, 0)};
        public IGeographicCRS Indonesian = new GeographicCRS {Name = "GCS_Indonesian", Datum = DatumRegistry.Instance.Indonesian, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS International1924 = new GeographicCRS {Name = "GCS_International_1924", Datum = DatumRegistry.Instance.International1924, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Israel = new GeographicCRS {Name = "Israel", Datum = DatumRegistry.Instance.Israel, ToWGS84 = new DatumShiftParameters (-48, 55, 52, 0, 0, 0, 0)};
        public IGeographicCRS IwoJima1945 = new GeographicCRS {Name = "Iwo Jima 1945", Datum = DatumRegistry.Instance.IwoJima1945, ToWGS84 = new DatumShiftParameters (145, 75, -272, 0, 0, 0, 0)};
        public IGeographicCRS JAD2001 = new GeographicCRS {Name = "JAD2001", Datum = DatumRegistry.Instance.Jamaica2001, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS JAD69 = new GeographicCRS {Name = "JAD69", Datum = DatumRegistry.Instance.Jamaica1969, ToWGS84 = new DatumShiftParameters (70, 207, 389.5, 0, 0, 0, 0)};
        public IGeographicCRS JGD2000 = new GeographicCRS {Name = "JGD2000", Datum = DatumRegistry.Instance.JapaneseGeodeticGeodeticDatum2000, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS JGD2011 = new GeographicCRS {Name = "GCS_JGD_2011", Datum = DatumRegistry.Instance.JGD2011, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS JohnstonIsland1961 = new GeographicCRS {Name = "Johnston Island 1961", Datum = DatumRegistry.Instance.JohnstonIsland1961, ToWGS84 = new DatumShiftParameters (189, -79, -202, 0, 0, 0, 0)};
        public IGeographicCRS Jordan = new GeographicCRS {Name = "GCS_Jordan", Datum = DatumRegistry.Instance.Jordan, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Jouik1961 = new GeographicCRS {Name = "Jouik 1961", Datum = DatumRegistry.Instance.Jouik1961, ToWGS84 = new DatumShiftParameters (-80.01, 253.26, 291.19, 0, 0, 0, 0)};
        public IGeographicCRS KKJ = new GeographicCRS {Name = "KKJ", Datum = DatumRegistry.Instance.Kartastokoordinaattijarjestelma1966, ToWGS84 = new DatumShiftParameters (-96.062, -82.428, -121.753, -4.801, -0.345, 1.376, 1.496)};
        public IGeographicCRS KOC = new GeographicCRS {Name = "KOC", Datum = DatumRegistry.Instance.KuwaitOilCompany, ToWGS84 = new DatumShiftParameters (-294.7, -200.1, 525.5, 0, 0, 0, 0)};
        public IGeographicCRS KUDAMS = new GeographicCRS {Name = "KUDAMS", Datum = DatumRegistry.Instance.KuwaitUtility, ToWGS84 = new DatumShiftParameters (-20.8, 11.3, 2.4, 0, 0, 0, 0)};
        public IGeographicCRS Kalianpur1937 = new GeographicCRS {Name = "Kalianpur 1937", Datum = DatumRegistry.Instance.Kalianpur1937, ToWGS84 = new DatumShiftParameters (214, 804, 268, 0, 0, 0, 0)};
        public IGeographicCRS Kalianpur1962 = new GeographicCRS {Name = "Kalianpur 1962", Datum = DatumRegistry.Instance.Kalianpur1962, ToWGS84 = new DatumShiftParameters (283, 682, 231, 0, 0, 0, 0)};
        public IGeographicCRS Kalianpur1975 = new GeographicCRS {Name = "Kalianpur 1975", Datum = DatumRegistry.Instance.Kalianpur1975, ToWGS84 = new DatumShiftParameters (295, 736, 257, 0, 0, 0, 0)};
        public IGeographicCRS Kandawala = new GeographicCRS {Name = "Kandawala", Datum = DatumRegistry.Instance.Kandawala, ToWGS84 = new DatumShiftParameters (-97, 787, 86, 0, 0, 0, 0)};
        public IGeographicCRS Karbala1979 = new GeographicCRS {Name = "Karbala 1979", Datum = DatumRegistry.Instance.Karbala1979, ToWGS84 = new DatumShiftParameters (70.995, -335.916, 262.898, 0, 0, 0, 0)};
        public IGeographicCRS Kasai1953 = new GeographicCRS {Name = "Kasai 1953", Datum = DatumRegistry.Instance.Kasai1953, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Katanga1955 = new GeographicCRS {Name = "Katanga 1955", Datum = DatumRegistry.Instance.Katanga1955, ToWGS84 = new DatumShiftParameters (-103.746, -9.614, -255.95, 0, 0, 0, 0)};
        public IGeographicCRS Kertau1968 = new GeographicCRS {Name = "Kertau 1968", Datum = DatumRegistry.Instance.Kertau1968, ToWGS84 = new DatumShiftParameters (-11, 851, 5, 0, 0, 0, 0)};
        public IGeographicCRS KertauRSO = new GeographicCRS {Name = "Kertau (RSO)", Datum = DatumRegistry.Instance.KertauRSO, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Korea2000 = new GeographicCRS {Name = "Korea 2000", Datum = DatumRegistry.Instance.GeocentricGeodeticDatumofKorea, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Korean1985 = new GeographicCRS {Name = "Korean 1985", Datum = DatumRegistry.Instance.KoreanGeodeticDatum1985, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Korean1995 = new GeographicCRS {Name = "Korean 1995", Datum = DatumRegistry.Instance.KoreanGeodeticDatum1995, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Kousseri = new GeographicCRS {Name = "Kousseri", Datum = DatumRegistry.Instance.Kousseri, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Kusaie1951 = new GeographicCRS {Name = "Kusaie 1951", Datum = DatumRegistry.Instance.Kusaie1951, ToWGS84 = new DatumShiftParameters (647, 1777, -1124, 0, 0, 0, 0)};
        public IGeographicCRS LC51961 = new GeographicCRS {Name = "GCS_LC5_1961", Datum = DatumRegistry.Instance.LC51961, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS LGD2006 = new GeographicCRS {Name = "LGD2006", Datum = DatumRegistry.Instance.LibyanGeodeticGeodeticDatum2006, ToWGS84 = new DatumShiftParameters (-208.4058, -109.8777, -2.5764, 0, 0, 0, 0)};
        public IGeographicCRS LKS92 = new GeographicCRS {Name = "LKS92", Datum = DatumRegistry.Instance.Latvia1992, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS LKS94 = new GeographicCRS {Name = "LKS94", Datum = DatumRegistry.Instance.Lithuania1994ETRS89, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS LaCanoa = new GeographicCRS {Name = "La Canoa", Datum = DatumRegistry.Instance.LaCanoa, ToWGS84 = new DatumShiftParameters (-273.5, 110.6, -357.9, 0, 0, 0, 0)};
        public IGeographicCRS Lake = new GeographicCRS {Name = "Lake", Datum = DatumRegistry.Instance.Lake, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Lao1993 = new GeographicCRS {Name = "Lao 1993", Datum = DatumRegistry.Instance.Lao1993, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Lao1997 = new GeographicCRS {Name = "Lao 1997", Datum = DatumRegistry.Instance.LaoNationalGeodeticDatum1997, ToWGS84 = new DatumShiftParameters (44.585, -131.212, -39.544, 0, 0, 0, 0)};
        public IGeographicCRS LePouce1934 = new GeographicCRS {Name = "Le Pouce 1934", Datum = DatumRegistry.Instance.LePouce1934, ToWGS84 = new DatumShiftParameters (-770.1, 158.4, -498.2, 0, 0, 0, 0)};
        public IGeographicCRS Leigon = new GeographicCRS {Name = "Leigon", Datum = DatumRegistry.Instance.Leigon, ToWGS84 = new DatumShiftParameters (-130, 29, 364, 0, 0, 0, 0)};
        public IGeographicCRS Liberia1964 = new GeographicCRS {Name = "Liberia 1964", Datum = DatumRegistry.Instance.Liberia1964, ToWGS84 = new DatumShiftParameters (-90, 40, 88, 0, 0, 0, 0)};
        public IGeographicCRS Lisbon = new GeographicCRS {Name = "Lisbon", Datum = DatumRegistry.Instance.Lisbon1937, ToWGS84 = new DatumShiftParameters (-304.046, -60.576, 103.64, 0, 0, 0, 0)};
        public IGeographicCRS Lisbon1890 = new GeographicCRS {Name = "Lisbon 1890", Datum = DatumRegistry.Instance.Lisbon1890, ToWGS84 = new DatumShiftParameters (508.088, -191.042, 565.223, 0, 0, 0, 0)};
        public IGeographicCRS Lisbon1890Lisbon = new GeographicCRS {Name = "Lisbon 1890 (Lisbon)", Datum = DatumRegistry.Instance.Lisbon1890Lisbon, ToWGS84 = new DatumShiftParameters (508.088, -191.042, 565.223, 0, 0, 0, 0)};
        public IGeographicCRS LisbonLisbon = new GeographicCRS {Name = "Lisbon (Lisbon)", Datum = DatumRegistry.Instance.Lisbon1937Lisbon, ToWGS84 = new DatumShiftParameters (-304.046, -60.576, 103.64, 0, 0, 0, 0)};
        public IGeographicCRS Locodjo1965 = new GeographicCRS {Name = "Locodjo 1965", Datum = DatumRegistry.Instance.Locodjo1965, ToWGS84 = new DatumShiftParameters (-125, 53, 467, 0, 0, 0, 0)};
        public IGeographicCRS LomaQuintana = new GeographicCRS {Name = "Loma Quintana", Datum = DatumRegistry.Instance.LomaQuintana, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Lome = new GeographicCRS {Name = "Lome", Datum = DatumRegistry.Instance.Lome, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Luxembourg1930 = new GeographicCRS {Name = "Luxembourg 1930", Datum = DatumRegistry.Instance.Luxembourg1930, ToWGS84 = new DatumShiftParameters (-189.6806, 18.3463, -42.7695, 0.33746, 3.09264, -2.53861, 0.4598)};
        public IGeographicCRS Luzon1911 = new GeographicCRS {Name = "Luzon 1911", Datum = DatumRegistry.Instance.Luzon1911, ToWGS84 = new DatumShiftParameters (-133, -77, -51, 0, 0, 0, 0)};
        public IGeographicCRS MACARIOSOLIS = new GeographicCRS {Name = "MACARIO SOLIS", Datum = DatumRegistry.Instance.SistemaGeodesicoNacionaldePanamaMACARIOSOLIS, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS MAGNASIRGAS = new GeographicCRS {Name = "MAGNA-SIRGAS", Datum = DatumRegistry.Instance.MarcoGeocentricoNacionaldeReferencia, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS MARGEN = new GeographicCRS {Name = "MARGEN", Datum = DatumRegistry.Instance.MarcoGeodesicoNacional, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS MGI = new GeographicCRS {Name = "MGI", Datum = DatumRegistry.Instance.MilitarGeographischeInstitut, ToWGS84 = new DatumShiftParameters (577.326, 90.129, 463.919, 5.137, 1.474, 5.297, 2.4232)};
        public IGeographicCRS MGI1901 = new GeographicCRS {Name = "MGI 1901", Datum = DatumRegistry.Instance.MGI1901, ToWGS84 = new DatumShiftParameters (682, -203, 480, 0, 0, 0, 0)};
        public IGeographicCRS MGIFerro = new GeographicCRS {Name = "MGI (Ferro)", Datum = DatumRegistry.Instance.MilitarGeographischeInstitutFerro, ToWGS84 = new DatumShiftParameters (682, -203, 480, 0, 0, 0, 0)};
        public IGeographicCRS MOLDREF99 = new GeographicCRS {Name = "MOLDREF99", Datum = DatumRegistry.Instance.MOLDREF99, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS MONREF1997 = new GeographicCRS {Name = "GCS_MONREF_1997", Datum = DatumRegistry.Instance.ITRF2000, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS MOP78 = new GeographicCRS {Name = "MOP78", Datum = DatumRegistry.Instance.MOP78, ToWGS84 = new DatumShiftParameters (253, -132, -127, 0, 0, 0, 0)};
        public IGeographicCRS Madeira1936 = new GeographicCRS {Name = "GCS_Madeira_1936", Datum = DatumRegistry.Instance.Madeira1936, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Madrid1870Madrid = new GeographicCRS {Name = "Madrid 1870 (Madrid)", Datum = DatumRegistry.Instance.Madrid1870Madrid, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Madzansua = new GeographicCRS {Name = "Madzansua", Datum = DatumRegistry.Instance.Madzansua, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Mahe1971 = new GeographicCRS {Name = "Mahe 1971", Datum = DatumRegistry.Instance.Mahe1971, ToWGS84 = new DatumShiftParameters (41, -220, -134, 0, 0, 0, 0)};
        public IGeographicCRS Majuro = new GeographicCRS {Name = "GCS_Majuro", Datum = DatumRegistry.Instance.Majuro, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Makassar = new GeographicCRS {Name = "Makassar", Datum = DatumRegistry.Instance.Makassar, ToWGS84 = new DatumShiftParameters (-587.8, 519.75, 145.76, 0, 0, 0, 0)};
        public IGeographicCRS MakassarJakarta = new GeographicCRS {Name = "Makassar (Jakarta)", Datum = DatumRegistry.Instance.MakassarJakarta, ToWGS84 = new DatumShiftParameters (-587.8, 519.75, 145.76, 0, 0, 0, 0)};
        public IGeographicCRS Malongo1987 = new GeographicCRS {Name = "Malongo 1987", Datum = DatumRegistry.Instance.Malongo1987, ToWGS84 = new DatumShiftParameters (-254.1, -5.36, -100.29, 0, 0, 0, 0)};
        public IGeographicCRS Manoca = new GeographicCRS {Name = "GCS_Manoca", Datum = DatumRegistry.Instance.Manoca, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Manoca1962 = new GeographicCRS {Name = "Manoca 1962", Datum = DatumRegistry.Instance.Manoca1962, ToWGS84 = new DatumShiftParameters (-70.9, -151.8, -41.4, 0, 0, 0, 0)};
        public IGeographicCRS MarcusIsland1952 = new GeographicCRS {Name = "Marcus Island 1952", Datum = DatumRegistry.Instance.MarcusIsland1952, ToWGS84 = new DatumShiftParameters (124, -234, -25, 0, 0, 0, 0)};
        public IGeographicCRS MarshallIslands1960 = new GeographicCRS {Name = "Marshall Islands 1960", Datum = DatumRegistry.Instance.MarshallIslands1960, ToWGS84 = new DatumShiftParameters (102, 52, -38, 0, 0, 0, 0)};
        public IGeographicCRS Martinique1938 = new GeographicCRS {Name = "Martinique 1938", Datum = DatumRegistry.Instance.Martinique1938, ToWGS84 = new DatumShiftParameters (186, 482, 151, 0, 0, 0, 0)};
        public IGeographicCRS Massawa = new GeographicCRS {Name = "Massawa", Datum = DatumRegistry.Instance.Massawa, ToWGS84 = new DatumShiftParameters (639, 405, 60, 0, 0, 0, 0)};
        public IGeographicCRS Maupiti83 = new GeographicCRS {Name = "Maupiti 83", Datum = DatumRegistry.Instance.Maupiti83, ToWGS84 = new DatumShiftParameters (217.037, 86.959, 23.956, 0, 0, 0, 0)};
        public IGeographicCRS Mauritania1999 = new GeographicCRS {Name = "Mauritania 1999", Datum = DatumRegistry.Instance.Mauritania1999, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Merchich = new GeographicCRS {Name = "Merchich", Datum = DatumRegistry.Instance.Merchich, ToWGS84 = new DatumShiftParameters (31, 146, 47, 0, 0, 0, 0)};
        public IGeographicCRS MerchichDegree = new GeographicCRS {Name = "GCS_Merchich_Degree", Datum = DatumRegistry.Instance.Merchich, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS MexicanDatumof1993 = new GeographicCRS {Name = "Mexican Datum of 1993", Datum = DatumRegistry.Instance.MexicanGeodeticDatumof1993, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Mhast1951 = new GeographicCRS {Name = "Mhast 1951", Datum = DatumRegistry.Instance.MissaoHidrograficoAngolaySaoTome1951, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Mhastoffshore = new GeographicCRS {Name = "Mhast (offshore)", Datum = DatumRegistry.Instance.Mhastoffshore, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Mhastonshore = new GeographicCRS {Name = "Mhast (onshore)", Datum = DatumRegistry.Instance.Mhastonshore, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Midway1961 = new GeographicCRS {Name = "Midway 1961", Datum = DatumRegistry.Instance.Midway1961, ToWGS84 = new DatumShiftParameters (403, -81, 277, 0, 0, 0, 0)};
        public IGeographicCRS Minna = new GeographicCRS {Name = "Minna", Datum = DatumRegistry.Instance.Minna, ToWGS84 = new DatumShiftParameters (-92, -93, 122, 0, 0, 0, 0)};
        public IGeographicCRS MonteMario = new GeographicCRS {Name = "Monte Mario", Datum = DatumRegistry.Instance.MonteMario, ToWGS84 = new DatumShiftParameters (-104.1, -49.1, -9.9, 0.971, -2.917, 0.714, -11.68)};
        public IGeographicCRS MonteMarioRome = new GeographicCRS {Name = "Monte Mario (Rome)", Datum = DatumRegistry.Instance.MonteMarioRome, ToWGS84 = new DatumShiftParameters (-104.1, -49.1, -9.9, 0.971, -2.917, 0.714, -11.68)};
        public IGeographicCRS Montserrat1958 = new GeographicCRS {Name = "Montserrat 1958", Datum = DatumRegistry.Instance.Montserrat1958, ToWGS84 = new DatumShiftParameters (174, 359, 365, 0, 0, 0, 0)};
        public IGeographicCRS Moorea87 = new GeographicCRS {Name = "Moorea 87", Datum = DatumRegistry.Instance.Moorea87, ToWGS84 = new DatumShiftParameters (215.525, 149.593, 176.229, 3.2624, 1.692, 1.1571, 10.4773)};
        public IGeographicCRS MountDillon = new GeographicCRS {Name = "Mount Dillon", Datum = DatumRegistry.Instance.MountDillon, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Moznet = new GeographicCRS {Name = "Moznet", Datum = DatumRegistry.Instance.MoznetITRF94, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Mporaloko = new GeographicCRS {Name = "M'poraloko", Datum = DatumRegistry.Instance.Mporaloko, ToWGS84 = new DatumShiftParameters (-74, -130, 42, 0, 0, 0, 0)};
        public IGeographicCRS NAD19832011 = new GeographicCRS {Name = "GCS_NAD_1983_2011", Datum = DatumRegistry.Instance.NAD19832011, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983CORS96 = new GeographicCRS {Name = "GCS_NAD_1983_CORS96", Datum = DatumRegistry.Instance.NAD1983CORS96, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNAnoka = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Anoka", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNAnoka, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNBecker = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Becker", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNBecker, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNBeltramiNorth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Beltrami_North", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNBeltramiNorth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNBeltramiSouth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Beltrami_South", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNBeltramiSouth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNBenton = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Benton", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNBenton, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNBigStone = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Big_Stone", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNBigStone, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNBlueEarth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Blue_Earth", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNBlueEarth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNBrown = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Brown", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNBrown, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNCarlton = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Carlton", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNCarlton, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNCarver = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Carver", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNCarver, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNCassNorth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Cass_North", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNCassNorth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNCassSouth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Cass_South", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNCassSouth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNChippewa = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Chippewa", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNChippewa, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNChisago = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Chisago", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNChisago, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNCookNorth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Cook_North", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNCookNorth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNCookSouth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Cook_South", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNCookSouth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNCottonwood = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Cottonwood", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNCottonwood, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNCrowWing = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Crow_Wing", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNCrowWing, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNDakota = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Dakota", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNDakota, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNDodge = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Dodge", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNDodge, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNDouglas = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Douglas", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNDouglas, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNFaribault = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Faribault", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNFaribault, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNFillmore = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Fillmore", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNFillmore, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNFreeborn = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Freeborn", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNFreeborn, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNGoodhue = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Goodhue", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNGoodhue, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNGrant = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Grant", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNGrant, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNHennepin = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Hennepin", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNHennepin, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNHouston = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Houston", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNHouston, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNIsanti = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Isanti", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNIsanti, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNItascaNorth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Itasca_North", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNItascaNorth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNItascaSouth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Itasca_South", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNItascaSouth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNJackson = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Jackson", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNJackson, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNKanabec = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Kanabec", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNKanabec, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNKandiyohi = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Kandiyohi", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNKandiyohi, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNKittson = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Kittson", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNKittson, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNKoochiching = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Koochiching", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNKoochiching, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNLacQuiParle = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Lac_Qui_Parle", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNLacQuiParle, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNLakeoftheWoodsNorth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Lake_of_the_Woods_North", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNLakeoftheWoodsNorth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNLakeoftheWoodsSouth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Lake_of_the_Woods_South", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNLakeoftheWoodsSouth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNLeSueur = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Le_Sueur", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNLeSueur, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNLincoln = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Lincoln", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNLincoln, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNLyon = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Lyon", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNLyon, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNMahnomen = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Mahnomen", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNMahnomen, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNMarshall = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Marshall", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNMarshall, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNMartin = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Martin", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNMartin, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNMcLeod = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_McLeod", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNMcLeod, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNMeeker = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Meeker", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNMeeker, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNMorrison = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Morrison", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNMorrison, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNMower = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Mower", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNMower, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNMurray = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Murray", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNMurray, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNNicollet = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Nicollet", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNNicollet, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNNobles = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Nobles", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNNobles, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNNorman = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Norman", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNNorman, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNOlmsted = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Olmsted", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNOlmsted, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNOttertail = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Ottertail", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNOttertail, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNPennington = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Pennington", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNPennington, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNPine = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Pine", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNPine, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNPipestone = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Pipestone", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNPipestone, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNPolk = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Polk", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNPolk, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNPope = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Pope", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNPope, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNRamsey = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Ramsey", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNRamsey, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNRedLake = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Red_Lake", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNRedLake, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNRedwood = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Redwood", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNRedwood, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNRenville = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Renville", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNRenville, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNRice = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Rice", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNRice, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNRock = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Rock", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNRock, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNRoseau = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Roseau", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNRoseau, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNScott = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Scott", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNScott, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNSherburne = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Sherburne", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNSherburne, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNSibley = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Sibley", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNSibley, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNStLouis = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_St_Louis", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNStLouis, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNStLouisCentral = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_St_Louis_Central", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNStLouisCentral, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNStLouisNorth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_St_Louis_North", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNStLouisNorth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNStLouisSouth = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_St_Louis_South", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNStLouisSouth, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNStearns = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Stearns", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNStearns, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNSteele = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Steele", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNSteele, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNStevens = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Stevens", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNStevens, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNSwift = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Swift", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNSwift, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNTodd = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Todd", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNTodd, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNTraverse = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Traverse", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNTraverse, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNWabasha = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Wabasha", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNWabasha, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNWadena = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Wadena", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNWadena, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNWaseca = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Waseca", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNWaseca, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNWatonwan = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Watonwan", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNWatonwan, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNWinona = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Winona", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNWinona, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNWright = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Wright", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNWright, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983HARNAdjMNYellowMedicine = new GeographicCRS {Name = "GCS_NAD_1983_HARN_Adj_MN_Yellow_Medicine", Datum = DatumRegistry.Instance.NAD1983HARNAdjMNYellowMedicine, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983MA11 = new GeographicCRS {Name = "GCS_NAD_1983_MA11", Datum = DatumRegistry.Instance.NAD1983MA11, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983MARP00 = new GeographicCRS {Name = "GCS_NAD_1983_MARP00", Datum = DatumRegistry.Instance.NAD1983MARP00, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983PA11 = new GeographicCRS {Name = "GCS_NAD_1983_PA11", Datum = DatumRegistry.Instance.NAD1983PA11, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD1983PACP00 = new GeographicCRS {Name = "GCS_NAD_1983_PACP00", Datum = DatumRegistry.Instance.NAD1983PACP00, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD27 = new GeographicCRS {Name = "NAD27", Datum = DatumRegistry.Instance.NorthAmericanGeodeticDatum1927, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD2776 = new GeographicCRS {Name = "NAD27(76)", Datum = DatumRegistry.Instance.NorthAmericanGeodeticDatum19271976, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD27CGQ77 = new GeographicCRS {Name = "NAD27(CGQ77)", Datum = DatumRegistry.Instance.NorthAmericanGeodeticDatum1927CGQ77, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD83 = new GeographicCRS {Name = "NAD83", Datum = DatumRegistry.Instance.NorthAmericanGeodeticDatum1983, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD83CSRS = new GeographicCRS {Name = "NAD83(CSRS)", Datum = DatumRegistry.Instance.NAD83CanadianSpatialReferenceSystem, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD83HARN = new GeographicCRS {Name = "NAD83(HARN)", Datum = DatumRegistry.Instance.NAD83HighAccuracyReferenceNetwork, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NAD83NSRS2007 = new GeographicCRS {Name = "NAD83(NSRS2007)", Datum = DatumRegistry.Instance.NAD83NationalSpatialReferenceSystem2007, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NEA74Noumea = new GeographicCRS {Name = "NEA74 Noumea", Datum = DatumRegistry.Instance.NEA74Noumea, ToWGS84 = new DatumShiftParameters (-10.18, -350.43, 291.37, 0, 0, 0, 0)};
        public IGeographicCRS NGN = new GeographicCRS {Name = "NGN", Datum = DatumRegistry.Instance.NationalGeodeticNetwork, ToWGS84 = new DatumShiftParameters (-3.2, -5.7, 2.8, 0, 0, 0, 0)};
        public IGeographicCRS NGO1948 = new GeographicCRS {Name = "NGO 1948", Datum = DatumRegistry.Instance.NGO1948, ToWGS84 = new DatumShiftParameters (278.3, 93, 474.5, 7.889, 0.05, -6.61, 6.21)};
        public IGeographicCRS NGO1948Oslo = new GeographicCRS {Name = "NGO 1948 (Oslo)", Datum = DatumRegistry.Instance.NGO1948Oslo, ToWGS84 = new DatumShiftParameters (278.3, 93, 474.5, 7.889, 0.05, -6.61, 6.21)};
        public IGeographicCRS NSWC9Z2 = new GeographicCRS {Name = "NSWC 9Z-2", Datum = DatumRegistry.Instance.NSWC9Z2, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NTF = new GeographicCRS {Name = "NTF", Datum = DatumRegistry.Instance.NouvelleTriangulationFrancaise, ToWGS84 = new DatumShiftParameters (-168, -60, 320, 0, 0, 0, 0)};
        public IGeographicCRS NTFParis = new GeographicCRS {Name = "NTF (Paris)", Datum = DatumRegistry.Instance.NouvelleTriangulationFrancaiseParis, ToWGS84 = new DatumShiftParameters (-168, -60, 320, 0, 0, 0, 0)};
        public IGeographicCRS NWL9D = new GeographicCRS {Name = "GCS_NWL_9D", Datum = DatumRegistry.Instance.NWL9D, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NZGD2000 = new GeographicCRS {Name = "NZGD2000", Datum = DatumRegistry.Instance.NewZealandGeodeticGeodeticDatum2000, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NZGD49 = new GeographicCRS {Name = "NZGD49", Datum = DatumRegistry.Instance.NewZealandGeodeticGeodeticDatum1949, ToWGS84 = new DatumShiftParameters (59.47, -5.04, 187.44, -0.47, 0.1, -1.024, -4.5993)};
        public IGeographicCRS Nahrwan1934 = new GeographicCRS {Name = "Nahrwan 1934", Datum = DatumRegistry.Instance.Nahrwan1934, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Nahrwan1967 = new GeographicCRS {Name = "Nahrwan 1967", Datum = DatumRegistry.Instance.Nahrwan1967, ToWGS84 = new DatumShiftParameters (-242.2, -144.9, 370.3, 0, 0, 0, 0)};
        public IGeographicCRS NakhleGhanem = new GeographicCRS {Name = "Nakhl-e Ghanem", Datum = DatumRegistry.Instance.NakhleGhanem, ToWGS84 = new DatumShiftParameters (0, -0.15, 0.68, 0, 0, 0, 0)};
        public IGeographicCRS Naparima1955 = new GeographicCRS {Name = "Naparima 1955", Datum = DatumRegistry.Instance.Naparima1955, ToWGS84 = new DatumShiftParameters (-0.465, 372.095, 171.736, 0, 0, 0, 0)};
        public IGeographicCRS Naparima1972 = new GeographicCRS {Name = "Naparima 1972", Datum = DatumRegistry.Instance.Naparima1972, ToWGS84 = new DatumShiftParameters (-10, 375, 165, 0, 0, 0, 0)};
        public IGeographicCRS NepalNagarkot = new GeographicCRS {Name = "GCS_Nepal_Nagarkot", Datum = DatumRegistry.Instance.NepalNagarkot, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NewBeijing = new GeographicCRS {Name = "New Beijing", Datum = DatumRegistry.Instance.NewBeijing, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NordSahara1959 = new GeographicCRS {Name = "Nord Sahara 1959", Datum = DatumRegistry.Instance.NordSahara1959, ToWGS84 = new DatumShiftParameters (-209.3622, -87.8162, 404.6198, 0.0046, 3.4784, 0.5805, -1.4547)};
        public IGeographicCRS NordSahara1959Paris = new GeographicCRS {Name = "GCS_Nord_Sahara_1959_Paris", Datum = DatumRegistry.Instance.NordSahara1959, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS NorddeGuerreParis = new GeographicCRS {Name = "GCS_Nord_de_Guerre_Paris", Datum = DatumRegistry.Instance.NorddeGuerre, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Nouakchott1965 = new GeographicCRS {Name = "Nouakchott 1965", Datum = DatumRegistry.Instance.Nouakchott1965, ToWGS84 = new DatumShiftParameters (124.5, -63.5, -281, 0, 0, 0, 0)};
        public IGeographicCRS OSGB1936 = new GeographicCRS {Name = "OSGB 1936", Datum = DatumRegistry.Instance.OSGB1936, ToWGS84 = new DatumShiftParameters (446.448, -125.157, 542.06, 0.15, 0.247, 0.842, -20.489)};
        public IGeographicCRS OSGB70 = new GeographicCRS {Name = "OSGB70", Datum = DatumRegistry.Instance.OSGB1970SN, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS OSNI1952 = new GeographicCRS {Name = "OSNI 1952", Datum = DatumRegistry.Instance.OSNI1952, ToWGS84 = new DatumShiftParameters (482.5, -130.6, 564.6, -1.042, -0.214, -0.631, 8.15)};
        public IGeographicCRS OSSN80 = new GeographicCRS {Name = "OS(SN)80", Datum = DatumRegistry.Instance.OSSN1980, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS OSU86F = new GeographicCRS {Name = "GCS_OSU_86F", Datum = DatumRegistry.Instance.OSU86F, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS OSU91A = new GeographicCRS {Name = "GCS_OSU_91A", Datum = DatumRegistry.Instance.OSU91A, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Observatario = new GeographicCRS {Name = "Observatario", Datum = DatumRegistry.Instance.Observatario, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ObservatorioMeteorologico1939 = new GeographicCRS {Name = "GCS_Observatorio_Meteorologico_1939", Datum = DatumRegistry.Instance.ObservatorioMeteorologico1939, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ObservatorioMeteorologico1965 = new GeographicCRS {Name = "GCS_Observatorio_Meteorologico_1965", Datum = DatumRegistry.Instance.ObservatorioMeteorologico1965, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Ocotepeque1935 = new GeographicCRS {Name = "Ocotepeque 1935", Datum = DatumRegistry.Instance.Ocotepeque1935, ToWGS84 = new DatumShiftParameters (213.11, 9.37, -74.95, 0, 0, 0, 0)};
        public IGeographicCRS OldHawaiian = new GeographicCRS {Name = "Old Hawaiian", Datum = DatumRegistry.Instance.OldHawaiian, ToWGS84 = new DatumShiftParameters (61, -285, -181, 0, 0, 0, 0)};
        public IGeographicCRS OldHawaiianIntl1924 = new GeographicCRS {Name = "GCS_Old_Hawaiian_Intl_1924", Datum = DatumRegistry.Instance.OldHawaiianIntl1924, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Oman = new GeographicCRS {Name = "GCS_Oman", Datum = DatumRegistry.Instance.Oman, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS PD83 = new GeographicCRS {Name = "GCS_PD/83", Datum = DatumRegistry.Instance.Potsdam1983, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS PNG94 = new GeographicCRS {Name = "PNG94", Datum = DatumRegistry.Instance.PapuaNewGuineaGeodeticGeodeticDatum1994, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS POSGAR = new GeographicCRS {Name = "GCS_POSGAR", Datum = DatumRegistry.Instance.POSGAR, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS POSGAR2007 = new GeographicCRS {Name = "POSGAR 2007", Datum = DatumRegistry.Instance.PosicionesGeodesicasArgentinas2007, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS POSGAR94 = new GeographicCRS {Name = "POSGAR 94", Datum = DatumRegistry.Instance.PosicionesGeodesicasArgentinas1994, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS POSGAR98 = new GeographicCRS {Name = "POSGAR 98", Datum = DatumRegistry.Instance.PosicionesGeodesicasArgentinas1998, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS PRS92 = new GeographicCRS {Name = "PRS92", Datum = DatumRegistry.Instance.PhilippineReferenceSystem1992, ToWGS84 = new DatumShiftParameters (-127.62, -67.24, -47.04, 3.068, -4.903, -1.578, -1.06)};
        public IGeographicCRS PSAD56 = new GeographicCRS {Name = "PSAD56", Datum = DatumRegistry.Instance.ProvisionalSouthAmericanGeodeticDatum1956, ToWGS84 = new DatumShiftParameters (-288, 175, -376, 0, 0, 0, 0)};
        public IGeographicCRS PSD93 = new GeographicCRS {Name = "PSD93", Datum = DatumRegistry.Instance.PDOSurveyGeodeticDatum1993, ToWGS84 = new DatumShiftParameters (-180.624, -225.516, 173.919, -0.81, -1.898, 8.336, 16.71006)};
        public IGeographicCRS PTRA08 = new GeographicCRS {Name = "PTRA08", Datum = DatumRegistry.Instance.AutonomousRegionsofPortugal2008, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS PZ90 = new GeographicCRS {Name = "PZ-90", Datum = DatumRegistry.Instance.ParametropZemp1990, ToWGS84 = new DatumShiftParameters (0, 0, 1.5, 0, 0, -0.076, 0)};
        public IGeographicCRS Padang = new GeographicCRS {Name = "Padang", Datum = DatumRegistry.Instance.Padang1884, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS PadangJakarta = new GeographicCRS {Name = "Padang (Jakarta)", Datum = DatumRegistry.Instance.Padang1884Jakarta, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Palestine1923 = new GeographicCRS {Name = "Palestine 1923", Datum = DatumRegistry.Instance.Palestine1923, ToWGS84 = new DatumShiftParameters (-275.7224, 94.7824, 340.8944, -8.001, -4.42, -11.821, 1)};
        public IGeographicCRS PampadelCastillo = new GeographicCRS {Name = "Pampa del Castillo", Datum = DatumRegistry.Instance.PampadelCastillo, ToWGS84 = new DatumShiftParameters (27.5, 14, 186.4, 0, 0, 0, 0)};
        public IGeographicCRS PanamaColon1911 = new GeographicCRS {Name = "Panama-Colon 1911", Datum = DatumRegistry.Instance.PanamaColon1911, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Perroud1950 = new GeographicCRS {Name = "Perroud 1950", Datum = DatumRegistry.Instance.PointeGeologiePerroud1950, ToWGS84 = new DatumShiftParameters (325, 154, 172, 0, 0, 0, 0)};
        public IGeographicCRS Peru96 = new GeographicCRS {Name = "Peru96", Datum = DatumRegistry.Instance.Peru96, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Petrels1972 = new GeographicCRS {Name = "Petrels 1972", Datum = DatumRegistry.Instance.Petrels1972, ToWGS84 = new DatumShiftParameters (365, 194, 166, 0, 0, 0, 0)};
        public IGeographicCRS PhoenixIslands1966 = new GeographicCRS {Name = "Phoenix Islands 1966", Datum = DatumRegistry.Instance.PhoenixIslands1966, ToWGS84 = new DatumShiftParameters (298, -304, -375, 0, 0, 0, 0)};
        public IGeographicCRS PicodelasNieves1984 = new GeographicCRS {Name = "Pico de las Nieves 1984", Datum = DatumRegistry.Instance.PicodelasNieves1984, ToWGS84 = new DatumShiftParameters (-307, -92, 127, 0, 0, 0, 0)};
        public IGeographicCRS Pitcairn1967 = new GeographicCRS {Name = "Pitcairn 1967", Datum = DatumRegistry.Instance.Pitcairn1967, ToWGS84 = new DatumShiftParameters (185, 165, 42, 0, 0, 0, 0)};
        public IGeographicCRS Pitcairn2006 = new GeographicCRS {Name = "Pitcairn 2006", Datum = DatumRegistry.Instance.Pitcairn2006, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Plessis1817 = new GeographicCRS {Name = "GCS_Plessis_1817", Datum = DatumRegistry.Instance.Plessis1817, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Pohnpei = new GeographicCRS {Name = "GCS_Pohnpei", Datum = DatumRegistry.Instance.Pohnpei, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Point58 = new GeographicCRS {Name = "Point 58", Datum = DatumRegistry.Instance.Point58, ToWGS84 = new DatumShiftParameters (-106, -129, 165, 0, 0, 0, 0)};
        public IGeographicCRS PointeNoire = new GeographicCRS {Name = "Pointe Noire", Datum = DatumRegistry.Instance.Congo1960PointeNoire, ToWGS84 = new DatumShiftParameters (-148, 51, -291, 0, 0, 0, 0)};
        public IGeographicCRS PortoSanto = new GeographicCRS {Name = "Porto Santo", Datum = DatumRegistry.Instance.PortoSanto1936, ToWGS84 = new DatumShiftParameters (-499, -249, 314, 0, 0, 0, 0)};
        public IGeographicCRS PortoSanto1995 = new GeographicCRS {Name = "GCS_Porto_Santo_1995", Datum = DatumRegistry.Instance.PortoSanto1995, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Principe = new GeographicCRS {Name = "Principe", Datum = DatumRegistry.Instance.Principe, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS PuertoRico = new GeographicCRS {Name = "Puerto Rico", Datum = DatumRegistry.Instance.PuertoRico, ToWGS84 = new DatumShiftParameters (11, 72, -101, 0, 0, 0, 0)};
        public IGeographicCRS Pulkovo1942 = new GeographicCRS {Name = "Pulkovo 1942", Datum = DatumRegistry.Instance.Pulkovo1942, ToWGS84 = new DatumShiftParameters (23.92, -141.27, -80.9, 0, -0.35, -0.82, -0.12)};
        public IGeographicCRS Pulkovo194258 = new GeographicCRS {Name = "Pulkovo 1942(58)", Datum = DatumRegistry.Instance.Pulkovo194258, ToWGS84 = new DatumShiftParameters (33.4, -146.6, -76.3, -0.359, -0.053, 0.844, -0.84)};
        public IGeographicCRS Pulkovo194283 = new GeographicCRS {Name = "Pulkovo 1942(83)", Datum = DatumRegistry.Instance.Pulkovo194283, ToWGS84 = new DatumShiftParameters (26, -121, -78, 0, 0, 0, 0)};
        public IGeographicCRS Pulkovo1995 = new GeographicCRS {Name = "Pulkovo 1995", Datum = DatumRegistry.Instance.Pulkovo1995, ToWGS84 = new DatumShiftParameters (24.47, -130.89, -81.56, 0, 0, -0.13, -0.22)};
        public IGeographicCRS QND95 = new GeographicCRS {Name = "QND95", Datum = DatumRegistry.Instance.QatarNationalGeodeticDatum1995, ToWGS84 = new DatumShiftParameters (-119.4248, -303.65872, -11.00061, 1.164298, 0.174458, 1.096259, 3.657065)};
        public IGeographicCRS Qatar1948 = new GeographicCRS {Name = "Qatar 1948", Datum = DatumRegistry.Instance.Qatar1948, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Qatar1974 = new GeographicCRS {Name = "Qatar 1974", Datum = DatumRegistry.Instance.Qatar1974, ToWGS84 = new DatumShiftParameters (-128.16, -282.42, 21.93, 0, 0, 0, 0)};
        public IGeographicCRS Qornoq1927 = new GeographicCRS {Name = "Qornoq 1927", Datum = DatumRegistry.Instance.Qornoq1927, ToWGS84 = new DatumShiftParameters (164, 138, -189, 0, 0, 0, 0)};
        public IGeographicCRS RD83 = new GeographicCRS {Name = "GCS_RD/83", Datum = DatumRegistry.Instance.Rauenberg1983, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS REGCAN95 = new GeographicCRS {Name = "REGCAN95", Datum = DatumRegistry.Instance.RedGeodesicadeCanarias1995, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS REGVEN = new GeographicCRS {Name = "REGVEN", Datum = DatumRegistry.Instance.RedGeodesicaVenezolana, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RGAF09 = new GeographicCRS {Name = "RGAF09", Datum = DatumRegistry.Instance.ReseauGeodesiquedesAntillesFrancaises2009, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RGF93 = new GeographicCRS {Name = "RGF93", Datum = DatumRegistry.Instance.ReseauGeodesiqueFrancais1993, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RGFG95 = new GeographicCRS {Name = "RGFG95", Datum = DatumRegistry.Instance.ReseauGeodesiqueFrancaisGuyane1995, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RGM04 = new GeographicCRS {Name = "RGM04", Datum = DatumRegistry.Instance.ReseauGeodesiquedeMayotte2004, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RGNC1991 = new GeographicCRS {Name = "GCS_RGNC_1991", Datum = DatumRegistry.Instance.RGNC1991, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RGNC9193 = new GeographicCRS {Name = "RGNC91-93", Datum = DatumRegistry.Instance.ReseauGeodesiquedeNouvelleCaledonie9193, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RGPF = new GeographicCRS {Name = "RGPF", Datum = DatumRegistry.Instance.ReseauGeodesiquedelaPolynesieFrancaise, ToWGS84 = new DatumShiftParameters (0.072, -0.507, -0.245, 0.0183, -0.0003, 0.007, -0.0093)};
        public IGeographicCRS RGR92 = new GeographicCRS {Name = "RGR92", Datum = DatumRegistry.Instance.ReseauGeodesiquedelaReunion1992, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RGRDC2005 = new GeographicCRS {Name = "RGRDC 2005", Datum = DatumRegistry.Instance.ReseauGeodesiquedelaRDC2005, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RGSPM06 = new GeographicCRS {Name = "RGSPM06", Datum = DatumRegistry.Instance.ReseauGeodesiquedeSaintPierreetMiquelon2006, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RRAF1991 = new GeographicCRS {Name = "RRAF 1991", Datum = DatumRegistry.Instance.ReseaudeReferencedesAntillesFrancaises1991, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RSRGD2000 = new GeographicCRS {Name = "RSRGD2000", Datum = DatumRegistry.Instance.RossSeaRegionGeodeticGeodeticDatum2000, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RT38 = new GeographicCRS {Name = "RT38", Datum = DatumRegistry.Instance.Stockholm1938, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RT38Stockholm = new GeographicCRS {Name = "RT38 (Stockholm)", Datum = DatumRegistry.Instance.Stockholm1938Stockholm, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS RT90 = new GeographicCRS {Name = "RT90", Datum = DatumRegistry.Instance.Riketskoordinatsystem1990, ToWGS84 = new DatumShiftParameters (414.1, 41.3, 603.1, 0.855, -2.141, 7.023, 0)};
        public IGeographicCRS Rassadiran = new GeographicCRS {Name = "Rassadiran", Datum = DatumRegistry.Instance.Rassadiran, ToWGS84 = new DatumShiftParameters (-133.63, -157.5, -158.62, 0, 0, 0, 0)};
        public IGeographicCRS Reunion1947 = new GeographicCRS {Name = "Reunion 1947", Datum = DatumRegistry.Instance.Reunion1947, ToWGS84 = new DatumShiftParameters (94, -948, -1262, 0, 0, 0, 0)};
        public IGeographicCRS Reykjavik1900 = new GeographicCRS {Name = "Reykjavik 1900", Datum = DatumRegistry.Instance.Reykjavik1900, ToWGS84 = new DatumShiftParameters (-28, 199, 5, 0, 0, 0, 0)};
        public IGeographicCRS Roma1940 = new GeographicCRS {Name = "GCS_Roma_1940", Datum = DatumRegistry.Instance.Roma1940, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SAD69 = new GeographicCRS {Name = "SAD69", Datum = DatumRegistry.Instance.SouthAmericanGeodeticDatum1969, ToWGS84 = new DatumShiftParameters (-57, 1, -41, 0, 0, 0, 0)};
        public IGeographicCRS SAD6996 = new GeographicCRS {Name = "SAD69(96)", Datum = DatumRegistry.Instance.SouthAmericanGeodeticDatum196996, ToWGS84 = new DatumShiftParameters (-67.35, 3.88, -38.22, 0, 0, 0, 0)};
        public IGeographicCRS SIGD61 = new GeographicCRS {Name = "SIGD61", Datum = DatumRegistry.Instance.SisterIslandsGeodeticGeodeticDatum1961, ToWGS84 = new DatumShiftParameters (8.853, -52.644, 180.304, 0.393, 2.323, -2.96, -24.081)};
        public IGeographicCRS SIRGAS1995 = new GeographicCRS {Name = "SIRGAS 1995", Datum = DatumRegistry.Instance.SistemadeReferenciaGeocentricoparaAmericadelSur1995, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SIRGAS2000 = new GeographicCRS {Name = "SIRGAS 2000", Datum = DatumRegistry.Instance.SistemadeReferenciaGeocentricoparalasAmericaS2000, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SIRGASChile = new GeographicCRS {Name = "SIRGAS-Chile", Datum = DatumRegistry.Instance.SIRGASChile, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SIRGASES20078 = new GeographicCRS {Name = "SIRGAS_ES2007.8", Datum = DatumRegistry.Instance.SIRGASES20078, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SIRGASROU98 = new GeographicCRS {Name = "SIRGAS-ROU98", Datum = DatumRegistry.Instance.SIRGASROU98, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SJTSK = new GeographicCRS {Name = "S-JTSK", Datum = DatumRegistry.Instance.SystemJednotneTrigonometrickeSiteKatastralni, ToWGS84 = new DatumShiftParameters (589, 76, 480, 0, 0, 0, 0)};
        public IGeographicCRS SJTSK05 = new GeographicCRS {Name = "S-JTSK/05", Datum = DatumRegistry.Instance.SystemJednotneTrigonometrickeSiteKatastralni05, ToWGS84 = new DatumShiftParameters (572.213, 85.334, 461.94, -4.9732, -1.529, -5.2484, 3.5378)};
        public IGeographicCRS SJTSK05Ferro = new GeographicCRS {Name = "S-JTSK/05 (Ferro)", Datum = DatumRegistry.Instance.SystemJednotneTrigonometrickeSiteKatastralni05Ferro, ToWGS84 = new DatumShiftParameters (572.213, 85.334, 461.94, -4.9732, -1.529, -5.2484, 3.5378)};
        public IGeographicCRS SJTSKFerro = new GeographicCRS {Name = "S-JTSK (Ferro)", Datum = DatumRegistry.Instance.SystemJednotneTrigonometrickeSiteKatastralniFerro, ToWGS84 = new DatumShiftParameters (589, 76, 480, 0, 0, 0, 0)};
        public IGeographicCRS SLD99 = new GeographicCRS {Name = "SLD99", Datum = DatumRegistry.Instance.SriLankaGeodeticDatum1999, ToWGS84 = new DatumShiftParameters (-0.293, 766.95, 87.713, -0.195704, -1.695068, -3.473016, -0.039338)};
        public IGeographicCRS SREF98 = new GeographicCRS {Name = "SREF98", Datum = DatumRegistry.Instance.SerbianReferenceNetwork1998, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS ST71Belep = new GeographicCRS {Name = "ST71 Belep", Datum = DatumRegistry.Instance.ST71Belep, ToWGS84 = new DatumShiftParameters (-480.26, -438.32, -643.429, 16.3119, 20.1721, -4.0349, -111.7002)};
        public IGeographicCRS ST84IledesPins = new GeographicCRS {Name = "ST84 Ile des Pins", Datum = DatumRegistry.Instance.ST84IledesPins, ToWGS84 = new DatumShiftParameters (-13, -348, 292, 0, 0, 0, 0)};
        public IGeographicCRS ST87Ouvea = new GeographicCRS {Name = "ST87 Ouvea", Datum = DatumRegistry.Instance.ST87Ouvea, ToWGS84 = new DatumShiftParameters (-56.263, 16.136, -22.856, 0, 0, 0, 0)};
        public IGeographicCRS SVY21 = new GeographicCRS {Name = "SVY21", Datum = DatumRegistry.Instance.SVY21, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SWEREF99 = new GeographicCRS {Name = "SWEREF99", Datum = DatumRegistry.Instance.SWEREF99, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SaintPierreetMiquelon1950 = new GeographicCRS {Name = "Saint Pierre et Miquelon 1950", Datum = DatumRegistry.Instance.SaintPierreetMiquelon1950, ToWGS84 = new DatumShiftParameters (30, 430, 368, 0, 0, 0, 0)};
        public IGeographicCRS Samboja = new GeographicCRS {Name = "GCS_Samboja", Datum = DatumRegistry.Instance.Samboja, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Santo1965 = new GeographicCRS {Name = "Santo 1965", Datum = DatumRegistry.Instance.Santo1965, ToWGS84 = new DatumShiftParameters (170, 42, 84, 0, 0, 0, 0)};
        public IGeographicCRS SaoBraz = new GeographicCRS {Name = "GCS_Sao_Braz", Datum = DatumRegistry.Instance.SaoBraz, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SaoTome = new GeographicCRS {Name = "Sao Tome", Datum = DatumRegistry.Instance.SaoTome, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SapperHill1943 = new GeographicCRS {Name = "Sapper Hill 1943", Datum = DatumRegistry.Instance.SapperHill1943, ToWGS84 = new DatumShiftParameters (-355, 21, 72, 0, 0, 0, 0)};
        public IGeographicCRS Schwarzeck = new GeographicCRS {Name = "Schwarzeck", Datum = DatumRegistry.Instance.Schwarzeck, ToWGS84 = new DatumShiftParameters (616, 97, -251, 0, 0, 0, 0)};
        public IGeographicCRS Scoresbysund1952 = new GeographicCRS {Name = "Scoresbysund 1952", Datum = DatumRegistry.Instance.Scoresbysund1952, ToWGS84 = new DatumShiftParameters (105, 326, -102.5, 0, 0, 0.814, -0.6)};
        public IGeographicCRS Segara = new GeographicCRS {Name = "Segara", Datum = DatumRegistry.Instance.GunungSegara, ToWGS84 = new DatumShiftParameters (-403, 684, 41, 0, 0, 0, 0)};
        public IGeographicCRS SegaraJakarta = new GeographicCRS {Name = "Segara (Jakarta)", Datum = DatumRegistry.Instance.GunungSegaraJakarta, ToWGS84 = new DatumShiftParameters (-403, 684, 41, 0, 0, 0, 0)};
        public IGeographicCRS Segora = new GeographicCRS {Name = "GCS_Segora", Datum = DatumRegistry.Instance.Segora, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SelvagemGrande = new GeographicCRS {Name = "Selvagem Grande", Datum = DatumRegistry.Instance.SelvagemGrande, ToWGS84 = new DatumShiftParameters (-289, -124, 60, 0, 0, 0, 0)};
        public IGeographicCRS Serindung = new GeographicCRS {Name = "Serindung", Datum = DatumRegistry.Instance.Serindung, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SibunGorge1922 = new GeographicCRS {Name = "Sibun Gorge 1922", Datum = DatumRegistry.Instance.SibunGorge1922, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SierraLeone1924 = new GeographicCRS {Name = "Sierra Leone 1924", Datum = DatumRegistry.Instance.SierraLeoneColony1924, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SierraLeone1960 = new GeographicCRS {Name = "GCS_Sierra_Leone_1960", Datum = DatumRegistry.Instance.SierraLeone1960, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SierraLeone1968 = new GeographicCRS {Name = "Sierra Leone 1968", Datum = DatumRegistry.Instance.SierraLeone1968, ToWGS84 = new DatumShiftParameters (-88, 4, 101, 0, 0, 0, 0)};
        public IGeographicCRS Slovenia1996 = new GeographicCRS {Name = "Slovenia 1996", Datum = DatumRegistry.Instance.SloveniaGeodeticGeodeticDatum1996, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Solomon1968 = new GeographicCRS {Name = "Solomon 1968", Datum = DatumRegistry.Instance.Solomon1968, ToWGS84 = new DatumShiftParameters (230, -199, -752, 0, 0, 0, 0)};
        public IGeographicCRS SouthAsiaSingapore = new GeographicCRS {Name = "GCS_South_Asia_Singapore", Datum = DatumRegistry.Instance.SouthAsiaSingapore, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SouthGeorgia1968 = new GeographicCRS {Name = "South Georgia 1968", Datum = DatumRegistry.Instance.SouthGeorgia1968, ToWGS84 = new DatumShiftParameters (-794, 119, -298, 0, 0, 0, 0)};
        public IGeographicCRS SouthYemen = new GeographicCRS {Name = "South Yemen", Datum = DatumRegistry.Instance.SouthYemen, ToWGS84 = new DatumShiftParameters (-76, -138, 67, 0, 0, 0, 0)};
        public IGeographicCRS Sphere = new GeographicCRS {Name = "GCS_Sphere", Datum = DatumRegistry.Instance.Sphere, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SphereARCINFO = new GeographicCRS {Name = "GCS_Sphere_ARC_INFO", Datum = DatumRegistry.Instance.SphereARCINFO, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SphereClarke1866Authalic = new GeographicCRS {Name = "GCS_Sphere_Clarke_1866_Authalic", Datum = DatumRegistry.Instance.SphereClarke1866Authalic, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SphereEMEP = new GeographicCRS {Name = "GCS_Sphere_EMEP", Datum = DatumRegistry.Instance.SphereEMEP, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SphereGRS1980Authalic = new GeographicCRS {Name = "GCS_Sphere_GRS_1980_Authalic", Datum = DatumRegistry.Instance.SphereGRS1980Authalic, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS SphereInternational1924Authalic = new GeographicCRS {Name = "GCS_Sphere_International_1924_Authalic", Datum = DatumRegistry.Instance.SphereInternational1924Authalic, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS StGeorgeIsland = new GeographicCRS {Name = "St. George Island", Datum = DatumRegistry.Instance.StGeorgeIsland, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS StHelena1971 = new GeographicCRS {Name = "St. Helena 1971", Datum = DatumRegistry.Instance.StHelena1971, ToWGS84 = new DatumShiftParameters (-320, 550, -494, 0, 0, 0, 0)};
        public IGeographicCRS StKitts1955 = new GeographicCRS {Name = "St. Kitts 1955", Datum = DatumRegistry.Instance.StKitts1955, ToWGS84 = new DatumShiftParameters (9, 183, 236, 0, 0, 0, 0)};
        public IGeographicCRS StLawrenceIsland = new GeographicCRS {Name = "St. Lawrence Island", Datum = DatumRegistry.Instance.StLawrenceIsland, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS StLucia1955 = new GeographicCRS {Name = "St. Lucia 1955", Datum = DatumRegistry.Instance.StLucia1955, ToWGS84 = new DatumShiftParameters (-149, 128, 296, 0, 0, 0, 0)};
        public IGeographicCRS StPaulIsland = new GeographicCRS {Name = "St. Paul Island", Datum = DatumRegistry.Instance.StPaulIsland, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS StVincent1945 = new GeographicCRS {Name = "St. Vincent 1945", Datum = DatumRegistry.Instance.StVincent1945, ToWGS84 = new DatumShiftParameters (195.671, 332.517, 274.607, 0, 0, 0, 0)};
        public IGeographicCRS Struve1860 = new GeographicCRS {Name = "GCS_Struve_1860", Datum = DatumRegistry.Instance.Struve1860, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Sudan = new GeographicCRS {Name = "GCS_Sudan", Datum = DatumRegistry.Instance.Sudan, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS TC1948 = new GeographicCRS {Name = "TC(1948)", Datum = DatumRegistry.Instance.TrucialCoast1948, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS TGD2005 = new GeographicCRS {Name = "TGD2005", Datum = DatumRegistry.Instance.TongaGeodeticGeodeticDatum2005, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS TM65 = new GeographicCRS {Name = "TM65", Datum = DatumRegistry.Instance.TM65, ToWGS84 = new DatumShiftParameters (482.5, -130.6, 564.6, -1.042, -0.214, -0.631, 8.15)};
        public IGeographicCRS TM75 = new GeographicCRS {Name = "TM75", Datum = DatumRegistry.Instance.GeodeticGeodeticDatumof1965, ToWGS84 = new DatumShiftParameters (482.5, -130.6, 564.6, -1.042, -0.214, -0.631, 8.15)};
        public IGeographicCRS TUREF = new GeographicCRS {Name = "TUREF", Datum = DatumRegistry.Instance.TurkishNationalReferenceFrame, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS TWD67 = new GeographicCRS {Name = "TWD67", Datum = DatumRegistry.Instance.TaiwanGeodeticDatum1967, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS TWD97 = new GeographicCRS {Name = "TWD97", Datum = DatumRegistry.Instance.TaiwanGeodeticDatum1997, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Tahaa54 = new GeographicCRS {Name = "Tahaa 54", Datum = DatumRegistry.Instance.Tahaa54, ToWGS84 = new DatumShiftParameters (72.438, 345.918, 79.486, -1.6045, -0.8823, -0.5565, 1.3746)};
        public IGeographicCRS Tahiti52 = new GeographicCRS {Name = "Tahiti 52", Datum = DatumRegistry.Instance.Tahiti52, ToWGS84 = new DatumShiftParameters (162, 117, 154, 0, 0, 0, 0)};
        public IGeographicCRS Tahiti79 = new GeographicCRS {Name = "Tahiti 79", Datum = DatumRegistry.Instance.Tahiti79, ToWGS84 = new DatumShiftParameters (221.525, 152.948, 176.768, 2.3847, 1.3896, 0.877, 11.4741)};
        public IGeographicCRS Tananarive = new GeographicCRS {Name = "Tananarive", Datum = DatumRegistry.Instance.Tananarive1925, ToWGS84 = new DatumShiftParameters (-189, -242, -91, 0, 0, 0, 0)};
        public IGeographicCRS TananariveParis = new GeographicCRS {Name = "Tananarive (Paris)", Datum = DatumRegistry.Instance.Tananarive1925Paris, ToWGS84 = new DatumShiftParameters (-189, -242, -91, 0, 0, 0, 0)};
        public IGeographicCRS TernIsland1961 = new GeographicCRS {Name = "Tern Island 1961", Datum = DatumRegistry.Instance.TernIsland1961, ToWGS84 = new DatumShiftParameters (114, -116, -333, 0, 0, 0, 0)};
        public IGeographicCRS Tete = new GeographicCRS {Name = "Tete", Datum = DatumRegistry.Instance.Tete, ToWGS84 = new DatumShiftParameters (-73.472, -51.66, -112.482, -0.953, -4.6, 2.368, 0.586)};
        public IGeographicCRS Timbalai1948 = new GeographicCRS {Name = "Timbalai 1948", Datum = DatumRegistry.Instance.Timbalai1948, ToWGS84 = new DatumShiftParameters (-679, 669, -48, 0, 0, 0, 0)};
        public IGeographicCRS Tokyo = new GeographicCRS {Name = "Tokyo", Datum = DatumRegistry.Instance.Tokyo, ToWGS84 = new DatumShiftParameters (-146.414, 507.337, 680.507, 0, 0, 0, 0)};
        public IGeographicCRS Tokyo1892 = new GeographicCRS {Name = "Tokyo 1892", Datum = DatumRegistry.Instance.Tokyo1892, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Trinidad1903 = new GeographicCRS {Name = "Trinidad 1903", Datum = DatumRegistry.Instance.Trinidad1903, ToWGS84 = new DatumShiftParameters (-61.702, 284.488, 472.052, 0, 0, 0, 0)};
        public IGeographicCRS Tristan1968 = new GeographicCRS {Name = "Tristan 1968", Datum = DatumRegistry.Instance.Tristan1968, ToWGS84 = new DatumShiftParameters (-632, 438, -609, 0, 0, 0, 0)};
        public IGeographicCRS UCS2000 = new GeographicCRS {Name = "UCS-2000", Datum = DatumRegistry.Instance.Ukraine2000, ToWGS84 = new DatumShiftParameters (25, -141, -78.5, 0, -0.35, -0.736, 0)};
        public IGeographicCRS VN2000 = new GeographicCRS {Name = "VN-2000", Datum = DatumRegistry.Instance.Vietnam2000, ToWGS84 = new DatumShiftParameters (-192.873, -39.382, -111.202, 0.00205, 0.0005, -0.00335, 0.0188)};
        public IGeographicCRS VanuaLevu1915 = new GeographicCRS {Name = "Vanua Levu 1915", Datum = DatumRegistry.Instance.VanuaLevu1915, ToWGS84 = new DatumShiftParameters (51, 391, -36, 0, 0, 0, 0)};
        public IGeographicCRS Venus1985 = new GeographicCRS {Name = "GCS_Venus_1985", Datum = DatumRegistry.Instance.Venus1985, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Venus2000 = new GeographicCRS {Name = "GCS_Venus_2000", Datum = DatumRegistry.Instance.Venus2000, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Vientiane1982 = new GeographicCRS {Name = "Vientiane 1982", Datum = DatumRegistry.Instance.Vientiane1982, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS VitiLevu1912 = new GeographicCRS {Name = "Viti Levu 1912", Datum = DatumRegistry.Instance.VitiLevu1912, ToWGS84 = new DatumShiftParameters (51, 391, -36, 0, 0, 0, 0)};
        public IGeographicCRS VitiLevu1916 = new GeographicCRS {Name = "GCS_Viti_Levu_1916", Datum = DatumRegistry.Instance.VitiLevu1916, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Voirol1875 = new GeographicCRS {Name = "Voirol 1875", Datum = DatumRegistry.Instance.Voirol1875, ToWGS84 = new DatumShiftParameters (-73, -247, 227, 0, 0, 0, 0)};
        public IGeographicCRS Voirol1875Grad = new GeographicCRS {Name = "GCS_Voirol_1875_Grad", Datum = DatumRegistry.Instance.Voirol1875, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Voirol1875Paris = new GeographicCRS {Name = "Voirol 1875 (Paris)", Datum = DatumRegistry.Instance.Voirol1875Paris, ToWGS84 = new DatumShiftParameters (-73, -247, 227, 0, 0, 0, 0)};
        public IGeographicCRS Voirol1879 = new GeographicCRS {Name = "Voirol 1879", Datum = DatumRegistry.Instance.Voirol1879, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Voirol1879Grad = new GeographicCRS {Name = "GCS_Voirol_1879_Grad", Datum = DatumRegistry.Instance.Voirol1879, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Voirol1879Paris = new GeographicCRS {Name = "Voirol 1879 (Paris)", Datum = DatumRegistry.Instance.Voirol1879Paris, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS VoirolUnifie1960 = new GeographicCRS {Name = "GCS_Voirol_Unifie_1960", Datum = DatumRegistry.Instance.VoirolUnifie1960, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS VoirolUnifie1960Degree = new GeographicCRS {Name = "GCS_Voirol_Unifie_1960_Degree", Datum = DatumRegistry.Instance.VoirolUnifie1960, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS VoirolUnifie1960Paris = new GeographicCRS {Name = "GCS_Voirol_Unifie_1960_Paris", Datum = DatumRegistry.Instance.VoirolUnifie1960, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS WGS66 = new GeographicCRS {Name = "WGS 66", Datum = DatumRegistry.Instance.WorldGeodeticSystem1966, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS WGS72 = new GeographicCRS {Name = "WGS 72", Datum = DatumRegistry.Instance.WorldGeodeticSystem1972, ToWGS84 = new DatumShiftParameters (0, 0, 4.5, 0, 0, 0.554, 0.2263)};
        public IGeographicCRS WGS72BE = new GeographicCRS {Name = "WGS 72BE", Datum = DatumRegistry.Instance.WGS72TransitBroadcastEphemeris, ToWGS84 = new DatumShiftParameters (0, 0, 1.9, 0, 0, 0.814, -0.38)};
        public IGeographicCRS WGS84 = new GeographicCRS {Name = "WGS 84", Datum = DatumRegistry.Instance.WorldGeodeticSystem1984, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS WakeIsland1952 = new GeographicCRS {Name = "Wake Island 1952", Datum = DatumRegistry.Instance.WakeIsland1952, ToWGS84 = new DatumShiftParameters (276, -57, 149, 0, 0, 0, 0)};
        public IGeographicCRS Walbeck = new GeographicCRS {Name = "GCS_Walbeck", Datum = DatumRegistry.Instance.Walbeck, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS WarOffice = new GeographicCRS {Name = "GCS_War_Office", Datum = DatumRegistry.Instance.WarOffice, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Xian1980 = new GeographicCRS {Name = "Xian 1980", Datum = DatumRegistry.Instance.Xian1980, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Yacare = new GeographicCRS {Name = "Yacare", Datum = DatumRegistry.Instance.Yacare, ToWGS84 = new DatumShiftParameters (-155, 171, 37, 0, 0, 0, 0)};
        public IGeographicCRS YemenNGN96 = new GeographicCRS {Name = "Yemen NGN96", Datum = DatumRegistry.Instance.YemenNationalGeodeticNetwork1996, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Yoff = new GeographicCRS {Name = "Yoff", Datum = DatumRegistry.Instance.Yoff, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};
        public IGeographicCRS Zanderij = new GeographicCRS {Name = "Zanderij", Datum = DatumRegistry.Instance.Zanderij, ToWGS84 = new DatumShiftParameters (-265, 120, -358, 0, 0, 0, 0)};
        public IGeographicCRS fk89 = new GeographicCRS {Name = "fk89", Datum = DatumRegistry.Instance.fk89, ToWGS84 = new DatumShiftParameters (0, 0, 0, 0, 0, 0, 0)};

        private GeographicCRSRegistry ()
        {
            coordSys.Add (HD1909);
            HD1909.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "HD1909", 3819));
            HD1909.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_HD1909", 3819));

            coordSys.Add (TWD67);
            TWD67.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "TWD67", 3821));
            TWD67.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_TWD_1967", 3821));

            coordSys.Add (TWD97);
            TWD97.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "TWD97", 3824));
            TWD97.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_TWD_1997", 3824));

            coordSys.Add (IGRS);
            IGRS.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGRS", 3889));
            IGRS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IGRS", 3889));

            coordSys.Add (MGI1901);
            MGI1901.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "MGI 1901", 3906));
            MGI1901.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_MGI_1901", 3906));

            coordSys.Add (MOLDREF99);
            MOLDREF99.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "MOLDREF99", 4023));
            MOLDREF99.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_MOLDREF99", 4023));

            coordSys.Add (RGRDC2005);
            RGRDC2005.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RGRDC 2005", 4046));
            RGRDC2005.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RGRDC_2005", 4046));

            coordSys.Add (SREF98);
            SREF98.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SREF98", 4075));
            SREF98.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_SREF98", 4075));

            coordSys.Add (REGCAN95);
            REGCAN95.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "REGCAN95", 4081));
            REGCAN95.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_REGCAN95", 4081));

            coordSys.Add (Greek);
            Greek.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Greek", 4120));
            Greek.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Greek", 4120));

            coordSys.Add (GGRS87);
            GGRS87.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GGRS87", 4121));
            GGRS87.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_GGRS_1987", 4121));

            coordSys.Add (ATS77);
            ATS77.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ATS77", 4122));
            ATS77.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ATS_1977", 4122));

            coordSys.Add (KKJ);
            KKJ.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "KKJ", 4123));
            KKJ.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_KKJ", 4123));

            coordSys.Add (RT90);
            RT90.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RT90", 4124));
            RT90.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RT_1990", 4124));

            coordSys.Add (Tete);
            Tete.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tete", 4127));
            Tete.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Tete", 4127));

            coordSys.Add (Madzansua);
            Madzansua.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Madzansua", 4128));
            Madzansua.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Madzansua", 4128));

            coordSys.Add (Observatario);
            Observatario.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Observatario", 4129));
            Observatario.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Observatario", 4129));

            coordSys.Add (Moznet);
            Moznet.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Moznet", 4130));
            Moznet.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Moznet", 4130));

            coordSys.Add (Indian1960);
            Indian1960.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Indian 1960", 4131));
            Indian1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Indian_1960", 4131));

            coordSys.Add (FD58);
            FD58.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "FD58", 4132));
            FD58.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_FD_1958", 4132));

            coordSys.Add (EST92);
            EST92.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "EST92", 4133));
            EST92.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Estonia_1992", 4133));

            coordSys.Add (PSD93);
            PSD93.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "PSD93", 4134));
            PSD93.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_PDO_1993", 4134));

            coordSys.Add (OldHawaiian);
            OldHawaiian.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Old Hawaiian", 4135));
            OldHawaiian.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Old_Hawaiian", 4135));

            coordSys.Add (StLawrenceIsland);
            StLawrenceIsland.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Lawrence Island", 4136));
            StLawrenceIsland.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_St_Lawrence_Island", 4136));

            coordSys.Add (StPaulIsland);
            StPaulIsland.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Paul Island", 4137));
            StPaulIsland.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_St_Paul_Island", 4137));

            coordSys.Add (StGeorgeIsland);
            StGeorgeIsland.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. George Island", 4138));
            StGeorgeIsland.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_St_George_Island", 4138));

            coordSys.Add (PuertoRico);
            PuertoRico.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Puerto Rico", 4139));
            PuertoRico.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Puerto_Rico", 4139));

            coordSys.Add (Israel);
            Israel.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Israel", 4141));
            Israel.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Israel", 4141));

            coordSys.Add (Locodjo1965);
            Locodjo1965.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Locodjo 1965", 4142));
            Locodjo1965.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Locodjo_1965", 4142));

            coordSys.Add (Abidjan1987);
            Abidjan1987.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Abidjan 1987", 4143));
            Abidjan1987.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Abidjan_1987", 4143));

            coordSys.Add (Kalianpur1937);
            Kalianpur1937.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kalianpur 1937", 4144));
            Kalianpur1937.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Kalianpur_1937", 4144));

            coordSys.Add (Kalianpur1962);
            Kalianpur1962.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kalianpur 1962", 4145));
            Kalianpur1962.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Kalianpur_1962", 4145));

            coordSys.Add (Kalianpur1975);
            Kalianpur1975.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kalianpur 1975", 4146));
            Kalianpur1975.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Kalianpur_1975", 4146));

            coordSys.Add (Hanoi1972);
            Hanoi1972.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hanoi 1972", 4147));
            Hanoi1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hanoi_1972", 4147));

            coordSys.Add (Hartebeesthoek94);
            Hartebeesthoek94.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hartebeesthoek94", 4148));
            Hartebeesthoek94.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hartebeesthoek_1994", 4148));

            coordSys.Add (CH1903);
            CH1903.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "CH1903", 4149));
            CH1903.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_CH1903", 4149));

            coordSys.Add (CH1903Plus);
            CH1903Plus.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "CH1903+", 4150));
            CH1903Plus.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_CH1903+", 4150));

            coordSys.Add (CHTRF95);
            CHTRF95.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "CHTRF95", 4151));
            CHTRF95.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Swiss_TRF_1995", 4151));

            coordSys.Add (NAD83HARN);
            NAD83HARN.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NAD83(HARN)", 4152));
            NAD83HARN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_North_American_1983_HARN", 4152));

            coordSys.Add (Rassadiran);
            Rassadiran.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Rassadiran", 4153));
            Rassadiran.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Rassadiran", 4153));

            coordSys.Add (ED50ED77);
            ED50ED77.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ED50(ED77)", 4154));
            ED50ED77.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_European_1950_ED77", 4154));

            coordSys.Add (Dabola1981);
            Dabola1981.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Dabola 1981", 4155));
            Dabola1981.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Dabola_1981", 4155));

            coordSys.Add (SJTSK);
            SJTSK.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "S-JTSK", 4156));
            SJTSK.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_S_JTSK", 4156));

            coordSys.Add (MountDillon);
            MountDillon.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mount Dillon", 4157));
            MountDillon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Mount_Dillon", 4157));

            coordSys.Add (Naparima1955);
            Naparima1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Naparima 1955", 4158));
            Naparima1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Naparima_1955", 4158));

            coordSys.Add (ELD79);
            ELD79.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ELD79", 4159));
            ELD79.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_European_Libyan_Datum_1979", 4159));

            coordSys.Add (ChosMalal1914);
            ChosMalal1914.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Chos Malal 1914", 4160));
            ChosMalal1914.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Chos_Malal_1914", 4160));

            coordSys.Add (PampadelCastillo);
            PampadelCastillo.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pampa del Castillo", 4161));
            PampadelCastillo.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Pampa_del_Castillo", 4161));

            coordSys.Add (Korean1985);
            Korean1985.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Korean 1985", 4162));
            Korean1985.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Korean_Datum_1985", 4162));

            coordSys.Add (YemenNGN96);
            YemenNGN96.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Yemen NGN96", 4163));
            YemenNGN96.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Yemen_NGN_1996", 4163));

            coordSys.Add (SouthYemen);
            SouthYemen.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "South Yemen", 4164));
            SouthYemen.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_South_Yemen", 4164));

            coordSys.Add (Bissau);
            Bissau.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bissau", 4165));
            Bissau.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bissau", 4165));

            coordSys.Add (Korean1995);
            Korean1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Korean 1995", 4166));
            Korean1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Korean_Datum_1995", 4166));

            coordSys.Add (NZGD2000);
            NZGD2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NZGD2000", 4167));
            NZGD2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NZGD_2000", 4167));

            coordSys.Add (Accra);
            Accra.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Accra", 4168));
            Accra.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Accra", 4168));

            coordSys.Add (AmericanSamoa1962);
            AmericanSamoa1962.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "American Samoa 1962", 4169));
            AmericanSamoa1962.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_American_Samoa_1962", 4169));

            coordSys.Add (SIRGAS1995);
            SIRGAS1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SIRGAS 1995", 4170));
            SIRGAS1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_SIRGAS", 4170));

            coordSys.Add (RGF93);
            RGF93.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RGF93", 4171));
            RGF93.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RGF_1993", 4171));

            coordSys.Add (IRENET95);
            IRENET95.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IRENET95", 4173));
            IRENET95.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IRENET95", 4173));

            coordSys.Add (SierraLeone1924);
            SierraLeone1924.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sierra Leone 1924", 4174));
            SierraLeone1924.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sierra_Leone_1924", 4174));

            coordSys.Add (SierraLeone1968);
            SierraLeone1968.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sierra Leone 1968", 4175));
            SierraLeone1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sierra_Leone_1968", 4175));

            coordSys.Add (AustralianAntarctic);
            AustralianAntarctic.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Australian Antarctic", 4176));
            AustralianAntarctic.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Australian_Antarctic_1998", 4176));

            coordSys.Add (Pulkovo194283);
            Pulkovo194283.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pulkovo 1942(83)", 4178));
            Pulkovo194283.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Pulkovo_1942_Adj_1983", 4178));

            coordSys.Add (Pulkovo194258);
            Pulkovo194258.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pulkovo 1942(58)", 4179));
            Pulkovo194258.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Pulkovo_1942_Adj_1958", 4179));

            coordSys.Add (EST97);
            EST97.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "EST97", 4180));
            EST97.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Estonia_1997", 4180));

            coordSys.Add (Luxembourg1930);
            Luxembourg1930.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Luxembourg 1930", 4181));
            Luxembourg1930.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Luxembourg_1930", 4181));

            coordSys.Add (AzoresOccidental1939);
            AzoresOccidental1939.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Azores Occidental 1939", 4182));
            AzoresOccidental1939.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Azores_Occidental_1939", 4182));

            coordSys.Add (AzoresCentral1948);
            AzoresCentral1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Azores Central 1948", 4183));
            AzoresCentral1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Azores_Central_1948", 4183));

            coordSys.Add (AzoresOriental1940);
            AzoresOriental1940.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Azores Oriental 1940", 4184));
            AzoresOriental1940.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Azores_Oriental_1940", 4184));

            coordSys.Add (OSNI1952);
            OSNI1952.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "OSNI 1952", 4188));
            OSNI1952.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_OSNI_1952", 4188));

            coordSys.Add (REGVEN);
            REGVEN.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "REGVEN", 4189));
            REGVEN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_REGVEN", 4189));

            coordSys.Add (POSGAR98);
            POSGAR98.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "POSGAR 98", 4190));
            POSGAR98.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_POSGAR_1998", 4190));

            coordSys.Add (Albanian1987);
            Albanian1987.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Albanian 1987", 4191));
            Albanian1987.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Albanian_1987", 4191));

            coordSys.Add (Douala1948);
            Douala1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Douala 1948", 4192));
            Douala1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Douala_1948", 4192));

            coordSys.Add (Manoca1962);
            Manoca1962.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Manoca 1962", 4193));
            Manoca1962.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Manoca_1962", 4193));

            coordSys.Add (Qornoq1927);
            Qornoq1927.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Qornoq 1927", 4194));
            Qornoq1927.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Qornoq_1927", 4194));

            coordSys.Add (Scoresbysund1952);
            Scoresbysund1952.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Scoresbysund 1952", 4195));
            Scoresbysund1952.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Scoresbysund_1952", 4195));

            coordSys.Add (Ammassalik1958);
            Ammassalik1958.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ammassalik 1958", 4196));
            Ammassalik1958.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Ammassalik_1958", 4196));

            coordSys.Add (Garoua);
            Garoua.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Garoua", 4197));
            Garoua.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Garoua", 4197));

            coordSys.Add (Kousseri);
            Kousseri.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kousseri", 4198));
            Kousseri.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Kousseri", 4198));

            coordSys.Add (Egypt1930);
            Egypt1930.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Egypt 1930", 4199));
            Egypt1930.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Egypt_1930", 4199));

            coordSys.Add (Pulkovo1995);
            Pulkovo1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pulkovo 1995", 4200));
            Pulkovo1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Pulkovo_1995", 4200));

            coordSys.Add (Adindan);
            Adindan.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Adindan", 4201));
            Adindan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Adindan", 4201));

            coordSys.Add (AGD66);
            AGD66.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "AGD66", 4202));
            AGD66.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Australian_1966", 4202));

            coordSys.Add (AGD84);
            AGD84.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "AGD84", 4203));
            AGD84.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Australian_1984", 4203));

            coordSys.Add (AinelAbd);
            AinelAbd.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ain el Abd", 4204));
            AinelAbd.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Ain_el_Abd_1970", 4204));

            coordSys.Add (Afgooye);
            Afgooye.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Afgooye", 4205));
            Afgooye.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Afgooye", 4205));

            coordSys.Add (Agadez);
            Agadez.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Agadez", 4206));
            Agadez.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Agadez", 4206));

            coordSys.Add (Lisbon);
            Lisbon.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lisbon", 4207));
            Lisbon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Lisbon", 4207));

            coordSys.Add (Aratu);
            Aratu.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Aratu", 4208));
            Aratu.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Aratu", 4208));

            coordSys.Add (Arc1950);
            Arc1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Arc 1950", 4209));
            Arc1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Arc_1950", 4209));

            coordSys.Add (Arc1960);
            Arc1960.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Arc 1960", 4210));
            Arc1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Arc_1960", 4210));

            coordSys.Add (Batavia);
            Batavia.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Batavia", 4211));
            Batavia.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Batavia", 4211));

            coordSys.Add (Barbados1938);
            Barbados1938.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Barbados 1938", 4212));
            Barbados1938.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Barbados_1938", 4212));

            coordSys.Add (Beduaram);
            Beduaram.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Beduaram", 4213));
            Beduaram.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Beduaram", 4213));

            coordSys.Add (Beijing1954);
            Beijing1954.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Beijing 1954", 4214));
            Beijing1954.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Beijing_1954", 4214));

            coordSys.Add (Belge1950);
            Belge1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Belge 1950", 4215));
            Belge1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Belge_1950", 4215));

            coordSys.Add (Bermuda1957);
            Bermuda1957.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bermuda 1957", 4216));
            Bermuda1957.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bermuda_1957", 4216));

            coordSys.Add (Bogota1975);
            Bogota1975.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bogota 1975", 4218));
            Bogota1975.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bogota", 4218));

            coordSys.Add (BukitRimpah);
            BukitRimpah.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bukit Rimpah", 4219));
            BukitRimpah.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bukit_Rimpah", 4219));

            coordSys.Add (Camacupa);
            Camacupa.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Camacupa", 4220));
            Camacupa.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Camacupa", 4220));

            coordSys.Add (CampoInchauspe);
            CampoInchauspe.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Campo Inchauspe", 4221));
            CampoInchauspe.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Campo_Inchauspe", 4221));

            coordSys.Add (Cape);
            Cape.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Cape", 4222));
            Cape.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Cape", 4222));

            coordSys.Add (Carthage);
            Carthage.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Carthage", 4223));
            Carthage.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Carthage", 4223));

            coordSys.Add (Chua);
            Chua.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Chua", 4224));
            Chua.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Chua", 4224));

            coordSys.Add (CorregoAlegre197072);
            CorregoAlegre197072.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Corrego Alegre 1970-72", 4225));
            CorregoAlegre197072.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Corrego_Alegre", 4225));

            coordSys.Add (DeirezZor);
            DeirezZor.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Deir ez Zor", 4227));
            DeirezZor.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Deir_ez_Zor", 4227));

            coordSys.Add (Egypt1907);
            Egypt1907.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Egypt 1907", 4229));
            Egypt1907.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Egypt_1907", 4229));

            coordSys.Add (ED50);
            ED50.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ED50", 4230));
            ED50.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_European_1950", 4230));

            coordSys.Add (ED87);
            ED87.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ED87", 4231));
            ED87.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_European_1987", 4231));

            coordSys.Add (Fahud);
            Fahud.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Fahud", 4232));
            Fahud.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Fahud", 4232));

            coordSys.Add (HuTzuShan1950);
            HuTzuShan1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hu Tzu Shan 1950", 4236));
            HuTzuShan1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hu_Tzu_Shan", 4236));

            coordSys.Add (HD72);
            HD72.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "HD72", 4237));
            HD72.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hungarian_1972", 4237));

            coordSys.Add (ID74);
            ID74.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ID74", 4238));
            ID74.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Indonesian_1974", 4238));

            coordSys.Add (Indian1954);
            Indian1954.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Indian 1954", 4239));
            Indian1954.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Indian_1954", 4239));

            coordSys.Add (Indian1975);
            Indian1975.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Indian 1975", 4240));
            Indian1975.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Indian_1975", 4240));

            coordSys.Add (JAD69);
            JAD69.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "JAD69", 4242));
            JAD69.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Jamaica_1969", 4242));

            coordSys.Add (Kandawala);
            Kandawala.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kandawala", 4244));
            Kandawala.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Kandawala", 4244));

            coordSys.Add (Kertau1968);
            Kertau1968.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kertau 1968", 4245));
            Kertau1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Kertau", 4245));

            coordSys.Add (KOC);
            KOC.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "KOC", 4246));
            KOC.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Kuwait_Oil_Company", 4246));

            coordSys.Add (LaCanoa);
            LaCanoa.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "La Canoa", 4247));
            LaCanoa.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_La_Canoa", 4247));

            coordSys.Add (PSAD56);
            PSAD56.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "PSAD56", 4248));
            PSAD56.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Provisional_S_American_1956", 4248));

            coordSys.Add (Lake);
            Lake.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lake", 4249));
            Lake.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Lake", 4249));

            coordSys.Add (Leigon);
            Leigon.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Leigon", 4250));
            Leigon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Leigon", 4250));

            coordSys.Add (Liberia1964);
            Liberia1964.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Liberia 1964", 4251));
            Liberia1964.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Liberia_1964", 4251));

            coordSys.Add (Lome);
            Lome.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lome", 4252));
            Lome.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Lome", 4252));

            coordSys.Add (Luzon1911);
            Luzon1911.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Luzon 1911", 4253));
            Luzon1911.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Luzon_1911", 4253));

            coordSys.Add (HitoXVIII1963);
            HitoXVIII1963.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hito XVIII 1963", 4254));
            HitoXVIII1963.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hito_XVIII_1963", 4254));

            coordSys.Add (HeratNorth);
            HeratNorth.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Herat North", 4255));
            HeratNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Herat_North", 4255));

            coordSys.Add (Mahe1971);
            Mahe1971.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mahe 1971", 4256));
            Mahe1971.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Mahe_1971", 4256));

            coordSys.Add (Makassar);
            Makassar.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Makassar", 4257));
            Makassar.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Makassar", 4257));

            coordSys.Add (ETRS89);
            ETRS89.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ETRS89", 4258));
            ETRS89.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ETRS_1989", 4258));

            coordSys.Add (Malongo1987);
            Malongo1987.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Malongo 1987", 4259));
            Malongo1987.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Malongo_1987", 4259));

            coordSys.Add (Merchich);
            Merchich.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Merchich", 4261));
            Merchich.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Merchich", 4261));

            coordSys.Add (Massawa);
            Massawa.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Massawa", 4262));
            Massawa.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Massawa", 4262));

            coordSys.Add (Minna);
            Minna.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Minna", 4263));
            Minna.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Minna", 4263));

            coordSys.Add (MonteMario);
            MonteMario.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Monte Mario", 4265));
            MonteMario.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Monte_Mario", 4265));

            coordSys.Add (Mporaloko);
            Mporaloko.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "M'poraloko", 4266));
            Mporaloko.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Mporaloko", 4266));

            coordSys.Add (NAD27);
            NAD27.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NAD27", 4267));
            NAD27.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_North_American_1927", 4267));

            coordSys.Add (NAD83);
            NAD83.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NAD83", 4269));
            NAD83.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_North_American_1983", 4269));

            coordSys.Add (Nahrwan1967);
            Nahrwan1967.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nahrwan 1967", 4270));
            Nahrwan1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Nahrwan_1967", 4270));

            coordSys.Add (Naparima1972);
            Naparima1972.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Naparima 1972", 4271));
            Naparima1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Naparima_1972", 4271));

            coordSys.Add (NZGD49);
            NZGD49.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NZGD49", 4272));
            NZGD49.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_New_Zealand_1949", 4272));

            coordSys.Add (NGO1948);
            NGO1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NGO 1948", 4273));
            NGO1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NGO_1948", 4273));

            coordSys.Add (Datum73);
            Datum73.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Datum 73", 4274));
            Datum73.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Datum_73", 4274));

            coordSys.Add (NTF);
            NTF.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NTF", 4275));
            NTF.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NTF", 4275));

            coordSys.Add (NSWC9Z2);
            NSWC9Z2.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NSWC 9Z-2", 4276));
            NSWC9Z2.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NSWC_9Z_2", 4276));

            coordSys.Add (OSGB1936);
            OSGB1936.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "OSGB 1936", 4277));
            OSGB1936.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_OSGB_1936", 4277));

            coordSys.Add (OSGB70);
            OSGB70.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "OSGB70", 4278));
            OSGB70.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_OSGB_1970_SN", 4278));

            coordSys.Add (OSSN80);
            OSSN80.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "OS(SN)80", 4279));
            OSSN80.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_OS_SN_1980", 4279));

            coordSys.Add (Padang);
            Padang.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Padang", 4280));
            Padang.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Padang_1884", 4280));

            coordSys.Add (Palestine1923);
            Palestine1923.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Palestine 1923", 4281));
            Palestine1923.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Palestine_1923", 4281));

            coordSys.Add (PointeNoire);
            PointeNoire.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pointe Noire", 4282));
            PointeNoire.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Pointe_Noire", 4282));

            coordSys.Add (GDA94);
            GDA94.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GDA94", 4283));
            GDA94.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_GDA_1994", 4283));

            coordSys.Add (Pulkovo1942);
            Pulkovo1942.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pulkovo 1942", 4284));
            Pulkovo1942.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Pulkovo_1942", 4284));

            coordSys.Add (Qatar1974);
            Qatar1974.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Qatar 1974", 4285));
            Qatar1974.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Qatar_1974", 4285));

            coordSys.Add (Qatar1948);
            Qatar1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Qatar 1948", 4286));
            Qatar1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Qatar_1948", 4286));

            coordSys.Add (LomaQuintana);
            LomaQuintana.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Loma Quintana", 4288));
            LomaQuintana.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Loma_Quintana", 4288));

            coordSys.Add (Amersfoort);
            Amersfoort.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Amersfoort", 4289));
            Amersfoort.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Amersfoort", 4289));

            coordSys.Add (SapperHill1943);
            SapperHill1943.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sapper Hill 1943", 4292));
            SapperHill1943.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sapper_Hill_1943", 4292));

            coordSys.Add (Schwarzeck);
            Schwarzeck.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Schwarzeck", 4293));
            Schwarzeck.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Schwarzeck", 4293));

            coordSys.Add (Serindung);
            Serindung.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Serindung", 4295));
            Serindung.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Serindung", 4295));

            coordSys.Add (Tananarive);
            Tananarive.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tananarive", 4297));
            Tananarive.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Tananarive_1925", 4297));

            coordSys.Add (Timbalai1948);
            Timbalai1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Timbalai 1948", 4298));
            Timbalai1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Timbalai_1948", 4298));

            coordSys.Add (TM65);
            TM65.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "TM65", 4299));
            TM65.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_TM65", 4299));

            coordSys.Add (TM75);
            TM75.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "TM75", 4300));
            TM75.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_TM75", 4300));

            coordSys.Add (Tokyo);
            Tokyo.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tokyo", 4301));
            Tokyo.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Tokyo", 4301));

            coordSys.Add (Trinidad1903);
            Trinidad1903.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Trinidad 1903", 4302));
            Trinidad1903.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Trinidad_1903", 4302));

            coordSys.Add (TC1948);
            TC1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "TC(1948)", 4303));
            TC1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Trucial_Coast_1948", 4303));

            coordSys.Add (Voirol1875);
            Voirol1875.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Voirol 1875", 4304));
            Voirol1875.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Voirol_1875", 4304));

            coordSys.Add (Bern1938);
            Bern1938.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bern 1938", 4306));
            Bern1938.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bern_1938", 4306));

            coordSys.Add (NordSahara1959);
            NordSahara1959.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nord Sahara 1959", 4307));
            NordSahara1959.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Nord_Sahara_1959", 4307));

            coordSys.Add (RT38);
            RT38.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RT38", 4308));
            RT38.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RT38", 4308));

            coordSys.Add (Yacare);
            Yacare.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Yacare", 4309));
            Yacare.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Yacare", 4309));

            coordSys.Add (Yoff);
            Yoff.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Yoff", 4310));
            Yoff.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Yoff", 4310));

            coordSys.Add (Zanderij);
            Zanderij.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Zanderij", 4311));
            Zanderij.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Zanderij", 4311));

            coordSys.Add (MGI);
            MGI.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "MGI", 4312));
            MGI.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_MGI", 4312));

            coordSys.Add (Belge1972);
            Belge1972.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Belge 1972", 4313));
            Belge1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Belge_1972", 4313));

            coordSys.Add (DHDN);
            DHDN.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "DHDN", 4314));
            DHDN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Deutsches_Hauptdreiecksnetz", 4314));

            coordSys.Add (Conakry1905);
            Conakry1905.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Conakry 1905", 4315));
            Conakry1905.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Conakry_1905", 4315));

            coordSys.Add (DealulPiscului1930);
            DealulPiscului1930.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Dealul Piscului 1930", 4316));
            DealulPiscului1930.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Dealul_Piscului_1933", 4316));

            coordSys.Add (NGN);
            NGN.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NGN", 4318));
            NGN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NGN", 4318));

            coordSys.Add (KUDAMS);
            KUDAMS.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "KUDAMS", 4319));
            KUDAMS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_KUDAMS", 4319));

            coordSys.Add (WGS72);
            WGS72.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "WGS 72", 4322));
            WGS72.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_WGS_1972", 4322));

            coordSys.Add (WGS72BE);
            WGS72BE.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "WGS 72BE", 4324));
            WGS72BE.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_WGS_1972_BE", 4324));

            coordSys.Add (WGS84);
            WGS84.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "WGS 84", 4326));
            WGS84.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_WGS_1984", 4326));

            coordSys.Add (RGSPM06);
            RGSPM06.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RGSPM06", 4463));
            RGSPM06.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RGSPM_2006", 4463));

            coordSys.Add (RGM04);
            RGM04.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RGM04", 4470));
            RGM04.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RGM_2004", 4470));

            coordSys.Add (Cadastre1997);
            Cadastre1997.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Cadastre 1997", 4475));
            Cadastre1997.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Cadastre_1997", 4475));

            coordSys.Add (MexicanDatumof1993);
            MexicanDatumof1993.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mexican Datum of 1993", 4483));
            MexicanDatumof1993.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Mexican_Datum_of_1993", 4483));

            coordSys.Add (ChinaGeodeticCoordinateSystem2000);
            ChinaGeodeticCoordinateSystem2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "China Geodetic Coordinate System 2000", 4490));
            ChinaGeodeticCoordinateSystem2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_China_Geodetic_Coordinate_System_2000", 4490));

            coordSys.Add (NewBeijing);
            NewBeijing.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "New Beijing", 4555));
            NewBeijing.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_New_Beijing", 4555));

            coordSys.Add (RRAF1991);
            RRAF1991.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RRAF 1991", 4558));
            RRAF1991.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RRAF_1991", 4558));

            coordSys.Add (Anguilla1957);
            Anguilla1957.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Anguilla 1957", 4600));
            Anguilla1957.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Anguilla_1957", 4600));

            coordSys.Add (Antigua1943);
            Antigua1943.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Antigua 1943", 4601));
            Antigua1943.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Antigua_1943", 4601));

            coordSys.Add (Dominica1945);
            Dominica1945.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Dominica 1945", 4602));
            Dominica1945.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Dominica_1945", 4602));

            coordSys.Add (Grenada1953);
            Grenada1953.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Grenada 1953", 4603));
            Grenada1953.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Grenada_1953", 4603));

            coordSys.Add (Montserrat1958);
            Montserrat1958.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Montserrat 1958", 4604));
            Montserrat1958.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Montserrat_1958", 4604));

            coordSys.Add (StKitts1955);
            StKitts1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Kitts 1955", 4605));
            StKitts1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_St_Kitts_1955", 4605));

            coordSys.Add (StLucia1955);
            StLucia1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Lucia 1955", 4606));
            StLucia1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_St_Lucia_1955", 4606));

            coordSys.Add (StVincent1945);
            StVincent1945.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Vincent 1945", 4607));
            StVincent1945.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_St_Vincent_1945", 4607));

            coordSys.Add (NAD2776);
            NAD2776.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NAD27(76)", 4608));
            NAD2776.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1927_Definition_1976", 4608));

            coordSys.Add (NAD27CGQ77);
            NAD27CGQ77.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NAD27(CGQ77)", 4609));
            NAD27CGQ77.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1927_CGQ77", 4609));

            coordSys.Add (Xian1980);
            Xian1980.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Xian 1980", 4610));
            Xian1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Xian_1980", 4610));

            coordSys.Add (HongKong1980);
            HongKong1980.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hong Kong 1980", 4611));
            HongKong1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hong_Kong_1980", 4611));

            coordSys.Add (JGD2000);
            JGD2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "JGD2000", 4612));
            JGD2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_JGD_2000", 4612));

            coordSys.Add (Segara);
            Segara.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Segara", 4613));
            Segara.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Gunung_Segara", 4613));

            coordSys.Add (QND95);
            QND95.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "QND95", 4614));
            QND95.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_QND_1995", 4614));

            coordSys.Add (PortoSanto);
            PortoSanto.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Porto Santo", 4615));
            PortoSanto.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Porto_Santo_1936", 4615));

            coordSys.Add (SelvagemGrande);
            SelvagemGrande.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Selvagem Grande", 4616));
            SelvagemGrande.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Selvagem_Grande_1938", 4616));

            coordSys.Add (NAD83CSRS);
            NAD83CSRS.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NAD83(CSRS)", 4617));
            NAD83CSRS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_North_American_1983_CSRS", 4617));

            coordSys.Add (SAD69);
            SAD69.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SAD69", 4618));
            SAD69.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_South_American_1969", 4618));

            coordSys.Add (SWEREF99);
            SWEREF99.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SWEREF99", 4619));
            SWEREF99.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_SWEREF99", 4619));

            coordSys.Add (Point58);
            Point58.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Point 58", 4620));
            Point58.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Point_58", 4620));

            coordSys.Add (FortMarigot);
            FortMarigot.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Fort Marigot", 4621));
            FortMarigot.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Fort_Marigot", 4621));

            coordSys.Add (Guadeloupe1948);
            Guadeloupe1948.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Guadeloupe 1948", 4622));
            Guadeloupe1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sainte_Anne", 4622));

            coordSys.Add (CSG67);
            CSG67.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "CSG67", 4623));
            CSG67.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_CSG_1967", 4623));

            coordSys.Add (RGFG95);
            RGFG95.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RGFG95", 4624));
            RGFG95.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RGFG_1995", 4624));

            coordSys.Add (Martinique1938);
            Martinique1938.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Martinique 1938", 4625));
            Martinique1938.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Fort_Desaix", 4625));

            coordSys.Add (Reunion1947);
            Reunion1947.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reunion 1947", 4626));
            Reunion1947.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Reunion_1947", 4626));

            coordSys.Add (RGR92);
            RGR92.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RGR92", 4627));
            RGR92.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RGR_1992", 4627));

            coordSys.Add (Tahiti52);
            Tahiti52.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tahiti 52", 4628));
            Tahiti52.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Tahiti_1952", 4628));

            coordSys.Add (Tahaa54);
            Tahaa54.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tahaa 54", 4629));
            Tahaa54.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Tahaa_1954", 4629));

            coordSys.Add (IGN72NukuHiva);
            IGN72NukuHiva.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN72 Nuku Hiva", 4630));
            IGN72NukuHiva.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IGN72_Nuku_Hiva", 4630));

            coordSys.Add (Combani1950);
            Combani1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Combani 1950", 4632));
            Combani1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Combani_1950", 4632));

            coordSys.Add (IGN56Lifou);
            IGN56Lifou.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN56 Lifou", 4633));
            IGN56Lifou.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IGN56_Lifou", 4633));

            coordSys.Add (Petrels1972);
            Petrels1972.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Petrels 1972", 4636));
            Petrels1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Petrels_1972", 4636));

            coordSys.Add (Perroud1950);
            Perroud1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Perroud 1950", 4637));
            Perroud1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Pointe_Geologie_Perroud_1950", 4637));

            coordSys.Add (SaintPierreetMiquelon1950);
            SaintPierreetMiquelon1950.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Saint Pierre et Miquelon 1950", 4638));
            SaintPierreetMiquelon1950.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Saint_Pierre_et_Miquelon_1950", 4638));

            coordSys.Add (MOP78);
            MOP78.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "MOP78", 4639));
            MOP78.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_MOP78", 4639));

            coordSys.Add (IGN53Mare);
            IGN53Mare.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN53 Mare", 4641));
            IGN53Mare.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IGN53_Mare", 4641));

            coordSys.Add (ST84IledesPins);
            ST84IledesPins.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ST84 Ile des Pins", 4642));
            ST84IledesPins.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ST84_Ile_des_Pins", 4642));

            coordSys.Add (ST71Belep);
            ST71Belep.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ST71 Belep", 4643));
            ST71Belep.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ST71_Belep", 4643));

            coordSys.Add (NEA74Noumea);
            NEA74Noumea.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NEA74 Noumea", 4644));
            NEA74Noumea.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NEA74_Noumea", 4644));

            coordSys.Add (GrandComoros);
            GrandComoros.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Grand Comoros", 4646));
            GrandComoros.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Grand_Comoros", 4646));

            coordSys.Add (Reykjavik1900);
            Reykjavik1900.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Reykjavik 1900", 4657));
            Reykjavik1900.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Reykjavik_1900", 4657));

            coordSys.Add (Hjorsey1955);
            Hjorsey1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hjorsey 1955", 4658));
            Hjorsey1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hjorsey_1955", 4658));

            coordSys.Add (ISN93);
            ISN93.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ISN93", 4659));
            ISN93.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ISN_1993", 4659));

            coordSys.Add (Helle1954);
            Helle1954.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Helle 1954", 4660));
            Helle1954.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Helle_1954", 4660));

            coordSys.Add (LKS92);
            LKS92.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "LKS92", 4661));
            LKS92.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_LKS_1992", 4661));

            coordSys.Add (IGN72GrandeTerre);
            IGN72GrandeTerre.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN72 Grande Terre", 4662));
            IGN72GrandeTerre.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IGN72_Grande_Terre", 4662));

            coordSys.Add (AzoresOriental1995);
            AzoresOriental1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Azores Oriental 1995", 4664));
            AzoresOriental1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Azores_Oriental_1995", 4664));

            coordSys.Add (AzoresCentral1995);
            AzoresCentral1995.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Azores Central 1995", 4665));
            AzoresCentral1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Azores_Central_1995", 4665));

            coordSys.Add (Lisbon1890);
            Lisbon1890.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lisbon 1890", 4666));
            Lisbon1890.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Lisbon_1890", 4666));

            coordSys.Add (IKBD92);
            IKBD92.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IKBD-92", 4667));
            IKBD92.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IKBD_1992", 4667));

            coordSys.Add (ED79);
            ED79.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ED79", 4668));
            ED79.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_European_1979", 4668));

            coordSys.Add (LKS94);
            LKS94.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "LKS94", 4669));
            LKS94.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_LKS_1994", 4669));

            coordSys.Add (IGM95);
            IGM95.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGM95", 4670));
            IGM95.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IGM_1995", 4670));

            coordSys.Add (Voirol1879);
            Voirol1879.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Voirol 1879", 4671));
            Voirol1879.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Voirol_1879", 4671));

            coordSys.Add (ChathamIslands1971);
            ChathamIslands1971.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Chatham Islands 1971", 4672));
            ChathamIslands1971.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Chatham_Island_1971", 4672));

            coordSys.Add (ChathamIslands1979);
            ChathamIslands1979.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Chatham Islands 1979", 4673));
            ChathamIslands1979.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Chatham_Islands_1979", 4673));

            coordSys.Add (SIRGAS2000);
            SIRGAS2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SIRGAS 2000", 4674));
            SIRGAS2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_SIRGAS_2000", 4674));

            coordSys.Add (Guam1963);
            Guam1963.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Guam 1963", 4675));
            Guam1963.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Guam_1963", 4675));

            coordSys.Add (Vientiane1982);
            Vientiane1982.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Vientiane 1982", 4676));
            Vientiane1982.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Vientiane_1982", 4676));

            coordSys.Add (Lao1993);
            Lao1993.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lao 1993", 4677));
            Lao1993.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Lao_1993", 4677));

            coordSys.Add (Lao1997);
            Lao1997.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lao 1997", 4678));
            Lao1997.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Lao_1997", 4678));

            coordSys.Add (Jouik1961);
            Jouik1961.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Jouik 1961", 4679));
            Jouik1961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Jouik_1961", 4679));

            coordSys.Add (Nouakchott1965);
            Nouakchott1965.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nouakchott 1965", 4680));
            Nouakchott1965.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Nouakchott_1965", 4680));

            coordSys.Add (Gulshan303);
            Gulshan303.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Gulshan 303", 4682));
            Gulshan303.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Gulshan_303", 4682));

            coordSys.Add (PRS92);
            PRS92.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "PRS92", 4683));
            PRS92.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_PRS_1992", 4683));

            coordSys.Add (Gan1970);
            Gan1970.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Gan 1970", 4684));
            Gan1970.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Gan_1970", 4684));

            coordSys.Add (MAGNASIRGAS);
            MAGNASIRGAS.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "MAGNA-SIRGAS", 4686));
            MAGNASIRGAS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_MAGNA", 4686));

            coordSys.Add (RGPF);
            RGPF.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RGPF", 4687));
            RGPF.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RGPF", 4687));

            coordSys.Add (FatuIva72);
            FatuIva72.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Fatu Iva 72", 4688));
            FatuIva72.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Fatu_Iva_1972", 4688));

            coordSys.Add (IGN63HivaOa);
            IGN63HivaOa.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN63 Hiva Oa", 4689));
            IGN63HivaOa.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IGN63_Hiva_Oa", 4689));

            coordSys.Add (Tahiti79);
            Tahiti79.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tahiti 79", 4690));
            Tahiti79.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Tahiti_1979", 4690));

            coordSys.Add (Moorea87);
            Moorea87.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Moorea 87", 4691));
            Moorea87.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Moorea_1987", 4691));

            coordSys.Add (Maupiti83);
            Maupiti83.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Maupiti 83", 4692));
            Maupiti83.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Maupiti_1983", 4692));

            coordSys.Add (NakhleGhanem);
            NakhleGhanem.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nakhl-e Ghanem", 4693));
            NakhleGhanem.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Nakhl-e_Ghanem", 4693));

            coordSys.Add (POSGAR94);
            POSGAR94.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "POSGAR 94", 4694));
            POSGAR94.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_POSGAR_1994", 4694));

            coordSys.Add (Katanga1955);
            Katanga1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Katanga 1955", 4695));
            Katanga1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Katanga_1955", 4695));

            coordSys.Add (Kasai1953);
            Kasai1953.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kasai 1953", 4696));
            Kasai1953.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Kasai_1953", 4696));

            coordSys.Add (IGC19626thParallelSouth);
            IGC19626thParallelSouth.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGC 1962 6th Parallel South", 4697));
            IGC19626thParallelSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IGC_1962_6th_Parallel_South", 4697));

            coordSys.Add (IGN1962Kerguelen);
            IGN1962Kerguelen.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN 1962 Kerguelen", 4698));
            IGN1962Kerguelen.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Kerguelen_Island_1949", 4698));

            coordSys.Add (LePouce1934);
            LePouce1934.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Le Pouce 1934", 4699));
            LePouce1934.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Le_Pouce_1934", 4699));

            coordSys.Add (IGNAstro1960);
            IGNAstro1960.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGN Astro 1960", 4700));
            IGNAstro1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IGN_Astro_1960", 4700));

            coordSys.Add (IGCB1955);
            IGCB1955.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IGCB 1955", 4701));
            IGCB1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_IGCB_1955", 4701));

            coordSys.Add (Mauritania1999);
            Mauritania1999.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mauritania 1999", 4702));
            Mauritania1999.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Mauritania_1999", 4702));

            coordSys.Add (Mhast1951);
            Mhast1951.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mhast 1951", 4703));
            Mhast1951.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Mhast_1951", 4703));

            coordSys.Add (Mhastonshore);
            Mhastonshore.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mhast (onshore)", 4704));
            Mhastonshore.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Mhast_Onshore", 4704));

            coordSys.Add (Mhastoffshore);
            Mhastoffshore.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Mhast (offshore)", 4705));
            Mhastoffshore.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Mhast_Offshore", 4705));

            coordSys.Add (EgyptGulfofSuezS650TL);
            EgyptGulfofSuezS650TL.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Egypt Gulf of Suez S-650 TL", 4706));
            EgyptGulfofSuezS650TL.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Egypt_Gulf_of_Suez_S-650_TL", 4706));

            coordSys.Add (TernIsland1961);
            TernIsland1961.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tern Island 1961", 4707));
            TernIsland1961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Tern_Island_1961", 4707));

            coordSys.Add (CocosIslands1965);
            CocosIslands1965.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Cocos Islands 1965", 4708));
            CocosIslands1965.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Anna_1_1965", 4708));

            coordSys.Add (IwoJima1945);
            IwoJima1945.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Iwo Jima 1945", 4709));
            IwoJima1945.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Beacon_E_1945", 4709));

            coordSys.Add (StHelena1971);
            StHelena1971.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "St. Helena 1971", 4710));
            StHelena1971.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_DOS_71_4", 4710));

            coordSys.Add (MarcusIsland1952);
            MarcusIsland1952.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Marcus Island 1952", 4711));
            MarcusIsland1952.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Astro_1952", 4711));

            coordSys.Add (AscensionIsland1958);
            AscensionIsland1958.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ascension Island 1958", 4712));
            AscensionIsland1958.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Ascension_Island_1958", 4712));

            coordSys.Add (AyabelleLighthouse);
            AyabelleLighthouse.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ayabelle Lighthouse", 4713));
            AyabelleLighthouse.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Ayabelle", 4713));

            coordSys.Add (Bellevue);
            Bellevue.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bellevue", 4714));
            Bellevue.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bellevue_IGN", 4714));

            coordSys.Add (CampAreaAstro);
            CampAreaAstro.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Camp Area Astro", 4715));
            CampAreaAstro.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Camp_Area", 4715));

            coordSys.Add (PhoenixIslands1966);
            PhoenixIslands1966.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Phoenix Islands 1966", 4716));
            PhoenixIslands1966.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Canton_1966", 4716));

            coordSys.Add (CapeCanaveral);
            CapeCanaveral.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Cape Canaveral", 4717));
            CapeCanaveral.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Cape_Canaveral", 4717));

            coordSys.Add (Solomon1968);
            Solomon1968.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Solomon 1968", 4718));
            Solomon1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Solomon_1968", 4718));

            coordSys.Add (EasterIsland1967);
            EasterIsland1967.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Easter Island 1967", 4719));
            EasterIsland1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Easter_Island_1967", 4719));

            coordSys.Add (Fiji1986);
            Fiji1986.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Fiji 1986", 4720));
            Fiji1986.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Fiji_1986", 4720));

            coordSys.Add (Fiji1956);
            Fiji1956.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Fiji 1956", 4721));
            Fiji1956.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Fiji_1956", 4721));

            coordSys.Add (SouthGeorgia1968);
            SouthGeorgia1968.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "South Georgia 1968", 4722));
            SouthGeorgia1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ISTS_061_1968", 4722));

            coordSys.Add (GCGD59);
            GCGD59.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GCGD59", 4723));
            GCGD59.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Grand_Cayman_1959", 4723));

            coordSys.Add (DiegoGarcia1969);
            DiegoGarcia1969.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Diego Garcia 1969", 4724));
            DiegoGarcia1969.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ISTS_073_1969", 4724));

            coordSys.Add (JohnstonIsland1961);
            JohnstonIsland1961.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Johnston Island 1961", 4725));
            JohnstonIsland1961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Johnston_Island_1961", 4725));

            coordSys.Add (SIGD61);
            SIGD61.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SIGD61", 4726));
            SIGD61.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Little_Cayman_1961", 4726));

            coordSys.Add (Midway1961);
            Midway1961.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Midway 1961", 4727));
            Midway1961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Midway_1961", 4727));

            coordSys.Add (PicodelasNieves1984);
            PicodelasNieves1984.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pico de las Nieves 1984", 4728));
            PicodelasNieves1984.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Pico_de_Las_Nieves", 4728));

            coordSys.Add (Pitcairn1967);
            Pitcairn1967.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pitcairn 1967", 4729));
            Pitcairn1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Pitcairn_1967", 4729));

            coordSys.Add (Santo1965);
            Santo1965.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Santo 1965", 4730));
            Santo1965.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Santo_DOS_1965", 4730));

            coordSys.Add (MarshallIslands1960);
            MarshallIslands1960.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Marshall Islands 1960", 4732));
            MarshallIslands1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Wake_Eniwetok_1960", 4732));

            coordSys.Add (WakeIsland1952);
            WakeIsland1952.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Wake Island 1952", 4733));
            WakeIsland1952.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Wake_Island_1952", 4733));

            coordSys.Add (Tristan1968);
            Tristan1968.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tristan 1968", 4734));
            Tristan1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Tristan_1968", 4734));

            coordSys.Add (Kusaie1951);
            Kusaie1951.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kusaie 1951", 4735));
            Kusaie1951.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Kusaie_1951", 4735));

            coordSys.Add (DeceptionIsland);
            DeceptionIsland.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Deception Island", 4736));
            DeceptionIsland.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Deception_Island", 4736));

            coordSys.Add (Korea2000);
            Korea2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Korea 2000", 4737));
            Korea2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Korea_2000", 4737));

            coordSys.Add (HongKong1963);
            HongKong1963.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hong Kong 1963", 4738));
            HongKong1963.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hong_Kong_1963", 4738));

            coordSys.Add (HongKong196367);
            HongKong196367.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hong Kong 1963(67)", 4739));
            HongKong196367.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hong_Kong_1963_67", 4739));

            coordSys.Add (PZ90);
            PZ90.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "PZ-90", 4740));
            PZ90.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_PZ_1990", 4740));

            coordSys.Add (FD54);
            FD54.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "FD54", 4741));
            FD54.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_FD_1954", 4741));

            coordSys.Add (GDM2000);
            GDM2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GDM2000", 4742));
            GDM2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_GDM_2000", 4742));

            coordSys.Add (Karbala1979);
            Karbala1979.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Karbala 1979", 4743));
            Karbala1979.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Karbala_1979_Polservice", 4743));

            coordSys.Add (Nahrwan1934);
            Nahrwan1934.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Nahrwan 1934", 4744));
            Nahrwan1934.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Nahrwan_1934", 4744));

            coordSys.Add (GR96);
            GR96.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GR96", 4747));
            GR96.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Greenland_1996", 4747));

            coordSys.Add (VanuaLevu1915);
            VanuaLevu1915.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Vanua Levu 1915", 4748));
            VanuaLevu1915.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Vanua_Levu_1915", 4748));

            coordSys.Add (RGNC9193);
            RGNC9193.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RGNC91-93", 4749));
            RGNC9193.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RGNC_1991-93", 4749));

            coordSys.Add (ST87Ouvea);
            ST87Ouvea.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ST87 Ouvea", 4750));
            ST87Ouvea.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ST87_Ouvea", 4750));

            coordSys.Add (KertauRSO);
            KertauRSO.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Kertau (RSO)", 4751));
            KertauRSO.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Kertau_RSO", 4751));

            coordSys.Add (VitiLevu1912);
            VitiLevu1912.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Viti Levu 1912", 4752));
            VitiLevu1912.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Viti_Levu_1912", 4752));

            coordSys.Add (fk89);
            fk89.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "fk89", 4753));
            fk89.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_fk89", 4753));

            coordSys.Add (LGD2006);
            LGD2006.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "LGD2006", 4754));
            LGD2006.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_LGD2006", 4754));

            coordSys.Add (DGN95);
            DGN95.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "DGN95", 4755));
            DGN95.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_DGN_1995", 4755));

            coordSys.Add (VN2000);
            VN2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "VN-2000", 4756));
            VN2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_VN_2000", 4756));

            coordSys.Add (SVY21);
            SVY21.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SVY21", 4757));
            SVY21.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_SVY21", 4757));

            coordSys.Add (JAD2001);
            JAD2001.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "JAD2001", 4758));
            JAD2001.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_JAD_2001", 4758));

            coordSys.Add (NAD83NSRS2007);
            NAD83NSRS2007.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NAD83(NSRS2007)", 4759));
            NAD83NSRS2007.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_NSRS2007", 4759));

            coordSys.Add (WGS66);
            WGS66.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "WGS 66", 4760));
            WGS66.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_WGS_1966", 4760));

            coordSys.Add (HTRS96);
            HTRS96.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "HTRS96", 4761));
            HTRS96.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_HTRS96", 4761));

            coordSys.Add (BDA2000);
            BDA2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "BDA2000", 4762));
            BDA2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bermuda_2000", 4762));

            coordSys.Add (Pitcairn2006);
            Pitcairn2006.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Pitcairn 2006", 4763));
            Pitcairn2006.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Pitcairn_2006", 4763));

            coordSys.Add (RSRGD2000);
            RSRGD2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RSRGD2000", 4764));
            RSRGD2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RSRGD2000", 4764));

            coordSys.Add (Slovenia1996);
            Slovenia1996.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Slovenia 1996", 4765));
            Slovenia1996.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Slovenia_1996", 4765));

            coordSys.Add (Bern1898Bern);
            Bern1898Bern.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bern 1898 (Bern)", 4801));
            Bern1898Bern.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bern_1898_Bern", 4801));

            coordSys.Add (Bogota1975Bogota);
            Bogota1975Bogota.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bogota 1975 (Bogota)", 4802));
            Bogota1975Bogota.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bogota_Bogota", 4802));

            coordSys.Add (LisbonLisbon);
            LisbonLisbon.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lisbon (Lisbon)", 4803));
            LisbonLisbon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Lisbon_Lisbon", 4803));

            coordSys.Add (MakassarJakarta);
            MakassarJakarta.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Makassar (Jakarta)", 4804));
            MakassarJakarta.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Makassar_Jakarta", 4804));

            coordSys.Add (MGIFerro);
            MGIFerro.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "MGI (Ferro)", 4805));
            MGIFerro.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_MGI_Ferro", 4805));

            coordSys.Add (MonteMarioRome);
            MonteMarioRome.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Monte Mario (Rome)", 4806));
            MonteMarioRome.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Monte_Mario_Rome", 4806));

            coordSys.Add (NTFParis);
            NTFParis.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NTF (Paris)", 4807));
            NTFParis.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NTF_Paris", 4807));

            coordSys.Add (PadangJakarta);
            PadangJakarta.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Padang (Jakarta)", 4808));
            PadangJakarta.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Padang_1884_Jakarta", 4808));

            coordSys.Add (Belge1950Brussels);
            Belge1950Brussels.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Belge 1950 (Brussels)", 4809));
            Belge1950Brussels.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Belge_1950_Brussels", 4809));

            coordSys.Add (TananariveParis);
            TananariveParis.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tananarive (Paris)", 4810));
            TananariveParis.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Tananarive_1925_Paris", 4810));

            coordSys.Add (Voirol1875Paris);
            Voirol1875Paris.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Voirol 1875 (Paris)", 4811));
            Voirol1875Paris.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Voirol_1875_Paris", 4811));

            coordSys.Add (BataviaJakarta);
            BataviaJakarta.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Batavia (Jakarta)", 4813));
            BataviaJakarta.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Batavia_Jakarta", 4813));

            coordSys.Add (RT38Stockholm);
            RT38Stockholm.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RT38 (Stockholm)", 4814));
            RT38Stockholm.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RT38_Stockholm", 4814));

            coordSys.Add (GreekAthens);
            GreekAthens.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Greek (Athens)", 4815));
            GreekAthens.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Greek_Athens", 4815));

            coordSys.Add (CarthageParis);
            CarthageParis.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Carthage (Paris)", 4816));
            CarthageParis.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Carthage_Paris", 4816));

            coordSys.Add (NGO1948Oslo);
            NGO1948Oslo.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NGO 1948 (Oslo)", 4817));
            NGO1948Oslo.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NGO_1948_Oslo", 4817));

            coordSys.Add (SJTSKFerro);
            SJTSKFerro.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "S-JTSK (Ferro)", 4818));
            SJTSKFerro.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_S_JTSK_Ferro", 4818));

            coordSys.Add (SegaraJakarta);
            SegaraJakarta.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Segara (Jakarta)", 4820));
            SegaraJakarta.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Gunung_Segara_Jakarta", 4820));

            coordSys.Add (Voirol1879Paris);
            Voirol1879Paris.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Voirol 1879 (Paris)", 4821));
            Voirol1879Paris.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Voirol_1879_Paris", 4821));

            coordSys.Add (SaoTome);
            SaoTome.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sao Tome", 4823));
            SaoTome.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sao_Tome", 4823));

            coordSys.Add (Principe);
            Principe.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Principe", 4824));
            Principe.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Principe", 4824));

            coordSys.Add (ATFParis);
            ATFParis.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ATF (Paris)", 4901));
            ATFParis.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ATF_Paris", 4901));

            coordSys.Add (Madrid1870Madrid);
            Madrid1870Madrid.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Madrid 1870 (Madrid)", 4903));
            Madrid1870Madrid.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Madrid_1870_Madrid", 4903));

            coordSys.Add (Lisbon1890Lisbon);
            Lisbon1890Lisbon.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lisbon 1890 (Lisbon)", 4904));
            Lisbon1890Lisbon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Lisbon_1890_Lisbon", 4904));

            coordSys.Add (PTRA08);
            PTRA08.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "PTRA08", 5013));
            PTRA08.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_PTRA08", 5013));

            coordSys.Add (Tokyo1892);
            Tokyo1892.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Tokyo 1892", 5132));

            coordSys.Add (SJTSK05);
            SJTSK05.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "S-JTSK/05", 5228));
            SJTSK05.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_S_JTSK/05", 5228));

            coordSys.Add (SJTSK05Ferro);
            SJTSK05Ferro.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "S-JTSK/05 (Ferro)", 5229));
            SJTSK05Ferro.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_S_JTSK/05_Ferro", 5229));

            coordSys.Add (SLD99);
            SLD99.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SLD99", 5233));
            SLD99.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_SLD99", 5233));

            coordSys.Add (GDBD2009);
            GDBD2009.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GDBD2009", 5246));
            GDBD2009.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_GDBD2009", 5246));

            coordSys.Add (TUREF);
            TUREF.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "TUREF", 5252));
            TUREF.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_TUREF", 5252));

            coordSys.Add (DRUKREF03);
            DRUKREF03.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "DRUKREF 03", 5264));
            DRUKREF03.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_DRUKREF_03", 5264));

            coordSys.Add (ISN2004);
            ISN2004.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ISN2004", 5324));
            ISN2004.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ISN_2004", 5324));

            coordSys.Add (POSGAR2007);
            POSGAR2007.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "POSGAR 2007", 5340));
            POSGAR2007.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_POSGAR_2007", 5340));

            coordSys.Add (MARGEN);
            MARGEN.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "MARGEN", 5354));
            MARGEN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_MARGEN", 5354));

            coordSys.Add (SIRGASChile);
            SIRGASChile.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SIRGAS-Chile", 5360));
            SIRGASChile.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_SIRGAS-Chile", 5360));

            coordSys.Add (CR05);
            CR05.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "CR05", 5365));
            CR05.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_CR05", 5365));

            coordSys.Add (MACARIOSOLIS);
            MACARIOSOLIS.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "MACARIO SOLIS", 5371));
            MACARIOSOLIS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_MARCARIO_SOLIS", 5371));

            coordSys.Add (Peru96);
            Peru96.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Peru96", 5373));
            Peru96.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Peru96", 5373));

            coordSys.Add (SIRGASROU98);
            SIRGASROU98.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SIRGAS-ROU98", 5381));
            SIRGASROU98.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_SIRGAS-ROU98", 5381));

            coordSys.Add (SIRGASES20078);
            SIRGASES20078.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SIRGAS_ES2007.8", 5393));
            SIRGASES20078.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_SIRGAS_ES2007.8", 5393));

            coordSys.Add (Ocotepeque1935);
            Ocotepeque1935.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ocotepeque 1935", 5451));
            Ocotepeque1935.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Ocotepeque_1935", 5451));

            coordSys.Add (SibunGorge1922);
            SibunGorge1922.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sibun Gorge 1922", 5464));
            SibunGorge1922.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sibun_Gorge_1922", 5464));

            coordSys.Add (PanamaColon1911);
            PanamaColon1911.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Panama-Colon 1911", 5467));
            PanamaColon1911.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Panama-Colon_1911", 5467));

            coordSys.Add (RGAF09);
            RGAF09.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "RGAF09", 5489));
            RGAF09.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RGAF09", 5489));

            coordSys.Add (CorregoAlegre1961);
            CorregoAlegre1961.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Corrego Alegre 1961", 5524));
            CorregoAlegre1961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Corrego_Alegre_1961", 5524));

            coordSys.Add (SAD6996);
            SAD6996.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "SAD69(96)", 5527));
            SAD6996.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_SAD_1969_96", 5527));

            coordSys.Add (PNG94);
            PNG94.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "PNG94", 5546));
            PNG94.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_PNG94", 5546));

            coordSys.Add (UCS2000);
            UCS2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "UCS-2000", 5561));
            UCS2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Ukraine_2000", 5561));

            coordSys.Add (FEH2010);
            FEH2010.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "FEH2010", 5593));
            FEH2010.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_FEH2010", 5593));

            coordSys.Add (DBREF);
            DBREF.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "DB_REF", 5681));
            DBREF.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_DB_REF", 5681));

            coordSys.Add (TGD2005);
            TGD2005.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "TGD2005", 5886));
            TGD2005.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_TGD2005", 5886));

            coordSys.Add (CIGD11);
            CIGD11.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "CIGD11", 6135));

            coordSys.Add (Airy1830);
            Airy1830.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Airy_1830", 4001));

            coordSys.Add (AiryModified);
            AiryModified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Airy_Modified", 4002));

            coordSys.Add (Australian);
            Australian.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Australian", 4003));

            coordSys.Add (Bessel1841);
            Bessel1841.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bessel_1841", 4004));

            coordSys.Add (BesselModified);
            BesselModified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bessel_Modified", 4005));

            coordSys.Add (BesselNamibia);
            BesselNamibia.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bessel_Namibia", 4006));

            coordSys.Add (Clarke1858);
            Clarke1858.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Clarke_1858", 4007));

            coordSys.Add (Clarke1866);
            Clarke1866.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Clarke_1866", 4008));

            coordSys.Add (Clarke1866Michigan);
            Clarke1866Michigan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Clarke_1866_Michigan", 4009));

            coordSys.Add (Clarke1880Benoit);
            Clarke1880Benoit.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Clarke_1880_Benoit", 4010));

            coordSys.Add (Clarke1880IGN);
            Clarke1880IGN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Clarke_1880_IGN", 4011));

            coordSys.Add (Clarke1880RGS);
            Clarke1880RGS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Clarke_1880_RGS", 4012));

            coordSys.Add (Clarke1880Arc);
            Clarke1880Arc.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Clarke_1880_Arc", 4013));

            coordSys.Add (Clarke1880SGA);
            Clarke1880SGA.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Clarke_1880_SGA", 4014));

            coordSys.Add (EverestAdj1937);
            EverestAdj1937.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Everest_Adj_1937", 4015));

            coordSys.Add (Everestdef1967);
            Everestdef1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Everest_def_1967", 4016));

            coordSys.Add (EverestModified);
            EverestModified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Everest_Modified", 4018));

            coordSys.Add (GRS1980);
            GRS1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_GRS_1980", 4019));

            coordSys.Add (Helmert1906);
            Helmert1906.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Helmert_1906", 4020));

            coordSys.Add (Indonesian);
            Indonesian.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Indonesian", 4021));

            coordSys.Add (International1924);
            International1924.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_International_1924", 4022));

            coordSys.Add (NWL9D);
            NWL9D.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NWL_9D", 4025));

            coordSys.Add (Plessis1817);
            Plessis1817.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Plessis_1817", 4027));

            coordSys.Add (Struve1860);
            Struve1860.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Struve_1860", 4028));

            coordSys.Add (WarOffice);
            WarOffice.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_War_Office", 4029));

            coordSys.Add (GEM10C);
            GEM10C.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_GEM_10C", 4031));

            coordSys.Add (OSU86F);
            OSU86F.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_OSU_86F", 4032));

            coordSys.Add (OSU91A);
            OSU91A.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_OSU_91A", 4033));

            coordSys.Add (Clarke1880);
            Clarke1880.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Clarke_1880", 4034));

            coordSys.Add (Sphere);
            Sphere.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sphere", 4035));

            coordSys.Add (GRS1967);
            GRS1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_GRS_1967", 4036));

            coordSys.Add (Everest1830);
            Everest1830.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Everest_1830", 4042));

            coordSys.Add (Everestdef1962);
            Everestdef1962.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Everest_def_1962", 4044));

            coordSys.Add (Everestdef1975);
            Everestdef1975.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Everest_def_1975", 4045));

            coordSys.Add (SphereGRS1980Authalic);
            SphereGRS1980Authalic.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sphere_GRS_1980_Authalic", 4047));

            coordSys.Add (SphereClarke1866Authalic);
            SphereClarke1866Authalic.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sphere_Clarke_1866_Authalic", 4052));

            coordSys.Add (SphereInternational1924Authalic);
            SphereInternational1924Authalic.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sphere_International_1924_Authalic", 4053));

            coordSys.Add (Hughes1980);
            Hughes1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hughes_1980", 4054));

            coordSys.Add (Samboja);
            Samboja.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Samboja", 4125));

            coordSys.Add (POSGAR);
            POSGAR.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_POSGAR", 4172));

            coordSys.Add (Madeira1936);
            Madeira1936.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Madeira_1936", 4185));

            coordSys.Add (CotedIvoire);
            CotedIvoire.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Cote_d_Ivoire", 4226));

            coordSys.Add (Douala);
            Douala.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Douala", 4228));

            coordSys.Add (GuyaneFrancaise);
            GuyaneFrancaise.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Guyane_Francaise", 4235));

            coordSys.Add (Manoca);
            Manoca.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Manoca", 4260));

            coordSys.Add (Segora);
            Segora.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Segora", 4294));

            coordSys.Add (Sudan);
            Sudan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sudan", 4296));

            coordSys.Add (VoirolUnifie1960);
            VoirolUnifie1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Voirol_Unifie_1960", 4305));

            coordSys.Add (RGNC1991);
            RGNC1991.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RGNC_1991", 4645));

            coordSys.Add (PortoSanto1995);
            PortoSanto1995.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Porto_Santo_1995", 4663));

            coordSys.Add (VitiLevu1916);
            VitiLevu1916.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Viti_Levu_1916", 4731));

            coordSys.Add (RD83);
            RD83.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_RD/83", 4745));

            coordSys.Add (PD83);
            PD83.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_PD/83", 4746));

            coordSys.Add (VoirolUnifie1960Paris);
            VoirolUnifie1960Paris.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Voirol_Unifie_1960_Paris", 4812));

            coordSys.Add (NordSahara1959Paris);
            NordSahara1959Paris.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Nord_Sahara_1959_Paris", 4819));

            coordSys.Add (NorddeGuerreParis);
            NorddeGuerreParis.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Nord_de_Guerre_Paris", 4902));

            coordSys.Add (Fischer1960);
            Fischer1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Fischer_1960", 37002));

            coordSys.Add (Fischer1968);
            Fischer1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Fischer_1968", 37003));

            coordSys.Add (FischerModified);
            FischerModified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Fischer_Modified", 37004));

            coordSys.Add (Hough1960);
            Hough1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hough_1960", 37005));

            coordSys.Add (EverestModified1969);
            EverestModified1969.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Everest_Modified_1969", 37006));

            coordSys.Add (Walbeck);
            Walbeck.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Walbeck", 37007));

            coordSys.Add (SphereARCINFO);
            SphereARCINFO.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sphere_ARC_INFO", 37008));

            coordSys.Add (EverestBangladesh);
            EverestBangladesh.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Everest_Bangladesh", 37202));

            coordSys.Add (EverestIndiaNepal);
            EverestIndiaNepal.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Everest_India_Nepal", 37203));

            coordSys.Add (Oman);
            Oman.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Oman", 37206));

            coordSys.Add (SouthAsiaSingapore);
            SouthAsiaSingapore.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_South_Asia_Singapore", 37207));

            coordSys.Add (DOS1968);
            DOS1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_DOS_1968", 37218));

            coordSys.Add (GUX1);
            GUX1.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_GUX_1", 37221));

            coordSys.Add (CarthageGrad);
            CarthageGrad.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Carthage_Grad", 37225));

            coordSys.Add (FortThomas1955);
            FortThomas1955.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Fort_Thomas_1955", 37240));

            coordSys.Add (GraciosaBaseSW1948);
            GraciosaBaseSW1948.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Graciosa_Base_SW_1948", 37241));

            coordSys.Add (LC51961);
            LC51961.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_LC5_1961", 37243));

            coordSys.Add (ObservatorioMeteorologico1939);
            ObservatorioMeteorologico1939.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Observatorio_Meteorologico_1939", 37245));

            coordSys.Add (SaoBraz);
            SaoBraz.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sao_Braz", 37249));

            coordSys.Add (AlaskanIslands);
            AlaskanIslands.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Alaskan_Islands", 37260));

            coordSys.Add (JGD2011);
            JGD2011.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_JGD_2011", 104020));

            coordSys.Add (Estonia1937);
            Estonia1937.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Estonia_1937", 104101));

            coordSys.Add (Hermannskogel);
            Hermannskogel.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Hermannskogel", 104102));

            coordSys.Add (SierraLeone1960);
            SierraLeone1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sierra_Leone_1960", 104103));

            coordSys.Add (DatumLisboaBessel);
            DatumLisboaBessel.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Datum_Lisboa_Bessel", 104105));

            coordSys.Add (DatumLisboaHayford);
            DatumLisboaHayford.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Datum_Lisboa_Hayford", 104106));

            coordSys.Add (Pohnpei);
            Pohnpei.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Pohnpei", 104109));

            coordSys.Add (BabSouth);
            BabSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Bab_South", 104112));

            coordSys.Add (Majuro);
            Majuro.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Majuro", 104113));

            coordSys.Add (ITRF1988);
            ITRF1988.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_1988", 104115));

            coordSys.Add (ITRF1989);
            ITRF1989.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_1989", 104116));

            coordSys.Add (ITRF1990);
            ITRF1990.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_1990", 104117));

            coordSys.Add (ITRF1991);
            ITRF1991.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_1991", 104118));

            coordSys.Add (ITRF1992);
            ITRF1992.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_1992", 104119));

            coordSys.Add (ITRF1993);
            ITRF1993.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_1993", 104120));

            coordSys.Add (ITRF1994);
            ITRF1994.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_1994", 104121));

            coordSys.Add (ITRF1996);
            ITRF1996.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_1996", 104122));

            coordSys.Add (ITRF1997);
            ITRF1997.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_1997", 104123));

            coordSys.Add (ITRF2000);
            ITRF2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_2000", 104124));

            coordSys.Add (ObservatorioMeteorologico1965);
            ObservatorioMeteorologico1965.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Observatorio_Meteorologico_1965", 104126));

            coordSys.Add (Roma1940);
            Roma1940.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Roma_1940", 104127));

            coordSys.Add (SphereEMEP);
            SphereEMEP.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Sphere_EMEP", 104128));

            coordSys.Add (EUREFFIN);
            EUREFFIN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_EUREF_FIN", 104129));

            coordSys.Add (Jordan);
            Jordan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Jordan", 104130));

            coordSys.Add (D48);
            D48.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_D48", 104131));

            coordSys.Add (MONREF1997);
            MONREF1997.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_MONREF_1997", 104134));

            coordSys.Add (OldHawaiianIntl1924);
            OldHawaiianIntl1924.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Old_Hawaiian_Intl_1924", 104138));

            coordSys.Add (Voirol1875Grad);
            Voirol1875Grad.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Voirol_1875_Grad", 104139));

            coordSys.Add (Voirol1879Grad);
            Voirol1879Grad.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Voirol_1879_Grad", 104140));

            coordSys.Add (CGRS1993);
            CGRS1993.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_CGRS_1993", 104141));

            coordSys.Add (NAD19832011);
            NAD19832011.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_2011", 104145));

            coordSys.Add (NAD1983CORS96);
            NAD1983CORS96.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_CORS96", 104223));

            coordSys.Add (NepalNagarkot);
            NepalNagarkot.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Nepal_Nagarkot", 104256));

            coordSys.Add (ITRF2008);
            ITRF2008.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_2008", 104257));

            coordSys.Add (ETRF1989);
            ETRF1989.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ETRF_1989", 104258));

            coordSys.Add (NAD1983PACP00);
            NAD1983PACP00.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_PACP00", 104259));

            coordSys.Add (NAD1983MARP00);
            NAD1983MARP00.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_MARP00", 104260));

            coordSys.Add (MerchichDegree);
            MerchichDegree.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Merchich_Degree", 104261));

            coordSys.Add (NAD1983MA11);
            NAD1983MA11.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_MA11", 104286));

            coordSys.Add (NAD1983PA11);
            NAD1983PA11.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_PA11", 104287));

            coordSys.Add (VoirolUnifie1960Degree);
            VoirolUnifie1960Degree.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Voirol_Unifie_1960_Degree", 104305));

            coordSys.Add (NAD1983HARNAdjMNAnoka);
            NAD1983HARNAdjMNAnoka.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Anoka", 104700));

            coordSys.Add (NAD1983HARNAdjMNBecker);
            NAD1983HARNAdjMNBecker.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Becker", 104701));

            coordSys.Add (NAD1983HARNAdjMNBeltramiNorth);
            NAD1983HARNAdjMNBeltramiNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Beltrami_North", 104702));

            coordSys.Add (NAD1983HARNAdjMNBeltramiSouth);
            NAD1983HARNAdjMNBeltramiSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Beltrami_South", 104703));

            coordSys.Add (NAD1983HARNAdjMNBenton);
            NAD1983HARNAdjMNBenton.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Benton", 104704));

            coordSys.Add (NAD1983HARNAdjMNBigStone);
            NAD1983HARNAdjMNBigStone.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Big_Stone", 104705));

            coordSys.Add (NAD1983HARNAdjMNBlueEarth);
            NAD1983HARNAdjMNBlueEarth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Blue_Earth", 104706));

            coordSys.Add (NAD1983HARNAdjMNBrown);
            NAD1983HARNAdjMNBrown.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Brown", 104707));

            coordSys.Add (NAD1983HARNAdjMNCarlton);
            NAD1983HARNAdjMNCarlton.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Carlton", 104708));

            coordSys.Add (NAD1983HARNAdjMNCarver);
            NAD1983HARNAdjMNCarver.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Carver", 104709));

            coordSys.Add (NAD1983HARNAdjMNCassNorth);
            NAD1983HARNAdjMNCassNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Cass_North", 104710));

            coordSys.Add (NAD1983HARNAdjMNCassSouth);
            NAD1983HARNAdjMNCassSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Cass_South", 104711));

            coordSys.Add (NAD1983HARNAdjMNChippewa);
            NAD1983HARNAdjMNChippewa.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Chippewa", 104712));

            coordSys.Add (NAD1983HARNAdjMNChisago);
            NAD1983HARNAdjMNChisago.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Chisago", 104713));

            coordSys.Add (NAD1983HARNAdjMNCookNorth);
            NAD1983HARNAdjMNCookNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Cook_North", 104714));

            coordSys.Add (NAD1983HARNAdjMNCookSouth);
            NAD1983HARNAdjMNCookSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Cook_South", 104715));

            coordSys.Add (NAD1983HARNAdjMNCottonwood);
            NAD1983HARNAdjMNCottonwood.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Cottonwood", 104716));

            coordSys.Add (NAD1983HARNAdjMNCrowWing);
            NAD1983HARNAdjMNCrowWing.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Crow_Wing", 104717));

            coordSys.Add (NAD1983HARNAdjMNDakota);
            NAD1983HARNAdjMNDakota.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Dakota", 104718));

            coordSys.Add (NAD1983HARNAdjMNDodge);
            NAD1983HARNAdjMNDodge.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Dodge", 104719));

            coordSys.Add (NAD1983HARNAdjMNDouglas);
            NAD1983HARNAdjMNDouglas.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Douglas", 104720));

            coordSys.Add (NAD1983HARNAdjMNFaribault);
            NAD1983HARNAdjMNFaribault.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Faribault", 104721));

            coordSys.Add (NAD1983HARNAdjMNFillmore);
            NAD1983HARNAdjMNFillmore.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Fillmore", 104722));

            coordSys.Add (NAD1983HARNAdjMNFreeborn);
            NAD1983HARNAdjMNFreeborn.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Freeborn", 104723));

            coordSys.Add (NAD1983HARNAdjMNGoodhue);
            NAD1983HARNAdjMNGoodhue.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Goodhue", 104724));

            coordSys.Add (NAD1983HARNAdjMNGrant);
            NAD1983HARNAdjMNGrant.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Grant", 104725));

            coordSys.Add (NAD1983HARNAdjMNHennepin);
            NAD1983HARNAdjMNHennepin.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Hennepin", 104726));

            coordSys.Add (NAD1983HARNAdjMNHouston);
            NAD1983HARNAdjMNHouston.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Houston", 104727));

            coordSys.Add (NAD1983HARNAdjMNIsanti);
            NAD1983HARNAdjMNIsanti.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Isanti", 104728));

            coordSys.Add (NAD1983HARNAdjMNItascaNorth);
            NAD1983HARNAdjMNItascaNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Itasca_North", 104729));

            coordSys.Add (NAD1983HARNAdjMNItascaSouth);
            NAD1983HARNAdjMNItascaSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Itasca_South", 104730));

            coordSys.Add (NAD1983HARNAdjMNJackson);
            NAD1983HARNAdjMNJackson.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Jackson", 104731));

            coordSys.Add (NAD1983HARNAdjMNKanabec);
            NAD1983HARNAdjMNKanabec.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Kanabec", 104732));

            coordSys.Add (NAD1983HARNAdjMNKandiyohi);
            NAD1983HARNAdjMNKandiyohi.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Kandiyohi", 104733));

            coordSys.Add (NAD1983HARNAdjMNKittson);
            NAD1983HARNAdjMNKittson.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Kittson", 104734));

            coordSys.Add (NAD1983HARNAdjMNKoochiching);
            NAD1983HARNAdjMNKoochiching.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Koochiching", 104735));

            coordSys.Add (NAD1983HARNAdjMNLacQuiParle);
            NAD1983HARNAdjMNLacQuiParle.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Lac_Qui_Parle", 104736));

            coordSys.Add (NAD1983HARNAdjMNLakeoftheWoodsNorth);
            NAD1983HARNAdjMNLakeoftheWoodsNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Lake_of_the_Woods_North", 104737));

            coordSys.Add (NAD1983HARNAdjMNLakeoftheWoodsSouth);
            NAD1983HARNAdjMNLakeoftheWoodsSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Lake_of_the_Woods_South", 104738));

            coordSys.Add (NAD1983HARNAdjMNLeSueur);
            NAD1983HARNAdjMNLeSueur.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Le_Sueur", 104739));

            coordSys.Add (NAD1983HARNAdjMNLincoln);
            NAD1983HARNAdjMNLincoln.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Lincoln", 104740));

            coordSys.Add (NAD1983HARNAdjMNLyon);
            NAD1983HARNAdjMNLyon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Lyon", 104741));

            coordSys.Add (NAD1983HARNAdjMNMcLeod);
            NAD1983HARNAdjMNMcLeod.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_McLeod", 104742));

            coordSys.Add (NAD1983HARNAdjMNMahnomen);
            NAD1983HARNAdjMNMahnomen.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Mahnomen", 104743));

            coordSys.Add (NAD1983HARNAdjMNMarshall);
            NAD1983HARNAdjMNMarshall.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Marshall", 104744));

            coordSys.Add (NAD1983HARNAdjMNMartin);
            NAD1983HARNAdjMNMartin.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Martin", 104745));

            coordSys.Add (NAD1983HARNAdjMNMeeker);
            NAD1983HARNAdjMNMeeker.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Meeker", 104746));

            coordSys.Add (NAD1983HARNAdjMNMorrison);
            NAD1983HARNAdjMNMorrison.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Morrison", 104747));

            coordSys.Add (NAD1983HARNAdjMNMower);
            NAD1983HARNAdjMNMower.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Mower", 104748));

            coordSys.Add (NAD1983HARNAdjMNMurray);
            NAD1983HARNAdjMNMurray.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Murray", 104749));

            coordSys.Add (NAD1983HARNAdjMNNicollet);
            NAD1983HARNAdjMNNicollet.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Nicollet", 104750));

            coordSys.Add (NAD1983HARNAdjMNNobles);
            NAD1983HARNAdjMNNobles.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Nobles", 104751));

            coordSys.Add (NAD1983HARNAdjMNNorman);
            NAD1983HARNAdjMNNorman.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Norman", 104752));

            coordSys.Add (NAD1983HARNAdjMNOlmsted);
            NAD1983HARNAdjMNOlmsted.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Olmsted", 104753));

            coordSys.Add (NAD1983HARNAdjMNOttertail);
            NAD1983HARNAdjMNOttertail.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Ottertail", 104754));

            coordSys.Add (NAD1983HARNAdjMNPennington);
            NAD1983HARNAdjMNPennington.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Pennington", 104755));

            coordSys.Add (NAD1983HARNAdjMNPine);
            NAD1983HARNAdjMNPine.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Pine", 104756));

            coordSys.Add (NAD1983HARNAdjMNPipestone);
            NAD1983HARNAdjMNPipestone.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Pipestone", 104757));

            coordSys.Add (NAD1983HARNAdjMNPolk);
            NAD1983HARNAdjMNPolk.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Polk", 104758));

            coordSys.Add (NAD1983HARNAdjMNPope);
            NAD1983HARNAdjMNPope.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Pope", 104759));

            coordSys.Add (NAD1983HARNAdjMNRamsey);
            NAD1983HARNAdjMNRamsey.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Ramsey", 104760));

            coordSys.Add (NAD1983HARNAdjMNRedLake);
            NAD1983HARNAdjMNRedLake.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Red_Lake", 104761));

            coordSys.Add (NAD1983HARNAdjMNRedwood);
            NAD1983HARNAdjMNRedwood.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Redwood", 104762));

            coordSys.Add (NAD1983HARNAdjMNRenville);
            NAD1983HARNAdjMNRenville.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Renville", 104763));

            coordSys.Add (NAD1983HARNAdjMNRice);
            NAD1983HARNAdjMNRice.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Rice", 104764));

            coordSys.Add (NAD1983HARNAdjMNRock);
            NAD1983HARNAdjMNRock.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Rock", 104765));

            coordSys.Add (NAD1983HARNAdjMNRoseau);
            NAD1983HARNAdjMNRoseau.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Roseau", 104766));

            coordSys.Add (NAD1983HARNAdjMNStLouisNorth);
            NAD1983HARNAdjMNStLouisNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_St_Louis_North", 104767));

            coordSys.Add (NAD1983HARNAdjMNStLouisCentral);
            NAD1983HARNAdjMNStLouisCentral.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_St_Louis_Central", 104768));

            coordSys.Add (NAD1983HARNAdjMNStLouisSouth);
            NAD1983HARNAdjMNStLouisSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_St_Louis_South", 104769));

            coordSys.Add (NAD1983HARNAdjMNScott);
            NAD1983HARNAdjMNScott.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Scott", 104770));

            coordSys.Add (NAD1983HARNAdjMNSherburne);
            NAD1983HARNAdjMNSherburne.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Sherburne", 104771));

            coordSys.Add (NAD1983HARNAdjMNSibley);
            NAD1983HARNAdjMNSibley.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Sibley", 104772));

            coordSys.Add (NAD1983HARNAdjMNStearns);
            NAD1983HARNAdjMNStearns.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Stearns", 104773));

            coordSys.Add (NAD1983HARNAdjMNSteele);
            NAD1983HARNAdjMNSteele.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Steele", 104774));

            coordSys.Add (NAD1983HARNAdjMNStevens);
            NAD1983HARNAdjMNStevens.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Stevens", 104775));

            coordSys.Add (NAD1983HARNAdjMNSwift);
            NAD1983HARNAdjMNSwift.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Swift", 104776));

            coordSys.Add (NAD1983HARNAdjMNTodd);
            NAD1983HARNAdjMNTodd.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Todd", 104777));

            coordSys.Add (NAD1983HARNAdjMNTraverse);
            NAD1983HARNAdjMNTraverse.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Traverse", 104778));

            coordSys.Add (NAD1983HARNAdjMNWabasha);
            NAD1983HARNAdjMNWabasha.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Wabasha", 104779));

            coordSys.Add (NAD1983HARNAdjMNWadena);
            NAD1983HARNAdjMNWadena.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Wadena", 104780));

            coordSys.Add (NAD1983HARNAdjMNWaseca);
            NAD1983HARNAdjMNWaseca.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Waseca", 104781));

            coordSys.Add (NAD1983HARNAdjMNWatonwan);
            NAD1983HARNAdjMNWatonwan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Watonwan", 104782));

            coordSys.Add (NAD1983HARNAdjMNWinona);
            NAD1983HARNAdjMNWinona.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Winona", 104783));

            coordSys.Add (NAD1983HARNAdjMNWright);
            NAD1983HARNAdjMNWright.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Wright", 104784));

            coordSys.Add (NAD1983HARNAdjMNYellowMedicine);
            NAD1983HARNAdjMNYellowMedicine.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_Yellow_Medicine", 104785));

            coordSys.Add (NAD1983HARNAdjMNStLouis);
            NAD1983HARNAdjMNStLouis.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_NAD_1983_HARN_Adj_MN_St_Louis", 104786));

            coordSys.Add (ITRF2005);
            ITRF2005.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_ITRF_2005", 104896));

            coordSys.Add (Venus1985);
            Venus1985.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Venus_1985", 104901));

            coordSys.Add (Venus2000);
            Venus2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GCS_Venus_2000", 104902));
        }


        public override IList <IGeographicCRS> All
        {
            get { return coordSys; }
        }

        public static GeographicCRSRegistry Instance
        {
            get { return instance ?? (instance = new GeographicCRSRegistry ()); }
        }
    }
}