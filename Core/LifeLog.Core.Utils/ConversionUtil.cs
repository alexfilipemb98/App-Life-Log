namespace LifeLog.Core.Utils;

/// <summary>
/// Conversion utility methods.
/// </summary>
public static class ConversionUtil
{
    #region METHODS

    /// <summary>
    /// Converts temperature from Kelvin to Celsius.
    /// </summary>
    /// <param name="kelvin">Temperature value in Kelvin.</param>
    /// <returns>Temperature value in Celsius.</returns>
    public static double KelvinToCelsius(this double kelvin)
    {
        return Math.Round((kelvin - 273.15) * 100) / 100;
    }

    /// <summary>
    /// Converts temperature from Celsius to Kelvin.
    /// </summary>
    /// <param name="celsius">Temperature value in Celsius.</param>
    /// <returns>Temperature value in Kelvin.</returns>
    public static double CelsiusToKelvin(this double celsius)
    {
        return celsius + 273.15;
    }

    /// <summary>
    /// Converts speed from meters per second (m/s) to kilometers per hour (km/h).
    /// </summary>
    /// <param name="metersPerSecond">Speed value in meters per second (m/s).</param>
    /// <returns>Speed value in kilometers per hour (km/h).</returns>
    public static double MetersPerSecondToKilometersPerHour(this double metersPerSecond)
    {
        return Math.Round(metersPerSecond * 3.6, 2);
    }

    /// <summary>
    /// Converts degrees to a compass direction.
    /// </summary>
    /// <param name="degrees">Angle in degrees (0 to 360).</param>
    /// <returns>Compass direction (N, NE, E, SE, S, SW, W, NW).</returns>
    public static string DegreesToCompassDirection(this double degrees)
    {
        // Normalize degrees to be within [0, 360) range
        degrees %= 360;
        if (degrees < 0)
        {
            degrees += 360;
        }

        // Determine the segment based on 45-degree intervals
        int segment = (int)((degrees + 22.5) / 45) % 8;

        // Assign compass direction based on the segment
        return segment switch
        {
            0 => "N",
            1 => "NE",
            2 => "E",
            3 => "SE",
            4 => "S",
            5 => "SW",
            6 => "W",
            7 => "NW",
            _ => "N",// This should not happen
        };
    }

    /// <summary>
    /// Converts a Unix timestamp (seconds since epoch) to a DateTime object.
    /// </summary>
    /// <param name="unixTime">Unix timestamp (seconds since epoch).</param>
    /// <returns>DateTime object representing the corresponding date and time.</returns>
    public static DateTime UnixToDateTime(this long unixTime)
    {
        return DateTimeOffset.FromUnixTimeSeconds(unixTime).DateTime;
    }

    /// <summary>
    /// Converts a Unix timestamp (seconds since epoch) to a DateTime object considering the timezone shift.
    /// </summary>
    /// <param name="unixTime">Unix timestamp (seconds since epoch).</param>
    /// <param name="timezoneShiftSeconds">Timezone shift in seconds from UTC.</param>
    /// <returns>DateTime object representing the corresponding date and time.</returns>
    public static DateTime UnixToDateTime(long unixTime, int timezoneShiftSeconds)
    {
        DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTime);
        TimeSpan offset = TimeSpan.FromSeconds(timezoneShiftSeconds);
        return dateTimeOffset.ToOffset(offset).DateTime;
    }

    /// <summary>
    /// Converts a datetime to seconds
    /// </summary>
    /// <param name="time"></param>
    /// <returns></returns>
    public static int ConvertTimeToSeconds(DateTime time)
    {
        int hours = time.Hour;
        int minutes = time.Minute;
        int seconds = time.Second;
        return (hours * 3600) + (minutes * 60) + seconds;
    }

    /// <summary>
    /// Converts a seconds to date time
    /// </summary>
    /// <param name="totalSeconds"></param>
    /// <returns></returns>
    public static DateTime ConvertSecondsToTime(int totalSeconds)
    {
        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;
        return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, seconds);
    }

    #endregion
}
