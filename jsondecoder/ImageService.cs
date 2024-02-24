using jsondecoder.Models;
using RestSharp;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace jsondecoder
{
    public class ImageService
    {

        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;

        public static void generateImage(DateTime dateTime)
        {
            string str = string.Format("scr{0:yyyyMMddHHmmssfff}.jpg", (object)dateTime);
            string path = Application.StartupPath + "img.jpg";
            byte[] bytes= File.ReadAllBytes(path);

            ImageDetail imageDetails = new ImageDetail()
            {
                Date = dateTime,
                LocalUtcTime = new DateTime?(DateTime.UtcNow),
                FileName = str,
                IsUploaded = false
            };



        }








        public static byte[] ResizeImage(byte[] byteArray)
        {
            Rectangle destRect = new Rectangle(0, 0, 205, 112);
            using (MemoryStream memoryStream1 = new MemoryStream(byteArray))
            {
                using (Image image = Image.FromStream((Stream)memoryStream1))
                {
                    using (MemoryStream memoryStream2 = new MemoryStream())
                    {
                        using (Bitmap bitmap = new Bitmap(205, 112))
                        {
                            bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
                            using (Graphics graphics = Graphics.FromImage((Image)bitmap))
                            {
                                graphics.CompositingMode = CompositingMode.SourceCopy;
                                graphics.CompositingQuality = CompositingQuality.HighQuality;
                                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                graphics.SmoothingMode = SmoothingMode.HighQuality;
                                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                                using (ImageAttributes imageAttr = new ImageAttributes())
                                {
                                    imageAttr.SetWrapMode(WrapMode.TileFlipXY);
                                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttr);
                                }
                            }
                            bitmap.Save((Stream)memoryStream2, ImageFormat.Jpeg);
                        }
                        return memoryStream2.ToArray();
                    }
                }
            }
        }



    }
}
