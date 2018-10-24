using System.Net;
using System.Net.Http;
using System.Web.Http;
using VtbCalculator.WebApplication.PickLists;

namespace VtbCalculator.WebApplication.Controllers
{
    public class PickListsController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new OperationTypeDataProvider().GetItems());
        }
    }
}