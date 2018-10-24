using VtbCalculator.BusinessLogic.Models;

namespace VtbCalculator.BusinessLogic.Calculation
{
    public interface ICalculationService
    {
        CalculationResultModel Calculate(CalculationRequestModel request);
    }
}