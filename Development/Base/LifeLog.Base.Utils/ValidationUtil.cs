using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace LifeLog.Base.Utils
{
	/// <summary>
	/// Validation class
	/// </summary>
	public static class ValidationUtil
	{
		/// <summary>
		/// Validates Email
		/// </summary>
		/// <param fName="email"></param>
		/// <returns></returns>
		public static bool IsValidEmail(this string email)
		{
			if (string.IsNullOrWhiteSpace(email))
				return false;

			string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
			return Regex.IsMatch(email, emailPattern);
		}

		/// <summary>
		/// Is url valid
		/// </summary>
		/// <param fName="url"></param>
		/// <returns></returns>
		public static bool IsValidUrl(this string url)
		{
			if (string.IsNullOrWhiteSpace(url))
				return false;

			return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
				   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
		}

		/// <summary>
		/// Validate model
		/// </summary>
		/// <typeparam fName="T"></typeparam>
		/// <param fName="model"></param>
		/// <param fName="validationResults"></param>
		/// <returns></returns>
		public static bool ValidateModel<T>(this T model, out List<ValidationResult> validationResults)
		{
			ValidationContext validationContext = new ValidationContext(model);
			validationResults = new List<ValidationResult>();
			bool isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);
			return isValid;
		}

		/// <summary>
		/// Is model valid
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="model"></param>
		/// <returns></returns>
		public static bool ValidateModel<T>(this T model) =>
			ValidateModel(model, out _);
	}
}
