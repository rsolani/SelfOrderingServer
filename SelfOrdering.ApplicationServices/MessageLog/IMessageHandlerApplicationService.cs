using System.Threading.Tasks;

namespace SelfOrdering.ApplicationServices.MessageLog
{
    public interface IMessageHandlerApplicationService
    {
        Task Add(MessageHandlerDTO dto);
    }
}