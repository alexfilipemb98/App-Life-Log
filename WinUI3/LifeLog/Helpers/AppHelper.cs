using LifeLog.Core.Models;
using LifeLog.Data;

namespace LifeLog.Helpers;

internal class AppHelper
{
    public static LoggedUserModel? LoggedUser { get; internal set; }
    internal static Engine? DataEngine { get; set; }
}
