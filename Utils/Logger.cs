using System;
using System.IO;

namespace HotelManagementSystem.Utils
{
    public static class Logger
    {
        private static readonly string logFilePath = "application.log";

        public static void LogInfo(string message)
        {
            Log("INFO", message);
        }

        public static void LogWarning(string message)
        {
            Log("WARNING", message);
        }

        public static void LogError(string message)
        {
            Log("ERROR", message);
        }

        private static void Log(string logLevel, string message)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{logLevel}] {message}";
            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
        }
    }
}