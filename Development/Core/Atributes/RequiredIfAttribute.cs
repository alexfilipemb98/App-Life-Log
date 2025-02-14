using Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Atributes
{
    /// <summary>
    /// This is an atribute that set a property to requiered if a condition
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class RequiredIfAttribute : ValidationAttribute
    {
        #region MAIN

        //PRIVATE

        private readonly string _otherPropertyName;
        private readonly object _otherPropertyValue;
        private readonly OperatorsEnum _operator;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param fName="otherPropertyName"></param>
        /// <param fName="operator"></param>
        /// <param fName="otherPropertyValue"></param>
        public RequiredIfAttribute(string otherPropertyName, OperatorsEnum @operator, object otherPropertyValue)
        {
            _otherPropertyName = otherPropertyName;
            _otherPropertyValue = otherPropertyValue;
            _operator = @operator;

            ErrorMessage = "The field '{0}' is required!";
        }

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Override IsValid
        /// </summary>
        /// <param fName="value"></param>
        /// <param fName="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (validationContext == null)
                throw new ArgumentException($"Validation context is null");

            System.Reflection.PropertyInfo otherPropertyInfo = validationContext.ObjectType.GetProperty(_otherPropertyName);

            if (otherPropertyInfo == null)
                return new ValidationResult($"Property {_otherPropertyName} not found.");

            object otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance);

            // Check if otherPropertyValue matches the condition
            if (!MatchesCondition(otherPropertyValue, _operator, _otherPropertyValue))
                return ValidationResult.Success;

            // Check for null or empty string
            if (value is string stringValue && string.IsNullOrWhiteSpace(stringValue))
                return new ValidationResult(string.Format(ErrorMessage, validationContext.MemberName), new[] { validationContext.MemberName });

            // Check for non-null
            if (value == null)
                return new ValidationResult(string.Format(ErrorMessage, validationContext.MemberName), new[] { validationContext.MemberName });

            // Check for non-zero integer
            if (value is int intValue && intValue == 0)
                return new ValidationResult(string.Format(ErrorMessage, validationContext.MemberName), new[] { validationContext.MemberName });

            return ValidationResult.Success;
        }

        #endregion

        #region FUNCTION'S

        /// <summary>
        /// Verify the codiciton
        /// </summary>
        /// <param fName="value1"></param>
        /// <param fName="operator"></param>
        /// <param fName="value2"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private bool MatchesCondition(object value1, OperatorsEnum @operator, object value2)
        {
            switch (@operator)
            {
                case OperatorsEnum.Equal:
                    return IsEqual(value1, value2);
                case OperatorsEnum.NotEqual:
                    return IsNotEqual(value1, value2);
                default:
                    throw new ArgumentException($"Invalid operator: '{@operator}'");
            }
        }

        /// <summary>
        /// Validate if is equal to value
        /// </summary>
        /// <param fName="value1"></param>
        /// <param fName="value2"></param>
        /// <returns></returns>
        private bool IsEqual(object value1, object value2)
        {
            if (value1 == null && value2 == null)
                return true;

            if (value1 == null || value2 == null)
                return false;

            if (value1.GetType() != value2.GetType())
            {
                try
                {
                    value2 = Convert.ChangeType(value2, value1.GetType());
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return value1.Equals(value2);
        }

        /// <summary>
        /// If is not equal
        /// </summary>
        /// <param fName="value1"></param>
        /// <param fName="value2"></param>
        /// <returns></returns>
        private bool IsNotEqual(object value1, object value2)
        {
            return !IsEqual(value1, value2);
        }

        #endregion
    }
}
