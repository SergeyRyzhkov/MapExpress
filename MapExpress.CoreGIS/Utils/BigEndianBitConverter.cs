using System;
using System.Linq;

namespace MapExpress.CoreGIS.Utils
{
    public static class BigEndianBitConverter
    {
        public static uint ToUInt32 (byte[] value, int startIndex)
        {
            var byteArray = value.Skip (startIndex).Take (4).ToArray ();
            Array.Reverse (byteArray);
            return BitConverter.ToUInt32 (byteArray, 0);
        }

        public static double ToDouble (byte[] value, int startIndex)
        {
            var byteArray = value.Skip (startIndex).Take (8).ToArray ();
            Array.Reverse (byteArray);
            return BitConverter.ToDouble (byteArray, 0);
        }
    }
}