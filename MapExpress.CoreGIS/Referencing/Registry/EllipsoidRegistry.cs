using System.Collections.Generic;
using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

namespace MapExpress.CoreGIS.Referencing.Registry
{
    public class EllipsoidRegistry : AuthorityObjectRegistry <IEllipsoid>
    {
        private static readonly List <IEllipsoid> ellipsoids = new List <IEllipsoid> ();
        private static EllipsoidRegistry instance;

        public IEllipsoid APL49 = new Ellipsoid
                                      {
                                          Name = "APL4.9",
                                          SemiMajorAxis = 6378137,
                                          InverseFlattening = 298.25
                                      };

        public IEllipsoid ATS1977 = new Ellipsoid
                                        {
                                            Name = "ATS_1977",
                                            SemiMajorAxis = 6378135,
                                            InverseFlattening = 298.257
                                        };

        public IEllipsoid Airy1830 = new Ellipsoid
                                         {
                                             Name = "Airy 1830",
                                             SemiMajorAxis = 6377563.396,
                                             InverseFlattening = 299.3249646
                                         };

        public IEllipsoid AiryModified = new Ellipsoid
                                             {
                                                 Name = "Airy_Modified",
                                                 SemiMajorAxis = 6377340.189,
                                                 InverseFlattening = 299.3249646
                                             };

        public IEllipsoid AiryModified1849 = new Ellipsoid
                                                 {
                                                     Name = "Airy Modified 1849",
                                                     SemiMajorAxis = 6377340.189,
                                                     InverseFlattening = 299.3249646
                                                 };

        public IEllipsoid Australian = new Ellipsoid
                                           {
                                               Name = "Australian",
                                               SemiMajorAxis = 6378160,
                                               InverseFlattening = 298.25
                                           };

        public IEllipsoid AustralianNationalSpheroid = new Ellipsoid
                                                           {
                                                               Name = "Australian National Spheroid",
                                                               SemiMajorAxis = 6378160,
                                                               InverseFlattening = 298.25
                                                           };

        public IEllipsoid AverageTerrestrialSystem1977 = new Ellipsoid
                                                             {
                                                                 Name = "Average Terrestrial System 1977",
                                                                 SemiMajorAxis = 6378135,
                                                                 InverseFlattening = 298.257
                                                             };

        public IEllipsoid Bessel1841 = new Ellipsoid
                                           {
                                               Name = "Bessel 1841",
                                               SemiMajorAxis = 6377397.155,
                                               InverseFlattening = 299.1528128
                                           };

        public IEllipsoid BesselModified = new Ellipsoid
                                               {
                                                   Name = "Bessel Modified",
                                                   SemiMajorAxis = 6377492.018,
                                                   InverseFlattening = 299.1528128
                                               };

        public IEllipsoid BesselNamibia = new Ellipsoid
                                              {
                                                  Name = "Bessel Namibia",
                                                  SemiMajorAxis = 6377483.865,
                                                  InverseFlattening = 299.1528128
                                              };

        public IEllipsoid BesselNamibiaGLM = new Ellipsoid
                                                 {
                                                     Name = "Bessel Namibia (GLM)",
                                                     SemiMajorAxis = 6377397.155,
                                                     InverseFlattening = 299.1528128
                                                 };

        public IEllipsoid CGCS2000 = new Ellipsoid
                                         {
                                             Name = "CGCS2000",
                                             SemiMajorAxis = 6378137,
                                             InverseFlattening = 298.257222101
                                         };

        public IEllipsoid CPM = new Ellipsoid
                                    {
                                        Name = "CPM",
                                        SemiMajorAxis = 6375738.7,
                                        InverseFlattening = 334.29
                                    };

        public IEllipsoid Clarke1858 = new Ellipsoid
                                           {
                                               Name = "Clarke 1858",
                                               SemiMajorAxis = 6378293.645,
                                               InverseFlattening = 294.26068
                                           };

        public IEllipsoid Clarke1866 = new Ellipsoid
                                           {
                                               Name = "Clarke 1866",
                                               SemiMajorAxis = 6378206.4,
                                               InverseFlattening = 293.978698213898
                                           };

        public IEllipsoid Clarke1866AuthalicSphere = new Ellipsoid
                                                         {
                                                             Name = "Clarke 1866 Authalic Sphere",
                                                             SemiMajorAxis = 6370997,
                                                             InverseFlattening = 0
                                                         };

        public IEllipsoid Clarke1866Michigan = new Ellipsoid
                                                   {
                                                       Name = "Clarke_1866_Michigan",
                                                       SemiMajorAxis = 6378450.047,
                                                       InverseFlattening = 294.978684677
                                                   };

        public IEllipsoid Clarke1880 = new Ellipsoid
                                           {
                                               Name = "Clarke_1880",
                                               SemiMajorAxis = 6378249.14480801,
                                               InverseFlattening = 293.466307655625
                                           };

        public IEllipsoid Clarke1880Arc = new Ellipsoid
                                              {
                                                  Name = "Clarke 1880 (Arc)",
                                                  SemiMajorAxis = 6378249.145,
                                                  InverseFlattening = 293.4663077
                                              };

        public IEllipsoid Clarke1880Benoit = new Ellipsoid
                                                 {
                                                     Name = "Clarke 1880 (Benoit)",
                                                     SemiMajorAxis = 6378300.789,
                                                     InverseFlattening = 0
                                                 };

        public IEllipsoid Clarke1880IGN = new Ellipsoid
                                              {
                                                  Name = "Clarke 1880 (IGN)",
                                                  SemiMajorAxis = 6378249.2,
                                                  InverseFlattening = 0
                                              };

        public IEllipsoid Clarke1880IntlFt = new Ellipsoid
                                                 {
                                                     Name = "Clarke_1880_Intl_Ft",
                                                     SemiMajorAxis = 6378306.3696,
                                                     InverseFlattening = 293.46630765563
                                                 };

        public IEllipsoid Clarke1880RGS = new Ellipsoid
                                              {
                                                  Name = "Clarke 1880 (RGS)",
                                                  SemiMajorAxis = 6378249.145,
                                                  InverseFlattening = 293.465
                                              };

        public IEllipsoid Clarke1880SGA = new Ellipsoid
                                              {
                                                  Name = "Clarke_1880_SGA",
                                                  SemiMajorAxis = 6378249.2,
                                                  InverseFlattening = 293.46598
                                              };

        public IEllipsoid Clarke1880SGA1922 = new Ellipsoid
                                                  {
                                                      Name = "Clarke 1880 (SGA 1922)",
                                                      SemiMajorAxis = 6378249.2,
                                                      InverseFlattening = 293.46598
                                                  };

        public IEllipsoid Clarke1880internationalfoot = new Ellipsoid
                                                            {
                                                                Name = "Clarke 1880 (international foot)",
                                                                SemiMajorAxis = 6378306.37,
                                                                InverseFlattening = 293.4663077
                                                            };

        public IEllipsoid Danish1876 = new Ellipsoid
                                           {
                                               Name = "Danish 1876",
                                               SemiMajorAxis = 6377019.27,
                                               InverseFlattening = 300
                                           };

        public IEllipsoid Everest1830 = new Ellipsoid
                                            {
                                                Name = "Everest_1830",
                                                SemiMajorAxis = 6377299.36,
                                                InverseFlattening = 300.8017
                                            };

        public IEllipsoid Everest18301937Adjustment = new Ellipsoid
                                                          {
                                                              Name = "Everest 1830 (1937 Adjustment)",
                                                              SemiMajorAxis = 6377276.345,
                                                              InverseFlattening = 300.8017
                                                          };

        public IEllipsoid Everest18301962Definition = new Ellipsoid
                                                          {
                                                              Name = "Everest 1830 (1962 Definition)",
                                                              SemiMajorAxis = 6377301.243,
                                                              InverseFlattening = 300.8017255
                                                          };

        public IEllipsoid Everest18301967Definition = new Ellipsoid
                                                          {
                                                              Name = "Everest 1830 (1967 Definition)",
                                                              SemiMajorAxis = 6377298.556,
                                                              InverseFlattening = 300.8017
                                                          };

        public IEllipsoid Everest18301975Definition = new Ellipsoid
                                                          {
                                                              Name = "Everest 1830 (1975 Definition)",
                                                              SemiMajorAxis = 6377299.151,
                                                              InverseFlattening = 300.8017255
                                                          };

        public IEllipsoid Everest1830Modified = new Ellipsoid
                                                    {
                                                        Name = "Everest 1830 Modified",
                                                        SemiMajorAxis = 6377304.063,
                                                        InverseFlattening = 300.8017
                                                    };

        public IEllipsoid Everest1830RSO1969 = new Ellipsoid
                                                   {
                                                       Name = "Everest 1830 (RSO 1969)",
                                                       SemiMajorAxis = 6377295.664,
                                                       InverseFlattening = 300.8017
                                                   };

        public IEllipsoid EverestAdjustment1937 = new Ellipsoid
                                                      {
                                                          Name = "Everest_Adjustment_1937",
                                                          SemiMajorAxis = 6377276.345,
                                                          InverseFlattening = 300.8017
                                                      };

        public IEllipsoid EverestDefinition1962 = new Ellipsoid
                                                      {
                                                          Name = "Everest_Definition_1962",
                                                          SemiMajorAxis = 6377301.243,
                                                          InverseFlattening = 300.8017255
                                                      };

        public IEllipsoid EverestDefinition1967 = new Ellipsoid
                                                      {
                                                          Name = "Everest_Definition_1967",
                                                          SemiMajorAxis = 6377298.556,
                                                          InverseFlattening = 300.8017
                                                      };

        public IEllipsoid EverestDefinition1975 = new Ellipsoid
                                                      {
                                                          Name = "Everest_Definition_1975",
                                                          SemiMajorAxis = 6377299.151,
                                                          InverseFlattening = 300.8017255
                                                      };

        public IEllipsoid EverestModified1969 = new Ellipsoid
                                                    {
                                                        Name = "Everest_Modified_1969",
                                                        SemiMajorAxis = 6377295.664,
                                                        InverseFlattening = 300.8017
                                                    };

        public IEllipsoid Fischer1960 = new Ellipsoid
                                            {
                                                Name = "Fischer_1960",
                                                SemiMajorAxis = 6378166,
                                                InverseFlattening = 298.3
                                            };

        public IEllipsoid Fischer1968 = new Ellipsoid
                                            {
                                                Name = "Fischer_1968",
                                                SemiMajorAxis = 6378150,
                                                InverseFlattening = 298.3
                                            };

        public IEllipsoid FischerModified = new Ellipsoid
                                                {
                                                    Name = "Fischer_Modified",
                                                    SemiMajorAxis = 6378155,
                                                    InverseFlattening = 298.3
                                                };

        public IEllipsoid GEM10C = new Ellipsoid
                                       {
                                           Name = "GEM 10C",
                                           SemiMajorAxis = 6378137,
                                           InverseFlattening = 298.257223563
                                       };

        public IEllipsoid GRS1967 = new Ellipsoid
                                        {
                                            Name = "GRS_1967",
                                            SemiMajorAxis = 6378160,
                                            InverseFlattening = 298.247167427
                                        };

        public IEllipsoid GRS1967Modified = new Ellipsoid
                                                {
                                                    Name = "GRS 1967 Modified",
                                                    SemiMajorAxis = 6378160,
                                                    InverseFlattening = 298.25
                                                };

        public IEllipsoid GRS1967Truncated = new Ellipsoid
                                                 {
                                                     Name = "GRS_1967_Truncated",
                                                     SemiMajorAxis = 6378160,
                                                     InverseFlattening = 298.25
                                                 };

        public IEllipsoid GRS1980 = new Ellipsoid
                                        {
                                            Name = "GRS 1980",
                                            SemiMajorAxis = 6378137,
                                            InverseFlattening = 298.257222101
                                        };

        public IEllipsoid GRS1980AdjMNAnoka = new Ellipsoid
                                                  {
                                                      Name = "S_GRS_1980_Adj_MN_Anoka",
                                                      SemiMajorAxis = 6378418.941,
                                                      InverseFlattening = 298.257222100883
                                                  };

        public IEllipsoid GRS1980AdjMNBecker = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Becker",
                                                       SemiMajorAxis = 6378586.581,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNBeltramiNorth = new Ellipsoid
                                                          {
                                                              Name = "S_GRS_1980_Adj_MN_Beltrami_North",
                                                              SemiMajorAxis = 6378505.809,
                                                              InverseFlattening = 298.257222100883
                                                          };

        public IEllipsoid GRS1980AdjMNBeltramiSouth = new Ellipsoid
                                                          {
                                                              Name = "S_GRS_1980_Adj_MN_Beltrami_South",
                                                              SemiMajorAxis = 6378544.823,
                                                              InverseFlattening = 298.257222100883
                                                          };

        public IEllipsoid GRS1980AdjMNBenton = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Benton",
                                                       SemiMajorAxis = 6378490.569,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNBigStone = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Big_Stone",
                                                         SemiMajorAxis = 6378470.757,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNBlueEarth = new Ellipsoid
                                                      {
                                                          Name = "S_GRS_1980_Adj_MN_Blue_Earth",
                                                          SemiMajorAxis = 6378403.701,
                                                          InverseFlattening = 298.257222100883
                                                      };

        public IEllipsoid GRS1980AdjMNBrown = new Ellipsoid
                                                  {
                                                      Name = "S_GRS_1980_Adj_MN_Brown",
                                                      SemiMajorAxis = 6378434.181,
                                                      InverseFlattening = 298.257222100883
                                                  };

        public IEllipsoid GRS1980AdjMNCarlton = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Carlton",
                                                        SemiMajorAxis = 6378454.907,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNCarver = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Carver",
                                                       SemiMajorAxis = 6378400.653,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNCassNorth = new Ellipsoid
                                                      {
                                                          Name = "S_GRS_1980_Adj_MN_Cass_North",
                                                          SemiMajorAxis = 6378567.378,
                                                          InverseFlattening = 298.257222100883
                                                      };

        public IEllipsoid GRS1980AdjMNCassSouth = new Ellipsoid
                                                      {
                                                          Name = "S_GRS_1980_Adj_MN_Cass_South",
                                                          SemiMajorAxis = 6378546.957,
                                                          InverseFlattening = 298.257222100883
                                                      };

        public IEllipsoid GRS1980AdjMNChippewa = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Chippewa",
                                                         SemiMajorAxis = 6378476.853,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNChisago = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Chisago",
                                                        SemiMajorAxis = 6378411.321,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNCookNorth = new Ellipsoid
                                                      {
                                                          Name = "S_GRS_1980_Adj_MN_Cook_North",
                                                          SemiMajorAxis = 6378647.541,
                                                          InverseFlattening = 298.257222100883
                                                      };

        public IEllipsoid GRS1980AdjMNCookSouth = new Ellipsoid
                                                      {
                                                          Name = "S_GRS_1980_Adj_MN_Cook_South",
                                                          SemiMajorAxis = 6378647.541,
                                                          InverseFlattening = 298.257222100883
                                                      };

        public IEllipsoid GRS1980AdjMNCottonwood = new Ellipsoid
                                                       {
                                                           Name = "S_GRS_1980_Adj_MN_Cottonwood",
                                                           SemiMajorAxis = 6378514.953,
                                                           InverseFlattening = 298.257222100883
                                                       };

        public IEllipsoid GRS1980AdjMNCrowWing = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Crow_Wing",
                                                         SemiMajorAxis = 6378546.957,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNDakota = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Dakota",
                                                       SemiMajorAxis = 6378421.989,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNDodge = new Ellipsoid
                                                  {
                                                      Name = "S_GRS_1980_Adj_MN_Dodge",
                                                      SemiMajorAxis = 6378481.425,
                                                      InverseFlattening = 298.257222100883
                                                  };

        public IEllipsoid GRS1980AdjMNDouglas = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Douglas",
                                                        SemiMajorAxis = 6378518.001,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNFaribault = new Ellipsoid
                                                      {
                                                          Name = "S_GRS_1980_Adj_MN_Faribault",
                                                          SemiMajorAxis = 6378521.049,
                                                          InverseFlattening = 298.257222100883
                                                      };

        public IEllipsoid GRS1980AdjMNFillmore = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Fillmore",
                                                         SemiMajorAxis = 6378464.661,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNFreeborn = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Freeborn",
                                                         SemiMajorAxis = 6378521.049,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNGoodhue = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Goodhue",
                                                        SemiMajorAxis = 6378434.181,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNGrant = new Ellipsoid
                                                  {
                                                      Name = "S_GRS_1980_Adj_MN_Grant",
                                                      SemiMajorAxis = 6378518.001,
                                                      InverseFlattening = 298.257222100883
                                                  };

        public IEllipsoid GRS1980AdjMNHennepin = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Hennepin",
                                                         SemiMajorAxis = 6378418.941,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNHouston = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Houston",
                                                        SemiMajorAxis = 6378436.619,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNIsanti = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Isanti",
                                                       SemiMajorAxis = 6378411.321,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNItascaNorth = new Ellipsoid
                                                        {
                                                            Name = "S_GRS_1980_Adj_MN_Itasca_North",
                                                            SemiMajorAxis = 6378574.389,
                                                            InverseFlattening = 298.257222100883
                                                        };

        public IEllipsoid GRS1980AdjMNItascaSouth = new Ellipsoid
                                                        {
                                                            Name = "S_GRS_1980_Adj_MN_Itasca_South",
                                                            SemiMajorAxis = 6378574.389,
                                                            InverseFlattening = 298.257222100883
                                                        };

        public IEllipsoid GRS1980AdjMNJackson = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Jackson",
                                                        SemiMajorAxis = 6378521.049,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNKanabec = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Kanabec",
                                                        SemiMajorAxis = 6378472.281,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNKandiyohi = new Ellipsoid
                                                      {
                                                          Name = "S_GRS_1980_Adj_MN_Kandiyohi",
                                                          SemiMajorAxis = 6378498.189,
                                                          InverseFlattening = 298.257222100883
                                                      };

        public IEllipsoid GRS1980AdjMNKittson = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Kittson",
                                                        SemiMajorAxis = 6378449.421,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNKoochiching = new Ellipsoid
                                                        {
                                                            Name = "S_GRS_1980_Adj_MN_Koochiching",
                                                            SemiMajorAxis = 6378525.621,
                                                            InverseFlattening = 298.257222100883
                                                        };

        public IEllipsoid GRS1980AdjMNLacQuiParle = new Ellipsoid
                                                        {
                                                            Name = "S_GRS_1980_Adj_MN_Lac_Qui_Parle",
                                                            SemiMajorAxis = 6378476.853,
                                                            InverseFlattening = 298.257222100883
                                                        };

        public IEllipsoid GRS1980AdjMNLakeoftheWoodsNorth = new Ellipsoid
                                                                {
                                                                    Name = "S_GRS_1980_Adj_MN_Lake_of_the_Woods_North",
                                                                    SemiMajorAxis = 6378466.185,
                                                                    InverseFlattening = 298.257222100883
                                                                };

        public IEllipsoid GRS1980AdjMNLakeoftheWoodsSouth = new Ellipsoid
                                                                {
                                                                    Name = "S_GRS_1980_Adj_MN_Lake_of_the_Woods_South",
                                                                    SemiMajorAxis = 6378496.665,
                                                                    InverseFlattening = 298.257222100883
                                                                };

        public IEllipsoid GRS1980AdjMNLeSueur = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Le_Sueur",
                                                        SemiMajorAxis = 6378434.181,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNLincoln = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Lincoln",
                                                        SemiMajorAxis = 6378643.579,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNLyon = new Ellipsoid
                                                 {
                                                     Name = "S_GRS_1980_Adj_MN_Lyon",
                                                     SemiMajorAxis = 6378559.758,
                                                     InverseFlattening = 298.257222100883
                                                 };

        public IEllipsoid GRS1980AdjMNMahnomen = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Mahnomen",
                                                         SemiMajorAxis = 6378586.581,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNMarshall = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Marshall",
                                                         SemiMajorAxis = 6378441.801,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNMartin = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Martin",
                                                       SemiMajorAxis = 6378521.049,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNMcLeod = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_McLeod",
                                                       SemiMajorAxis = 6378414.369,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNMeeker = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Meeker",
                                                       SemiMajorAxis = 6378498.189,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNMorrison = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Morrison",
                                                         SemiMajorAxis = 6378502.761,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNMower = new Ellipsoid
                                                  {
                                                      Name = "S_GRS_1980_Adj_MN_Mower",
                                                      SemiMajorAxis = 6378521.049,
                                                      InverseFlattening = 298.257222100883
                                                  };

        public IEllipsoid GRS1980AdjMNMurray = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Murray",
                                                       SemiMajorAxis = 6378617.061,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNNicollet = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Nicollet",
                                                         SemiMajorAxis = 6378403.701,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNNobles = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Nobles",
                                                       SemiMajorAxis = 6378624.681,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNNorman = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Norman",
                                                       SemiMajorAxis = 6378468.623,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNOlmsted = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Olmsted",
                                                        SemiMajorAxis = 6378481.425,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNOttertail = new Ellipsoid
                                                      {
                                                          Name = "S_GRS_1980_Adj_MN_Ottertail",
                                                          SemiMajorAxis = 6378525.621,
                                                          InverseFlattening = 298.257222100883
                                                      };

        public IEllipsoid GRS1980AdjMNPennington = new Ellipsoid
                                                       {
                                                           Name = "S_GRS_1980_Adj_MN_Pennington",
                                                           SemiMajorAxis = 6378445.763,
                                                           InverseFlattening = 298.257222100883
                                                       };

        public IEllipsoid GRS1980AdjMNPine = new Ellipsoid
                                                 {
                                                     Name = "S_GRS_1980_Adj_MN_Pine",
                                                     SemiMajorAxis = 6378472.281,
                                                     InverseFlattening = 298.257222100883
                                                 };

        public IEllipsoid GRS1980AdjMNPipestone = new Ellipsoid
                                                      {
                                                          Name = "S_GRS_1980_Adj_MN_Pipestone",
                                                          SemiMajorAxis = 6378670.401,
                                                          InverseFlattening = 298.257222100883
                                                      };

        public IEllipsoid GRS1980AdjMNPolk = new Ellipsoid
                                                 {
                                                     Name = "S_GRS_1980_Adj_MN_Polk",
                                                     SemiMajorAxis = 6378445.763,
                                                     InverseFlattening = 298.257222100883
                                                 };

        public IEllipsoid GRS1980AdjMNPope = new Ellipsoid
                                                 {
                                                     Name = "S_GRS_1980_Adj_MN_Pope",
                                                     SemiMajorAxis = 6378502.761,
                                                     InverseFlattening = 298.257222100883
                                                 };

        public IEllipsoid GRS1980AdjMNRamsey = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Ramsey",
                                                       SemiMajorAxis = 6378418.941,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNRedLake = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Red_Lake",
                                                        SemiMajorAxis = 6378445.763,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNRedwood = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Redwood",
                                                        SemiMajorAxis = 6378438.753,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNRenville = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Renville",
                                                         SemiMajorAxis = 6378414.369,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNRice = new Ellipsoid
                                                 {
                                                     Name = "S_GRS_1980_Adj_MN_Rice",
                                                     SemiMajorAxis = 6378434.181,
                                                     InverseFlattening = 298.257222100883
                                                 };

        public IEllipsoid GRS1980AdjMNRock = new Ellipsoid
                                                 {
                                                     Name = "S_GRS_1980_Adj_MN_Rock",
                                                     SemiMajorAxis = 6378624.681,
                                                     InverseFlattening = 298.257222100883
                                                 };

        public IEllipsoid GRS1980AdjMNRoseau = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Roseau",
                                                       SemiMajorAxis = 6378449.421,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNScott = new Ellipsoid
                                                  {
                                                      Name = "S_GRS_1980_Adj_MN_Scott",
                                                      SemiMajorAxis = 6378421.989,
                                                      InverseFlattening = 298.257222100883
                                                  };

        public IEllipsoid GRS1980AdjMNSherburne = new Ellipsoid
                                                      {
                                                          Name = "S_GRS_1980_Adj_MN_Sherburne",
                                                          SemiMajorAxis = 6378443.325,
                                                          InverseFlattening = 298.257222100883
                                                      };

        public IEllipsoid GRS1980AdjMNSibley = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Sibley",
                                                       SemiMajorAxis = 6378414.369,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNStLouis = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_St_Louis",
                                                        SemiMajorAxis = 6378523,
                                                        InverseFlattening = 298.2752724
                                                    };

        public IEllipsoid GRS1980AdjMNStLouisCentral = new Ellipsoid
                                                           {
                                                               Name = "S_GRS_1980_Adj_MN_St_Louis_Central",
                                                               SemiMajorAxis = 6378605.783,
                                                               InverseFlattening = 298.257222100883
                                                           };

        public IEllipsoid GRS1980AdjMNStLouisNorth = new Ellipsoid
                                                         {
                                                             Name = "S_GRS_1980_Adj_MN_St_Louis_North",
                                                             SemiMajorAxis = 6378543.909,
                                                             InverseFlattening = 298.257222100883
                                                         };

        public IEllipsoid GRS1980AdjMNStLouisSouth = new Ellipsoid
                                                         {
                                                             Name = "S_GRS_1980_Adj_MN_St_Louis_South",
                                                             SemiMajorAxis = 6378540.861,
                                                             InverseFlattening = 298.257222100883
                                                         };

        public IEllipsoid GRS1980AdjMNStearns = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Stearns",
                                                        SemiMajorAxis = 6378502.761,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNSteele = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Steele",
                                                       SemiMajorAxis = 6378481.425,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNStevens = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Stevens",
                                                        SemiMajorAxis = 6378502.761,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNSwift = new Ellipsoid
                                                  {
                                                      Name = "S_GRS_1980_Adj_MN_Swift",
                                                      SemiMajorAxis = 6378470.757,
                                                      InverseFlattening = 298.257222100883
                                                  };

        public IEllipsoid GRS1980AdjMNTodd = new Ellipsoid
                                                 {
                                                     Name = "S_GRS_1980_Adj_MN_Todd",
                                                     SemiMajorAxis = 6378548.481,
                                                     InverseFlattening = 298.257222100883
                                                 };

        public IEllipsoid GRS1980AdjMNTraverse = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Traverse",
                                                         SemiMajorAxis = 6378463.746,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNWabasha = new Ellipsoid
                                                    {
                                                        Name = "S_GRS_1980_Adj_MN_Wabasha",
                                                        SemiMajorAxis = 6378426.561,
                                                        InverseFlattening = 298.257222100883
                                                    };

        public IEllipsoid GRS1980AdjMNWadena = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Wadena",
                                                       SemiMajorAxis = 6378546.957,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNWaseca = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Waseca",
                                                       SemiMajorAxis = 6378481.425,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNWatonwan = new Ellipsoid
                                                     {
                                                         Name = "S_GRS_1980_Adj_MN_Watonwan",
                                                         SemiMajorAxis = 6378514.953,
                                                         InverseFlattening = 298.257222100883
                                                     };

        public IEllipsoid GRS1980AdjMNWinona = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Winona",
                                                       SemiMajorAxis = 6378453.688,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNWright = new Ellipsoid
                                                   {
                                                       Name = "S_GRS_1980_Adj_MN_Wright",
                                                       SemiMajorAxis = 6378443.325,
                                                       InverseFlattening = 298.257222100883
                                                   };

        public IEllipsoid GRS1980AdjMNYellowMedicine = new Ellipsoid
                                                           {
                                                               Name = "S_GRS_1980_Adj_MN_Yellow_Medicine",
                                                               SemiMajorAxis = 6378530.193,
                                                               InverseFlattening = 298.257222100883
                                                           };

        public IEllipsoid GRS1980AuthalicSphere = new Ellipsoid
                                                      {
                                                          Name = "GRS 1980 Authalic Sphere",
                                                          SemiMajorAxis = 6371007,
                                                          InverseFlattening = 0
                                                      };

        public IEllipsoid Helmert1906 = new Ellipsoid
                                            {
                                                Name = "Helmert 1906",
                                                SemiMajorAxis = 6378200,
                                                InverseFlattening = 298.3
                                            };

        public IEllipsoid Hough1960 = new Ellipsoid
                                          {
                                              Name = "Hough 1960",
                                              SemiMajorAxis = 6378270,
                                              InverseFlattening = 297
                                          };

        public IEllipsoid Hughes1980 = new Ellipsoid
                                           {
                                               Name = "Hughes 1980",
                                               SemiMajorAxis = 6378273,
                                               InverseFlattening = 0
                                           };

        public IEllipsoid IAG1975 = new Ellipsoid
                                        {
                                            Name = "IAG 1975",
                                            SemiMajorAxis = 6378140,
                                            InverseFlattening = 298.257
                                        };

        public IEllipsoid Indonesian = new Ellipsoid
                                           {
                                               Name = "Indonesian",
                                               SemiMajorAxis = 6378160,
                                               InverseFlattening = 298.247
                                           };

        public IEllipsoid IndonesianNationalSpheroid = new Ellipsoid
                                                           {
                                                               Name = "Indonesian National Spheroid",
                                                               SemiMajorAxis = 6378160,
                                                               InverseFlattening = 298.247
                                                           };

        public IEllipsoid International1924 = new Ellipsoid
                                                  {
                                                      Name = "International 1924",
                                                      SemiMajorAxis = 6378388,
                                                      InverseFlattening = 297
                                                  };

        public IEllipsoid International1924AuthalicSphere = new Ellipsoid
                                                                {
                                                                    Name = "International 1924 Authalic Sphere",
                                                                    SemiMajorAxis = 6371228,
                                                                    InverseFlattening = 0
                                                                };
        // TODO: А чего их два?
        public IEllipsoid Krassovsky1940 = new Ellipsoid
                                               {
                                                   Name = "Krassovsky_1940",
                                                   SemiMajorAxis = 6378245,
                                                   InverseFlattening = 298.3
                                               };

        public IEllipsoid Krassowsky1940 = new Ellipsoid
                                               {
                                                   Name = "Krassowsky 1940",
                                                   SemiMajorAxis = 6378245,
                                                   InverseFlattening = 298.3
                                               };

        public IEllipsoid NWL9D = new Ellipsoid
                                      {
                                          Name = "NWL 9D",
                                          SemiMajorAxis = 6378145,
                                          InverseFlattening = 298.25
                                      };

        public IEllipsoid OSU86F = new Ellipsoid
                                       {
                                           Name = "OSU_86F",
                                           SemiMajorAxis = 6378136.2,
                                           InverseFlattening = 298.257223563
                                       };

        public IEllipsoid OSU91A = new Ellipsoid
                                       {
                                           Name = "OSU_91A",
                                           SemiMajorAxis = 6378136.3,
                                           InverseFlattening = 298.257223563
                                       };

        public IEllipsoid PZ1990 = new Ellipsoid
                                       {
                                           Name = "PZ_1990",
                                           SemiMajorAxis = 6378136,
                                           InverseFlattening = 298.257839303
                                       };

        public IEllipsoid PZ90 = new Ellipsoid
                                     {
                                         Name = "PZ-90",
                                         SemiMajorAxis = 6378136,
                                         InverseFlattening = 298.257839303
                                     };

        public IEllipsoid Plessis1817 = new Ellipsoid
                                            {
                                                Name = "Plessis 1817",
                                                SemiMajorAxis = 6376523,
                                                InverseFlattening = 308.64
                                            };

        public IEllipsoid PopularVisualisationSphere = new Ellipsoid
                                                           {
                                                               Name = "Popular Visualisation Sphere",
                                                               SemiMajorAxis = 6378137,
                                                               InverseFlattening = 0
                                                           };

        public IEllipsoid SEasia = new Ellipsoid
                                       {
                                           Name = "SEasia",
                                           SemiMajorAxis = 6378155,
                                           InverseFlattening = 297.300000240866
                                       };

        public IEllipsoid SGS85 = new Ellipsoid
                                      {
                                          Name = "SGS85",
                                          SemiMajorAxis = 6378136,
                                          InverseFlattening = 298.257
                                      };

        public IEllipsoid Sphere = new Ellipsoid
                                       {
                                           Name = "Sphere",
                                           SemiMajorAxis = 6371000,
                                           InverseFlattening = 0
                                       };

        public IEllipsoid SphereARCINFO = new Ellipsoid
                                              {
                                                  Name = "Sphere_ARC_INFO",
                                                  SemiMajorAxis = 6370997,
                                                  InverseFlattening = 0
                                              };

        public IEllipsoid SphereClarke1866Authalic = new Ellipsoid
                                                         {
                                                             Name = "Sphere_Clarke_1866_Authalic",
                                                             SemiMajorAxis = 6370997,
                                                             InverseFlattening = 0
                                                         };

        public IEllipsoid SphereEMEP = new Ellipsoid
                                           {
                                               Name = "Sphere_EMEP",
                                               SemiMajorAxis = 6370000,
                                               InverseFlattening = 0
                                           };

        public IEllipsoid SphereGRS1980Authalic = new Ellipsoid
                                                      {
                                                          Name = "Sphere_GRS_1980_Authalic",
                                                          SemiMajorAxis = 6371007,
                                                          InverseFlattening = 0
                                                      };

        public IEllipsoid SphereInternational1924Authalic = new Ellipsoid
                                                                {
                                                                    Name = "Sphere_International_1924_Authalic",
                                                                    SemiMajorAxis = 6371228,
                                                                    InverseFlattening = 0
                                                                };

        public IEllipsoid Struve1860 = new Ellipsoid
                                           {
                                               Name = "Struve 1860",
                                               SemiMajorAxis = 6378298.3,
                                               InverseFlattening = 294.73
                                           };

        public IEllipsoid Venus1985IAUIAGCOSPAR = new Ellipsoid
                                                      {
                                                          Name = "Venus_1985_IAU_IAG_COSPAR",
                                                          SemiMajorAxis = 6051000,
                                                          InverseFlattening = 0
                                                      };

        public IEllipsoid Venus2000IAUIAG = new Ellipsoid
                                                {
                                                    Name = "Venus_2000_IAU_IAG",
                                                    SemiMajorAxis = 6051800,
                                                    InverseFlattening = 0
                                                };

        public IEllipsoid WG1972 = new Ellipsoid
                                       {
                                           Name = "WGS_1972",
                                           SemiMajorAxis = 6378135,
                                           InverseFlattening = 298.26
                                       };
        // TODO: Свести с WG84    
        public IEllipsoid WG1984 = new Ellipsoid
                                       {
                                           Name = "WGS_1984",
                                           SemiMajorAxis = 6378137,
                                           InverseFlattening = 298.257223563
                                       };

        public IEllipsoid WGS60 = new Ellipsoid
                                      {
                                          Name = "WGS60",
                                          SemiMajorAxis = 6378165,
                                          InverseFlattening = 298.3
                                      };

        public IEllipsoid WGS66 = new Ellipsoid
                                      {
                                          Name = "WGS_1966",
                                          SemiMajorAxis = 6378145,
                                          InverseFlattening = 298.25
                                      };

        public IEllipsoid WGS72 = new Ellipsoid
                                      {
                                          Name = "WGS 72",
                                          SemiMajorAxis = 6378135,
                                          InverseFlattening = 298.26
                                      };

        public IEllipsoid WGS84 = new Ellipsoid
                                      {
                                          Name = "WGS 84",
                                          SemiMajorAxis = 6378137,
                                          InverseFlattening = 298.257223563
                                      };

        public IEllipsoid Walbeck = new Ellipsoid
                                        {
                                            Name = "Walbeck",
                                            SemiMajorAxis = 6376896,
                                            InverseFlattening = 302.78
                                        };

        public IEllipsoid WarOffice = new Ellipsoid
                                          {
                                              Name = "War Office",
                                              SemiMajorAxis = 6378300,
                                              InverseFlattening = 296
                                          };

        public IEllipsoid Xian1980 = new Ellipsoid
                                         {
                                             Name = "Xian_1980",
                                             SemiMajorAxis = 6378140,
                                             InverseFlattening = 298.257
                                         };

        public IEllipsoid airy = new Ellipsoid
                                     {
                                         Name = "airy",
                                         SemiMajorAxis = 6377563.396,
                                         InverseFlattening = 298.324975315035
                                     };

        public IEllipsoid andrae = new Ellipsoid
                                       {
                                           Name = "andrae",
                                           SemiMajorAxis = 6377104.43,
                                           InverseFlattening = 300
                                       };

        public IEllipsoid delmbr = new Ellipsoid
                                       {
                                           Name = "delmbr",
                                           SemiMajorAxis = 6376428,
                                           InverseFlattening = 311.5
                                       };

        public IEllipsoid engelis = new Ellipsoid
                                        {
                                            Name = "engelis",
                                            SemiMajorAxis = 6378136.05,
                                            InverseFlattening = 298.2566
                                        };

        public IEllipsoid kaula = new Ellipsoid
                                      {
                                          Name = "kaula",
                                          SemiMajorAxis = 6378163,
                                          InverseFlattening = 298.24
                                      };

        public IEllipsoid lerch = new Ellipsoid
                                      {
                                          Name = "lerch",
                                          SemiMajorAxis = 6378139,
                                          InverseFlattening = 298.257
                                      };

        public IEllipsoid modairy = new Ellipsoid
                                        {
                                            Name = "mod_airy",
                                            SemiMajorAxis = 6377340.189,
                                            InverseFlattening = 298.324937365482
                                        };

        public IEllipsoid mprts = new Ellipsoid
                                      {
                                          Name = "mprts",
                                          SemiMajorAxis = 6397300,
                                          InverseFlattening = 191
                                      };

        public IEllipsoid newintl = new Ellipsoid
                                        {
                                            Name = "new_intl",
                                            SemiMajorAxis = 6378157.5,
                                            InverseFlattening = 0
                                        };

        public IEllipsoid plessis = new Ellipsoid
                                        {
                                            Name = "plessis",
                                            SemiMajorAxis = 6376523,
                                            InverseFlattening = 307.640997095837
                                        };

        private EllipsoidRegistry ()
        {
            ellipsoids.Add (CGCS2000);
            CGCS2000.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "CGCS2000", 1024));
            CGCS2000.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "CGCS2000", 0));
            CGCS2000.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "MERIT", 0));
            CGCS2000.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "GRS80", 0));
            CGCS2000.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "WGS84", 0));

            ellipsoids.Add (Airy1830);
            Airy1830.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Airy 1830", 7001));
            Airy1830.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Airy_1830", 0));

            ellipsoids.Add (AiryModified1849);
            AiryModified1849.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Airy Modified 1849", 7002));

            ellipsoids.Add (AustralianNationalSpheroid);
            AustralianNationalSpheroid.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Australian National Spheroid", 7003));
            AustralianNationalSpheroid.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "aust_SA", 0));

            ellipsoids.Add (Bessel1841);
            Bessel1841.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bessel 1841", 7004));
            Bessel1841.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Bessel_1841", 0));
            Bessel1841.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "bessel", 0));

            ellipsoids.Add (BesselModified);
            BesselModified.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bessel Modified", 7005));
            BesselModified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Bessel_Modified", 0));

            ellipsoids.Add (BesselNamibia);
            BesselNamibia.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bessel Namibia", 7006));
            BesselNamibia.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Bessel_Namibia", 0));
            BesselNamibia.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "bess_nam", 0));

            ellipsoids.Add (Clarke1858);
            Clarke1858.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Clarke 1858", 7007));
            Clarke1858.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Clarke_1858", 0));

            ellipsoids.Add (Clarke1866);
            Clarke1866.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Clarke 1866", 7008));
            Clarke1866.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Clarke_1866", 0));
            Clarke1866.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "clrk66", 0));

            ellipsoids.Add (Clarke1880);
            Clarke1880.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Clarke_1880", 0));

            ellipsoids.Add (Clarke1880Benoit);
            Clarke1880Benoit.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Clarke 1880 (Benoit)", 7010));
            Clarke1880Benoit.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Clarke_1880_Benoit", 0));

            ellipsoids.Add (Clarke1880IGN);
            Clarke1880IGN.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Clarke 1880 (IGN)", 7011));
            Clarke1880IGN.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Clarke_1880_IGN", 0));

            ellipsoids.Add (Clarke1880RGS);
            Clarke1880RGS.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Clarke 1880 (RGS)", 7012));
            Clarke1880RGS.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Clarke_1880_RGS", 0));

            ellipsoids.Add (Clarke1880Arc);
            Clarke1880Arc.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Clarke 1880 (Arc)", 7013));
            Clarke1880Arc.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Clarke_1880_Arc", 0));
            Clarke1880Arc.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "clrk80", 0));

            ellipsoids.Add (Clarke1880SGA1922);
            Clarke1880SGA1922.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Clarke 1880 (SGA 1922)", 7014));

            ellipsoids.Add (Everest18301937Adjustment);
            Everest18301937Adjustment.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Everest 1830 (1937 Adjustment)", 7015));
            Everest18301937Adjustment.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "evrst30", 0));

            ellipsoids.Add (Everest18301967Definition);
            Everest18301967Definition.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Everest 1830 (1967 Definition)", 7016));
            Everest18301967Definition.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "evrstSS", 0));

            ellipsoids.Add (Everest1830Modified);
            Everest1830Modified.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Everest 1830 Modified", 7018));
            Everest1830Modified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Everest_1830_Modified", 0));
            Everest1830Modified.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "evrst48", 0));

            ellipsoids.Add (GRS1980);
            GRS1980.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GRS 1980", 7019));

            ellipsoids.Add (Helmert1906);
            Helmert1906.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Helmert 1906", 7020));
            Helmert1906.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Helmert_1906", 0));
            Helmert1906.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "helmert", 0));

            ellipsoids.Add (IndonesianNationalSpheroid);
            IndonesianNationalSpheroid.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Indonesian National Spheroid", 7021));
            IndonesianNationalSpheroid.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "GRS67", 0));

            ellipsoids.Add (International1924);
            International1924.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International 1924", 7022));
            International1924.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "International_1924", 0));
            International1924.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "intl", 0));

            ellipsoids.Add (Krassowsky1940);
            Krassowsky1940.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Krassowsky 1940", 7024));
            Krassowsky1940.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "krass", 0));

            ellipsoids.Add (NWL9D);
            NWL9D.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "NWL 9D", 7025));
            NWL9D.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "NWL_9D", 0));
            NWL9D.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "NWL9D", 0));
            NWL9D.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "WGS66", 0));

            ellipsoids.Add (Plessis1817);
            Plessis1817.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Plessis 1817", 7027));
            Plessis1817.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Plessis_1817", 0));

            ellipsoids.Add (Struve1860);
            Struve1860.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Struve 1860", 7028));
            Struve1860.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Struve_1860", 0));

            ellipsoids.Add (WarOffice);
            WarOffice.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "War Office", 7029));
            WarOffice.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "War_Office", 0));

            ellipsoids.Add (WGS84);
            WGS84.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "WGS 84", 7030));

            ellipsoids.Add (GEM10C);
            GEM10C.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GEM 10C", 7031));
            GEM10C.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GEM_10C", 0));

            ellipsoids.Add (OSU86F);
            OSU86F.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "OSU86F", 7032));

            ellipsoids.Add (OSU91A);
            OSU91A.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "OSU91A", 7033));

            ellipsoids.Add (Sphere);
            Sphere.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Sphere", 7035));
            Sphere.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Sphere", 0));
            Sphere.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "sphere", 0));

            ellipsoids.Add (GRS1967);
            GRS1967.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GRS 1967", 7036));

            ellipsoids.Add (AverageTerrestrialSystem1977);
            AverageTerrestrialSystem1977.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Average Terrestrial System 1977", 7041));

            ellipsoids.Add (WGS72);
            WGS72.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "WGS 72", 7043));
            WGS72.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "WGS72", 0));

            ellipsoids.Add (Everest18301962Definition);
            Everest18301962Definition.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Everest 1830 (1962 Definition)", 7044));
            Everest18301962Definition.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "evrst56", 0));

            ellipsoids.Add (Everest18301975Definition);
            Everest18301975Definition.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Everest 1830 (1975 Definition)", 7045));

            ellipsoids.Add (BesselNamibiaGLM);
            BesselNamibiaGLM.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Bessel Namibia (GLM)", 7046));

            ellipsoids.Add (GRS1980AuthalicSphere);
            GRS1980AuthalicSphere.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GRS 1980 Authalic Sphere", 7048));

            ellipsoids.Add (IAG1975);
            IAG1975.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "IAG 1975", 7049));
            IAG1975.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "IAU76", 0));

            ellipsoids.Add (GRS1967Modified);
            GRS1967Modified.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "GRS 1967 Modified", 7050));

            ellipsoids.Add (Danish1876);
            Danish1876.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Danish 1876", 7051));
            Danish1876.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Danish_1876", 0));

            ellipsoids.Add (Clarke1866AuthalicSphere);
            Clarke1866AuthalicSphere.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Clarke 1866 Authalic Sphere", 7052));

            ellipsoids.Add (Hough1960);
            Hough1960.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hough 1960", 7053));
            Hough1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Hough_1960", 0));
            Hough1960.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "hough", 0));

            ellipsoids.Add (PZ90);
            PZ90.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "PZ-90", 7054));

            ellipsoids.Add (Clarke1880internationalfoot);
            Clarke1880internationalfoot.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Clarke 1880 (international foot)", 7055));

            ellipsoids.Add (Everest1830RSO1969);
            Everest1830RSO1969.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Everest 1830 (RSO 1969)", 7056));
            Everest1830RSO1969.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "evrst69", 0));

            ellipsoids.Add (International1924AuthalicSphere);
            International1924AuthalicSphere.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "International 1924 Authalic Sphere", 7057));

            ellipsoids.Add (Hughes1980);
            Hughes1980.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Hughes 1980", 7058));
            Hughes1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Hughes_1980", 0));

            ellipsoids.Add (PopularVisualisationSphere);
            PopularVisualisationSphere.AuthorityAliases.Add (new Authority (AuthorityType.EPSG, "Popular Visualisation Sphere", 7059));

            ellipsoids.Add (GRS1967Truncated);
            GRS1967Truncated.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GRS_1967_Truncated", 0));

            ellipsoids.Add (GRS1980);
            GRS1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GRS_1980", 0));

            ellipsoids.Add (AiryModified);
            AiryModified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Airy_Modified", 0));

            ellipsoids.Add (Australian);
            Australian.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Australian", 0));

            ellipsoids.Add (Clarke1866Michigan);
            Clarke1866Michigan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Clarke_1866_Michigan", 0));

            ellipsoids.Add (Clarke1880SGA);
            Clarke1880SGA.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Clarke_1880_SGA", 0));

            ellipsoids.Add (EverestAdjustment1937);
            EverestAdjustment1937.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Everest_Adjustment_1937", 0));

            ellipsoids.Add (EverestDefinition1967);
            EverestDefinition1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Everest_Definition_1967", 0));

            ellipsoids.Add (Indonesian);
            Indonesian.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Indonesian", 0));

            ellipsoids.Add (Krassovsky1940);
            Krassovsky1940.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Krassovsky_1940", 0));

            ellipsoids.Add (OSU86F);
            OSU86F.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "OSU_86F", 0));

            ellipsoids.Add (OSU91A);
            OSU91A.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "OSU_91A", 0));

            ellipsoids.Add (GRS1967);
            GRS1967.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "GRS_1967", 0));

            ellipsoids.Add (Everest1830);
            Everest1830.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Everest_1830", 0));

            ellipsoids.Add (EverestDefinition1962);
            EverestDefinition1962.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Everest_Definition_1962", 0));

            ellipsoids.Add (EverestDefinition1975);
            EverestDefinition1975.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Everest_Definition_1975", 0));

            ellipsoids.Add (SphereGRS1980Authalic);
            SphereGRS1980Authalic.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Sphere_GRS_1980_Authalic", 0));

            ellipsoids.Add (SphereClarke1866Authalic);
            SphereClarke1866Authalic.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Sphere_Clarke_1866_Authalic", 0));

            ellipsoids.Add (SphereInternational1924Authalic);
            SphereInternational1924Authalic.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Sphere_International_1924_Authalic", 0));

            ellipsoids.Add (ATS1977);
            ATS1977.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "ATS_1977", 0));

            ellipsoids.Add (WG1984);
            WG1984.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "WGS_1984", 0));

            ellipsoids.Add (WG1972);
            WG1972.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "WGS_1972", 0));

            ellipsoids.Add (Xian1980);
            Xian1980.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Xian_1980", 0));

            ellipsoids.Add (PZ1990);
            PZ1990.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "PZ_1990", 0));

            ellipsoids.Add (Clarke1880IntlFt);
            Clarke1880IntlFt.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Clarke_1880_Intl_Ft", 0));

            ellipsoids.Add (EverestModified1969);
            EverestModified1969.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Everest_Modified_1969", 0));

            ellipsoids.Add (WGS66);
            WGS66.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "WGS_1966", 0));

            ellipsoids.Add (Fischer1960);
            Fischer1960.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Fischer_1960", 0));
            Fischer1960.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "fschr60", 0));

            ellipsoids.Add (Fischer1968);
            Fischer1968.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Fischer_1968", 0));
            Fischer1968.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "fschr68", 0));

            ellipsoids.Add (FischerModified);
            FischerModified.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Fischer_Modified", 0));
            FischerModified.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "fschr60m", 0));

            ellipsoids.Add (Walbeck);
            Walbeck.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Walbeck", 0));
            Walbeck.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "walbeck", 0));

            ellipsoids.Add (SphereARCINFO);
            SphereARCINFO.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Sphere_ARC_INFO", 0));

            ellipsoids.Add (SphereEMEP);
            SphereEMEP.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Sphere_EMEP", 0));

            ellipsoids.Add (GRS1980AdjMNAnoka);
            GRS1980AdjMNAnoka.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Anoka", 0));

            ellipsoids.Add (GRS1980AdjMNBecker);
            GRS1980AdjMNBecker.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Becker", 0));

            ellipsoids.Add (GRS1980AdjMNBeltramiNorth);
            GRS1980AdjMNBeltramiNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Beltrami_North", 0));

            ellipsoids.Add (GRS1980AdjMNBeltramiSouth);
            GRS1980AdjMNBeltramiSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Beltrami_South", 0));

            ellipsoids.Add (GRS1980AdjMNBenton);
            GRS1980AdjMNBenton.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Benton", 0));

            ellipsoids.Add (GRS1980AdjMNBigStone);
            GRS1980AdjMNBigStone.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Big_Stone", 0));

            ellipsoids.Add (GRS1980AdjMNBlueEarth);
            GRS1980AdjMNBlueEarth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Blue_Earth", 0));

            ellipsoids.Add (GRS1980AdjMNBrown);
            GRS1980AdjMNBrown.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Brown", 0));

            ellipsoids.Add (GRS1980AdjMNCarlton);
            GRS1980AdjMNCarlton.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Carlton", 0));

            ellipsoids.Add (GRS1980AdjMNCarver);
            GRS1980AdjMNCarver.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Carver", 0));

            ellipsoids.Add (GRS1980AdjMNCassNorth);
            GRS1980AdjMNCassNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Cass_North", 0));

            ellipsoids.Add (GRS1980AdjMNCassSouth);
            GRS1980AdjMNCassSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Cass_South", 0));

            ellipsoids.Add (GRS1980AdjMNChippewa);
            GRS1980AdjMNChippewa.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Chippewa", 0));

            ellipsoids.Add (GRS1980AdjMNChisago);
            GRS1980AdjMNChisago.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Chisago", 0));

            ellipsoids.Add (GRS1980AdjMNCookNorth);
            GRS1980AdjMNCookNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Cook_North", 0));

            ellipsoids.Add (GRS1980AdjMNCookSouth);
            GRS1980AdjMNCookSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Cook_South", 0));

            ellipsoids.Add (GRS1980AdjMNCottonwood);
            GRS1980AdjMNCottonwood.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Cottonwood", 0));

            ellipsoids.Add (GRS1980AdjMNCrowWing);
            GRS1980AdjMNCrowWing.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Crow_Wing", 0));

            ellipsoids.Add (GRS1980AdjMNDakota);
            GRS1980AdjMNDakota.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Dakota", 0));

            ellipsoids.Add (GRS1980AdjMNDodge);
            GRS1980AdjMNDodge.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Dodge", 0));

            ellipsoids.Add (GRS1980AdjMNDouglas);
            GRS1980AdjMNDouglas.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Douglas", 0));

            ellipsoids.Add (GRS1980AdjMNFaribault);
            GRS1980AdjMNFaribault.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Faribault", 0));

            ellipsoids.Add (GRS1980AdjMNFillmore);
            GRS1980AdjMNFillmore.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Fillmore", 0));

            ellipsoids.Add (GRS1980AdjMNFreeborn);
            GRS1980AdjMNFreeborn.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Freeborn", 0));

            ellipsoids.Add (GRS1980AdjMNGoodhue);
            GRS1980AdjMNGoodhue.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Goodhue", 0));

            ellipsoids.Add (GRS1980AdjMNGrant);
            GRS1980AdjMNGrant.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Grant", 0));

            ellipsoids.Add (GRS1980AdjMNHennepin);
            GRS1980AdjMNHennepin.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Hennepin", 0));

            ellipsoids.Add (GRS1980AdjMNHouston);
            GRS1980AdjMNHouston.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Houston", 0));

            ellipsoids.Add (GRS1980AdjMNIsanti);
            GRS1980AdjMNIsanti.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Isanti", 0));

            ellipsoids.Add (GRS1980AdjMNItascaNorth);
            GRS1980AdjMNItascaNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Itasca_North", 0));

            ellipsoids.Add (GRS1980AdjMNItascaSouth);
            GRS1980AdjMNItascaSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Itasca_South", 0));

            ellipsoids.Add (GRS1980AdjMNJackson);
            GRS1980AdjMNJackson.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Jackson", 0));

            ellipsoids.Add (GRS1980AdjMNKanabec);
            GRS1980AdjMNKanabec.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Kanabec", 0));

            ellipsoids.Add (GRS1980AdjMNKandiyohi);
            GRS1980AdjMNKandiyohi.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Kandiyohi", 0));

            ellipsoids.Add (GRS1980AdjMNKittson);
            GRS1980AdjMNKittson.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Kittson", 0));

            ellipsoids.Add (GRS1980AdjMNKoochiching);
            GRS1980AdjMNKoochiching.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Koochiching", 0));

            ellipsoids.Add (GRS1980AdjMNLacQuiParle);
            GRS1980AdjMNLacQuiParle.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Lac_Qui_Parle", 0));

            ellipsoids.Add (GRS1980AdjMNLakeoftheWoodsNorth);
            GRS1980AdjMNLakeoftheWoodsNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Lake_of_the_Woods_North", 0));

            ellipsoids.Add (GRS1980AdjMNLakeoftheWoodsSouth);
            GRS1980AdjMNLakeoftheWoodsSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Lake_of_the_Woods_South", 0));

            ellipsoids.Add (GRS1980AdjMNLeSueur);
            GRS1980AdjMNLeSueur.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Le_Sueur", 0));

            ellipsoids.Add (GRS1980AdjMNLincoln);
            GRS1980AdjMNLincoln.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Lincoln", 0));

            ellipsoids.Add (GRS1980AdjMNLyon);
            GRS1980AdjMNLyon.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Lyon", 0));

            ellipsoids.Add (GRS1980AdjMNMcLeod);
            GRS1980AdjMNMcLeod.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_McLeod", 0));

            ellipsoids.Add (GRS1980AdjMNMahnomen);
            GRS1980AdjMNMahnomen.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Mahnomen", 0));

            ellipsoids.Add (GRS1980AdjMNMarshall);
            GRS1980AdjMNMarshall.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Marshall", 0));

            ellipsoids.Add (GRS1980AdjMNMartin);
            GRS1980AdjMNMartin.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Martin", 0));

            ellipsoids.Add (GRS1980AdjMNMeeker);
            GRS1980AdjMNMeeker.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Meeker", 0));

            ellipsoids.Add (GRS1980AdjMNMorrison);
            GRS1980AdjMNMorrison.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Morrison", 0));

            ellipsoids.Add (GRS1980AdjMNMower);
            GRS1980AdjMNMower.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Mower", 0));

            ellipsoids.Add (GRS1980AdjMNMurray);
            GRS1980AdjMNMurray.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Murray", 0));

            ellipsoids.Add (GRS1980AdjMNNicollet);
            GRS1980AdjMNNicollet.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Nicollet", 0));

            ellipsoids.Add (GRS1980AdjMNNobles);
            GRS1980AdjMNNobles.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Nobles", 0));

            ellipsoids.Add (GRS1980AdjMNNorman);
            GRS1980AdjMNNorman.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Norman", 0));

            ellipsoids.Add (GRS1980AdjMNOlmsted);
            GRS1980AdjMNOlmsted.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Olmsted", 0));

            ellipsoids.Add (GRS1980AdjMNOttertail);
            GRS1980AdjMNOttertail.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Ottertail", 0));

            ellipsoids.Add (GRS1980AdjMNPennington);
            GRS1980AdjMNPennington.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Pennington", 0));

            ellipsoids.Add (GRS1980AdjMNPine);
            GRS1980AdjMNPine.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Pine", 0));

            ellipsoids.Add (GRS1980AdjMNPipestone);
            GRS1980AdjMNPipestone.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Pipestone", 0));

            ellipsoids.Add (GRS1980AdjMNPolk);
            GRS1980AdjMNPolk.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Polk", 0));

            ellipsoids.Add (GRS1980AdjMNPope);
            GRS1980AdjMNPope.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Pope", 0));

            ellipsoids.Add (GRS1980AdjMNRamsey);
            GRS1980AdjMNRamsey.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Ramsey", 0));

            ellipsoids.Add (GRS1980AdjMNRedLake);
            GRS1980AdjMNRedLake.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Red_Lake", 0));

            ellipsoids.Add (GRS1980AdjMNRedwood);
            GRS1980AdjMNRedwood.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Redwood", 0));

            ellipsoids.Add (GRS1980AdjMNRenville);
            GRS1980AdjMNRenville.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Renville", 0));

            ellipsoids.Add (GRS1980AdjMNRice);
            GRS1980AdjMNRice.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Rice", 0));

            ellipsoids.Add (GRS1980AdjMNRock);
            GRS1980AdjMNRock.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Rock", 0));

            ellipsoids.Add (GRS1980AdjMNRoseau);
            GRS1980AdjMNRoseau.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Roseau", 0));

            ellipsoids.Add (GRS1980AdjMNStLouisNorth);
            GRS1980AdjMNStLouisNorth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_St_Louis_North", 0));

            ellipsoids.Add (GRS1980AdjMNStLouisCentral);
            GRS1980AdjMNStLouisCentral.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_St_Louis_Central", 0));

            ellipsoids.Add (GRS1980AdjMNStLouisSouth);
            GRS1980AdjMNStLouisSouth.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_St_Louis_South", 0));

            ellipsoids.Add (GRS1980AdjMNScott);
            GRS1980AdjMNScott.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Scott", 0));

            ellipsoids.Add (GRS1980AdjMNSherburne);
            GRS1980AdjMNSherburne.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Sherburne", 0));

            ellipsoids.Add (GRS1980AdjMNSibley);
            GRS1980AdjMNSibley.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Sibley", 0));

            ellipsoids.Add (GRS1980AdjMNStearns);
            GRS1980AdjMNStearns.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Stearns", 0));

            ellipsoids.Add (GRS1980AdjMNSteele);
            GRS1980AdjMNSteele.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Steele", 0));

            ellipsoids.Add (GRS1980AdjMNStevens);
            GRS1980AdjMNStevens.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Stevens", 0));

            ellipsoids.Add (GRS1980AdjMNSwift);
            GRS1980AdjMNSwift.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Swift", 0));

            ellipsoids.Add (GRS1980AdjMNTodd);
            GRS1980AdjMNTodd.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Todd", 0));

            ellipsoids.Add (GRS1980AdjMNTraverse);
            GRS1980AdjMNTraverse.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Traverse", 0));

            ellipsoids.Add (GRS1980AdjMNWabasha);
            GRS1980AdjMNWabasha.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Wabasha", 0));

            ellipsoids.Add (GRS1980AdjMNWadena);
            GRS1980AdjMNWadena.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Wadena", 0));

            ellipsoids.Add (GRS1980AdjMNWaseca);
            GRS1980AdjMNWaseca.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Waseca", 0));

            ellipsoids.Add (GRS1980AdjMNWatonwan);
            GRS1980AdjMNWatonwan.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Watonwan", 0));

            ellipsoids.Add (GRS1980AdjMNWinona);
            GRS1980AdjMNWinona.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Winona", 0));

            ellipsoids.Add (GRS1980AdjMNWright);
            GRS1980AdjMNWright.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Wright", 0));

            ellipsoids.Add (GRS1980AdjMNYellowMedicine);
            GRS1980AdjMNYellowMedicine.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_Yellow_Medicine", 0));

            ellipsoids.Add (GRS1980AdjMNStLouis);
            GRS1980AdjMNStLouis.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "S_GRS_1980_Adj_MN_St_Louis", 0));

            ellipsoids.Add (Venus1985IAUIAGCOSPAR);
            Venus1985IAUIAGCOSPAR.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Venus_1985_IAU_IAG_COSPAR", 0));

            ellipsoids.Add (Venus2000IAUIAG);
            Venus2000IAUIAG.AuthorityAliases.Add (new Authority (AuthorityType.ESRI, "Venus_2000_IAU_IAG", 0));

            ellipsoids.Add (SGS85);
            SGS85.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "SGS85", 0));

            ellipsoids.Add (airy);
            airy.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "airy", 0));

            ellipsoids.Add (APL49);
            APL49.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "APL4.9", 0));

            ellipsoids.Add (modairy);
            modairy.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "mod_airy", 0));

            ellipsoids.Add (andrae);
            andrae.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "andrae", 0));

            ellipsoids.Add (CPM);
            CPM.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "CPM", 0));

            ellipsoids.Add (delmbr);
            delmbr.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "delmbr", 0));

            ellipsoids.Add (engelis);
            engelis.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "engelis", 0));

            ellipsoids.Add (kaula);
            kaula.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "kaula", 0));

            ellipsoids.Add (lerch);
            lerch.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "lerch", 0));

            ellipsoids.Add (mprts);
            mprts.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "mprts", 0));

            ellipsoids.Add (newintl);
            newintl.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "new_intl", 0));

            ellipsoids.Add (plessis);
            plessis.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "plessis", 0));

            ellipsoids.Add (SEasia);
            SEasia.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "SEasia", 0));

            ellipsoids.Add (WGS60);
            WGS60.AuthorityAliases.Add (new Authority (AuthorityType.PROJ4, "WGS60", 0));
        }


        public override IList <IEllipsoid> All
        {
            get { return ellipsoids; }
        }

        public static EllipsoidRegistry Instance
        {
            get { return instance ?? (instance = new EllipsoidRegistry ()); }
        }
    }
}