using System.Net.Http;
using System.Collections.Specialized;


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

        public ConnectorRequest Build<T>(T request)
        {
            if (request is FetchDataRequest)            
                BuildForFetch(request as FetchDataRequest);

            return null;
        }

        private ConnectorRequest BuildForFetch(FetchDataRequest request)
        {
            var httpMethod = HttpMethod.Get;
            return new ConnectorRequest(BuildUri(httpMethod), BuildHeaders(httpMethod), httpMethod);
        }

        public override string BuildQuery(HttpMethod httpMethod)
        {
            // TODO: Implement

            return null;
        }
    }
}
