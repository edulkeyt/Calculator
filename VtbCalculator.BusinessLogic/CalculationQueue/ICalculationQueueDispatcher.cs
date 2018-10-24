using System.Collections.Generic;
using VtbCalculator.BusinessLogic.Models;
using VtbCalculator.Domain.Models;

namespace VtbCalculator.BusinessLogic.CalculationQueue
{
    public interface ICalculationQueueDispatcher
    {
        void Dequeue(long id);
        CalculationRequest Enqueue(CalculationRequestModel calculationRequest);
        IEnumerable<CalculationRequest> GetAll();
    }
}