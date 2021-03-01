using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Connector
{
    using Core;

    public sealed class OpenWeatherConnectorResponse : ConnectorResponse
    {
        public OpenWeatherConnectorResponse(HttpResponseMessage responseMessage, string content) : base(responseMessage, content)
        {

        }
    }
}
