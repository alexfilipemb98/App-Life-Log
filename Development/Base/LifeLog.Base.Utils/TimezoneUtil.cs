using GeoTimeZone;
using NodaTime;
using System;
using TimeZoneNames;

namespace LifeLog.Base.Utils
{
	public static class TimezoneUtil
	{

		/// <summary>
		/// Get timezone
		/// </summary>
		/// <param name="latitude"></param>
		/// <param name="longitude"></param>
		/// <param name="timezoneShiftSeconds"></param>
		/// <returns></returns>
		public static string GetTimeZoneInfo(double latitude, double longitude, int timezoneShiftSeconds)
		{
			return $"{GetFriendlyTimeZoneName(latitude, longitude)} ({GetUtcOffsetLabel(timezoneShiftSeconds)})";
		}

		/// <summary>
		/// Returns a human-friendly name of the time zone (e.g., "Western European Summer Time")
		/// based on latitude/longitude. Default locale is "en" (you can also use "pt-PT").
		/// </summary>
		public static string GetFriendlyTimeZoneName(double latitude, double longitude, DateTime? utcDateTime = null, string locale = "en")
		{
			// 1) IANA id a partir de coordenadas (ex.: "Europe/Lisbon")
			string iana = TimeZoneLookup.GetTimeZone(latitude, longitude).Result;

			// 2) Em que intervalo estamos (DST ou não) para a data pedida (ou agora)
			IDateTimeZoneProvider tzdb = DateTimeZoneProviders.Tzdb;
			DateTimeZone zone = tzdb[iana];
			Instant instant = utcDateTime.HasValue
				? Instant.FromDateTimeUtc(DateTime.SpecifyKind(utcDateTime.Value, DateTimeKind.Utc))
				: SystemClock.Instance.GetCurrentInstant();

			NodaTime.TimeZones.ZoneInterval interval = zone.GetZoneInterval(instant);
			bool isDaylight = interval.Savings != Offset.Zero;

			// 3) Nomes localizados completos (Standard/Daylight/Generic)
			var names = TZNames.GetNamesForTimeZone(iana, locale);

			// 4) Preferir Daylight/Standard conforme a data; cair para Generic se necessário
			if (isDaylight && !string.IsNullOrWhiteSpace(names.Daylight))
				return names.Daylight;   // ex.: "Western European Summer Time"
			if (!isDaylight && !string.IsNullOrWhiteSpace(names.Standard))
				return names.Standard;   // ex.: "Western European Time"

			// fallback
			return !string.IsNullOrWhiteSpace(names.Generic) ? names.Generic : iana;
		}

		/// <summary>
		/// Fallback using only the offset (when latitude/longitude are not available): returns "UTC+01:00".
		/// Does not distinguish between DST and the real time zone name.
		/// </summary>
		public static string GetUtcOffsetLabel(int timezoneShiftSeconds)
		{
			TimeSpan offset = TimeSpan.FromSeconds(timezoneShiftSeconds);
			return $"UTC{(offset >= TimeSpan.Zero ? "+" : "-")}{offset:hh\\:mm}";
		}
	}
}
