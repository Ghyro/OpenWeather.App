using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Core
{
    public class ConnectorResponse
    {
        public ConnectorResponse(HttpResponseMessage responseMessage, string content)
        {
            IsSuccess = responseMessage.IsSuccessStatusCode;
            StatusCode = responseMessage.StatusCode;
            Content = content;
            Headers = GetHeaderFromResponse(responseMessage.Headers);
        }

        public bool IsSuccess { get; }

        public string Content { get; }

        public HttpStatusCode StatusCode { get; }

        public IDictionary<string, string> Headers { get; }

        private IDictionary<string, string> GetHeaderFromResponse(HttpResponseHeaders headers)
        {
            //TODO: Implement later
            throw new NotImplementedException();
        }
    }
}
