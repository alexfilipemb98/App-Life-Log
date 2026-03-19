using System;
using System.ComponentModel.DataAnnotations;

namespace LifeLog.Core.Attributes;

/// <summary>
/// Validate date atribute
/// </summary>
public class ValidDateAttribute : ValidationAttribute
{
    #region OVERRIDES

    /// <summary>
    /// Check if the date only is valid
    /// </summary>
    /// <param name="value"></param>
    /// <param name="validationContext"></param>
    /// <returns></returns>
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is not DateTime dateValue)
            return new ValidationResult(string.Format(ErrorMessage ?? "Invalid date: {0}", value), [validationContext.MemberName ?? string.Empty]);

        if (dateValue == DateTime.MinValue)
            return new ValidationResult(string.Format(ErrorMessage ?? "Invalid date: {0}", dateValue), [validationContext.MemberName ?? string.Empty]);

        return ValidationResult.Success;
    }

    #endregion
}
