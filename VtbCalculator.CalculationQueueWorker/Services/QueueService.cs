using System;
using VtbCalculator.BusinessLogic.CalculationQueue;
using VtbCalculator.BusinessLogic.Models.Mappers;
using VtbCalculator.CalculationServiceClients;
using VtbCalculator.EmailService;

namespace VtbCalculator.CalculationQueueWorker.Services
{
    public class QueueService : IQueueService
    {
        private static bool _isCalculationg;

        private readonly ICalculationServiceClient _calculationService = new CalculationServiceClient();

        private readonly IEmailService _emailService = new EmailService.EmailService();

        private readonly ICalculationQueueDispatcher _queueDispatcher = new CalculationQueueDispatcher();

        public void RerunCalculationsInQueue()
        {
            if (_isCalculationg)
                return;

            try
            {
                _isCalculationg = true;

                lock (typeof(QueueService))
                {
                    var calculationRequests = _queueDispatcher.GetAll();

                    foreach (var calculationRequest in calculationRequests)
                    {
                        var result =
                            _calculationService.Calculate(CalculationRequestMapper.ToModel(calculationRequest));

                        _queueDispatcher.Dequeue(calculationRequest.Id);

                        var emailMessage = result.IsSuccessfull
                            ? $"Result {result.Result}"
                            : $"Error: {result.Message}";

                        _emailService.SendEmail("defaultQueueEmail", "defaultQueueCcEmail", "Calculation Results",
                            emailMessage);
                    }
                }
            }
            catch (Exception e)
            {
                _isCalculationg = false;
                throw;
            }

            _isCalculationg = false;
        }
    }
}