using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Base.Models.Data
{
    [Table("ExternalPrograms")]
	[Description("Database model for external programs")]
	public class ExternalProgramsModel : Bases.DataModelBase
	{
		#region PROPERTIES
		
		[DataType(DataType.Text)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		public string Name { get; set; }

		[DataType(DataType.Text)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(5)]
		public string FileExtension { get; set; }

		[DataType(DataType.Text)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(400)]
		public string PathToProgram { get; set; }

		[DataType(DataType.Text)]
		[Infrastructure.Attributes.StringLength(150)]
		public string Arguments { get; set; }

		#endregion

		#region CLASS

		[JsonIgnore]
		public ImagesModel Image { get; set; }

		#endregion

		#region NOT MAPPED

		[NotMapped]
		[JsonIgnore]
		public dynamic Icon { get; set; } 

		#endregion
	}
}
