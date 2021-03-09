using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using DTO = OpenWeather.API.DTO;


namespace OpenWeather
{
    public class ConnectorService : IConnectorService
    {
        private readonly HttpClient _httpClient;

        public ConnectorService()
        {
            if (_httpClient == null)
                _httpClient = new HttpClient();
        }

        public async Task<ConnectorResponse> ExecuteAsync(ConnectorRequest request)
        {
            var httpRequest = PrepareHttpRequest(request);

            var httpResponse = await DoExecuteAsync(_httpClient, httpRequest).ConfigureAwait(false);

            return await PrepareConnectorResponseAsync(httpResponse).ConfigureAwait(false);
        }

        private static async Task<HttpResponseMessage> DoExecuteAsync(HttpClient client, HttpRequestMessage request)
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

        private static HttpRequestMessage PrepareHttpRequest(ConnectorRequest connectorRequest)
        {
            var request = new HttpRequestMessage(connectorRequest.HttpMethod, connectorRequest.Uri);
            ApplyHttpRequestHeaders(request, connectorRequest.Headers);

            return request;
        }

        private static async Task<ConnectorResponse> PrepareConnectorResponseAsync(HttpResponseMessage responseMessage)
        {
            var content = responseMessage?.Content != null
                ? await responseMessage.Content.ReadAsStringAsync()
                : null;
            
            return new ConnectorResponse(JsonParser.ConvertToAppModel<DTO.OpenWeatherEntityModel>(content), responseMessage);
        }

        private static void ApplyHttpRequestHeaders(HttpRequestMessage request, IDictionary<string, string> headers)
        {
            foreach (var header in headers)
                request.Headers.Add(header.Key, header.Value);
        }
    }
}
