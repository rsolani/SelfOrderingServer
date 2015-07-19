using System;

namespace SelfOrdering.ApplicationServices.MessageLog
{
    public class MessageHandlerDTO
    {
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