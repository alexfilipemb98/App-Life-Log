using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace LifeLog.Base.Utils
{
	/// <summary>
	/// Model util
	/// </summary>
	public static class ModelUtil
	{
		/// <summary>
		/// Get the key of the model
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="model"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static PropertyInfo GetModelKey<T>(this T model) where T : class
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
		public static PropertyInfo GetModelKey(this Type type)
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
		public static void SetEditingMode(this object entity, bool value)
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
		public static string GetTableName(this Type entityType)
		{
			if (entityType == null)
				throw new ArgumentNullException(nameof(entityType));

			var attribute = entityType.GetCustomAttribute<DescriptionAttribute>();
			return attribute?.Description;
		}

		/// <summary>
		/// Maps properties from source to target object.
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <typeparam name="TTarget"></typeparam>
		/// <param name="source"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static TTarget MapTo<TSource, TTarget>(this TSource source)
			where TTarget : class, new()
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));

			TTarget target = new TTarget();

			source.MapTo(target);

			return target;
		}

		/// <summary>
		/// Map to object
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <typeparam name="TTarget"></typeparam>
		/// <param name="source"></param>
		/// <param name="target"></param>
		/// <exception cref="ArgumentNullException"></exception>
		public static void MapTo<TSource, TTarget>(this TSource source, TTarget target)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));

			PropertyInfo[] sourceProps = typeof(TSource)
			.GetProperties(BindingFlags.Public | BindingFlags.Instance);

			Dictionary<string, PropertyInfo> targetProps = typeof(TTarget)
				.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(p => p.CanWrite)
				.ToDictionary(p => p.Name);

			foreach (PropertyInfo sProp in sourceProps)
			{
				// find matching target property
				if (!targetProps.TryGetValue(sProp.Name, out var tProp))
					continue;

				// handle Key attributes specially:
				bool sourceHasDataKey =
					sProp.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.KeyAttribute), false).Any();

				if (sourceHasDataKey)
					continue;

				// handle Key attributes specially:
				bool sourceHasDataKeyxpo =
					sProp.GetCustomAttributes(typeof(DevExpress.Xpo.KeyAttribute), false).Any();

				//if (sourceHasDataKeyxpo)
				//	continue;

				object value = sProp.GetValue(source);
				if (value == null)
					continue;

				// enum -> int
				if (sProp.PropertyType.IsEnum && tProp.PropertyType == typeof(int))
					tProp.SetValue(target, (int)value);
				// int -> enum
				else if (sProp.PropertyType == typeof(int) && tProp.PropertyType.IsEnum)
					tProp.SetValue(target, Enum.ToObject(tProp.PropertyType, value));
				// same or assignable type
				else if (tProp.PropertyType.IsAssignableFrom(sProp.PropertyType))
					tProp.SetValue(target, value);
				else
				{
					object converted = Convert.ChangeType(value, tProp.PropertyType);
					tProp.SetValue(target, converted);
				}
			}
		}
	}
}
