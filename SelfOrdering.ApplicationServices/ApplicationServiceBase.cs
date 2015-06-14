using System.Collections.Generic;
using System.Threading.Tasks;
using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.Domain.Contracts;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.ApplicationServices
{
    public class ApplicationServiceBase<T> : IApplicationService<T> where T : IMongoEntity 
    {

        private IDomainService<T> _service;

        public ApplicationServiceBase(IDomainService<T> service)
        {
            _service = service;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _service.GetAll();
        }
    }
}
