using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace OpenWeather.Connector
{
    using OpenWeather.Infrastructure;

    public class OpenWeatherConnectorService : IConnectorService
    {
        private readonly HttpClient _httpClient;

        public OpenWeatherConnectorService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<ConnectorResponse> ExecuteAsync(ConnectorRequest request)
        {
            var httpRequest = PrepareHttpRequest(request);

            var httpResponse = await DoExecuteAsync(_httpClient, httpRequest).ConfigureAwait(false);

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
            var request = new HttpRequestMessage();

            // TODO: fill out this object

            return request;
        }

        private async Task<ConnectorResponse> PrepareConnectorResponseAsync(HttpResponseMessage responseMessage)
        {
            var content = responseMessage?.Content != null
                ? await responseMessage.Content.ReadAsStringAsync()
                : null;
            
            return new ConnectorResponse(responseMessage, content);
        }
    }
}
