using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using MapInfo.Geometry;

namespace MapExpress.Web.Wms
{
    public class Wgs84ToPlanTransformer
    {
        private string configPathName = new StringBuilder (@"C:\_Work\_Projects\Vodokanal\Win4\Starter\bin\x86\Debug").Append (Path.DirectorySeparatorChar).Append ("TranstoSPB.cfg").ToString ();

        private int iterationCount = 0;
        public static Wgs84ToPlanTransformer Instance = new Wgs84ToPlanTransformer ();
       
        private double currentLatBottom = 59;
        private double currentLatTop = 60.5;

        private double currentLonLeft = 28.2;
        private double currentLonRight = 31.5;

        private bool isXComplete;
        private bool isYComplete;
        private double x;
        private double y;
        private double centerLon;
        private double centerLat;
        [DllImport ("TransDll.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void WgsToLocal (string configFileName, double B, double L, double H, ref double x, ref double y, ref double h);

        public DPoint ToLocalNew (double longituted, double latitude, double h)
        {
            double[] xy = ToLocal (longituted, latitude, h);
            return new DPoint (xy[0], xy[1]);
        }

        public PointF ToLocal (double longituted, double latitude)
        {
            double[] xy = ToLocal (longituted, latitude, 1);
            return new PointF ((float)xy[0], (float)xy[1]);
        }

        public double[] ToLocal (double longituted, double latitude, double h)//широта и долгота перепутаны местами - должно быть широта потом долгота
        {
            double x = 0, y = 0, localH = 0;


            longituted = longituted * 10000;
            latitude = latitude * 10000;

            longituted = (longituted * Math.PI) / 1800000;
            latitude = (latitude * Math.PI) / 1800000;

            configPathName = configPathName.Replace (@"\\", @"\");
            WgsToLocal (configPathName, latitude, longituted, h, ref x, ref y, ref localH);

            return new[] { y, x };
        }

        public double[] ToLocal (string latitude, string longituted)
        {
            double[] xy = ToLocal (GetDecimalDegFromString (latitude), GetDecimalDegFromString (longituted), 1);
            return xy;
        }


        public double[] ToWgs84 (double x, double y)
        {
            this.x = x;
            this.y = y;

            currentLatBottom = 58;
            currentLatTop = 61;
            currentLonLeft = 29;
            currentLonRight = 31;
            isXComplete = false;
            isYComplete = false;
            centerLon = 0;
            centerLat = 0;

            ProcessCompute ();

            return new[] { centerLon, centerLat };
        }

        public double GetDecimalDegFromString (string value)
        {
            double grad = 0;
            double min = 0;
            double sec = 0;
            try
            {

                Double.TryParse (value.Substring (0, 2), out grad);
                if (value.Length > 3)
                {
                    Double.TryParse (value.Substring (3, value.IndexOf ("'") - 3).Replace (".", ","), out min);
                }
                if (value.Length > value.IndexOf ("'") + 1)
                    Double.TryParse (value.Substring (value.IndexOf ("'") + 1, value.Length - value.IndexOf ("'") - 2).Replace (".", ","), out sec);
            }
            catch (Exception exc)
            {
            }

            return grad + min / 60 + sec / 3600;
        }



        private void ProcessCompute ()
        {
            iterationCount++;

            if (iterationCount == 1000)
            {
                isXComplete = true;
                isYComplete = true;
            }

            if (Math.Round (currentLonRight, 4) == Math.Round (currentLonLeft, 4))
            {
                isXComplete = true;
            }

            if (Math.Round (currentLatTop, 4) == Math.Round (currentLatBottom, 4))
            {
                isYComplete = true;
            }

            centerLon = (currentLonRight + currentLonLeft) / 2;
            centerLat = (currentLatTop + currentLatBottom) / 2;

            double[] currentResultXY = ToLocal (centerLon, centerLat, 1);

            double resultX = currentResultXY[0];
            double resultY = currentResultXY[1];

            if (!isXComplete)
            {
                if (resultX < x)
                {
                    currentLonLeft = centerLon;
                }
                if (resultX > x)
                {
                    currentLonRight = centerLon;
                }
            }


            if (!isYComplete)
            {
                if (resultY < y)
                {
                    currentLatBottom = centerLat;
                }

                if (resultY > y)
                {
                    currentLatTop = centerLat;
                }
            }

            if (!isXComplete && Math.Abs (resultX - x) < 0.5)
            {
                isXComplete = true;
            }

            if (!isYComplete && Math.Abs (resultY - y) < 0.5)
            {
                isYComplete = true;
            }

            if (!isYComplete || !isXComplete)
            {
                ProcessCompute ();
            }
        }
    }
}