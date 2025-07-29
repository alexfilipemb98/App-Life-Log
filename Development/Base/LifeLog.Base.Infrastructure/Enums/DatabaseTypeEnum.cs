using System.ComponentModel;

namespace LifeLog.Base.Infrastructure.Enums
{
    /// <summary>
    /// Type of connections
    /// </summary>
    public enum DatabaseTypeEnum
    {
        [Description("SQL LITE")]
        SQLLITE,
        [Description("MSSQL")]
        MSSQL,
    }
}
