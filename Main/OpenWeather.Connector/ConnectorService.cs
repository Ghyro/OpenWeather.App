using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace OpenWeather.Connector
{
    using Core;

    public class ConnectorService : IConnectorService
    {
        private readonly HttpClient HttpClient;

        public ConnectorService()
        {
            if (HttpClient == null)
                HttpClient = new HttpClient();
        }

        public async Task<ConnectorResponse> ExecuteAsync(ConnectorRequest request)
        {
            var httpRequest = PrepareHttpRequest(request);

            var httpResponse = await DoExecuteAsync(HttpClient, httpRequest).ConfigureAwait(false);

            return await PrepareConnectorResponseAsync(httpResponse).ConfigureAwait(false);
        }

        private async Task<HttpResponseMessage> DoExecuteAsync(HttpClient client, HttpRequestMessage request)
        {
            try
            {
                using (var response = await client.SendAsync(request))
                {
                    return response;
                }
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message, ex);
            }
        }

        private HttpRequestMessage PrepareHttpRequest(ConnectorRequest connectorRequest)
        {
            var request = new HttpRequestMessage(connectorRequest.HttpMethod, connectorRequest.Uri);
            ApplyHttpRequestHeaders(request, connectorRequest.Headers);

            return request;
        }

        private async Task<ConnectorResponse> PrepareConnectorResponseAsync(HttpResponseMessage responseMessage)
        {
            var content = responseMessage?.Content != null
                ? await responseMessage.Content.ReadAsStringAsync()
                : null;
            
            return new OpenWeatherConnectorResponse(responseMessage, content);
        }

        private void ApplyHttpRequestHeaders(HttpRequestMessage request, IDictionary<string, string> headers)
        {
            foreach (var header in headers)
                request.Headers.Add(header.Key, header.Value);
        }
    }
}
