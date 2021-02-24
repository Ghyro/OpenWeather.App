using System.Collections.Generic;
using System.Net.Http;

namespace Core
{
    public sealed class ConnectorRequest
    {
        public string Uri { get; set; }

        public IDictionary<string, string> Headers { get; set; }

        public HttpMethod HttpMethod { get; set; }
    }
}
