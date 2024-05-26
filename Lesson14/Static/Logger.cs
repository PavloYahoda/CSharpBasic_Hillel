using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public static class Logger
    {
        private static List<LogEntry> logs = new List<LogEntry>();
        public static void AddLog(string message)
        {
            LogEntry logEntry = new LogEntry(message);
            logs.Add(logEntry);
        }

        public static List<LogEntry> GetLogs()
        {
            return logs;
        }
    }
}
