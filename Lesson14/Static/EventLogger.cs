using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public static class EventLogger
    {
        private static Dictionary<DateTime, string> logs = new Dictionary<DateTime, string>();

        public static void AddLog(string message)
        {
            DateTime currentTime = DateTime.Now;
            logs[currentTime] = message;
        }
        public static Dictionary<DateTime, string> GetLogs()
        {
            return logs;
        }
    }
}
