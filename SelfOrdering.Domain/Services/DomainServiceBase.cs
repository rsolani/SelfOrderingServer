using System.Collections.Generic;
using System.Threading.Tasks;
using SelfOrdering.Domain.Contracts;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.Domain.Services
{
    public class DomainServiceBase<T> : IDomainService<T> where T : IMongoEntity
    {
        private IBaseRepository<T> _repository; 

        public DomainServiceBase(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _repository.Get();
        }
    }
}
