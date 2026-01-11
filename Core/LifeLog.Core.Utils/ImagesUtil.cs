using DevExpress.Utils.Svg;
using System.Drawing;
using System.Net;

namespace LifeLog.Core.Utils;

/// <summary>
/// Images class
/// </summary>
public static class ImagesUtil
{
    /// <summary>
    /// Get image bytes from file
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static byte[] GetImageBytes(this string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
            return null;

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            using (BinaryReader br = new BinaryReader(fs))
            {
                return br.ReadBytes((int)fs.Length);
            }
        }
    }

    /// <summary>
    /// Array to bitmap
    /// </summary>
    /// <param fName="imageData"></param>
    /// <returns></returns>
    public static Bitmap? ArrayToBitmap(this byte[] imageData)
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
    public static SvgImage ArrayToSvgImage(this byte[] imageData)
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
    public static Bitmap ImageUrlToBitmap(this string imageUrl)
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
