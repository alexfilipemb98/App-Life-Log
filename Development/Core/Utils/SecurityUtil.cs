using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Utils
{
    /// <summary>
    /// This is class that contains security functions
    /// </summary>
    public static class SecurityUtil
    {
        //PUBLIC
        public static readonly byte[] JWT_SECREET = Encoding.UTF8.GetBytes("aUekGKhhQM7wLxTBXlug1FbqcJaAqN46"); // 32 bytes (256 bits)

        //PRIVATE
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("X<HPe9Gv@,(;CMj!"); // 16 bytes (128 bits)
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("j4df,2}Z!P^uheBw"); // 16 bytes (128 bits)

        /// <summary>
        /// Encrypts Bytes
        /// </summary>
        /// <param fName="plainBytes"></param>
        /// <returns></returns>
        public static byte[] Encrypt(byte[] plainBytes)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(plainBytes, 0, plainBytes.Length);
                        cs.FlushFinalBlock();
                    }
                    return ms.ToArray();
                }
            }
        }

        /// <summary>
        /// Encripts the text
        /// </summary>
        /// <param fName="plainText"></param>
        /// <returns></returns>
        public static string Encrypt(string plainText)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(plainText))
                    return null;

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Key;
                    aes.IV = IV;

                    using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        using (var sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
            catch (Exception)
            {
                return plainText;
            }
        }

        /// <summary>
        /// Decrypts bytes
        /// </summary>
        /// <param fName="encryptedBytes"></param>
        /// <returns></returns>
        public static byte[] Decrypt(byte[] encryptedBytes)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream(encryptedBytes))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var msOutput = new MemoryStream())
                {
                    cs.CopyTo(msOutput);
                    return msOutput.ToArray();
                }
            }
        }

        /// <summary>
        /// Decripts the text
        /// </summary>
        /// <param fName="cipherText"></param>
        /// <returns></returns>
        public static string Decrypt(string cipherText)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cipherText))
                    return default;

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Key;
                    aes.IV = IV;

                    using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                    using (var ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    using (var sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
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
            using (var random = RandomNumberGenerator.Create())
            {
                byte[] salt = new byte[length];
                random.GetBytes(salt);
                return Convert.ToBase64String(salt);
            }
        }

        /// <summary>
        /// Computes a sha512 that joins password and salt
        /// </summary>
        /// <param fName="password"></param>
        /// <param fName="salt"></param>
        /// <returns></returns>
        public static string Sha512_EncryptPasswordWithSalt(string password, string salt)
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
        public static bool CompareStringEncryptedWithSalt(string plainText, string encryptedString, string salt)
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
        public static string Base64Encode(string plainText)
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
        public static string Base64Decode(string base64EncodedData)
        {
            byte[] base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            string final = Encoding.UTF8.GetString(base64EncodedBytes);
            return final;
        }

        /// <summary>
        /// Generates a random password
        /// </summary>
        /// <param fName="minLength"></param>
        /// <param fName="maxLength"></param>
        /// <returns></returns>
        public static string GeneratePassword(int legth, bool useUCase, bool useLCase, bool useNum, bool useSpecial)
        {
            string PASSWORD_CHARS_LCASE = "abcdefghijklmnopqrstuvwxyz";
            string PASSWORD_CHARS_UCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string PASSWORD_CHARS_NUMERIC = "23456789";
            string PASSWORD_CHARS_SPECIAL = "!@#$%^&*()_-+=[]{};:,.<>?";

            string caracteres = string.Empty;

            if (useUCase)
                caracteres += PASSWORD_CHARS_UCASE;

            if (useLCase)
                caracteres += PASSWORD_CHARS_LCASE;

            if (useNum)
                caracteres += PASSWORD_CHARS_NUMERIC;

            if (useSpecial)
                caracteres += PASSWORD_CHARS_SPECIAL;

            if (string.IsNullOrEmpty(caracteres))
                throw new ArgumentException("At least one character type must be selected.");

            using (var rng = RandomNumberGenerator.Create())
            {
                var senha = new char[legth];
                var charArray = caracteres.ToCharArray();

                for (var i = 0; i < legth; i++)
                {
                    var randomBytes = new byte[1];
                    rng.GetBytes(randomBytes);
                    var indice = randomBytes[0] % charArray.Length;
                    senha[i] = charArray[indice];
                }

                return new string(senha);
            }
        }

        #region FUNCTIONS

        /// <summary>
        /// Computes a string to SHA512 Hash
        /// </summary>
        /// <param fName="input"></param>
        /// <returns></returns>
        private static string ComputeSHA512Hash(string input)
        {

            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha512.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        #endregion

    }
}
