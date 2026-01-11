using Newtonsoft.Json;

namespace LifeLog.Core.Utils;

/// <summary>
/// Json Utility class
/// </summary>
public static class JsonUtil
{
    /// <summary>
    /// Serializa um objeto para JSON (string).
    /// </summary>
    public static string ExportToJson<T>(T obj, bool indented = true)
    {
        Formatting formatting = indented ? Formatting.Indented : Formatting.None;
        return JsonConvert.SerializeObject(obj, formatting);
    }

    /// <summary>
    /// Serializa um objeto para ficheiro JSON.
    /// </summary>
    public static void ExportToFile<T>(this T obj, string filePath, bool indented = true) =>
        File.WriteAllText(filePath, ExportToJson(obj, indented));

    /// <summary>
    /// Desserializa (importa) JSON de string para objeto.
    /// </summary>
    public static T? ImportFromJson<T>(this string json) =>
        JsonConvert.DeserializeObject<T>(json);

    /// <summary>
    /// Desserializa (importa) JSON de ficheiro para objeto.
    /// </summary>
    public static T? ImportFromFile<T>(this string filePath) =>
        ImportFromJson<T>(File.ReadAllText(filePath));
}