using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenWeather.Connector
{
    using Core;

    public abstract class BaseConnectorRequestBuilder
    {
        public virtual ConnectorRequest Build()
        {
            return new ConnectorRequest();
        }


    }
}
