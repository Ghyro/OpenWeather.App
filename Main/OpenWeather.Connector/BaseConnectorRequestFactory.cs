using System.Net.Http;
using System.Collections.Generic;
using System.Text;


namespace OpenWeather.Connector
{
    using Core;

    public abstract class BaseConnectorRequestFactory : IRequestBuilder
    {
        public virtual ConnectorRequest Build(HttpMethod method)
            => new ConnectorRequest(BuildQuery(method), BuildHeaders(method), method);

        public virtual string BuildUri(HttpMethod httpMethod)
        {
            var uri = new StringBuilder();
            uri.Append(BuildQuery(httpMethod));
            return uri.ToString();
        }

        public virtual HttpContent BuildBody(HttpMethod httpMethod)
            => null;

        public virtual IDictionary<string, string> BuildHeaders(HttpMethod httpMethod)
            => new Dictionary<string, string>();

        public virtual string BuildQuery(HttpMethod httpMethod)
            => string.Empty;
    }
}
