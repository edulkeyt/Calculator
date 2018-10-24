using VtbCalculator.DAL.Repositories;

namespace VtbCalculator.DbLogger
{
    public class DbLogger : IDbLogger
    {
        private readonly IServiceActionsLogRepository _dbLogRepository = new ServiceActionsLogRepository();

        public void Log(string source, string method, string message)
        {
            _dbLogRepository.Write(source, method, message);
        }
    }
}