using System.Threading.Tasks;


namespace OpenWeather.Infrastructure.Connector
{
    public interface IConnectorService
    {
        Task<ConnectorResponse> ExecuteAsync(ConnectorRequest request);
    }
}
