using System.Collections.Generic;
using System.Threading.Tasks;

namespace SelfOrdering.Domain.Contracts.Services
{
    public interface IDomainService<T> where T : IMongoEntity
    {
        Task<IEnumerable<T>> GetAll();

    }
}
