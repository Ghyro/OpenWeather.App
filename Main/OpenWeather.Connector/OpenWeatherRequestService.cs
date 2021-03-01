using System;


namespace OpenWeather.Connector
{
    using Core;

    public class OpenWeatherRequestService : IServiceBase
    {
        private readonly OpenWeatherRequestBuilder OpenWeatherRequestBuilder;

        public OpenWeatherRequestService()
        {
            if (OpenWeatherRequestBuilder == null)
                OpenWeatherRequestBuilder = new OpenWeatherRequestBuilder();
        }

        public FetchDataResponse Fetch(FetchDataRequest request)
        {
            var connectorRequest = OpenWeatherRequestBuilder.Build<FetchDataRequest>(request);

            //TODO: Implement

            return new FetchDataResponse();
        }
    }
}
