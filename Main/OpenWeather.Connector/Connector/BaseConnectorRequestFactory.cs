using System.Net.Http;
using System.Collections.Generic;
using System.Text;


namespace OpenWeather
{
    using Core;

    public abstract class BaseConnectorRequestFactory : IRequestBuilder
    {
        public virtual ConnectorRequest Build(AppRequest request, HttpMethod method)
            => new ConnectorRequest(BuildQuery(request, method), BuildHeaders(method), method);

        public virtual string BuildUri(AppRequest request, HttpMethod httpMethod)
        {
            var uri = new StringBuilder();
            uri.Append(BuildQuery(request, httpMethod));
            return uri.ToString();
        }

        public virtual HttpContent BuildBody(HttpMethod httpMethod)
            => null;

        public virtual IDictionary<string, string> BuildHeaders(HttpMethod httpMethod)
            => new Dictionary<string, string>();

        public virtual string BuildQuery(AppRequest request, HttpMethod httpMethod)
            => string.Empty;
    }
}
