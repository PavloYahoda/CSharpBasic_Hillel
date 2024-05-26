using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class LogEntry
    {
        public DateTime Timestamp { get; }
        public string Message { get; }

        public LogEntry(string message)
        {
            Timestamp = DateTime.Now;
            Message = message;
        }
    }
}
