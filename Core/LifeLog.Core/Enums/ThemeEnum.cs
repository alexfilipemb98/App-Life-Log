using System.ComponentModel;

namespace LifeLog.Core.Enums;

/// <summary>
/// Theme enums
/// </summary>
public enum ThemeEnum
{
    [Description("System Theme")]
    SYSTEM,
    [Description("Dark Theme")]
    DARK,
    [Description("Light Theme")]
    LIGHT,
    [Description("Other Theme")]
    OTHER,
}