using Core.Enums;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Core.Utils;

public class WindowsUtil
{
    /// <summary>
    /// Get user theme
    /// </summary>
    /// <returns></returns>
    public static ThemeEnum GetWindowsTheme()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return ThemeEnum.LIGHT;

        const string registryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        object themeValue = Registry.GetValue(registryKey, "AppsUseLightTheme", null) ?? 1;

        if (themeValue != null && themeValue is int theme)
            return theme == 0 ? ThemeEnum.DARK : ThemeEnum.LIGHT;

        return ThemeEnum.LIGHT;
    }

    /// <summary>
    /// Checks if is running with admin perms
    /// </summary>
    /// <returns></returns>
    public static bool IsRunningAsAdmin()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return false;

        WindowsIdentity identity = WindowsIdentity.GetCurrent();
        WindowsPrincipal principal = new WindowsPrincipal(identity);
        return principal.IsInRole(WindowsBuiltInRole.Administrator);
    }
}
