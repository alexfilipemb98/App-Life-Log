using LifeLog.Core.Enums;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Data.DTOs;

[Table("Commands")]
[Description("Database model for commands")]
public class CommandsDTO
{
	#region PROPERTIES

	[Key]
	public Guid? Id { get; set; }

	[DataType(DataType.Text)]
	[Core.Attributes.Required]
	[Core.Attributes.StringLength(13, MinimumLength = 3)]
	public string? Name { get; set; }

	[DataType(DataType.Text)]
	[Core.Attributes.Required]
	[Core.Attributes.StringLength(30, MinimumLength = 3)]
	public string? Description { get; set; }

	[DataType(DataType.Text)]
	[Core.Attributes.Required]
	[Core.Attributes.StringLength(4000)]
	public string? Command { get; set; }

	[JsonIgnore]
	public bool IsEnabled { get; set; }

	[JsonIgnore]
	public bool NeedsAdmin { get; set; }

	[JsonIgnore]
	public short Position { get; set; }

	#endregion

	#region CLASS

	[JsonIgnore]
	[Core.Attributes.RequiredIf(nameof(IsEnabled), OperatorsEnum.Equal, true)]
	public ExternalProgramsDTO? ExternalProgram { get; set; }

	#endregion

	#region EXTERNAL ID'S

	[JsonIgnore]
	[Core.Attributes.Required]
	public Guid? IdUser { get; set; }

	#endregion

	#region NOT MAPPED

	[NotMapped]
	[JsonIgnore]
	public dynamic? Icon { get; set; }

	#endregion

}
