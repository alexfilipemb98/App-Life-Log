using System;
using System.IO;
using System.Linq;
using System.Text;

namespace LifeLog.Base.Utils
{
	/// <summary>
	/// Logger utility class for logging messages and errors to files.
	/// </summary>
	public static class LoggerUtil
	{
		private static readonly string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
		private static readonly string logFilePath = Path.Combine(logDirectory, "Log.txt");
		private static readonly string errorFilePath = Path.Combine(logDirectory, "Error.txt");

		/// <summary>
		/// Logs a message to the log file.
		/// </summary>
		/// <param name="message"></param>
		public static void Log(this string message)
		{
			WriteLog(logFilePath, "INFO", message);
		}

		/// <summary>
		/// Logs multiple messages to the log file.
		/// </summary>
		/// <param name="messages"></param>
		public static void Log(this string[] messages)
		{
			string combinedMessage = string.Join(", ", messages);
			WriteLog(logFilePath, "INFO", combinedMessage);
		}

		/// <summary>
		/// Error log to the error file.
		/// </summary>
		/// <param name="ex"></param>
		public static void LogError(this Exception ex)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(ex.Message);
			sb.AppendLine(ex.StackTrace);

			if (ex.InnerException != null)
			{
				sb.AppendLine("Inner Exception:");
				sb.AppendLine(ex.InnerException.Message);
				sb.AppendLine(ex.InnerException.StackTrace);
			}

			WriteLog(errorFilePath, "ERROR", sb.ToString());
		}

		#region FUNCTIONS

		/// <summary>
		/// Wite log to the file.
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="level"></param>
		/// <param name="message"></param>
		private static void WriteLog(string filePath, string level, string message)
		{
			CheckFiles();

			string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";
			File.AppendAllText(filePath, logMessage + Environment.NewLine);
		}

		/// <summary>
		/// Checks if the log and error files exist, and creates them if they do not.
		/// </summary>
		private static void CheckFiles()
		{
			if (!Directory.Exists(logDirectory))
				Directory.CreateDirectory(logDirectory);

			if (!File.Exists(logFilePath))
				File.Create(logFilePath).Dispose();

			if (!File.Exists(errorFilePath))
				File.Create(errorFilePath).Dispose();
		}

		#endregion
	}
}
