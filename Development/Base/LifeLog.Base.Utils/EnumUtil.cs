using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace LifeLog.Base.Utils
{
	/// <summary>
	/// Enum Util
	/// </summary>
	public static class EnumUtil
	{
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

			return Enum.GetValues(enumType)
					   .Cast<Enum>()
					   .Select(e => new KeyValuePair<Enum, string>(
						   e, e.GetDescription()))
					   .ToList();
		}

		/// <summary>
		/// Get the description of the enum
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetDescription(this Enum value)
		{
			FieldInfo field = value.GetType().GetField(value.ToString());
			DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
			return attribute?.Description ?? value.ToString();
		}
	}
}
