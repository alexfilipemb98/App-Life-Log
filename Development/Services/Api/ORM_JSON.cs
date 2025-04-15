using DevExpress.Xpo;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using DevExpress.Xpo.Metadata;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace Api;

public class ORM_ConfigureJsonOptions : IConfigureOptions<JsonOptions>, IServiceProvider
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IServiceProvider _serviceProvider;

    public ORM_ConfigureJsonOptions(IHttpContextAccessor httpContextAccessor,IServiceProvider serviceProvider)
    {
        _httpContextAccessor = httpContextAccessor;
        _serviceProvider = serviceProvider;
    }

    public void Configure(JsonOptions options)
    {
        options.JsonSerializerOptions.Converters.Add(new ORM_PersistentBaseConverterFactory(this));
    }

    public object GetService(Type serviceType)
    {
        return (_httpContextAccessor.HttpContext?.RequestServices ?? _serviceProvider).GetService(serviceType);
    }
}

public class ORM_XpoMetadataProvider : DefaultModelMetadataProvider
{
    public ORM_XpoMetadataProvider(ICompositeMetadataDetailsProvider detailsProvider) : base(detailsProvider)
    {
    }

    public ORM_XpoMetadataProvider(ICompositeMetadataDetailsProvider detailsProvider, IOptions<MvcOptions> optionsAccessor) : base(detailsProvider, optionsAccessor)
    {
    }

    protected override DefaultMetadataDetails[] CreatePropertyDetails(ModelMetadataIdentity key)
    {
        DefaultMetadataDetails[] result = base.CreatePropertyDetails(key);
        if (typeof(PersistentBase).IsAssignableFrom(key.ModelType))
            return result.Where(x => !IsServiceField(x.Key)).ToArray();
        else
            return result;
    }

    public static bool IsServiceField(ModelMetadataIdentity identity)
    {
        Type declaringType = identity.PropertyInfo.DeclaringType;
        return declaringType == typeof(PersistentBase)
            || declaringType == typeof(XPBaseObject);
    }
}

public class ORM_PersistentBaseConverter<T> : JsonConverter<T> where T : PersistentBase
{
    IServiceProvider _serviceProvider;

    public ORM_PersistentBaseConverter(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    UnitOfWork GetUnitOfWork()
    {
        return (UnitOfWork)_serviceProvider.GetService(typeof(UnitOfWork));
    }

    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        UnitOfWork uow = GetUnitOfWork();

        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        XPClassInfo classInfo = uow.GetClassInfo(typeToConvert);
        Dictionary<string, object> resultDict = CollectPropertyValues(ref reader, options, classInfo, uow);
        return (T)PopulateObjectProperties(null, resultDict, uow, classInfo);
    }

    public static PersistentBase PopulateObjectProperties(PersistentBase persistentObject, Dictionary<string, object> propertyValues, UnitOfWork uow, XPClassInfo classInfo)
    {
        object keyValue;

        if (persistentObject == null && propertyValues.TryGetValue(classInfo.KeyProperty.Name, out keyValue))
        {
            persistentObject = (PersistentBase)uow.GetObjectByKey(classInfo, keyValue);
        }

        if (persistentObject == null)
            persistentObject = (PersistentBase)classInfo.CreateNewObject(uow);

        foreach (KeyValuePair<string, object> pair in propertyValues)
        {
            XPMemberInfo memberInfo = classInfo.FindMember(pair.Key);
            if (memberInfo.IsReadOnly)
                continue;

            if (memberInfo.ReferenceType != null)
            {
                PopulateReferenceProperty(persistentObject, uow, pair.Value, memberInfo);
            }
            else
            {
                PopulateScalarProperty(persistentObject, pair.Value, memberInfo);
            }
        }

        return persistentObject;
    }

    private static void PopulateScalarProperty(PersistentBase theObject, object theValue, XPMemberInfo memberInfo)
    {
        if (memberInfo == theObject.ClassInfo.OptimisticLockField)
        {
            SetOptimisticLockField(theObject, (int)theValue);
        }
        else
        {
            memberInfo.SetValue(theObject, theValue);
        }
    }

    private static void PopulateReferenceProperty(PersistentBase parent, UnitOfWork uow, object theValue, XPMemberInfo memberInfo)
    {
        if (memberInfo.IsAggregated)
        {
            PersistentBase propertyValue = (PersistentBase)memberInfo.GetValue(parent);
            propertyValue = PopulateObjectProperties(propertyValue, (Dictionary<string, object>)theValue, uow, memberInfo.ReferenceType);
            memberInfo.SetValue(parent, propertyValue);
        }
        else
        {
            memberInfo.SetValue(parent, uow.GetObjectByKey(memberInfo.MemberType, theValue));
        }
    }

    public static Dictionary<string, object> CollectPropertyValues(ref Utf8JsonReader reader, JsonSerializerOptions options, XPClassInfo classInfo, UnitOfWork uow)
    {
        Dictionary<string, object> propertyValues = new Dictionary<string, object>();
        while (reader.Read())
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.EndObject:
                    return propertyValues;
                case JsonTokenType.PropertyName:
                    ReadPropertyValue(ref reader, options, classInfo, uow, propertyValues);
                    break;
            }
        }
        throw new JsonException();
    }

    private static void SkipObject(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
        int startCount = 0;
        while (reader.Read())
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.EndObject:
                    startCount -= 1;
                    if (startCount == 0)
                        return;
                    else
                        break;
                case JsonTokenType.EndArray:
                    startCount -= 1;
                    if (startCount == 0)
                        return;
                    else
                        break;
                case JsonTokenType.StartObject:
                    startCount += 1;
                    break;
                case JsonTokenType.StartArray:
                    startCount += 1;
                    break;
                default:
                    if (startCount == 0) return;
                    else break;
            }

        }
    }
    
    private static void ReadPropertyValue(ref Utf8JsonReader reader, JsonSerializerOptions options, XPClassInfo classInfo, UnitOfWork uow, Dictionary<string, object> propertyValues)
    {
        string propertyName = reader.GetString();
        var member = classInfo.FindMember(propertyName);
        if (member != null && CanSerializeProperty(member))
        {
            reader.Read();
            if (member.IsCollection || member.IsNonAssociationList && !member.IsPersistent)
            {
                SkipArray(ref reader);
            }
            else
            {
                try
                {
                    if (member.ReferenceType == null)
                    {

                        propertyValues[propertyName] = JsonSerializer.Deserialize(ref reader, member.MemberType, options);
                    }
                    else
                    {
                        if (member.IsAggregated)
                        {

                            propertyValues[propertyName] = CollectPropertyValues(ref reader, options, member.ReferenceType, uow);
                        }
                        else
                        {
                            try
                            {
                                propertyValues[propertyName] = JsonSerializer.Deserialize(ref reader, member.ReferenceType.KeyProperty.MemberType, options);
                            }
                            catch (Exception)
                            {
                                //IGNORAR!!!
                            }
                        }
                    }
                }
                catch (JsonException) { throw new JsonException("BadJsonFormat"); }
            }
        }
        else SkipObject(ref reader, options);
    }

    private static void SkipArray(ref Utf8JsonReader reader)
    {
        int count = 1;
        while (true)
        {
            reader.Read();
            if (reader.TokenType == JsonTokenType.StartArray) count += 1;
            if (reader.TokenType == JsonTokenType.EndArray) count -= 1;
            if (count == 0) break;
        }
    }

    static void SetOptimisticLockField(PersistentBase obj, int newValue)
    {
        obj.ClassInfo.OptimisticLockField?.SetValue(obj, newValue);
        obj.ClassInfo.OptimisticLockFieldInDataLayer?.SetValue(obj, newValue);
    }

    public override void Write(Utf8JsonWriter writer,T Value,JsonSerializerOptions options)
    {
        if (writer.CurrentDepth > options.MaxDepth) throw new JsonException("Cycles are not supported");
        UnitOfWork uow = GetUnitOfWork();
        XPClassInfo classInfo = uow.GetClassInfo(Value);
        writer.WriteStartObject();
        foreach (var member in classInfo.Members)
        {
            if (member != null && CanSerializeProperty(member) && member.IsPublic && !member.IsCollection)
            { //ispersistent
                object value = member.GetValue(Value);
                writer.WritePropertyName(member.Name);
                if (!typeof(PersistentBase).IsAssignableFrom(member.MemberType))
                {
                    if (member.MemberType.Name == "DateTime" && value == null)
                        value = new DateTime();

                    JsonSerializer.Serialize(writer, value, member.MemberType, options);
                }
                else if (member.IsAggregated)
                    JsonSerializer.Serialize(writer, value, options);
                else
                {
                    if (value != null)
                        value = uow.GetKeyValue(value);
                    JsonSerializer.Serialize(writer, value, options);
                }
            }
        }
        writer.WriteEndObject();
    }

    static bool CanSerializeProperty(XPMemberInfo member)
    {
        return member.Owner.ClassType != typeof(PersistentBase) && member.Owner.ClassType != typeof(XPBaseObject);
    }

    public override bool CanConvert(Type typeToConvert)
    {
        return typeof(PersistentBase).IsAssignableFrom(typeToConvert);
    }
}

public class ORM_PersistentBaseConverterFactory : JsonConverterFactory
{
    readonly IServiceProvider serviceProvider;
    public ORM_PersistentBaseConverterFactory(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public override bool CanConvert(Type typeToConvert)
    {
        return typeof(PersistentBase).IsAssignableFrom(typeToConvert);
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        Type converterType = typeof(ORM_PersistentBaseConverter<>).MakeGenericType(typeToConvert);
        return (JsonConverter)Activator.CreateInstance(converterType, serviceProvider);
    }
}

public class ORM_NullableNumberConverter<T> : JsonConverter<T?> where T : struct, IConvertible
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return null;

        if (reader.TokenType == JsonTokenType.Number)
            return (T)Convert.ChangeType(reader.GetDouble(), typeof(T), CultureInfo.InvariantCulture);

        if (reader.TokenType == JsonTokenType.String)
        {
            string strValue = reader.GetString();
            if (string.IsNullOrWhiteSpace(strValue))
                return null;

            if (double.TryParse(strValue, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
                return (T)Convert.ChangeType(result, typeof(T), CultureInfo.InvariantCulture);
        }

        throw new JsonException($"Valor inválido para um {typeof(T).Name}: {reader.GetString()}");
    }

    public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
    {
        if (value.HasValue)
            writer.WriteNumberValue(Convert.ToDouble(value.Value, CultureInfo.InvariantCulture));
        else
            writer.WriteNullValue();
    }
}

public class ORM_XpoContractResolver : Newtonsoft.Json.Serialization.DefaultContractResolver
{
    protected override Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization)
    {
        Newtonsoft.Json.Serialization.JsonProperty property = base.CreateProperty(member, memberSerialization);

        // Ignorar propriedades do XPO que podem causar erros de serialização
        if (typeof(DevExpress.Xpo.Session).IsAssignableFrom(property.PropertyType) ||
            property.PropertyName == "_Session" ||
            property.PropertyName == "Session" ||
            property.PropertyName == "ClassInfo" ||
            property.PropertyName == "CollectionElementType")
        {
            property.ShouldSerialize = _ => false;
        }

        return property;
    }
}

public class ORM_SimpleXpoJsonConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeof(PersistentBase).IsAssignableFrom(typeToConvert);
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        Type converterType = typeof(ORM_SimpleXpoJsonConverter<>).MakeGenericType(typeToConvert);
        return (JsonConverter)Activator.CreateInstance(converterType)!;
    }
}

public class ORM_SimpleXpoJsonConverter<T> : JsonConverter<T> where T : PersistentBase
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotSupportedException("Deserialização de objetos XPO não é suportada nesta API.");
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteNullValue();
            return;
        }

        XPClassInfo classInfo = value.ClassInfo;
        writer.WriteStartObject();

        foreach (var member in classInfo.Members)
        {
            if (member.IsPublic && member.IsPersistent && !member.IsCollection)
            {
                object propValue = member.GetValue(value);
                writer.WritePropertyName(member.Name);
                JsonSerializer.Serialize(writer, propValue, propValue?.GetType() ?? typeof(object), options);
            }
        }

        writer.WriteEndObject();
    }
}
