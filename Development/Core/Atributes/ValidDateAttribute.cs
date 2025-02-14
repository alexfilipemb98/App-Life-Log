using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Atributes
{
    /// <summary>
    /// Validate date atribute
    /// </summary>
    public class ValidDateAttribute : ValidationAttribute
    {
        #region OVERRIDES

        /// <summary>
        /// Check if the date only is valid
        /// </summary>
        /// <param fName="value"></param>
        /// <param fName="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is DateTime dateValue))
                return new ValidationResult(string.Format(ErrorMessage, value), new[] { validationContext.MemberName });

            if (dateValue == DateTime.MinValue)
                return new ValidationResult(string.Format(ErrorMessage, dateValue), new[] { validationContext.MemberName });

            return ValidationResult.Success;
        }

        #endregion
    }
}
