using System;
using System.Collections.Generic;
using System.Net.Http;


namespace OpenWeather
{
    public class ConnectorRequest : BaseApiRequest
    {
        public Uri Uri { get; set; }

        public IDictionary<string, string> Headers { get; set; }

        public HttpMethod HttpMethod { get; set; }

        public ConnectorRequest(string uri, IDictionary<string, string> headers, HttpMethod httpMethod) : base()
        {
            Uri = new Uri(uri);
            Headers = headers;
            HttpMethod = httpMethod;
        }
    }
}
