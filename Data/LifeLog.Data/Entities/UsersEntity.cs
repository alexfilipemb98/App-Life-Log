using LifeLog.Core.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Data.Entities;

[Table("Users")]
[Description("Database model for users")]
public class UsersEntity
{
	#region PROPERTIES

	[Key]
	public Guid? Id { get; set; }

	[DataType(DataType.Text)]
	[Core.Attributes.Required]
	[Core.Attributes.StringLength(20, MinimumLength = 5)]
	public string? Username { get; set; }

	[DataType(DataType.EmailAddress)]
	[Core.Attributes.Required]
	[Core.Attributes.StringLength(256, MinimumLength = 5)]
	[Core.Attributes.EmailValidator]
	public string? Email { get; set; }

	[DataType(DataType.Password)]
	[Core.Attributes.RequiredIf(nameof(RequiredPassword), OperatorsEnum.Equal, true)]
	[Core.Attributes.StringLength(30, MinimumLength = 3)]
	public string? Password { get; set; }

    #endregion

    #region NOT MAPPED

    [NotMapped]
    public bool IsNew { get; set; }
    
	[NotMapped]
    public bool ChangePassword { get; set; }

	[NotMapped]
	private bool RequiredPassword => IsNew || ChangePassword;

	#endregion
}