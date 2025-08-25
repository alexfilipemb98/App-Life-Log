using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Base.Models.Data
{
	[Table("Commands")]
	public class CommandsModel : Bases.DataModelBase
	{
		#region PROPERTIES

		[DataType(DataType.Text)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(13, MinimumLength = 3)]
		public string Name { get; set; }

		[DataType(DataType.Text)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		public string Description { get; set; }

		[DataType(DataType.Text)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(4000)]
		public string Command { get; set; }

		public bool IsEnabled { get; set; }

		public bool NeedsAdmin { get; set; }

		#endregion

		#region CLASS

		[JsonIgnore]
		[DataType(DataType.Custom)]
		[Infrastructure.Attributes.Required]
		public LoggedUserModel User { get; set; }

		[JsonIgnore]
		[DataType(DataType.Custom)]
		[Infrastructure.Attributes.Required]
		public ExternalProgramsModel ExternalProgram { get; set; }

		#endregion

		#region NOT MAPPED

		[NotMapped]
		[JsonIgnore]
		[DataType(DataType.Custom)]
		public dynamic Icon { get; set; } 
		
		#endregion
	}
}
