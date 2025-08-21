using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Base.Models.Data
{
	[Table("Images")]
	public class ImagesModel : Bases.DataModelBase
	{
		public string Name { get; set; }
		public byte[] Data { get; set; }
		public string FileExtension { get; set; }
		
		public bool IsSvg => FileExtension == null ? false : FileExtension.EndsWith("svg", System.StringComparison.InvariantCultureIgnoreCase);
		public DevExpress.Utils.Svg.SvgImage SvgImage => Data != null && Data.Length > 0 && IsSvg ? Utils.ImagesUtil.ArrayToSvgImage(Data) : null;
		public System.Drawing.Bitmap BitImage => Data != null && Data.Length > 0 && IsSvg ? Utils.ImagesUtil.ArrayToBitmap(Data) : null;

	}
}
