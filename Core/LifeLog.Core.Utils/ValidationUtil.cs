using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LifeLog.Core.Utils;

/// <summary>
/// <summary>
/// Validation class
/// </summary>
public static class ValidationUtil
{
	#region METHODS

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
	/// <typeparam name="T"></typeparam>
	/// <param name="model"></param>
	/// <param name="validationResults"></param>
	/// <returns></returns>
	public static bool ValidateModel<T>(this T model, out List<ValidationResult> validationResults)
	{
		if (model == null)
		{
			validationResults = new List<ValidationResult>
			{
				new("Model is null")
			};
			return false;
		}

		ValidationContext validationContext = new(model);
		validationResults = [];
		bool isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);
		return isValid;
	}

	/// <summary>
	/// Is model valid
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="model"></param>
	/// <returns></returns>
	public static bool IsValid<T>(this T model) =>
		ValidateModel(model, out _);

	#endregion
}
