using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Data.Entities;

[Table("Motes")]
[Description("Database model for notes")]
public class NotesEntity
{
	#region PROPERTIES

	[Key]
	public Guid? Id { get; set; }

	[DataType(DataType.Text)]
	[Core.Attributes.Required]
	[Core.Attributes.StringLength(30, MinimumLength = 3)]
	public string? Title { get; set; }

	[DataType(DataType.Text)]
	public string? Text { get; set; }
	
	public int Color { get; set; }

	public short Position { get; set; }

	#endregion

	#region EXTERNAL ID'S

	[Core.Attributes.Required]
	public Guid? IdUser { get; set; }

	#endregion
}
