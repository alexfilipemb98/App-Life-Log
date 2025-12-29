using System.ComponentModel;

namespace LifeLog.Core.Enums
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
