using LifeLog.Base.Infrastructure.Enums;
using LifeLog.Base.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Data.Models
{
	[Table("Commands")]
	[Description("Database model for commands")]
	public class CommandsModel : Bases.DataModelBase
	{
		#region PROPERTIES

		[DataType(DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(13, MinimumLength = 3)]
		public string Name { get; set; }

		[DataType(DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		public string Description { get; set; }

		[DataType(DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(4000)]
		public string Command { get; set; }

		[JsonIgnore]
		public bool IsEnabled { get; set; }

		[JsonIgnore]
		public bool NeedsAdmin { get; set; }
		
		[JsonIgnore]
		public short Position { get; set; }

		#endregion

		#region CLASS

		[JsonIgnore]
		[Base.Infrastructure.Attributes.Required]
		public LoggedUserModel User { get; set; }

		[JsonIgnore]
		[Base.Infrastructure.Attributes.RequiredIf(nameof(IsEnabled), OperatorsEnum.Equal, true)]
		public ExternalProgramsModel ExternalProgram { get; set; }

		#endregion

		#region NOT MAPPED

		[NotMapped]
		[JsonIgnore]
		public dynamic Icon { get; set; } 
		
		#endregion
	}
}
