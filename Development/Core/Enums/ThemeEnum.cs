using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Enums
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
