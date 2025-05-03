using LoggerFramework.AbstractHandler;
using LoggerFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerFramework
{
    public class DebugLogger:LogHandler
    {
        public override void Log(string message, LoggerEnum loglevel)
        {
            if (loglevel == LoggerEnum.DEBUG)
            {
                Console.WriteLine($"[DEBUG] {message}");
            }
            else
                _next?.Log(message, loglevel);
        }
    }
}
