using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Drawing;
using DevExpress.Utils.Svg;

namespace LifeLog.Data.Models
{
	[Table("Images")]
	[Description("Database model for images")]
	public class ImagesModel : Bases.DataModelBase
	{
		#region PROPERTIES
		
		[DataType(DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		public string Name { get; set; }

		[Base.Infrastructure.Attributes.Required]
		public byte[] Data { get; set; }

		[DataType(DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(10)]
		public string FileExtension { get; set; }

		#endregion
		
		#region NOT MAPPED

		[JsonIgnore]
		[NotMapped]
		public bool IsSvg => FileExtension == null ? false : FileExtension.EndsWith("svg", System.StringComparison.InvariantCultureIgnoreCase);

		[JsonIgnore]
		[NotMapped]
		public SvgImage SvgImage => Data != null && Data.Length > 0 && IsSvg ? Base.Utils.ImagesUtil.ArrayToSvgImage(Data) : null;

		[JsonIgnore]
		[NotMapped]
		public Bitmap BitImage => Data != null && Data.Length > 0 && !IsSvg ? Base.Utils.ImagesUtil.ArrayToBitmap(Data) : null;

		#endregion
	}
}
