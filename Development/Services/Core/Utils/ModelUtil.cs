using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Core.Utils
{
    public static class ModelUtil
    {
        /// <summary>
        /// Get the key of the model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static PropertyInfo GetModelKey<T>(T model) where T : class
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            PropertyInfo keyProperty = typeof(T)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .FirstOrDefault(p => p.GetCustomAttributes().Any(a => a.GetType().Name == "KeyAttribute"));

            return keyProperty;
        }

        /// <summary>
        /// Get the key of the model
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static PropertyInfo GetModelKey(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            return type
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                 .FirstOrDefault(p => p.GetCustomAttributes().Any(a => a.GetType().Name == "KeyAttribute"));
        }

        /// <summary>
        /// Retrieves the property named "EditingMode" from the given entity and sets its value to the specified value.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="value"></param>
        public static void SetEditingMode(object entity, bool value)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var editingModeProperty = entity.GetType()
                .GetProperty("EditingMode", BindingFlags.Public | BindingFlags.Instance);

            if (editingModeProperty == null)
                throw new Exception($"The property 'EditingMode' was not found on type '{entity.GetType().Name}'.");

            if (editingModeProperty.PropertyType != typeof(bool))
                throw new Exception($"The property 'EditingMode' is not of type 'bool'.");

            editingModeProperty.SetValue(entity, value);
        }

        /// <summary>
        /// Gets the table name from the DescriptionAttribute of the entity type.
        /// Returns null if not defined.
        /// </summary>
        /// <param name="entityType">The entity class type.</param>
        /// <returns>The table name or null.</returns>
        public static string? GetTableName(Type entityType)
        {
            if (entityType == null)
                throw new ArgumentNullException(nameof(entityType));

            var attribute = entityType.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description;
        }

    }
}
