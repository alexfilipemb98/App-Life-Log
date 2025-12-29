using System;
using System.Linq;

namespace LifeLog.Core.Attributes
{
    /// <summary>
    /// String lengh with a auto message
    /// </summary>
    public class StringLengthAttribute : System.ComponentModel.DataAnnotations.StringLengthAttribute
    {
        #region MAIN

        //PRIVATE
        private int? CurrentLength { get; set; }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="maximumLength"></param>
        public StringLengthAttribute(int maximumLength) : base(maximumLength)
        {
        }

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Is Valid
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            int currentLength = value is string str ? str.Length : 0;

            CurrentLength = currentLength;

            if (value != null)
            {
                if (currentLength >= MinimumLength)
                {
                    return currentLength <= MaximumLength;
                }
                return false;
            }

            return true;
        }

        /// <summary>
        /// Format error message
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override string FormatErrorMessage(string name)
        {

            if (CurrentLength.HasValue)
            {
                if (CurrentLength.Value < MinimumLength)
                {
                    return $"The '{name}' length is '{CurrentLength.Value}', must be at least '{MinimumLength}' characters!";
                }
                else if (CurrentLength.Value > MaximumLength)
                {
                    return $"The '{name}' length is '{CurrentLength.Value}', must be less or equal to '{MaximumLength}' characters!";
                }
            }

            return $"The '{name}' length must be between '{MinimumLength}' and '{MaximumLength}' characters!";
        }

        #endregion
    }
}
