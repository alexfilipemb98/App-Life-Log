using System;
using System.ComponentModel;
using System.Linq;

namespace Models.Enums
{
    /// <summary>
    /// Theme enums
    /// </summary>
    public enum ThemeEnum
    {
        [Description("System Theme")]
        SYSTEM,
        [Description("Light Theme")]
        LIGHT,
        [Description("Dark Theme")]
        DARK,
    }
}
