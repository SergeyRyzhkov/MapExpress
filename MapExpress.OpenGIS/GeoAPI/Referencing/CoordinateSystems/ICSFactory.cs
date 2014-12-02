#region

using MapExpress.OpenGIS.GeoAPI.Referencing.Units;

#endregion

namespace MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateSystems
{
    public interface ICSFactory
    {
        ICoordinateSystemAxis CreateCoordinateSystemAxis (AxisDirectionType direction, IUnit unit);

        ICartesianCS CreateCartesianCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1);

        ICartesianCS CreateCartesianCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2);

        IAffineCS CreateAffineCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1);

        IAffineCS CreateAffineCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2);

        IPolarCS CreatePolarCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1);

        ICylindricalCS CreateCylindricalCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2);

        ISphericalCS CreateSphericalCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2);

        IEllipsoidalCS CreateEllipsoidalCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1);

        IEllipsoidalCS CreateEllipsoidalCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2);

        IVerticalCS CreateVerticalCS (ICoordinateSystemAxis axis);

        ITimeCS CreateTimeCS (ICoordinateSystemAxis axis);

        ILinearCS CreateLinearCS (ICoordinateSystemAxis axis);

        IUserDefinedCS CreateUserDefinedCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1);

        IUserDefinedCS CreateUserDefinedCS (ICoordinateSystemAxis axis0, ICoordinateSystemAxis axis1, ICoordinateSystemAxis axis2);
    }
}