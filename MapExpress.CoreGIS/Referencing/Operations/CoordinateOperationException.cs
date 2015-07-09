#region

using System;
using System.Runtime.Serialization;

#endregion

namespace MapExpress.CoreGIS.Referencing.Operations
{
    // TODO: Там где null возвращается или Empty кидать экзепшн
    public class CoordinateOperationException : MapExpressException
    {
        public CoordinateOperationException ()
        {
        }

        public CoordinateOperationException (string message) : base (message)
        {
        }

        public CoordinateOperationException (string message, Exception innerException) : base (message, innerException)
        {
        }


        protected CoordinateOperationException (SerializationInfo info, StreamingContext context) : base (info, context)
        {
        }
    }
}