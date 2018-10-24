using VtbCalculator.BusinessLogic.Models;
using VtbCalculator.Common.Helpers;
using VtbCalculator.Common.Helpers.Enumerations;
using VtbCalculator.Domain.Models;

namespace VtbCalculator.BusinessLogic.Calculation.Validators
{
    public static class CalculationRequestValidator
    {
        public static bool IsValid(CalculationRequestModel request)
        {
            if (!EnumCastHelper.IsValueDefined<OperationType>(request.OperationType))
                return false;

            return request.OperationType != (int) OperationType.Division || request.RightOperand != decimal.Zero;
        }
    }
}