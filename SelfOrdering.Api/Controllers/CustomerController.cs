using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper;
using SelfOrdering.Api.Models;
using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.ApplicationServices.DTO;

namespace SelfOrdering.Api.Controllers
{
    public class CustomerController : BaseApiController
    {
        private readonly ICustomerApplicationService _applicationService;

        public CustomerController(ICustomerApplicationService applicationService)
        {
            _applicationService = applicationService;
        }


        [HttpGet]
        public async Task<HttpResponseMessage> Get([FromUri] string id)
        {
            try
            {
                var dto = await _applicationService.GetCustomer(id);

                var viewModel = Mapper.Map(dto, new CustomerViewModel());

                return Request.CreateResponse(HttpStatusCode.OK, viewModel);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        public async Task<HttpResponseMessage> Post([FromBody] CustomerViewModel customer)
        {
            try
            {
                var dto = Mapper.Map(customer, new CustomerDTO());

                dto = await _applicationService.RegisterOrGetCustomer(dto);

                var viewModel = Mapper.Map(dto, new CustomerViewModel());
                
                if(string.IsNullOrWhiteSpace(customer.Id))
                    return Request.CreateResponse(HttpStatusCode.Created, viewModel);
                else
                    return Request.CreateResponse(HttpStatusCode.OK, viewModel);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
