using Core.Utils;
using System;
using System.Globalization;

namespace Core.Extensions
{
    /// <summary>
    /// Extensions form strings
    /// </summary>
    public static class StringExtension
    {
        #region SECURITY

        /// <summary>
        /// Extension to encrypt string
        /// </summary>
        /// <param fName="plainText"></param>
        /// <returns></returns>
        public static string Encrypt(this string plainText) => SecurityUtil.Encrypt(plainText);

        /// <summary>
        /// Extension to decrypt string
        /// </summary>
        /// <param fName="plainText"></param>
        /// <returns></returns>
        public static string Decrypt(this string encondeString) => SecurityUtil.Decrypt(encondeString);

        #endregion

        #region VALIDATION

        /// <summary>
        /// Checks if string is a valid email
        /// </summary>
        /// <param fName="email"></param>
        /// <returns></returns>
        public static bool IsEmailValid(this string email) => ValidationUtil.IsValidEmail(email);

        /// <summary>
        /// Checks if a string is a valid url
        /// </summary>
        /// <param fName="url"></param>
        /// <returns></returns>
        public static bool IsValidUrl(this string url) => ValidationUtil.IsValidUrl(url);

        #endregion

        #region OTHERS

        /// <summary>
        /// Converts a string to title case.
        /// </summary>
        /// <param fName="text">The input string to be converted.</param>
        /// <returns>The input string converted to title case.</returns>
        public static string ToTitleCase(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            text = text.ToLower();

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(text);
        }

        /// <summary>
        /// Converts a string to sentence case (first letter uppercase, rest lowercase).
        /// </summary>
        /// <param fName="text">The input string to be converted.</param>
        /// <returns>The input string converted to sentence case.</returns>
        public static string ToSentenceCase(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string[] sentences = text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;
            foreach (string sentence in sentences)
            {
                string sentenceCase = char.ToUpper(sentence[0]) + sentence.Substring(1).ToLower();
                result += sentenceCase + "\r\n";
            }

            result = result.TrimEnd('\r', '\n');
            return result;
        }

        /// <summary>
        /// Converts the input string to an alternative case, where each character's case alternates between upper and lower case.
        /// </summary>
        /// <param fName="input">The input string to convert.</param>
        /// <returns>The input string with alternating upper and lower case characters.</returns>
        public static string ToAlternativeCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (i % 2 == 0)
                    chars[i] = char.ToUpper(chars[i]);
                else
                    chars[i] = char.ToLower(chars[i]);
            }

            return new string(chars);
        }

        /// <summary>
        /// Inverts the case of each character in the input string.
        /// </summary>
        /// <param fName="input">The input string to invert.</param>
        /// <returns>The input string with the case of each character inverted.</returns>
        public static string InvertCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                    chars[i] = char.ToLower(chars[i]);
                else if (char.IsLower(chars[i]))
                    chars[i] = char.ToUpper(chars[i]);
            }

            return new string(chars);
        }

        #endregion
    }
}
