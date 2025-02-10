using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Exceptions
{
    /// <summary>
    /// Validation Exception
    /// </summary>
    public class ValidationException : Exception
    {
        //PROPERTIES
        public List<ValidationResult> ValidationResults { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="validationResults"></param>
        public ValidationException(List<ValidationResult> validationResults)
            : base("Validation failed. See ValidationResults for details.")
        {
            ValidationResults = validationResults;
        }
    }
}
