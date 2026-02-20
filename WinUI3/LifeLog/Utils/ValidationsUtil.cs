using System;
using System.Text.RegularExpressions;

namespace LifeLog.Utils;

/// <summary>
/// Validation
/// </summary>
public static partial class ValidationsUtil
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
}
