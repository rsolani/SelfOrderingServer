using System.Collections.Generic;
using System.Threading.Tasks;
using SelfOrdering.ApplicationServices.DTO;

namespace SelfOrdering.ApplicationServices.Contracts
{
    public interface IRestaurantApplicationService : IApplicationService
    {
        Task<IReadOnlyList<RestaurantDTO>> GetAll();
        Task<RestaurantDTO> GetById(string id);
    }
}
