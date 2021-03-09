using System.Net.Http;


namespace OpenWeather
{
    using Core;

    public interface IRequestBuilder
    {
        ConnectorRequest Build(AppRequest request, HttpMethod method);
    }
}
