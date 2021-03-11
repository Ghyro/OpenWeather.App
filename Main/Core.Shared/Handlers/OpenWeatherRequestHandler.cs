namespace Core
{
    using OpenWeather;

    public class OpenWeatherRequestHandler : IBaseRequestHandler
    {                
        public AppResponse DoHandle(AppRequest request)
        {
            var response = new AppResponse();
            var service = TryGetOpenWeatherServiceType(request);

            if (service != null)
            {                
                service.Handle(request, response);
                return response;
            }

            return response;
        }

        private static IServiceBase TryGetOpenWeatherServiceType(AppRequest request)
        {
            switch (request.ActionType)
            {
                case ActionType.API:
                  return new OpenWeatherRequestConnectorService();
                case ActionType.Store:
                  return new OpenWeatherRequestStoreConnectorService();
                default:
                  return null;
            }
        }
    }
}
