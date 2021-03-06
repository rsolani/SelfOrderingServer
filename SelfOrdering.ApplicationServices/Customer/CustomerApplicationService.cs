﻿using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MongoDB.Bson;
using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.ApplicationServices.Customer
{
    public class CustomerApplicationService : ApplicationServiceBase<Domain.Customer.Customer>, ICustomerApplicationService
    {
        private readonly ICustomerService _customerService;

        public CustomerApplicationService(IBaseRepository<Domain.Customer.Customer> repository, ICustomerService customerService) 
            : base(repository)
        {
            _customerService = customerService;
        }


        public async Task<CustomerDTO> RegisterOrGetCustomer(CustomerDTO customerDto)
        {
            var existingCustomer = await Repository.GetByFilterAsync(x => x.Email == customerDto.Email);

            if (existingCustomer.FirstOrDefault() == null)
            {
                var newCustomer = Mapper.Map(customerDto, new Domain.Customer.Customer(customerDto.Name, customerDto.Email, customerDto.Cpf));
                await _customerService.RegisterCustomer(newCustomer);
                return Mapper.Map(newCustomer, new CustomerDTO());
            }

            return Mapper.Map(existingCustomer.FirstOrDefault(), new CustomerDTO());
        }

        public async Task<CustomerDTO> GetCustomer(string id)
        {
            var customer = await Repository.GetByIdAsync(new ObjectId(id));
            return Mapper.Map(customer, new CustomerDTO());
        }
    }
}
