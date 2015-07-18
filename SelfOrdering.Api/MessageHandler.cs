﻿using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using AutoMapper;
using SelfOrdering.Api.Models.MessageLog;
using SelfOrdering.ApplicationServices.MessageLog;

namespace SelfOrdering.Api
{
    public class MessageHandler : DelegatingHandler
    {
        private readonly IMessageHandlerApplicationService _service;

        public MessageHandler(IMessageHandlerApplicationService service)
        {
            _service = service;
        }

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.RequestUri.Query != string.Empty || request.RequestUri.AbsolutePath != @"/")
            {
                var requestDate = DateTime.Now;

                var message = new MessageHandlerViewModel
                {
                    Method = request.RequestUri.AbsolutePath,
                    Parameters = request.RequestUri.Query,
                    Verb = request.Method.Method,
                    Ip = HttpContext.Current.Request.UserHostAddress,
                    RequestContent = request.Content.ToString()
                };

                return await Task.Run(async () => await base.SendAsync(request, cancellationToken), cancellationToken)
                .ContinueWith(responseTask =>
                {
                    var result          = responseTask.Result;
                    var responseMessage = result.Content.ReadAsByteArrayAsync().Result;

                    message.ResponseContent = Encoding.UTF8.GetString(responseMessage, 0, responseMessage.Length);
                    message.HttpStatusCode = (int) result.StatusCode;
                    
                    var responseDate = DateTime.Now;

                    message.Duration = responseDate.Subtract(requestDate);

                    var dto = Mapper.Map(message, new MessageHandlerDTO());

                    _service.Add(dto);

                    return result;

                }, cancellationToken);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}