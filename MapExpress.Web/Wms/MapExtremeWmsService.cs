using System;
using System.Drawing.Imaging;
using System.IO;
using MapExpress.CoreGIS.Referencing;
using MapExpress.OpenGIS.Wms;
using MapExpress.OpenGIS.Wms.Operations;
using MapInfo.Geometry;
using MapInfo.Mapping;

namespace MapExpress.Web.Wms
{
    public class MapExtremeWmsService : WmsService
    {
        private ImageCodecInfo imageCodecInfo;
        private MapExport mapExport;

        public override MetadataResponse GetCapabilities (MetadataRequest metadataRequest)
        {
            throw new NotImplementedException ();
        }

        public override MapResponse GetMap (MapRequest mapRequest)
        {
            var mapResponse = new MapResponse ();
            var map = MapRegistry.GetWmsServiceMap ();
            
            var p1 = new Tracformer ().Geogr2Geogr (new GeographicCoordinate (mapRequest.BoundingBox.MinY, mapRequest.BoundingBox.MinX));
            var p2 = new Tracformer ().Geogr2Geogr (new GeographicCoordinate (mapRequest.BoundingBox.MaxY, mapRequest.BoundingBox.MaxX));
            map.Bounds = new DRect (p1, p2);

            var export = GetMapExport (map, mapRequest.MapAttributes.Width, mapRequest.MapAttributes.Height);

            using (var memoryStream = new MemoryStream ())
            {
                var codecInfo = GetCodecInfo (mapRequest.MapAttributes.Format.Format);
         
                var image = export.Export ();
                image.Save (memoryStream, GetCodecInfo (mapRequest.MapAttributes.Format.Format), null);
                mapResponse.MapImage = memoryStream.ToArray ();
                mapResponse.MimeType = codecInfo;

                image.Dispose ();
            }
            return mapResponse;
        }

        public override FeatureInfoResponse GetFeatureInfo (FeatureInfoRequest featureInfoRequest)
        {
            throw new NotImplementedException ();
        }

        private MapExport GetMapExport (Map map, int width, int height)
        {
            return mapExport ?? (mapExport = new MapExport (map)
                                                 {
                                                     ExportSize = new ExportSize (width, height),
                                                     Transparent = true,
                                                     Format = ExportFormat.Png,
                                                     Border = ExportBorder.Off
                                                 });
        }

        private ImageCodecInfo GetCodecInfo (string mimeType)
        {
            if (imageCodecInfo == null)
            {
                foreach (ImageCodecInfo encoder in ImageCodecInfo.GetImageEncoders ())
                {
                    if (encoder.MimeType == mimeType)
                        imageCodecInfo = encoder;
                }
            }
            return imageCodecInfo;
        }
    }
}