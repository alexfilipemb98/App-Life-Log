using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Utils.Extensions
{
    /// <summary>
    /// Model Extensions
    /// </summary>
    public static class ModelsExtension
    {
        /// <summary>
        /// Is model Valid
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="validationResults"></param>
        /// <returns></returns>
        public static bool IsValid<T>(this T model, out List<ValidationResult> validationResults) =>
            Utils.ValidationUtil.ValidateModel(model, out validationResults);

        /// <summary>
        /// Is model valid
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool IsValid<T>(this T model) =>
            Utils.ValidationUtil.ValidateModel(model, out _);

        /// <summary>
        /// Get the key of the model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public static PropertyInfo GetKey<T>(this T model) where T : class =>
            Utils.ModelUtil.GetModelKey(model);

        /// <summary>
        /// Retrieves the property named "EditingMode" from the given entity and sets its value to the specified value.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="value"></param>
        public static void SetEditingMode(this object entity, bool value) =>
            Utils.ModelUtil.SetEditingMode(entity, value);

        /// <summary>
        /// Obtém a propriedade marcada como chave em um tipo.
        /// </summary>
        /// <param name="type">O tipo do qual obter a propriedade chave.</param>
        /// <returns>Propriedade marcada com um atributo de chave.</returns>
        public static PropertyInfo GetKey(this Type type) =>
          Utils.ModelUtil.GetModelKey(type);

        /// <summary>
        /// Get the table name of the model
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetTableName(this Type type) =>
            Utils.ModelUtil.GetTableName(type);
    }

}
