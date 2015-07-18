using System;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.Domain.MessageLog
{
    
    public class MessageHandler : MongoEntityBase, IAggregateRoot
    {
        public TimeSpan Duration { get; set; }
        public string Method { get; set; }
        public string Parameters { get; set; }
        public string Verb { get; set; }
        public int HttpStatusCode { get; set; }
        public string Ip { get; set; }
        public string ResponseContent { get; set; }
        public string RequestContent { get; set; }

    }
}
