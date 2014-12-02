using System;
using System.Text;

namespace MapExpress.OpenGIS.Wms
{
    // TODO: /// <summary> - перенести в атр [Description], потом его можно использовать в exception
    public enum WmsExceptionType
    {
        /// <summary>
        /// No error code
        /// </summary>
        NotApplicable,

        /// <summary>
        /// Request contains a Format not offered by the server.
        /// </summary>
        InvalidFormat,

        /// <summary>
        /// Request contains a CRS not offered by the server for one or more of the
        /// Layers in the request.
        /// </summary>
        InvalidCRS,

        /// <summary>
        /// GetMap request is for a Layer not offered by the server, or GetFeatureInfo
        /// request is for a Layer not shown on the map.
        /// </summary>
        LayerNotDefined,

        /// <summary>
        /// Request is for a Layer in a Style not offered by the server.
        /// </summary>
        StyleNotDefined,

        /// <summary>
        /// GetFeatureInfo request is applied to a Layer which is not declared queryable.
        /// </summary>
        LayerNotQueryable,

        /// <summary>
        /// GetFeatureInfo request contains invalid X or Y value.
        /// </summary>
        InvalidPoint,

        /// <summary>
        /// Value of (optional) UpdateSequence parameter in GetCapabilities request is
        /// equal to current value of service metadata update sequence number.
        /// </summary>
        CurrentUpdateSequence,

        /// <summary>
        /// Value of (optional) UpdateSequence parameter in GetCapabilities request is
        /// greater than current value of service metadata update sequence number.
        /// </summary>
        InvalidUpdateSequence,

        /// <summary>
        /// Request does not include a sample dimension value, and the server did not
        /// declare a default value for that dimension.
        /// </summary>
        MissingDimensionValue,

        /// <summary>
        /// Request contains an invalid sample dimension value.
        /// </summary>
        InvalidDimensionValue,

        /// <summary>
        /// Request is for an optional operation that is not supported by the server.
        /// </summary>
        OperationNotSupported
    }

    public class WmsException : Exception
    {
        public WmsException (string message) : this (message, WmsExceptionType.NotApplicable)
        {
        }

        public WmsException (string message, WmsExceptionType wmsExceptionType) : base (message)
        {
            WmsExceptionType = wmsExceptionType;
        }

        public WmsExceptionType WmsExceptionType { get; private set; }

        // TODO: Вынести в Converter class
        public string ToXmlText ()
        {
            var sb = new StringBuilder ();
            sb.Append ("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n");
            sb.Append (
                "<ServiceExceptionReport version=\"1.3.0\" xmlns=\"http://www.opengis.net/ogc\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://www.opengis.net/ogc http://schemas.opengis.net/wms/1.3.0/exceptions_1_3_0.xsd\">\n");
            sb.Append ("<ServiceException");
            if (WmsExceptionType != WmsExceptionType.NotApplicable)
                sb.Append (" code=\"" + WmsExceptionType + "\"");
            sb.Append (">" + Message + "</ServiceException>\n");
            sb.Append ("</ServiceExceptionReport>");
            return sb.ToString ();
        }
    }
}