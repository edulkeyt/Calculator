using System.Collections.Generic;
using VtbCalculator.Domain.Models;

namespace VtbCalculator.DAL.Repositories
{
    public interface ICalculationQueueRepository
    {
        CalculationRequest Add(CalculationRequest request);
        IEnumerable<CalculationRequest> GetAll();
        void Remove(long id);
    }
}