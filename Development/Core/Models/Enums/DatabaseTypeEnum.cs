using System.ComponentModel;

namespace Models.Enums
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
