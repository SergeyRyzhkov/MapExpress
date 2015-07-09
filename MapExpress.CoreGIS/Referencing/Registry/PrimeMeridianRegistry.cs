#region

using System.Collections.Generic;
using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.Registry
{
    public class PrimeMeridianRegistry : AuthorityObjectRegistry <IPrimeMeridian>
    {
        private static readonly List <IPrimeMeridian> meridians = new List <IPrimeMeridian> ();
        private static PrimeMeridianRegistry instance;

        public IPrimeMeridian Athens = new PrimeMeridian
                                           {
                                               Name = "Athens",
                                               Longitude = 23.7163375
                                           };

        public IPrimeMeridian Bern = new PrimeMeridian
                                         {
                                             Name = "Bern",
                                             Longitude = 7.43958333333333
                                         };

        public IPrimeMeridian Bogota = new PrimeMeridian
                                           {
                                               Name = "Bogota",
                                               Longitude = -74.0809166666667
                                           };

        public IPrimeMeridian Brussels = new PrimeMeridian
                                             {
                                                 Name = "Brussels",
                                                 Longitude = 4.367975
                                             };

        public IPrimeMeridian Ferro = new PrimeMeridian
                                          {
                                              Name = "Ferro",
                                              Longitude = -17.6666666666667
                                          };

        public IPrimeMeridian Greenwich = new PrimeMeridian
                                              {
                                                  Name = "Greenwich",
                                                  Longitude = 0
                                              };

        public IPrimeMeridian Jakarta = new PrimeMeridian
                                            {
                                                Name = "Jakarta",
                                                Longitude = 106.807719444444
                                            };

        public IPrimeMeridian Lisbon = new PrimeMeridian
                                           {
                                               Name = "Lisbon",
                                               Longitude = -9.13190611111111
                                           };

        public IPrimeMeridian Madrid = new PrimeMeridian
                                           {
                                               Name = "Madrid",
                                               Longitude = -2.33720833333333
                                           };

        public IPrimeMeridian Oslo = new PrimeMeridian
                                         {
                                             Name = "Oslo",
                                             Longitude = 10.7229166666667
                                         };

        public IPrimeMeridian Paris = new PrimeMeridian
                                          {
                                              Name = "Paris",
                                              Longitude = 2.33722916666667
                                          };

        public IPrimeMeridian ParisRGS = new PrimeMeridian
                                             {
                                                 Name = "ParisRGS",
                                                 Longitude = 2.33720833333333
                                             };

        public IPrimeMeridian Rome = new PrimeMeridian
                                         {
                                             Name = "Rome",
                                             Longitude = 12.4523333333333
                                         };

        public IPrimeMeridian Stockholm = new PrimeMeridian
                                              {
                                                  Name = "Stockholm",
                                                  Longitude = 18.0582777777778
                                              };

        private PrimeMeridianRegistry ()
        {
            meridians.Add (Greenwich);
            Greenwich.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Greenwich", 8901));
            Greenwich.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Greenwich", 0));
            Greenwich.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Reference_Meridian", 0));
            Greenwich.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "Greenwich", 0));

            meridians.Add (Lisbon);
            Lisbon.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Lisbon", 8902));
            Lisbon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Lisbon", 0));
            Lisbon.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "lisbon", 0));

            meridians.Add (Paris);
            Paris.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Paris", 8903));
            Paris.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Paris", 0));
            Paris.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "paris", 0));

            meridians.Add (Bogota);
            Bogota.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bogota", 8904));
            Bogota.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Bogota", 0));
            Bogota.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "bogota", 0));

            meridians.Add (Madrid);
            Madrid.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Madrid", 8905));
            Madrid.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Madrid", 0));
            Madrid.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "madrid", 0));

            meridians.Add (Rome);
            Rome.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Rome", 8906));
            Rome.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Rome", 0));
            Rome.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "rome", 0));

            meridians.Add (Bern);
            Bern.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bern", 8907));
            Bern.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Bern", 0));
            Bern.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "bern", 0));

            meridians.Add (Jakarta);
            Jakarta.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Jakarta", 8908));
            Jakarta.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Jakarta", 0));
            Jakarta.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "jakarta", 0));

            meridians.Add (Ferro);
            Ferro.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Ferro", 8909));
            Ferro.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Ferro", 0));
            Ferro.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "ferro", 0));

            meridians.Add (Brussels);
            Brussels.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Brussels", 8910));
            Brussels.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Brussels", 0));
            Brussels.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "brussels", 0));

            meridians.Add (Stockholm);
            Stockholm.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Stockholm", 8911));
            Stockholm.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Stockholm", 0));
            Stockholm.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "stockholm", 0));

            meridians.Add (Athens);
            Athens.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Athens", 8912));
            Athens.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Athens", 0));
            Athens.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "athens", 0));

            meridians.Add (Oslo);
            Oslo.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Oslo", 8913));
            Oslo.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Oslo", 0));
            Oslo.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "oslo", 0));

            meridians.Add (ParisRGS);
            ParisRGS.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "ParisRGS", 8914));
            ParisRGS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Paris_RGS", 0));
        }


        public static PrimeMeridianRegistry Instance
        {
            get { return instance ?? (instance = new PrimeMeridianRegistry ()); }
        }


        public override IList <IPrimeMeridian> All
        {
            get { return meridians; }
        }
    }
}