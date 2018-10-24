using VtbCalculator.BusinessLogic.Calculation.Validators;
using VtbCalculator.BusinessLogic.Models;

namespace VtbCalculator.BusinessLogic.Calculation
{
    public class CalculationService : ICalculationService
    {
        public CalculationResultModel Calculate(CalculationRequestModel request)
        {
            if (!CalculationRequestValidator.IsValid(request))
                return new CalculationResultModel {IsSuccessfull = false, Message = "Calculation request not valid"};

            var result = Calculator.Calculate(request);

            return new CalculationResultModel {IsSuccessfull = true, Result = result};
        }
    }
}