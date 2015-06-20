using System.Threading.Tasks;
using MongoDB.Bson;

namespace SelfOrdering.Domain.Contracts.Services
{
    public interface ICustomerService : IDomainService<Customer.Customer>
    {
        
    }
}
