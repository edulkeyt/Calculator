using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtbCalculator.Domain.Models;

namespace VtbCalculator.BusinessLogic.Models.Mappers
{
    public static class CalculationRequestMapper
    {
        public static CalculationRequest FromModel(CalculationRequestModel model)
        {
            return new CalculationRequest()
            {
                OperationType = (OperationType) model.OperationType,
                OperandLeft = model.LeftOperand,
                OperandRight = model.RightOperand
            };
        }

        public static CalculationRequestModel ToModel(CalculationRequest request)
        {
            return new CalculationRequestModel()
            {
                OperationType = (int) request.OperationType,
                LeftOperand = request.OperandLeft,
                RightOperand = request.OperandRight
            };
        }
    }
}
