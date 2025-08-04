using System;

namespace LifeLog.Base.Utils
{
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
            return metersPerSecond * 3.6;
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
            switch (segment)
            {
                case 0: return "N";
                case 1: return "NE";
                case 2: return "E";
                case 3: return "SE";
                case 4: return "S";
                case 5: return "SW";
                case 6: return "W";
                case 7: return "NW";
                default: return "N"; // This should not happen
            }
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
        /// Gets the timezone name and UTC offset based on the timezone shift in seconds from UTC.
        /// </summary>
        /// <param name="timezoneShiftSeconds">Timezone shift in seconds from UTC.</param>
        /// <returns>A tuple containing the timezone name and the UTC offset.</returns>
        public static (string name, string utcOffset) GetTimeZoneInfo(int timezoneShiftSeconds)
        {
            string timezoneName;
            string utcOffset;

            switch (timezoneShiftSeconds)
            {
                case -43200:
                    timezoneName = "International Date Line West";
                    utcOffset = "-12:00";
                    break;
                case -39600:
                    timezoneName = "Midway Island, Samoa";
                    utcOffset = "-11:00";
                    break;
                case -36000:
                    timezoneName = "Hawaii";
                    utcOffset = "-10:00";
                    break;
                case -34200:
                    timezoneName = "French Polynesia, Marquesas Islands";
                    utcOffset = "-09:30";
                    break;
                case -32400:
                    timezoneName = "Alaska";
                    utcOffset = "-09:00";
                    break;
                case -28800:
                    timezoneName = "Pacific Time (US & Canada)";
                    utcOffset = "-08:00";
                    break;
                case -25200:
                    timezoneName = "Mountain Time (US & Canada)";
                    utcOffset = "-07:00";
                    break;
                case -21600:
                    timezoneName = "Central Time (US & Canada), Guadalajara, Mexico city";
                    utcOffset = "-06:00";
                    break;
                case -18000:
                    timezoneName = "Eastern time (US & Canada)";
                    utcOffset = "-05:00";
                    break;
                case -16200:
                    timezoneName = "Venezuela";
                    utcOffset = "-04:30";
                    break;
                case -14400:
                    timezoneName = "Atlantic time (Canada), Manaus, Santiago";
                    utcOffset = "-04:00";
                    break;
                case -12600:
                    timezoneName = "Newfoundland";
                    utcOffset = "-03:30";
                    break;
                case -10800:
                    timezoneName = "Greenland, Brasilia, Montevideo";
                    utcOffset = "-03:00";
                    break;
                case -7200:
                    timezoneName = "Mid-Atlantic";
                    utcOffset = "-02:00";
                    break;
                case -3600:
                    timezoneName = "Azores";
                    utcOffset = "-01:00";
                    break;
                case 0:
                    timezoneName = "GMT: Dublin, Edinburgh, Lisbon, London";
                    utcOffset = "+00:00";
                    break;
                case 3600:
                    timezoneName = "Amsterdam, Berlin, Rome, Vienna, Prague, Brussels";
                    utcOffset = "+01:00";
                    break;
                case 7200:
                    timezoneName = "Athens, Istanbul, Beirut, Cairo, Jerusalem";
                    utcOffset = "+02:00";
                    break;
                case 10800:
                    timezoneName = "St. Petersburg, Minsk, Baghdad, Moscow";
                    utcOffset = "+03:00";
                    break;
                case 12600:
                    timezoneName = "Iran";
                    utcOffset = "+03:30";
                    break;
                case 14400:
                    timezoneName = "Volgograd, Baku, Yerevan";
                    utcOffset = "+04:00";
                    break;
                case 16200:
                    timezoneName = "Afghanistan";
                    utcOffset = "+04:30";
                    break;
                case 18000:
                    timezoneName = "Yekaterinburg, Tashkent";
                    utcOffset = "+05:00";
                    break;
                case 19800:
                    timezoneName = "Chennai, Kolkata, Mumbai, New Delhi";
                    utcOffset = "+05:30";
                    break;
                case 20700:
                    timezoneName = "Nepal";
                    utcOffset = "+05:45";
                    break;
                case 21600:
                    timezoneName = "Omsk, Almaty";
                    utcOffset = "+06:00";
                    break;
                case 23400:
                    timezoneName = "Myanmar, Cocos Islands";
                    utcOffset = "+06:30";
                    break;
                case 25200:
                    timezoneName = "+07:00";
                    utcOffset = "+07:00";
                    break;
                case 28800:
                    timezoneName = "Krasnoyarsk, Ulaan Bataar, Perth";
                    utcOffset = "+08:00";
                    break;
                case 32400:
                    timezoneName = "Irkutsk";
                    utcOffset = "+09:00";
                    break;
                case 34200:
                    timezoneName = "Australian Central Standard Time";
                    utcOffset = "+09:30";
                    break;
                case 36000:
                    timezoneName = "Yakutsk, Canberra, Melbourne, Sydney, Hobart";
                    utcOffset = "+10:00";
                    break;
                case 37800:
                    timezoneName = "Lord Howe Standard Time";
                    utcOffset = "+10:30";
                    break;
                case 39600:
                    timezoneName = "Vladivostok, Solomon Is., New Caledonia";
                    utcOffset = "+11:00";
                    break;
                case 41400:
                    timezoneName = "Norfolk Islan";
                    utcOffset = "+11:30";
                    break;
                case 43200:
                    timezoneName = "Magadan, Auckland, Wellington";
                    utcOffset = "+12:00";
                    break;
                case 45900:
                    timezoneName = "New Zealand, Chatham Island";
                    utcOffset = "+12:45";
                    break;
                case 46800:
                    timezoneName = "Nuku'alofa";
                    utcOffset = "+13:00";
                    break;
                case 50400:
                    timezoneName = "Kiribati, Line Islands";
                    utcOffset = "+14:00";
                    break;
                default:
                    timezoneName = "Unknown Timezone";
                    utcOffset = "";
                    break;
            }

            return (timezoneName, utcOffset);
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
}
