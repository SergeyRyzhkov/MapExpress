using System;
using System.Runtime.Serialization;

namespace MapExpress.CoreGIS
{
    public class MapExpressException : Exception
    {
        public MapExpressException ()
        {
        }

        public MapExpressException (string message) : base (message)
        {
        }

        public MapExpressException (string message, Exception innerException) : base (message, innerException)
        {
        }

        protected MapExpressException (SerializationInfo info, StreamingContext context) : base (info, context)
        {
        }
    }
}