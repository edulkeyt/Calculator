using System;
using VtbCalculator.BusinessLogic.CalculationQueue;
using VtbCalculator.BusinessLogic.Models;
using VtbCalculator.CalculationServiceClients;

namespace VtbCalculator.WebApplication.Services
{
    public class CalculationService : ICalculationService
    {
        private readonly ICalculationServiceClient _calculationServiceClient = new CalculationServiceClient();

        private readonly ICalculationQueueDispatcher _queueDispatcher = new CalculationQueueDispatcher();

        public CalculationResultModel Calculate(CalculationRequestModel calculationRequest)
        {
            var queueedRequest = _queueDispatcher.Enqueue(calculationRequest);

            CalculationResultModel result;
            try
            {
                result = _calculationServiceClient.Calculate(calculationRequest);
            }
            catch (Exception e)
            {
                return new CalculationResultModel
                {
                    IsSuccessfull = false,
                    Message =
                        "Something went wrong. Please, wait for calculation result in your e-mail. Sorry for inconvenience"
                };
            }

            _queueDispatcher.Dequeue(queueedRequest.Id);

            return result;
        }
    }
}