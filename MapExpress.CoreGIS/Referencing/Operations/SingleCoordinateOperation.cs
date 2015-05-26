#region

using System.Collections.Generic;
using System.Collections.ObjectModel;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Authority;
using MapExpress.OpenGIS.GeoAPI.Geometries;
using MapExpress.OpenGIS.GeoAPI.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations
{
    public abstract class SingleCoordinateOperation : IMathTransform, ISingleOperation, IOperationMethod
    {
        private AuthorityList authorityList;

        protected SingleCoordinateOperation () : this (null, null, null)
        {
        }

        protected SingleCoordinateOperation (ParameterGroup parameters) : this (null, null, parameters)
        {
        }

        protected SingleCoordinateOperation (ICoordinateReferenceSystem sourceCRS, ICoordinateReferenceSystem targetCRS, ParameterGroup parameters)
        {
            AuthorityAliases = new AuthorityList ();
            SourceCRS = sourceCRS;
            TargetCRS = targetCRS;
            Parameters = parameters;
        }

        #region IMathTransform Members

        public int SourceDimensions
        {
            get { return SourceCRS != null ? SourceCRS.CoordinateSystem.Dimension : 0; }
        }

        public int TargetDimensions
        {
            get { return TargetCRS != null ? TargetCRS.CoordinateSystem.Dimension : 0; }
        }

        public double[] Transform (double x, double y, double z)
        {
            var coordinate = Transform (new Coordinate (x, y, z));
            return new[] {coordinate.X, coordinate.Y, coordinate.Z};
        }

        // TODO: Надо оптимизировать много объектов создается. Этот методот надо реализовать в потомках, а не ICoordinate Transform (ICoordinate point);
        public abstract ICoordinate Transform (ICoordinate point);

        public abstract ICoordinate TransformInverse (ICoordinate point);

        // TODO: Parallel.For ?
        public virtual ICollection <ICoordinate> Transform (ICollection <ICoordinate> points)
        {
            var result = new Collection <ICoordinate> ();
            foreach (var point in points)
            {
                result.Add (Transform (point));
            }
            return result;
        }

        public double[] TransformInverse (double x, double y, double z)
        {
            var coordinate = TransformInverse (new Coordinate (x, y, z));
            return new[] {coordinate.X, coordinate.Y, coordinate.Z};
        }

        public ICollection <ICoordinate> TransformInverse (ICollection <ICoordinate> points)
        {
            var result = new Collection <ICoordinate> ();
            foreach (var point in points)
            {
                result.Add (TransformInverse (point));
            }
            return result;
        }

        #endregion

        #region IOperationMethod Members

        public string Name { get; set; }


        public string Formula { get; set; }

        public AuthorityList AuthorityAliases
        {
            get { return authorityList ?? (authorityList = new AuthorityList ()); }
            set { authorityList = value; }
        }

        public abstract IParameterValueGroup CreateParameters ();

        #endregion

        #region ISingleOperation Members

        public virtual IParameterValueGroup Parameters { get; set; }

        public ICoordinateReferenceSystem SourceCRS { get; set; }

        public ICoordinateReferenceSystem TargetCRS { get; set; }

        public string OperationVersion { get; set; }

        public IEnvelope DomainOfValidity { get; set; }

        public virtual IMathTransform MathTransform
        {
            get { return this; }
        }

        public virtual IOperationMethod OperationMethod
        {
            get { return this; }
        }

        public abstract string ExportToWKT ();

        #endregion

        public virtual void InitializeConstants ()
        {
        }

        public virtual void InitAuthorityAliases ()
        {
        }
    }
}