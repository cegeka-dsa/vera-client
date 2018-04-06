namespace VeraClient.Logger
{
    public class LoggerSingleton
    {
        private static volatile Logger _instance;
        private static readonly object SyncRoot = new object();

        private LoggerSingleton() { }

        public static Logger Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (SyncRoot)
                {
                    if (_instance == null)
                        _instance = new Logger();
                }

                return _instance;
            }
        }
    }
}
