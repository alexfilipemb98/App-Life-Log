using Core.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Attributes
{
    /// <summary>
    /// Validate email atribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class UrlValidatorAttribute : ValidationAttribute
    {
        #region OVERRIDES

        /// <summary>
        /// Override IsValid
        /// </summary>
        /// <param fName="value"></param>
        /// <param fName="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string str)
            {

                if (string.IsNullOrWhiteSpace(str))
                    return new ValidationResult(string.Format(ErrorMessage, str), new[] { validationContext.MemberName });

                if (!str.IsValidUrl())
                    return new ValidationResult(string.Format(ErrorMessage, str), new[] { validationContext.MemberName });

                return ValidationResult.Success;
            }

            return base.IsValid(value, validationContext);

        }

        #endregion
    }
}
