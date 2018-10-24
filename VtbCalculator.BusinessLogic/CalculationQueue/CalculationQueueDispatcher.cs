using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtbCalculator.BusinessLogic.Models;
using VtbCalculator.BusinessLogic.Models.Mappers;
using VtbCalculator.DAL.Repositories;
using VtbCalculator.Domain.Models;

namespace VtbCalculator.BusinessLogic.CalculationQueue
{
    public class CalculationQueueDispatcher : ICalculationQueueDispatcher
    {
        private readonly ICalculationQueueRepository _repository = new CalculationQueueRepository();

        public CalculationRequest Enqueue(CalculationRequestModel calculationRequest)
        {
            return _repository.Add(CalculationRequestMapper.FromModel(calculationRequest));
        }

        public void Dequeue(long id)
        {
            _repository.Remove(id);
        }

        public IEnumerable<CalculationRequest> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
