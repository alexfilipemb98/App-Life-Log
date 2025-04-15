using System.ComponentModel;

namespace Core.Enums
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
