using System.Net;
using System.Net.Http;
using System.Web.Http;
using VtbCalculator.BusinessLogic.Models;
using VtbCalculator.DbLogger;
using VtbCalculator.WebApplication.Services;

namespace VtbCalculator.WebApplication.Controllers
{
    public class CalculationController : ApiController
    {
        private readonly ICalculationService _calculationService = new CalculationService();

        private readonly IDbLogger _dbLogger = new DbLogger.DbLogger();

        public HttpResponseMessage Post([FromBody] CalculationRequestModel request)
        {
            _dbLogger.Log(nameof(WebApplication), nameof(Post), $"Calculation request received. Left operand {request.LeftOperand}. Right operand {request.RightOperand}. Operation id {request.OperationType}");

            return Request.CreateResponse(HttpStatusCode.OK, _calculationService.Calculate(request));
        }
    }
}