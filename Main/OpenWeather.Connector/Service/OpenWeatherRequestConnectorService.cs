using System;
using System.Collections.Generic;
using System.Net.Http;


namespace OpenWeather
{
    using Core;

    public class OpenWeatherRequestConnectorService : IServiceBase
    {
        private readonly IDictionary<RequestType, Func<AppRequest, AppResponse>> _knownMethods;
        private readonly OpenWeatherRequestBuilder _openWeatherRequestBuilder;
        private readonly ConnectorService _connectorService;

        public OpenWeatherRequestConnectorService()
        {
            if (_knownMethods == null)
                _knownMethods = PopulateKnownMethods();

            if (_openWeatherRequestBuilder == null)
                _openWeatherRequestBuilder = new OpenWeatherRequestBuilder();

            if (_connectorService == null)
              _connectorService = new ConnectorService();
        }

        public void Handle(AppRequest request, AppResponse response)
        {
            if (!_knownMethods.TryGetValue(request.RequestType, out var method))
                throw new NotSupportedException();

            response = method.Invoke(request);
        }

        public AppResponse Fetch(AppRequest request)
        {
            var connectorRequest = _openWeatherRequestBuilder.Build(request, HttpMethod.Get);

            var connectorResponse = _connectorService.ExecuteAsync(connectorRequest).Result;

            // TODO: Mock to return null
            return null;
        }

        private Dictionary<RequestType, Func<AppRequest, AppResponse>> PopulateKnownMethods()
        {
            return new Dictionary<RequestType, Func<AppRequest, AppResponse>>
            {
                { RequestType.Fetch, Fetch }
            };
        }
    }
}
