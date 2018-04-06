namespace VeraClient.Logger
{
    public class Logger
    {
        public delegate void LogEvent(LogType logType, string message);

        public event LogEvent OnLogEventCreated;

        public LogType LogLevel{ get; set; }

        public void LogDebug(string logText)
        {
            if (LogLevel == LogType.Debug)
                OnLogEventCreated?.Invoke(LogType.Debug, logText);
        }

        public void LogInfo(string logText)
        {
            if (LogLevel <= LogType.Info)
                OnLogEventCreated?.Invoke(LogType.Info, logText);
        }

        public void LogWarning(string logText)
        {
            if (LogLevel <= LogType.Warning)
                OnLogEventCreated?.Invoke(LogType.Warning, logText);
        }

        public void LogError(string logText)
        {
            OnLogEventCreated?.Invoke(LogType.Error, logText);
        }
    }
}