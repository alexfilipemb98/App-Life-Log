using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Utils.Extensions
{
    /// <summary>
    /// Enum Extensions
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// Enum To List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        //public static List<object> ToList(this Type enumType)
        //{
        //    if (!enumType.IsEnum)
        //        throw new ArgumentException("Provided type must be an enum.");

        //    List<object> enums = Enum.GetValues(enumType)
        //        .Cast<Enum>()
        //        .Select(e => new {
        //            Type = e.ToString(),
        //            Description = e.GetDescription()
        //        })
        //        .ToList<object>();

        //    return enums;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="enumType"></param>
        /// <returns></returns>
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
