namespace OpenWeather.Infrastructure.Connector
{
    public abstract class BaseApiRequest
    {
        public string Key { get; set; }

        public BaseApiRequest()
        {
            // TODO: Config key
        }
    }
}