using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LifeLog.Base.Utils
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
		public static T LoadFileWithEncryption<T>(string filePath)
		{
			if (!File.Exists(filePath))
				throw new FileNotFoundException("File not found.", filePath);

			byte[] encryptedBytes = File.ReadAllBytes(filePath);
			byte[] plainBytes = SecurityUtil.Decrypt(encryptedBytes);

			string json = Encoding.UTF8.GetString(plainBytes);
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
		public static T ReadFromJsonFile<T>(string filePath)
		{
			string jsonString = File.ReadAllText(filePath);
			return JsonConvert.DeserializeObject<T>(jsonString);
		}

		/// <summary>
		/// Gets the cities, filter by country
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="resourceName"></param>
		/// <returns></returns>
		public static async Task<T> ReadAssemblyJsonFile<T>(Assembly assembly, string resourceName)
		{
			string resourse = assembly
				.GetManifestResourceNames()
				.FirstOrDefault(w => w.ToLower().Contains(resourceName.ToLower()));

			using (Stream stream = assembly.GetManifestResourceStream(resourse))
			{
				if (stream == null)
					return default;

				using (StreamReader reader = new StreamReader(stream))
				{
					string jsonContent = await reader.ReadToEndAsync();
					return JsonConvert.DeserializeObject<T>(jsonContent);
				}
			}
		}
	}
}
