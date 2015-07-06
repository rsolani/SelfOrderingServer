using System.Threading.Tasks;
using SelfOrdering.ApplicationServices.Customer;

namespace SelfOrdering.ApplicationServices.Contracts
{
    public interface ICustomerApplicationService
    {
        Task<CustomerDTO> RegisterOrGetCustomer(CustomerDTO customerDto);
        Task<CustomerDTO> GetCustomer(string id);

    }
}