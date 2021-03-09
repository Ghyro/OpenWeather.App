using System.Net.Http;


namespace OpenWeather.Infrastructure.Connector
{
    using Core;

    public interface IRequestBuilder
    {
        ConnectorRequest Build(AppRequest request, HttpMethod method);
    }
}
