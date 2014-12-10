using System.Globalization;

namespace MapExpress.OpenGIS.Wms.Metadata
{
    public struct BoundingBox
    {
        public double MaxX;
        public double MaxY;
        public double MinX;
        public double MinY;

        public static BoundingBox Create (string bboxParameter)
        {
            var result = new BoundingBox ();
            if(!string.IsNullOrEmpty (bboxParameter))
            {
                var parts = bboxParameter.Split (',');
                if (parts.Length == 4)
                {
                    result.MinX = GetDoubleValueOrZero (parts[0]);
                    result.MinY = GetDoubleValueOrZero (parts[1]);
                    result.MaxX = GetDoubleValueOrZero (parts[2]);
                    result.MaxY = GetDoubleValueOrZero (parts[3]);
                }
            }
            return result;
        }

        private static double GetDoubleValueOrZero (string parameter)
        {
            double result = 0;
            if (!string.IsNullOrEmpty (parameter))
            {
                double.TryParse (parameter.Trim (), NumberStyles.Any, CultureInfo.InvariantCulture, out result);
            }
            return result;
        }
    }
}