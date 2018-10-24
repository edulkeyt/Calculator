using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtbCalculator.Domain.Models;
using VtbCalculator.Models;

namespace VtbCalculator.DAL.Repositories
{
    public class ServiceActionsLogRepository : IServiceActionsLogRepository
    {
        private readonly VtbCalculatorContext dbContext = new VtbCalculatorContext();

        public void Write(LogEntry logEntry)
        {
            dbContext.ServiceActionsLog.Add(logEntry);
            dbContext.SaveChanges();
        }

        public void Write(string source, string action, string message)
        {
            Write(new LogEntry(source, action, message));
        }

        public IEnumerable<LogEntry> GetInTimeRange(DateTime from, DateTime to)
        {
            return dbContext.ServiceActionsLog.Where(x => x.Time >= from && x.Time <= to).ToArray();
        }
    }
}
