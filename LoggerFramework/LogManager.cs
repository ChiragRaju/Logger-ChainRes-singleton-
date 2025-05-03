using LoggerFramework.AbstractHandler;

namespace LoggerFramework
{
    public class LogManager
    {
        private static readonly LogManager _instance = new LogManager();
        public static LogManager Instance => _instance;

        private readonly LogHandler _handlerChain;

        private LogManager()
        {
            // Create logger instances
            var debugLogger = new DebugLogger();
            var consoleLogger = new ConsoleLogger();
            var fileLogger = new FileLogger();

            // Chain: Debug -> Console -> File
            debugLogger.SetNext(consoleLogger);
            consoleLogger.SetNext(fileLogger);

            _handlerChain = debugLogger;
        }

        public void Logger(string message, LoggerEnum level)
        {
            _handlerChain.Log(message, level);
        }
    }
}
