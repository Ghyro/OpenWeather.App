using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Infrastructure
{
    using Core;

    public class ServiceResponse
    {
        public ServiceResponse(ConnectorResponse connectorResponse)
        {

        }

        //TODO:
    }

    public sealed class ServiceResponse<T> where T : class
    {
        // TODO:
    }
}
