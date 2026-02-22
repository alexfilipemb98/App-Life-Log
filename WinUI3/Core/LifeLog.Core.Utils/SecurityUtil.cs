using System;
using System.Collections.Generic;
using System.Linq;

namespace LifeLog.Core.Utils;

/// <summary>
/// Security-related utility functions, such as password generation, encryption, and hashing. This class provides static methods to assist with common security tasks in the application.
/// </summary>
public static class SecurityUtil
{

    /// <summary>
    /// Generates a random password of the specified length using a combination of upper-case letters, lower-case
    /// letters, numbers, and symbols, with options to include or exclude ambiguous characters.
    /// </summary>
    /// <remarks>At least one character from each selected character type is guaranteed to appear in the
    /// password. If no character types are selected, the resulting password may be empty or invalid. Ambiguous
    /// characters are those that are easily confused, such as 'l', '1', 'O', and '0'.</remarks>
    /// <param name="length">The total number of characters in the generated password. Must be a positive integer greater than or equal to
    /// the number of selected character types.</param>
    /// <param name="useUpper">true to include upper-case letters (A–Z) in the password; otherwise, false.</param>
    /// <param name="useLower">true to include lower-case letters (a–z) in the password; otherwise, false.</param>
    /// <param name="useNumbers">true to include numeric digits (0–9) in the password; otherwise, false.</param>
    /// <param name="useSymbols">true to include special symbol characters in the password; otherwise, false.</param>
    /// <param name="excludeAmbiguous">true to exclude ambiguous characters (such as 'l', '1', 'O', and '0') from the password; otherwise, false.</param>
    /// <returns>A randomly generated password string that meets the specified criteria.</returns>
    public static string GeneratePassword(int length, bool useUpper, bool useLower, bool useNumbers, bool useSymbols, bool excludeAmbiguous)
    {
        string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowerChars = "abcdefghijklmnopqrstuvwxyz";
        string numberChars = "0123456789";
        string symbolChars = "!@#$%^&*()_-+=[{]};:>|./?";
        string ambiguousChars = "il1Lo0O";

        if (excludeAmbiguous)
        {
            upperChars = new string(upperChars.Where(c => !ambiguousChars.Contains(c)).ToArray());
            lowerChars = new string(lowerChars.Where(c => !ambiguousChars.Contains(c)).ToArray());
            numberChars = new string(numberChars.Where(c => !ambiguousChars.Contains(c)).ToArray());
            symbolChars = new string(symbolChars.Where(c => !ambiguousChars.Contains(c)).ToArray());
        }

        List<char> password = new List<char>();
        string fullPool = "";

        if (useUpper && upperChars.Length > 0)
        {
            password.Add(upperChars[Random.Shared.Next(upperChars.Length)]);
            fullPool += upperChars;
        }
        if (useLower && lowerChars.Length > 0)
        {
            password.Add(lowerChars[Random.Shared.Next(lowerChars.Length)]);
            fullPool += lowerChars;
        }
        if (useNumbers && numberChars.Length > 0)
        {
            password.Add(numberChars[Random.Shared.Next(numberChars.Length)]);
            fullPool += numberChars;
        }
        if (useSymbols && symbolChars.Length > 0)
        {
            password.Add(symbolChars[Random.Shared.Next(symbolChars.Length)]);
            fullPool += symbolChars;
        }

        while (password.Count < length)
        {
            password.Add(fullPool[Random.Shared.Next(fullPool.Length)]);
        }

        return new string(password.OrderBy(x => Random.Shared.Next()).ToArray());
    }
}
