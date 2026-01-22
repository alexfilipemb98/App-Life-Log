using System.ComponentModel;
using System.Reflection;

namespace LifeLog.Core.Utils;

/// <summary>
/// Enum Util
/// </summary>
public static class EnumUtil
{
    #region METHODS

    /// <summary>
    /// Convert enum to datatable
    /// </summary>
    /// <param name="enumType"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static List<KeyValuePair<Enum, string>> ToList(this Type enumType)
    {
        if (!enumType.IsEnum)
            throw new ArgumentException("Type must be an Enum.");

        return [.. Enum.GetValues(enumType)
                   .Cast<Enum>()
                   .Select(e => new KeyValuePair<Enum, string>(
                       e, e.GetDescription()))];
    }

    /// <summary>
    /// Get the description of the enum
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetDescription(this Enum value)
    {
        FieldInfo? field = value.GetType().GetField(value.ToString());
        if (field == null)
            return value.ToString();
        DescriptionAttribute? attribute = field.GetCustomAttribute<DescriptionAttribute>();
        return attribute?.Description ?? value.ToString();
    }
    #endregion
}
