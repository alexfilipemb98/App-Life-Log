using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LifeLog.Core.Utils;

/// <summary>
/// Security-related utility functions, such as password generation, encryption, and hashing. This class provides static methods to assist with common security tasks in the application.
/// </summary>
public static class SecurityUtil
{
    #region MAIN

    //PUBLIC
    public static readonly byte[] JWT_SECREET = Encoding.UTF8.GetBytes("539e63b7d5776f8a8cd1d20e723e74b6cef02056743c8ec90bab844394084b27"); // 32 bytes (256 bits)

    //PRIVATE
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("cbed4803512b57c8704987808f6738e2"); // 16 bytes (128 bits)
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("1fd147bacb857e4f8e15e65e98facca9"); // 16 bytes (128 bits)

    #endregion

    #region METHODS

    /// <summary>
    /// Encrypts Bytes
    /// </summary>
    /// <param fName="plainBytes"></param>
    /// <returns></returns>
    public static byte[] Encrypt(this byte[] plainBytes)
    {
        using Aes aes = Aes.Create();
        aes.Key = Key;
        aes.IV = IV;

        using ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        using MemoryStream ms = new();
        using CryptoStream? cs = new(ms, encryptor, CryptoStreamMode.Write);

        cs.Write(plainBytes, 0, plainBytes.Length);
        cs.FlushFinalBlock();

        return ms.ToArray();
    }

    /// <summary>
    /// Encripts the text
    /// </summary>
    /// <param fName="plainText"></param>
    /// <returns></returns>
    public static string? Encrypt(this string plainText)
    {
        if (string.IsNullOrWhiteSpace(plainText))
            return null;

        using Aes aes = Aes.Create();
        aes.Key = Key;
        aes.IV = IV;

        using ICryptoTransform? encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        using MemoryStream? ms = new();
        using CryptoStream? cs = new(ms, encryptor, CryptoStreamMode.Write);
        using StreamWriter? sw = new(cs);

        sw.Write(plainText);

        return Convert.ToBase64String(ms.ToArray());
    }

    /// <summary>
    /// Decrypts bytes
    /// </summary>
    /// <param fName="encryptedBytes"></param>
    /// <returns></returns>
    public static byte[] Decrypt(this byte[] encryptedBytes)
    {
        using Aes aes = Aes.Create();
        aes.Key = Key;
        aes.IV = IV;

        using ICryptoTransform? decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        using MemoryStream? ms = new(encryptedBytes);
        using CryptoStream? cs = new(ms, decryptor, CryptoStreamMode.Read);
        using MemoryStream? msOutput = new();

        cs.CopyTo(msOutput);
        return msOutput.ToArray();
    }

    /// <summary>
    /// Decripts the text
    /// </summary>
    /// <param fName="cipherText"></param>
    /// <returns></returns>
    public static string? Decrypt(this string cipherText)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(cipherText))
                return default;

            using Aes aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;

            using ICryptoTransform? decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using MemoryStream? ms = new(Convert.FromBase64String(cipherText));
            using CryptoStream? cs = new(ms, decryptor, CryptoStreamMode.Read);
            using StreamReader? sr = new(cs);
            return sr.ReadToEnd();
        }
        catch (Exception)
        {
            return cipherText;
        }
    }

    /// <summary>
    /// Generates a salt
    /// </summary>
    /// <param fName="length"></param>
    /// <returns></returns>
    public static string GenerateSalt(int length = 30)
    {
        using var random = RandomNumberGenerator.Create();
        byte[] salt = new byte[length];
        random.GetBytes(salt);
        return Convert.ToBase64String(salt);
    }

    /// <summary>
    /// Computes a sha512 that joins password and salt
    /// </summary>
    /// <param fName="password"></param>
    /// <param fName="salt"></param>
    /// <returns></returns>
    public static string Sha512_EncryptPasswordWithSalt(this string password, string salt)
    {
        string saltAndPwd = string.Concat(password, salt);
        return ComputeSHA512Hash(saltAndPwd);
    }

    /// <summary>
    /// Validate Computed SHA512 Hash
    /// </summary>
    /// <param fName="encryptedString"></param>
    /// <param fName="plainText"></param>
    /// <returns></returns>
    public static bool CompareStringEncryptedWithSalt(this string plainText, string encryptedString, string salt)
    {
        string saltAndPwd = string.Concat(plainText, salt);
        string hashedPassword = ComputeSHA512Hash(saltAndPwd);
        return encryptedString.Equals(hashedPassword);
    }

    /// <summary>
    /// Encodes a string to base64 encription
    /// </summary>
    /// <param fName="plainText"></param>
    /// <returns></returns>
    /// <returns></returns>
    public static string Base64Encode(this string plainText)
    {
        byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        string final = Convert.ToBase64String(plainTextBytes);
        return final;
    }

    /// <summary>
    /// Decodes a string to base64 encription
    /// </summary>
    /// <param fName="base64EncodedData"></param>
    /// <returns></returns>
    public static string Base64Decode(this string base64EncodedData)
    {
        byte[] base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
        string final = Encoding.UTF8.GetString(base64EncodedBytes);
        return final;
    }

    #endregion

    #region FUNCTIONS

    /// <summary>
    /// Computes a string to SHA512 Hash
    /// </summary>
    /// <param fName="input"></param>
    /// <returns></returns>
    private static string ComputeSHA512Hash(string input)
    {
        using SHA512 sha512 = SHA512.Create();
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashBytes = sha512.ComputeHash(inputBytes);

        StringBuilder builder = new();

        for (int i = 0; i < hashBytes.Length; i++)
            builder.Append(hashBytes[i].ToString("x2"));

        return builder.ToString();
    }

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

    #endregion
}
