using System.Collections.Generic;
using System.Net.Http;

namespace OpenWeather.Infrastructure
{
    public sealed class ConnectorRequest
    {
        public string Uri { get; set; }

        public IDictionary<string, string> Headers { get; set; }

        public HttpMethod HttpMethod { get; set; }
    }
}
