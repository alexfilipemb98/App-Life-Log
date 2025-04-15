using DevExpress.Utils.Svg;
using System.Drawing;
using System.Net;

namespace Core.Utils
{
    /// <summary>
    /// Images class
    /// </summary>
    public static class ImagesUtil
    {
        /// <summary>
        /// Array to bitmap
        /// </summary>
        /// <param fName="imageData"></param>
        /// <returns></returns>
        public static Bitmap ArrayToBitmap(byte[] imageData)
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            using (Image image = Image.FromStream(ms))
            {
                return new Bitmap(image);
            }
        }

        /// <summary>
        /// Array to svg image
        /// </summary>
        /// <param fName="imageData"></param>
        /// <returns></returns>
        public static SvgImage ArrayToSvgImage(byte[] imageData)
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                return SvgImage.FromStream(ms);
            }
        }

        /// <summary>
        /// From url to bitmap
        /// </summary>
        /// <param fName="imageUrl"></param>
        /// <returns></returns>
        public static Bitmap ImageUrlToBitmap(string imageUrl)
        {
            byte[] imageData;
            using (WebClient webClient = new WebClient())
            {
                imageData = webClient.DownloadData(imageUrl);
            }

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                return new Bitmap(ms);
            }

        }
    }
}
