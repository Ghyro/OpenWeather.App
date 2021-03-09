using System.Net.Http;


namespace OpenWeather.Connector
{
    using Core;

    public class OpenWeatherRequestService : IServiceBase
    {
        private readonly OpenWeatherRequestBuilder _openWeatherRequestBuilder;
        private readonly ConnectorService _connectorService;

        public OpenWeatherRequestService()
        {
            if (_openWeatherRequestBuilder == null)
                _openWeatherRequestBuilder = new OpenWeatherRequestBuilder();

            if (_connectorService == null)
              _connectorService = new ConnectorService();
        }

        public AppResponse Fetch(AppRequest request)
        {
            var connectorRequest = _openWeatherRequestBuilder.Build(request, HttpMethod.Get);

            var connectorResponse = _connectorService.ExecuteAsync(connectorRequest).Result;

            // TODO: Mock to return null
            return null;
        }
    }
}
