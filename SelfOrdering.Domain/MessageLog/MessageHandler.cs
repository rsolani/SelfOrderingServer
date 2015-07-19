using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.Domain.MessageLog
{
    
    public class MessageHandler : MongoEntityBase, IAggregateRoot
    {
        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Utc, Representation = BsonType.DateTime)]
        public DateTime RequestDateTime { get; set; }

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
