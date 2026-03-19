using LifeLog.Core.Utils;
using System;
using System.ComponentModel.DataAnnotations;

namespace LifeLog.Core.Attributes;

/// <summary>
/// Validate url atribute
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class UrlValidatorAttribute : ValidationAttribute
{
	#region OVERRIDES

	/// <summary>
	/// Override IsValid
	/// </summary>
	/// <param name="value"></param>
	/// <param name="validationContext"></param>
	/// <returns></returns>
	protected override ValidationResult IsValid(object value, ValidationContext validationContext)
	{
		if (value is string str)
		{

			if (string.IsNullOrWhiteSpace(str))
				return new ValidationResult(string.Format(ErrorMessage ?? "Invalid URL: {0}", str), [validationContext.MemberName ?? string.Empty]);

			if (!str.IsValidUrl())
				return new ValidationResult(string.Format(ErrorMessage ?? "Invalid URL: {0}", str), [validationContext.MemberName ?? string.Empty]);

			return ValidationResult.Success;
		}

		return base.IsValid(value, validationContext);

	}

	#endregion
}
