using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using Newtonsoft.Json;
using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.ApplicationServices.DTO;
using SelfOrdering.Domain.Restaurant;

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
        public async Task<HttpResponseMessage> Get(string id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, await _applicationService.GetById(new ObjectId(id)));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpPost]
        public async Task<HttpResponseMessage> Post([FromBody]RestaurantDTO restaurant)
        {
            try
            {
                var x = restaurant;

                return Request.CreateResponse(HttpStatusCode.Created, x);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
    }
}
