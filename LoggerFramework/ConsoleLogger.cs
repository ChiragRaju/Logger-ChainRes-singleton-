using LoggerFramework.AbstractHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerFramework
{
    public class ConsoleLogger : LogHandler
    {
        public override void Log(string message, LoggerEnum loglevel)
        {
            if (loglevel == LoggerEnum.INFO || loglevel == LoggerEnum.WARNING)
            {
                Console.WriteLine($"[CONSOLE] {loglevel}: {message}");
            }
            else
            {
                _next?.Log(message, loglevel);
            }
        }
    }

}
