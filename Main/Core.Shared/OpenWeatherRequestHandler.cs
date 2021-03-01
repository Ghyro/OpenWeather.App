namespace Core
{
    using OpenWeather.Connector;    

    public class OpenWeatherRequestHandler
    {
        private readonly IServiceBase Service;

        public OpenWeatherRequestHandler()
        {
            if (Service == null)
                Service = new OpenWeatherRequestService();
        }

        public FetchDataResponse DoHandle(AppRequest request)
        {
            FetchDataRequest fetchDataRequest = null;
            FetchDataResponse fetchDataResponse = null;

            if (TryGetFetchDataRequest(request, ref fetchDataRequest))  
                fetchDataResponse = Service.Fetch(fetchDataRequest);            

            return fetchDataResponse;
        }     

        private bool TryGetFetchDataRequest(AppRequest request, ref FetchDataRequest fetchDataRequest)
        {
            fetchDataRequest = RequestHelper.GetRequest<FetchDataRequest>(request);
            return fetchDataRequest != null;
        }
    }
}
