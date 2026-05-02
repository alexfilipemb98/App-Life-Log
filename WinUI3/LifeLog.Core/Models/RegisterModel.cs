using LifeLog.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace LifeLog.Core.Models;

/// <summary>
/// Register Model
/// </summary>
public class RegisterModel
{
    #region PROPERTIES

    [DataType(DataType.Text)]
    [Attributes.StringLength(20, MinimumLength = 5)]
    public required string Username { get; set; }

    [DataType(DataType.EmailAddress)]
    [Attributes.Required]
    [Attributes.StringLength(256, MinimumLength = 5)]
    [Attributes.EmailValidator]
    public required string Email { get; set; }

    [DataType(DataType.Password)]
    [Attributes.Required]
    [Attributes.StringLength(30, MinimumLength = 3)]
    public required string Password { get; set; }

    #endregion
}
