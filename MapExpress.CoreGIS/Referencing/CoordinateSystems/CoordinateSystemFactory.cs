#region

using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.CoreGIS.Referencing.CoordinateSystems
{
    public class CoordinateSystemFactory : ICSFactory
    {
        #region ICSFactory Members

        public ICoordinateSystemAxis CreateCoordinateSystemAxis (AxisDirectionType direction, IUnit unit)
        {
            return new CoordinateSystemAxis (direction, unit);
        }


        public ICartesianCS CreateCartesianCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1)
        {
            return new CartesianCS (new[] {axis0, axis1}, "Cartesian_2D");
        }

        public ICartesianCS CreateCartesianCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2)
        {
            return new CartesianCS (new[] {axis0, axis1, axis2}, "Cartesian_3D");
        }

        public IAffineCS CreateAffineCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1)
        {
            return new AffineCS (new[] {axis0, axis1}, "Affine_2D");
        }

        public IAffineCS CreateAffineCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2)
        {
            return new AffineCS (new[] {axis0, axis1, axis2}, "Affine_3D");
        }

        public IPolarCS CreatePolarCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1)
        {
            return new PolarCS (new[] {axis0, axis1}, "Polar_2D");
        }

        public ICylindricalCS CreateCylindricalCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2)
        {
            return new CylindricalCS (new[] {axis0, axis1, axis2}, "Cylindrical_3D");
        }


        public ISphericalCS CreateSphericalCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2)
        {
            return new SphericalCS (new[] {axis0, axis1, axis2}, "Spherical_3D");
        }

        public IEllipsoidalCS CreateEllipsoidalCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1)
        {
            return new EllipsoidalCS (new[] {axis0, axis1}, "Ellipsoidal_2D");
        }

        public IEllipsoidalCS CreateEllipsoidalCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2)
        {
            return new EllipsoidalCS (new[] {axis0, axis1, axis2}, "Ellipsoidal_3D");
        }


        public IVerticalCS CreateVerticalCS (ICoordinateSystemAxis axis)
        {
            return new VerticalCS (new[] {axis}, "Vertical");
        }


        public ITimeCS CreateTimeCS (ICoordinateSystemAxis axis)
        {
            return new TimeCS (new[] {axis}, "Time");
        }

        public ILinearCS CreateLinearCS (ICoordinateSystemAxis axis)
        {
            return new LinearCS (new[] {axis}, "Linear");
        }

        public IUserDefinedCS CreateUserDefinedCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1)
        {
            return new UserDefinedCS (new[] {axis0, axis1}, "UserDefined_2D");
        }

        public IUserDefinedCS CreateUserDefinedCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2)
        {
            return new UserDefinedCS (new[] {axis0, axis1, axis2}, "UserDefined_3D");
        }

        #endregion

        public ICartesianCS Create2DCartesianCS ()
        {
            return CreateCartesianCS (CoordinateSystemAxis.GeocentricX, CoordinateSystemAxis.GeocentricY);
        }

        public ICartesianCS Create3DCartesianCS ()
        {
            return CreateCartesianCS (CoordinateSystemAxis.GeocentricX, CoordinateSystemAxis.GeocentricY, CoordinateSystemAxis.GeocentricZ);
        }

        // TODO: А что это за СК?
        public ISphericalCS CreateSphericalCS ()
        {
            return CreateSphericalCS (CoordinateSystemAxis.OriginDistance, CoordinateSystemAxis.Lat, CoordinateSystemAxis.Lon);
        }

        public IEllipsoidalCS Create3DEllipsoidalCS ()
        {
            return CreateEllipsoidalCS (CoordinateSystemAxis.Lat, CoordinateSystemAxis.Lon, CoordinateSystemAxis.EllipsoidalHeight);
        }

        public IEllipsoidalCS Create2DEllipsoidalCS ()
        {
            return CreateEllipsoidalCS (CoordinateSystemAxis.Lat, CoordinateSystemAxis.Lon);
        }

        public IVerticalCS CreateVerticalCS ()
        {
            return CreateVerticalCS (CoordinateSystemAxis.Depth);
        }

        public ITimeCS CreateTimeCS ()
        {
            return CreateTimeCS (CoordinateSystemAxis.Future);
        }
    }
}