using System.Net.Http;
using OpenWeather.Infrastructure.Connector;


namespace OpenWeather.Connector
{
    using Core;

    public class OpenWeatherRequestBuilder : BaseConnectorRequestFactory
    {
        private readonly string ResourceUrl;

        public OpenWeatherRequestBuilder()
        {
            // AppInfo
        }

        public override ConnectorRequest Build(AppRequest request, HttpMethod httpMethod)
        {
            return new ConnectorRequest(BuildUri(request, httpMethod), BuildHeaders(httpMethod), httpMethod);
        }

        public override string BuildQuery(AppRequest request, HttpMethod httpMethod)
        {
            // TODO: Implement

            return null;
        }
    }
}
