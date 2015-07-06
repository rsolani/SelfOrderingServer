using System.Threading.Tasks;
using MongoDB.Bson;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.Domain.Customer
{
    public class CustomerService : DomainServiceBase<Customer>, ICustomerService
    {

        public CustomerService(IBaseRepository<Customer> repository)
            : base(repository)
        {
           
        }

        public async Task<ObjectId> RegisterCustomer(Customer customer)
        {
            await Repository.InsertAsync(customer);
            return customer.Id;
        }
    }
}
