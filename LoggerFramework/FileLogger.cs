using LoggerFramework.AbstractHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerFramework
{
    public class FileLogger : LogHandler
    {
        public override void Log(string message, LoggerEnum loglevel)
        {
            if(loglevel==LoggerEnum.ERROR)
            {
                Console.WriteLine($"[FILE] ERROR logged to file:{message}");
            }
            else
                _next?.Log(message, loglevel);
        }
    }
}
