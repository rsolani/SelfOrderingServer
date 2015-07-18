using System.Threading.Tasks;
using AutoMapper;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.MessageLog;

namespace SelfOrdering.ApplicationServices.MessageLog
{
    public class MessageHandlerApplicationService : ApplicationServiceBase<MessageHandler>, IMessageHandlerApplicationService
    {
        public MessageHandlerApplicationService(IBaseRepository<MessageHandler> repository) 
            : base(repository)
        {
        }

        public async Task Add(MessageHandlerDTO dto)
        {
            var message = Mapper.Map(dto, new MessageHandler());
            await Repository.InsertAsync(message);
        }
    }
}
