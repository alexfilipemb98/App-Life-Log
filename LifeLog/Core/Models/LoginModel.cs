using LifeLog.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LifeLog.Core.Models;

/// <summary>
/// Login Model
/// </summary>
public class LoginModel
{
	#region PROPERTIES
	
	[DataType(DataType.Text)]
	[Attributes.RequiredIf(nameof(IsNewUser), OperatorsEnum.Equal, true)]
	[Attributes.StringLength(20, MinimumLength = 5)]
	public string? Username { get; set; }

	[DataType(DataType.EmailAddress)]
	[Attributes.Required]
	[Attributes.StringLength(256, MinimumLength = 5)]
	[Attributes.EmailValidator]
	public string? Email { get; set; }

	[DataType(DataType.Password)]
	[Attributes.Required]
	[Attributes.StringLength(30, MinimumLength = 3)]
	public string? Password { get; set; }

	public bool IsNewUser { get; set; } 

	#endregion
}
