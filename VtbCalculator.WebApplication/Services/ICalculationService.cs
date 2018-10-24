using VtbCalculator.BusinessLogic.Models;

namespace VtbCalculator.WebApplication.Services
{
    public interface ICalculationService
    {
        CalculationResultModel Calculate(CalculationRequestModel calculationRequest);
    }
}