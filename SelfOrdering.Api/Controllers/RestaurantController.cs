﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper;
using SelfOrdering.Api.Models.Restaurant;
using SelfOrdering.ApplicationServices.Contracts;

namespace SelfOrdering.Api.Controllers
{
    public class RestaurantController : BaseApiController
    {
        private readonly IRestaurantApplicationService _applicationService;

        public RestaurantController(IRestaurantApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public async Task<HttpResponseMessage> Get()
        {
            try
            {
                var dto = await _applicationService.GetAll();
                var viewModel = Mapper.Map(dto, new List<RestaurantListViewModel>());
                return Request.CreateResponse(HttpStatusCode.OK, viewModel);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/restaurant/{restaurantId}")]
        public async Task<HttpResponseMessage> Get([FromUri]string restaurantId)
        {
            try
            {
                var dto = await _applicationService.GetById(restaurantId);
                var viewModel = Mapper.Map(dto, new RestaurantViewModel());

                return Request.CreateResponse(HttpStatusCode.OK, viewModel);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<HttpResponseMessage> Get([FromUri] double longitude, double latitude)
        {
            try
            {
                var dto = await _applicationService.GetNearRestaurants(longitude, latitude);
                var viewModel = Mapper.Map(dto, new List<RestaurantListViewModel>());

                return Request.CreateResponse(HttpStatusCode.OK, viewModel);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
