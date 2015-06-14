using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SelfOrdering.ApplicationServices.Contracts;

namespace SelfOrdering.Api.Controllers
{
    public class RestaurantController : ApiController
    {
        private IRestaurantApplicationService _applicationService;

        public RestaurantController(IRestaurantApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public async Task<HttpResponseMessage> Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, await _applicationService.GetAll());
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpGet]
        public async Task<HttpResponseMessage> GetById(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, await _applicationService.GetAll());
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

    }
}
