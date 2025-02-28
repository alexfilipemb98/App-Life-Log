using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public class LoggerUtil
    {
        private static readonly string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        private static readonly string logFilePath = Path.Combine(logDirectory, "Log.txt");
        private static readonly string errorFilePath = Path.Combine(logDirectory, "Error.txt");
        private static readonly object _lock = new object();

        public static void Initialize()
        {
            if (!Directory.Exists(logDirectory))
                Directory.CreateDirectory(logDirectory);

            if (!File.Exists(logFilePath))
                File.Create(logFilePath).Dispose();

            if (!File.Exists(errorFilePath))
                File.Create(errorFilePath).Dispose();
        }

        public static void Log(string message)
        {
            WriteLog(logFilePath, "INFO", message);
        }

        public static void Log(string[] messages)
        {
            string combinedMessage = string.Join(", ", messages);
            WriteLog(logFilePath, "INFO", combinedMessage);
        }

        public static void LogError(Exception ex)
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

        private static void WriteLog(string filePath, string level, string message)
        {
            lock (_lock)
            {
                string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";
                File.AppendAllText(filePath, logMessage + Environment.NewLine);
            }
        }
    }
}
