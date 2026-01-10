using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace LifeLog.Core.Utils;

/// <summary>
/// Model util
/// </summary>
public static class ModelUtil
{
	/// <summary>
	/// Valida uma propriedade de um modelo e devolve a mensagem de erro (se existir).
	/// </summary>
	public static string? GetValidationMessage<T>(this T model, string propertyName) where T : class
	{
		if (model == null) return null;

		PropertyInfo? property = typeof(T).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
		if (property == null) return null;

		object? value = property.GetValue(model);

		ValidationContext context = new ValidationContext(model) { MemberName = propertyName };
		List<ValidationResult> results = new List<ValidationResult>();

		bool isValid = Validator.TryValidateProperty(value, context, results);

		return !isValid ? results.FirstOrDefault()?.ErrorMessage : null;
	}

	/// <summary>
	/// Get the key of the model
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="model"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentNullException"></exception>
	public static PropertyInfo? GetModelKey<T>(this T model) where T : class
	{
		if (model == null)
			throw new ArgumentNullException(nameof(model));

		PropertyInfo? keyProperty = typeof(T)
			.GetProperties(BindingFlags.Public | BindingFlags.Instance)
			.FirstOrDefault(p => p.GetCustomAttributes().Any(a => a.GetType().Name == "KeyAttribute"));

		return keyProperty;
	}

	/// <summary>
	/// Get the key of the model
	/// </summary>
	/// <param name="type"></param>
	/// <returns></returns>
	public static PropertyInfo? GetModelKey(this Type type)
	{
		if (type == null)
			throw new ArgumentNullException(nameof(type));

		return type
			.GetProperties(BindingFlags.Public | BindingFlags.Instance)
			 .FirstOrDefault(p => p.GetCustomAttributes().Any(a => a.GetType().Name == "KeyAttribute"));
	}

	/// <summary>
	/// Gets the table name from the DescriptionAttribute of the entity type.
	/// Returns null if not defined.
	/// </summary>
	/// <param name="entityType">The entity class type.</param>
	/// <returns>The table name or null.</returns>
	public static string GetTableName(this Type entityType)
	{
		if (entityType is null)
			throw new ArgumentNullException(nameof(entityType));

		TableAttribute? attribute = entityType.GetCustomAttribute<TableAttribute>();
		return attribute?.Name ?? entityType.Name;
	}

	/// <summary>
	/// Clones the object deeply using JSON serialization.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="obj"></param>
	/// <returns></returns>
	public static T DeepCloneJson<T>(this T obj)
	{
		var json = JsonConvert.SerializeObject(obj);
		return JsonConvert.DeserializeObject<T>(json)!;
	}
}
