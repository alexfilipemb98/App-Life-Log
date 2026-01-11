using System.Text;

namespace LifeLog.Services;

/// <summary>
/// Logger utility class for logging messages and errors to files.
/// </summary>
public class LoggerService
{
	#region MAIN

	//PRIVATE
	private readonly string logDirectory;
	private readonly string logFilePath;
	private readonly string errorFilePath;

	/// <summary>
	/// Consturctor
	/// </summary>
	/// <param name="directory"></param>
	public LoggerService(string directory)
	{
		logDirectory = Path.Combine(directory, "Logs");
		logFilePath = Path.Combine(logDirectory, "Log.txt");
		errorFilePath = Path.Combine(logDirectory, "Error.txt");

		CheckFiles();
	}

	#endregion

	#region CORE

	/// <summary>
	/// Logs a message to the log file.
	/// </summary>
	/// <param name="message"></param>
	public void Log(string message)
	{
		WriteLog(logFilePath, "INFO", message);
	}

	/// <summary>
	/// Logs multiple messages to the log file.
	/// </summary>
	/// <param name="messages"></param>
	public void Log(string[] messages)
	{
		string combinedMessage = string.Join(", ", messages);
		WriteLog(logFilePath, "INFO", combinedMessage);
	}

	/// <summary>
	/// Error log to the error file.
	/// </summary>
	/// <param name="ex"></param>
	public void LogError(Exception ex)
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

	#endregion

	#region FUNCTIONS

	/// <summary>
	/// Wite log to the file.
	/// </summary>
	/// <param name="filePath"></param>
	/// <param name="level"></param>
	/// <param name="message"></param>
	private void WriteLog(string filePath, string level, string message)
	{
		string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";
		File.AppendAllText(filePath, logMessage + Environment.NewLine);
	}

	/// <summary>
	/// Checks if the log and error files exist, and creates them if they do not.
	/// </summary>
	private void CheckFiles()
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
