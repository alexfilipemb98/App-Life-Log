namespace LifeLog.Core.Utils;

/// <summary>
/// Flags util
/// </summary>
public static class FlagsUtil
{
	/// <summary>
	/// Checks if a flag is active in a value
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="perm"></param>
	/// <param name="valor"></param>
	/// <returns></returns>
	public static bool IsActive<T>(this T perm, long valor) where T : Enum
    {
        long p = Convert.ToInt64(perm);
        long ps = valor;

        return (ps & p) == p;
    }

	/// <summary>
	/// Gets the combined value of all flags in an enum
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <returns></returns>
	public static long GetAllFlagsValue<T>() where T : Enum
    {
        long total = 0;
        foreach (var f in Enum.GetValues(typeof(T)))
            total |= Convert.ToInt64(f);
        return total;
    }
}
