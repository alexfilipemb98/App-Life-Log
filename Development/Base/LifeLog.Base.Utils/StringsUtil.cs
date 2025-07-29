using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Base.Utils
{
	/// <summary>
	/// Strings utility class providing various string manipulation methods.
	/// </summary>
	public static class StringsUtil
	{
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
	}
}
