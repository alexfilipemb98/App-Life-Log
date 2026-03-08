using System;
using System.Text.RegularExpressions;

namespace LifeLog.Core.Utils;

/// <summary>
/// Validation utility functions, such as email and URL validation. This class provides static methods to assist with common validation tasks in the application.
/// </summary>
public static partial class ValidationsUtil
{
    /// <summary>
    /// Validate email format using a regular expression. The method checks if the input string is a valid email address by ensuring it contains an '@' symbol, followed by a domain name and a top-level domain. 
    /// It returns true if the email is valid, and false otherwise.
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
    /// Validate URL format using the Uri.TryCreate method. The method checks if the input string is a well-formed URL by attempting to create a Uri object. 
    /// It ensures that the URL has an absolute format and uses either the HTTP or HTTPS scheme. It returns true if the URL is valid, and false otherwise.
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
}
