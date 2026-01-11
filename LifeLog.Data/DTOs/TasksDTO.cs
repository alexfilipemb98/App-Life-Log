using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Data.DTOs;

[Table("Tasks")]
[Description("Database model for tasks")]
public class TasksDTO
{
	#region PROPERTIES

	[Key]
	public Guid? Id { get; set; }

	[DataType(DataType.Text)]
	[Core.Attributes.Required]
	[Core.Attributes.StringLength(350, MinimumLength = 3)]
	public string? Description { get; set; }

	public bool IsDone { get; set; }

	#endregion

	#region EXTERNAL ID'S

	[Core.Attributes.Required]
	public Guid? IdUser { get; set; }

	#endregion
}
