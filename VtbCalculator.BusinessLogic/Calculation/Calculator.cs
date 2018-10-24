using System;
using VtbCalculator.BusinessLogic.Models;
using VtbCalculator.Domain.Models;

namespace VtbCalculator.BusinessLogic.Calculation
{
    public static class Calculator
    {
        public static decimal Calculate(CalculationRequestModel request)
        {
            switch ((OperationType) request.OperationType)
            {
                case OperationType.Addition:
                    return request.LeftOperand + request.RightOperand;
                case OperationType.Substraction:
                    return request.LeftOperand - request.RightOperand;
                case OperationType.Multiplication:
                    return request.LeftOperand * request.RightOperand;
                case OperationType.Division:
                    return request.LeftOperand / request.RightOperand;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}