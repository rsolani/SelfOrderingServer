
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace SelfOrdering.Domain.Contracts.Services
{
    public interface ICustomerService : IDomainService<Customer.Customer>
    {
        Task<ObjectId> RegisterCustomer(Customer.Customer customer);
        
    }
}
