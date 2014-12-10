#region

#endregion

#region

using System;
using MapExpress.CoreGIS.Referencing.Datums;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Parameters
{
    // TODO: IEquatable<ProjectionParameters>
    public class ProjectionParameters : ParameterGroup
    {
        private static ProjectionParameters allParameters;
        private static readonly AuthorityList allParametersAuthorityList = new AuthorityList ();
        private IEllipsoid ellipsoid;

        static ProjectionParameters ()
        {
            InitializeAllParameters ();
        }

        public ProjectionParameters ()
        {
        }

        public ProjectionParameters (IEllipsoid ellipsoid)
        {
            Ellipsoid = ellipsoid;
        }

        public IEllipsoid Ellipsoid
        {
            get
            {
                if (ellipsoid != null)
                {
                    return ellipsoid;
                }
                Ellipsoid = new DatumFactory ().CreateEllipsoid (SemiMajor, SemiMinor);
                return ellipsoid;
            }
            set
            {
                ellipsoid = value;
                if (ellipsoid != null)
                {
                    SemiMajor = ellipsoid.SemiMajorAxis;
                    SemiMinor = ellipsoid.SemiMinorAxis;
                }
            }
        }

        public double SemiMajor
        {
            get { return GetParameterValue ("semi_major"); }
            set
            {
                CreateOrReplaceParameter ("semi_major", value, false).
                    AddAlias ("semi_major", AuthorityType.OGC).
                    AddAlias ("Semi-major axis", AuthorityType.EPSG).
                    AddAlias ("Semi_Major", AuthorityType.ESRI).
                    AddAlias ("SemiMajor", AuthorityType.GeoTIFF).
                    AddAlias ("a", AuthorityType.PROJ4);
                if (ellipsoid != null && !ellipsoid.SemiMajorAxis.Equals (value))
                {
                    ellipsoid = new DatumFactory ().CreateEllipsoid (value, SemiMinor);
                }
            }
        }

        public double SemiMinor
        {
            get { return GetParameterValue ("semi_minor"); }
            set
            {
                CreateOrReplaceParameter ("semi_minor", value, false).
                    AddAlias ("semi_minor", AuthorityType.OGC).
                    AddAlias ("Semi-minor axis", AuthorityType.EPSG).
                    AddAlias ("Semi_Minor", AuthorityType.ESRI).
                    AddAlias ("SemiMinor", AuthorityType.GeoTIFF).
                    AddAlias ("b", AuthorityType.PROJ4);
                if (ellipsoid != null && !ellipsoid.SemiMinorAxis.Equals (value))
                {
                    ellipsoid = new DatumFactory ().CreateEllipsoid (SemiMajor, value);
                }
            }
        }

        public double CentralMeridian
        {
            get { return GetParameterValue ("central_meridian"); }
            set
            {
                CreateOrReplaceParameter ("central_meridian", value, false).
                    AddAlias ("central_meridian", AuthorityType.OGC).
                    AddAlias ("Longitude of false origin", AuthorityType.EPSG).
                    AddAlias ("Central_Meridian", AuthorityType.ESRI).
                    AddAlias ("NatOriginLong", AuthorityType.GeoTIFF).
                    AddAlias ("lon_0", AuthorityType.PROJ4);
            }
        }

        public double LatitudeOfOrigin
        {
            get { return GetParameterValue ("latitude_of_origin"); }
            set
            {
                CreateOrReplaceParameter ("latitude_of_origin", value, false).
                    AddAlias ("latitude_of_origin", AuthorityType.OGC).
                    AddAlias ("Latitude of false origin", AuthorityType.EPSG).
                    AddAlias ("Latitude_Of_Origin", AuthorityType.ESRI).
                    AddAlias ("NatOriginLat", AuthorityType.GeoTIFF).
                    AddAlias ("lat_0", AuthorityType.PROJ4);
            }
        }

        public double ScaleFactor
        {
            get
            {
                var k0 = GetParameterValue ("scale_factor");
                return k0 > 0 ? k0 : 1;
            }
            set
            {
                CreateOrReplaceParameter ("scale_factor", value, false).
                    AddAlias ("scale_factor", AuthorityType.OGC).
                    AddAlias ("Scale factor on initial line", AuthorityType.EPSG).
                    AddAlias ("Scale_Factor", AuthorityType.ESRI).
                    AddAlias ("ScaleAtCenter", AuthorityType.GeoTIFF).
                    AddAlias ("k", AuthorityType.PROJ4).
                    AddAlias ("k0", AuthorityType.PROJ4);
            }
        }

        public double StandardParallel1
        {
            get { return GetParameterValue ("standard_parallel_1"); }
            set
            {
                CreateOrReplaceParameter ("standard_parallel_1", value, false).
                    AddAlias ("standard_parallel_1", AuthorityType.OGC).
                    AddAlias ("Latitude of 1st standard parallel", AuthorityType.EPSG).
                    AddAlias ("Standard_Parallel_1", AuthorityType.ESRI).
                    AddAlias ("StdParallel1", AuthorityType.GeoTIFF).
                    AddAlias ("lat_1", AuthorityType.PROJ4).
                    AddAlias ("lat_ts", AuthorityType.PROJ4);
            }
        }

        public double StandardParallel2
        {
            get { return GetParameterValue ("standard_parallel_2"); }
            set
            {
                CreateOrReplaceParameter ("standard_parallel_2", value, false).
                    AddAlias ("standard_parallel_2", AuthorityType.OGC).
                    AddAlias ("Latitude of 2nd standard parallel", AuthorityType.EPSG).
                    AddAlias ("Standard_Parallel_2", AuthorityType.ESRI).
                    AddAlias ("StdParallel2", AuthorityType.GeoTIFF).
                    AddAlias ("lat_2", AuthorityType.PROJ4);
            }
        }

        public double LongitudeOfCenter
        {
            get { return GetParameterValue ("longitude_of_center"); }
            set
            {
                CreateOrReplaceParameter ("longitude_of_center", value, false).
                    AddAlias ("longitude_of_center", AuthorityType.OGC).
                    AddAlias ("Longitude of projection centre", AuthorityType.EPSG).
                    AddAlias ("Longitude_Of_Center", AuthorityType.ESRI).
                    AddAlias ("CenterLong", AuthorityType.GeoTIFF).
                    AddAlias ("lon_0", AuthorityType.PROJ4).
                    AddAlias ("lonc", AuthorityType.PROJ4);
            }
        }

        public double LatitudeOfCenter
        {
            get { return GetParameterValue ("latitude_of_center"); }
            set
            {
                CreateOrReplaceParameter ("latitude_of_center", value, false).
                    AddAlias ("latitude_of_center", AuthorityType.OGC).
                    AddAlias ("Latitude of projection centre", AuthorityType.EPSG).
                    AddAlias ("Latitude_Of_Center", AuthorityType.ESRI).
                    AddAlias ("CenterLat", AuthorityType.GeoTIFF).
                    AddAlias ("lat_0", AuthorityType.PROJ4);
            }
        }

        public double FalseEasting
        {
            get { return GetParameterValue ("false_easting"); }
            set
            {
                CreateOrReplaceParameter ("false_easting", value, false).
                    AddAlias ("false_easting", AuthorityType.OGC).
                    AddAlias ("False easting", AuthorityType.EPSG).
                    AddAlias ("False_Easting", AuthorityType.ESRI).
                    AddAlias ("FalseEasting", AuthorityType.GeoTIFF).
                    AddAlias ("x_0", AuthorityType.PROJ4);
            }
        }

        public double FalseNorthing
        {
            get { return GetParameterValue ("false_northing"); }
            set
            {
                CreateOrReplaceParameter ("false_northing", value, false).
                    AddAlias ("false_northing", AuthorityType.OGC).
                    AddAlias ("False northing", AuthorityType.EPSG).
                    AddAlias ("False_Northing", AuthorityType.ESRI).
                    AddAlias ("FalseNorthing", AuthorityType.GeoTIFF).
                    AddAlias ("y_0", AuthorityType.PROJ4);
            }
        }

        public double Azimuth
        {
            get { return GetParameterValue ("azimuth"); }
            set
            {
                CreateOrReplaceParameter ("azimuth", value, false).
                    AddAlias ("azimuth", AuthorityType.OGC).
                    AddAlias ("Azimuth of initial line", AuthorityType.EPSG).
                    AddAlias ("Azimuth", AuthorityType.ESRI).
                    AddAlias ("RectifiedGridAngle", AuthorityType.GeoTIFF).
                    AddAlias ("alpha", AuthorityType.PROJ4);
            }
        }

        public double RectifiedGridAngle
        {
            get { return GetParameterValue ("rectified_grid_angle"); }
            set
            {
                CreateOrReplaceParameter ("rectified_grid_angle", value, false).
                    AddAlias ("rectified_grid_angle", AuthorityType.OGC).
                    AddAlias ("Angle from Rectified to Skew Grid", AuthorityType.EPSG).
                    AddAlias ("XY_Plane_Rotation", AuthorityType.ESRI);
            }
        }

      
        public static bool IsParamNameValid (string paramName)
        {
            return allParametersAuthorityList.Contains (paramName);
        }

        public static bool IsParamNameValid (AuthorityType type, string paramName)
        {
            return allParametersAuthorityList.Contains (type, paramName);
        }

        public static bool TryConvertName (string sourceName, AuthorityType authorityType, out string authorityName)
        {
            authorityName = null;
            foreach (Parameter iterParam in allParameters.Values)
            {
                if (iterParam.AuthorityList.TryConvertName (sourceName, authorityType, out authorityName))
                {
                    return true;
                }
            }
            return false;
        }

        private static void InitializeAllParameters ()
        {
            if (allParameters == null)
            {
                allParameters = new ProjectionParameters
                                    {
                                        SemiMajor = 0,
                                        SemiMinor = 0,
                                        CentralMeridian = 0,
                                        LatitudeOfOrigin = 0,
                                        ScaleFactor = 0,
                                        StandardParallel1 = 0,
                                        StandardParallel2 = 0,
                                        LongitudeOfCenter = 0,
                                        LatitudeOfCenter = 0,
                                        FalseEasting = 0,
                                        FalseNorthing = 0,
                                        Azimuth = 0,
                                        RectifiedGridAngle = 0
                                    };

                foreach (Parameter iterParameter in allParameters.Values)
                {
                    allParametersAuthorityList.All ().AddRange (iterParameter.AuthorityList.All ());
                }
            }
        }
    }
}