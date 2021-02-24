using System.Threading.Tasks;


namespace Core
{
    public interface IConnectorService
    {
        Task<ConnectorResponse> ExecuteAsync(ConnectorRequest request);
    }
}
