using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LifeLog.Core.Models;

/// <summary>
/// Logged user model
/// </summary>
public class LoggedUserModel
{
	#region PROPERTIES
	
	[DataType(DataType.Custom)]
	public Guid Id { get; set; }

	[DataType(DataType.Text)]
	[Attributes.Required]
	[Attributes.StringLength(20, MinimumLength = 5)]
	public string? Username { get; set; }

	[DataType(DataType.EmailAddress)]
	[Attributes.Required]
	[Attributes.StringLength(256, MinimumLength = 5)]
	[Attributes.EmailValidator]
	public string? Email { get; set; } 

	#endregion

}
