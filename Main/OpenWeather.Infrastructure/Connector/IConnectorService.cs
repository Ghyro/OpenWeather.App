using System.Threading.Tasks;


namespace OpenWeather
{
    public interface IConnectorService
    {
        Task<ConnectorResponse> ExecuteAsync(ConnectorRequest request);
    }
}
