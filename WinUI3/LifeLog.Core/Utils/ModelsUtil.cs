using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace LifeLog.Core.Utils;

public static class ModelsUtil
{
    public static string GetTableName(this Type entityType)
    {
        ArgumentNullException.ThrowIfNull(entityType);

        TableAttribute attribute = entityType.GetCustomAttribute<TableAttribute>();
        return attribute?.Name ?? entityType.Name;
    }
}
