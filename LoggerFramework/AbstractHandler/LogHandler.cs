using LoggerFramework.Interface;


namespace LoggerFramework.AbstractHandler
{
    public abstract class LogHandler:ILogger
    {
        protected ILogger _next;

       public void SetNext(ILogger next)
        {
            _next = next;
        }

        public abstract void Log(string message, LoggerEnum loglevel);
    }
}
