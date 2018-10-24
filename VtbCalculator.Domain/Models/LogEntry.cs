using System;

namespace VtbCalculator.Domain.Models
{
    public class LogEntry
    {
        public LogEntry()
        {
        }

        public LogEntry(string source, string action, string message)
        {
            Time = DateTime.UtcNow;
            Source = source;
            Action = action;
            Message = message;
        }

        public long Id { get; set; }
        public DateTime Time { get; set; }
        public string Source { get; set; }
        public string Action { get; set; }
        public string Message { get; set; }
    }
}