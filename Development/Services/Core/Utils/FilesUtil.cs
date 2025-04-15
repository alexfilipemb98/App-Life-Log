using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text;
using Newtonsoft.Json;

namespace Core.Utils
{
    /// <summary>
    /// Files util
    /// </summary>
    public static class FilesUtil
    {
        /// <summary>
        /// Saves data to the file
        /// </summary>
        /// <typeparam fName="T"></typeparam>
        /// <param fName="model"></param>
        /// <param fName="filePath"></param>
        public static void SaveFileWithEncryption<T>(T model, string filePath)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true });
            byte[] plainBytes = Encoding.UTF8.GetBytes(json);
            byte[] encryptedBytes = SecurityUtil.Encrypt(plainBytes);

            File.WriteAllBytes(filePath, encryptedBytes);
        }

        /// <summary>
        /// Loads file to the object
        /// </summary>
        /// <typeparam fName="T"></typeparam>
        /// <returns></returns>
        public static T? LoadFileWithEncryption<T>(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found.", filePath);

            byte[] encryptedBytes = File.ReadAllBytes(filePath);
            byte[] plainBytes = SecurityUtil.Decrypt(encryptedBytes);

            string json = System.Text.Encoding.UTF8.GetString(plainBytes);
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Saves data to the file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <param name="data"></param>
        public static void SaveToJsonFile<T>(string filePath, T data)
        {
            string jsonString = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Reads data from the file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static T? ReadFromJsonFile<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}
