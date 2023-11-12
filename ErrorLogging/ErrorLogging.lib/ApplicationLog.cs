using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorLogging.lib
{
    public static class ApplicationLog
    {
        private static ILogger currentLogger=null;
        public static void Initialize(ILogger logger)
        { 
        ApplicationLog.currentLogger = logger;
        }
        public static void WriteMessage(LogLavel lavel, string message)
        { 
            if (ApplicationLog.currentLogger is not null)
            {
                ApplicationLog.currentLogger.WriteMessage(lavel, message);
            }
        
        }
    }
}
