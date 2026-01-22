using DevExpress.Utils.Svg;
using System.Drawing;
using System.Runtime.Versioning;

namespace LifeLog.Core.Utils;

/// <summary>
/// Images class
/// </summary>
public static class ImagesUtil
{
	#region METHODS

	/// <summary>
	/// Get image bytes from file
	/// </summary>
	/// <param name="filePath"></param>
	/// <returns></returns>
	public static byte[]? GetImageBytes(this string filePath)
	{
		if (string.IsNullOrWhiteSpace(filePath))
			return null;

		using FileStream fs = new(filePath, FileMode.Open, FileAccess.Read);
		using BinaryReader br = new(fs);
		return br.ReadBytes((int)fs.Length);
	}

	/// <summary>
	/// Array to bitmap
	/// </summary>
	/// <param fName="imageData"></param>
	/// <returns></returns>
	[SupportedOSPlatform("windows")]
	public static Bitmap? ArrayToBitmap(this byte[] imageData)
	{
		using MemoryStream ms = new(imageData);
		using Image image = Image.FromStream(ms);
		return new Bitmap(image);
	}

	/// <summary>
	/// Array to svg image
	/// </summary>
	/// <param fName="imageData"></param>
	/// <returns></returns>
	public static SvgImage ArrayToSvgImage(this byte[] imageData)
	{
		using MemoryStream ms = new(imageData);
		return SvgImage.FromStream(ms);
	}

	/// <summary>
	/// Image from URL to Bitmap async
	/// </summary>
	/// <param name="imageUrl"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentException"></exception>
	[SupportedOSPlatform("windows")]
	public static async Task<Bitmap> ImageUrlToBitmapAsync(this string imageUrl)
	{
		if (string.IsNullOrWhiteSpace(imageUrl))
			throw new ArgumentException("URL inválida.", nameof(imageUrl));

		using HttpClient? http = new();

		byte[] bytes = await http.GetByteArrayAsync(imageUrl, default).ConfigureAwait(false);

		using MemoryStream? ms = new(bytes);
		using Bitmap? temp = new(ms);
		return new Bitmap(temp);
	}
	
	#endregion
}
