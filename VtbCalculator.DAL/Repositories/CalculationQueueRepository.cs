using System.Collections.Generic;
using System.Linq;
using VtbCalculator.Domain.Models;
using VtbCalculator.Models;

namespace VtbCalculator.DAL.Repositories
{
    public class CalculationQueueRepository : ICalculationQueueRepository
    {
        private readonly VtbCalculatorContext dbContext = new VtbCalculatorContext();

        public CalculationQueueRepository()
        {
            //hack not working without it https://www.koskila.net/system-invalidoperationexception-ado-net/
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public CalculationRequest Add(CalculationRequest request)
        {
            dbContext.CalculationQueue.Add(request);
            dbContext.SaveChanges();
            return request;
        }

        public void Remove(long id)
        {
            dbContext.CalculationQueue.Remove(dbContext.CalculationQueue.First(x => x.Id == id));
            dbContext.SaveChanges();
        }

        public IEnumerable<CalculationRequest> GetAll()
        {
            return dbContext.CalculationQueue.ToArray();
        }
    }
}