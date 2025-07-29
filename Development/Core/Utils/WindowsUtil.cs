using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Utils
{
    public class WindowsUtil
    {
        /// <summary>
        /// Get user theme 0 dark, 1 light
        /// </summary>
        /// <returns></returns>
        public static int GetWindowsTheme()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return 1;

            const string registryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            object themeValue = Registry.GetValue(registryKey, "AppsUseLightTheme", null) ?? 1;

            if (themeValue != null && themeValue is int theme)
                return theme;

            return 1;
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
}
