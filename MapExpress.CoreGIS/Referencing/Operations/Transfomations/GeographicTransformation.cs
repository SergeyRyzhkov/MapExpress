#region

using System;
using MapExpress.CoreGIS.Referencing.Operations.Parameters;
using MapExpress.OpenGIS.GeoAPI.Parameters;
using MapExpress.OpenGIS.GeoAPI.Referencing;
using MapExpress.OpenGIS.GeoAPI.Referencing.CoordinateReferenceSystems;
using MapExpress.OpenGIS.GeoAPI.Referencing.Datum;
using MapExpress.OpenGIS.GeoAPI.Referencing.Operations;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations.Transfomations
{
    public class GeographicTransformation : SingleCoordinateOperation, ITransformation
    {
        private PositionVector datumTransformOperation;
        private DatumTransformationType datumTransformationType;
        private GeographicGeocentricConversion sourceGeocentricConversion;
        private GeographicGeocentricConversion targetGeocentricConversion;

        public GeographicTransformation (GeographicTrasformParameters parameters)
            : this (null, null, parameters, DatumTransformationType.AutoDetect)
        {
        }

        public GeographicTransformation (GeographicTrasformParameters parameters, DatumTransformationType datumTransformationType)
            : this (null, null, parameters, datumTransformationType)
        {
        }


        public GeographicTransformation (double dx, double dy, double dz, IEllipsoid sourceEllipsoid, IEllipsoid targetEllipsoid)
            : this (new GeographicTrasformParameters (sourceEllipsoid, targetEllipsoid, dx, dy, dz), DatumTransformationType.AutoDetect)
        {
        }

        public GeographicTransformation (double dx, double dy, double dz, IEllipsoid sourceEllipsoid, IEllipsoid targetEllipsoid, DatumTransformationType datumTransformationType)
            : this (new GeographicTrasformParameters (sourceEllipsoid, targetEllipsoid, dx, dy, dz), datumTransformationType)
        {
        }
        
        public GeographicTransformation (IEllipsoid sourceEllipsoid, IEllipsoid targetEllipsoid, double dx, double dy, double dz, double ex, double ey, double ez, double ppm)
            : this (sourceEllipsoid, targetEllipsoid, new DatumShiftParameters (dx, dy, dz, ex, ey, ez, ppm), DatumTransformationType.AutoDetect)
        {
        }
        
        public GeographicTransformation (IEllipsoid sourceEllipsoid, IEllipsoid targetEllipsoid, double dx, double dy, double dz, double ex, double ey, double ez, double ppm, DatumTransformationType datumTransformationType)
            : this (sourceEllipsoid, targetEllipsoid, new DatumShiftParameters (dx, dy, dz, ex, ey, ez, ppm), datumTransformationType)
        {
        }
        
        public GeographicTransformation (IEllipsoid sourceEllipsoid, IEllipsoid targetEllipsoid, DatumShiftParameters datumShiftParameters)
            : this (new GeographicTrasformParameters (sourceEllipsoid, targetEllipsoid, datumShiftParameters), DatumTransformationType.AutoDetect)
        {
        }

        public GeographicTransformation (IEllipsoid sourceEllipsoid, IEllipsoid targetEllipsoid, DatumShiftParameters datumShiftParameters, DatumTransformationType datumTransformationType)
            : this (new GeographicTrasformParameters (sourceEllipsoid, targetEllipsoid, datumShiftParameters), datumTransformationType)
        {
        }
        
        public GeographicTransformation (IGeographicCRS sourceCRS, IGeographicCRS targetCRS, DatumShiftParameters datumShiftParameters )
            : this (sourceCRS, targetCRS, new GeographicTrasformParameters (sourceCRS.Datum.Ellipsoid, targetCRS.Datum.Ellipsoid, datumShiftParameters), DatumTransformationType.AutoDetect)
        {
        }

        public GeographicTransformation (IGeographicCRS sourceCRS, IGeographicCRS targetCRS, DatumShiftParameters datumShiftParameters, DatumTransformationType datumTransformationType)
            : this (sourceCRS, targetCRS, new GeographicTrasformParameters (sourceCRS.Datum.Ellipsoid, targetCRS.Datum.Ellipsoid, datumShiftParameters), datumTransformationType)
        {
        }


        public GeographicTransformation (IGeographicCRS sourceCRS, IGeographicCRS targetCRS, GeographicTrasformParameters parameters)
            : this (sourceCRS, targetCRS, parameters, DatumTransformationType.AutoDetect)
        {

        }

        public GeographicTransformation (IGeographicCRS sourceCRS, IGeographicCRS targetCRS, GeographicTrasformParameters parameters, DatumTransformationType datumTransformationType) : base (sourceCRS, targetCRS, parameters)
        {
            this.datumTransformationType = datumTransformationType;
            Parameters = parameters;
            if (sourceCRS != null && sourceCRS.Datum != null && (Parameters.SourceEllipsoid == null || Parameters.TargetEllipsoid == null))
            {
                Parameters.SourceEllipsoid = sourceCRS.Datum.Ellipsoid;
            }
            if (targetCRS != null && targetCRS.Datum != null && (Parameters.SourceEllipsoid == null || Parameters.TargetEllipsoid == null))
            {
                Parameters.TargetEllipsoid = targetCRS.Datum.Ellipsoid;
            }
            InitializeConstants ();
        }


        public new GeographicTrasformParameters Parameters { get; private set; }

        #region ITransformation Members

        public override string ExportToWKT ()
        {
            throw new NotImplementedException ();
        }

        #endregion

        public override IParameterValueGroup CreateParameters ()
        {
            return new GeographicTrasformParameters ();
        }

        public override sealed void InitializeConstants ()
        {
        }

        public override ICoordinate Transform (ICoordinate point)
        {
            return Transform (point is GeographicCoordinate ? (GeographicCoordinate) point : new GeographicCoordinate (point.X, point.Y, point.Z));
        }


        public override ICoordinate TransformInverse (ICoordinate point)
        {
            return TransformInverse (point is GeographicCoordinate ? (GeographicCoordinate) point : new GeographicCoordinate (point.X, point.Y, point.Z));
        }

        public virtual GeographicCoordinate Transform (GeographicCoordinate sourceCoord)
        {
            var geocentricCoordinate = GetSourceGeographicGeocentricConversion ().Transform (sourceCoord);
            var trasformedGeocentricCoordinate = GetDatumTrasformOperation ().Transform (geocentricCoordinate);
            var geographicCoordinate = GetTargetGeographicGeocentricConversion ().TransformInverse (trasformedGeocentricCoordinate);
            return new GeographicCoordinate (geographicCoordinate);
        }

        public virtual GeographicCoordinate TransformInverse (GeographicCoordinate sourceCoord)
        {
            var geocentricCoordinate = GetTargetGeographicGeocentricConversion ().Transform (sourceCoord);
            var trasformedGeocentricCoordinate = GetDatumTrasformOperation ().TransformInverse (geocentricCoordinate);
            var geographicCoordinate = GetSourceGeographicGeocentricConversion ().TransformInverse (trasformedGeocentricCoordinate);
            return new GeographicCoordinate (geographicCoordinate);
        }

        private GeographicGeocentricConversion GetSourceGeographicGeocentricConversion ()
        {
            if (sourceGeocentricConversion == null)
            {
                sourceGeocentricConversion = new GeographicGeocentricConversion (Parameters.SourceEllipsoid);
            }
            else
            {
                if (sourceGeocentricConversion.Ellipsoid != null && !sourceGeocentricConversion.Ellipsoid.Equals (Parameters.SourceEllipsoid))
                {
                    sourceGeocentricConversion = new GeographicGeocentricConversion (Parameters.SourceEllipsoid);
                }
            }
            return sourceGeocentricConversion;
        }

        private GeographicGeocentricConversion GetTargetGeographicGeocentricConversion ()
        {
            if (targetGeocentricConversion == null)
            {
                targetGeocentricConversion = new GeographicGeocentricConversion (Parameters.TargetEllipsoid);
            }
            else
            {
                if (targetGeocentricConversion.Ellipsoid != null && !targetGeocentricConversion.Ellipsoid.Equals (Parameters.TargetEllipsoid))
                {
                    targetGeocentricConversion = new GeographicGeocentricConversion (Parameters.TargetEllipsoid);
                }
            }
            return targetGeocentricConversion;
        }

        private PositionVector GetDatumTrasformOperation ()
        {
            if (datumTransformOperation == null)
            {
                datumTransformOperation = ResolveAndCreateDatumTransformOperation ();
            }
            else
            {
                if (!datumTransformOperation.Parameters.Equals (Parameters.DatumShiftParameters))
                {
                    datumTransformOperation = ResolveAndCreateDatumTransformOperation ();
                }
            }
            return datumTransformOperation;
        }

        private PositionVector ResolveAndCreateDatumTransformOperation ()
        {
            switch (datumTransformationType)
            {
                case DatumTransformationType.AutoDetect:
                    return Parameters.DatumShiftParameters.Ex < 0 || Parameters.DatumShiftParameters.Ey < 0 || Parameters.DatumShiftParameters.Ez < 0 ? new CoordinateFrameRotation (Parameters.DatumShiftParameters) : new PositionVector (Parameters.DatumShiftParameters);
                case DatumTransformationType.CoordinateFrameRotation:
                    return new CoordinateFrameRotation (Parameters.DatumShiftParameters);

                case DatumTransformationType.PositionVector:
                    return new PositionVector (Parameters.DatumShiftParameters);
            }
            return new PositionVector (Parameters.DatumShiftParameters);
        }
    }
}