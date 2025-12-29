using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Data.DTOs;

[Table("Users")]
[Description("Database model for users")]
public class UsersDTO
{
	#region PROPERTIES

	[Key]
	public Guid? Id { get; set; }

	[DataType(DataType.Text)]
	[LifeLog.Core.Attributes.Required]
	[LifeLog.Core.Attributes.StringLength(20, MinimumLength = 5)]
	public string? Username { get; set; }

	[DataType(DataType.EmailAddress)]
	[LifeLog.Core.Attributes.Required]
	[LifeLog.Core.Attributes.StringLength(256, MinimumLength = 5)]
	[LifeLog.Core.Attributes.EmailValidator]
	public string? Email { get; set; }

	[DataType(DataType.Password)]
	[LifeLog.Core.Attributes.Required]
	[LifeLog.Core.Attributes.StringLength(30, MinimumLength = 3)]
	public string? Password { get; set; }

	#endregion
}