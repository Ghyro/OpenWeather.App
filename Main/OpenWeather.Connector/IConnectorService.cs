using System.Threading.Tasks;


namespace OpenWeather.Connector
{
    using OpenWeather.Infrastructure;

    public interface IConnectorService
    {
        Task<ConnectorResponse> ExecuteAsync(ConnectorRequest request);
    }
}
