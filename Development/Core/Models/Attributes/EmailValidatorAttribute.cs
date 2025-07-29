using System;
using System.ComponentModel.DataAnnotations;
using Utils.Extensions;

namespace Models.Attributes
{
    /// <summary>
    /// Validate email attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class EmailValidatorAttribute : ValidationAttribute
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
            if (value == null)
                return ValidationResult.Success;

            if (value is string str)
            {
                if (!str.IsEmailValid())
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
