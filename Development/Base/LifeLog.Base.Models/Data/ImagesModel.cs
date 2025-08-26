using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LifeLog.Base.Models.Data
{
	[Table("Images")]
	[Description("Database model for images")]
	public class ImagesModel : Bases.DataModelBase
	{
		#region PROPERTIES
		
		[DataType(DataType.Text)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		public string Name { get; set; }

		[Infrastructure.Attributes.Required]
		public byte[] Data { get; set; }

		[DataType(DataType.Text)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(10)]
		public string FileExtension { get; set; }

		#endregion
		
		#region NOT MAPPED

		[JsonIgnore]
		[NotMapped]
		public bool IsSvg => FileExtension == null ? false : FileExtension.EndsWith("svg", System.StringComparison.InvariantCultureIgnoreCase);

		[JsonIgnore]
		[NotMapped]
		public DevExpress.Utils.Svg.SvgImage SvgImage => Data != null && Data.Length > 0 && IsSvg ? Utils.ImagesUtil.ArrayToSvgImage(Data) : null;

		[JsonIgnore]
		[NotMapped]
		public System.Drawing.Bitmap BitImage => Data != null && Data.Length > 0 && !IsSvg ? Utils.ImagesUtil.ArrayToBitmap(Data) : null;

		#endregion
	}
}
