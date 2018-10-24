using VtbCalculator.BusinessLogic.Models;
using VtbCalculator.CalculationServiceClients.Reference;
using VtbCalculator.DbLogger;

namespace VtbCalculator.CalculationServiceClients
{
    public class CalculationServiceClient : ICalculationServiceClient
    {
        private readonly ICalculationWcfService _service = new CalculationWcfServiceClient();

        private readonly IDbLogger _dbLogger = new DbLogger.DbLogger();

        public CalculationResultModel Calculate(CalculationRequestModel calculationRequest)
        {
            _dbLogger.Log(nameof(CalculationServiceClient), nameof(Calculate),
                $"Start sending calculation request. Operation id:{calculationRequest.OperationType}, left operand:{calculationRequest.LeftOperand}, right operand:{calculationRequest.RightOperand}");

            var result = _service.Calculate(calculationRequest);

            _dbLogger.Log(nameof(CalculationServiceClient), nameof(Calculate),
                $"Calculation result recieved. Operation id:{calculationRequest.OperationType}, left operand:{calculationRequest.LeftOperand}, right operand:{calculationRequest.RightOperand}. Result isSuccess:{result.IsSuccessfull}, resultValue{result.Result}, message:{result.Message}");

            return result;
        }
    }
}