using VtbCalculator.BusinessLogic.Models;

namespace VtbCalculator.CalculationServiceClients
{
    public interface ICalculationServiceClient
    {
        CalculationResultModel Calculate(CalculationRequestModel calculationRequest);
    }
}