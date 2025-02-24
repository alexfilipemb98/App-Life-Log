using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Core.Extensions
{
    public static class EnumExtension
    {
        public static List<EnumModel> ToList(this Type enumType)
        {
            if (!enumType.IsEnum)
                throw new ArgumentException("Provided type must be an enum.");

            List<EnumModel> enums = Enum.GetValues(enumType)
                .Cast<Enum>()
                .Select(e => new EnumModel {
                    Type = e.ToString(),
                    Description = e.GetDescription()
                })
                .ToList();

            return enums;
        }

        public static string GetDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? value.ToString();
        }

    }
}
