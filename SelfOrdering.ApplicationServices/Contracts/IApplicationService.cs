using System.Collections.Generic;
using System.Threading.Tasks;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.ApplicationServices.Contracts
{
    public interface IApplicationService<T> where T : IMongoEntity 
    {
        Task<IEnumerable<T>> GetAll();
    }
}
