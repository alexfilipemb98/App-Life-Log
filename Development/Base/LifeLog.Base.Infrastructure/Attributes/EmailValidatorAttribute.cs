using LifeLog.Base.Utils;
using System;
using System.ComponentModel.DataAnnotations;

namespace LifeLog.Base.Infrastructure.Attributes
{
	/// <summary>
	/// Validate email attribute
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class EmailValidatorAttribute : ValidationAttribute
	{
		#region OVERRIDES

		/// <summary>
		/// Override ValidateModel
		/// </summary>
		/// <param name="value"></param>
		/// <param name="validationContext"></param>
		/// <returns></returns>
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value == null)
				return ValidationResult.Success;

			if (value is string str)
			{
				if (!str.IsValidEmail())
				{
					string memberName = validationContext?.MemberName ?? "Unknown";
					return new ValidationResult($"Email '{str}' is not valid!", new[] { memberName });
				}

				return ValidationResult.Success;
			}

			return base.IsValid(value, validationContext);
		}

		#endregion
	}
}
