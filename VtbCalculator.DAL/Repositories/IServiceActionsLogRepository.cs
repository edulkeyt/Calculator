using System;
using System.Collections.Generic;
using VtbCalculator.Domain.Models;

namespace VtbCalculator.DAL.Repositories
{
    public interface IServiceActionsLogRepository
    {
        IEnumerable<LogEntry> GetInTimeRange(DateTime from, DateTime to);
        void Write(LogEntry logEntry);
        void Write(string source, string action, string message);
    }
}