using System.Net.Http;


namespace Core
{
    public interface IRequestBuilder
    {
        ConnectorRequest Build(HttpMethod method);
    }
}
