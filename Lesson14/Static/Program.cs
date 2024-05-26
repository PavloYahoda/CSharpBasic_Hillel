using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Option 1: Dictionary
            EventLogger.AddLog("App is started");
            Thread.Sleep(1000);
            EventLogger.AddLog("User is logged in");
            Thread.Sleep(1000);
            EventLogger.AddLog("User is logged out");
            Thread.Sleep(1000);
            EventLogger.AddLog("App is stopped");

            Dictionary<DateTime, string> allLogs = EventLogger.GetLogs();
            Console.WriteLine("All logs:");
            foreach (var log in allLogs)
            {
                Console.WriteLine($"{log.Key}: {log.Value}");
            }
            Console.WriteLine("---------------------------");

            //Option 2: List
            Logger.AddLog("User is logged in");
            Thread.Sleep(1000);
            Logger.AddLog("Chrome browser is opened");
            Thread.Sleep(1000);
            Logger.AddLog("Email is sent");
            Thread.Sleep(1000);
            Logger.AddLog("User is logged out");

            List<LogEntry> allLogs2 = Logger.GetLogs();
            Console.WriteLine("All logs:");
            foreach (var log in allLogs2)
            {
                Console.WriteLine($"{log.Timestamp}: {log.Message}");
            }

            Console.ReadKey();
        }
    }
}
