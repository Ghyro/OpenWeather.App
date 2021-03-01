namespace Core
{
    public class HandlerBuilder
    {
        public void DoHandle(ProcessRequest processRequest, ProcessResponse processResponse)
        {
            processResponse = new ProcessResponse();

            OpenWeatherRequestHandler openWeatherRequestHandler = null;

            foreach (var request in processRequest.Requests)
            {
                AppResponse response = null;

                if (TryGetOpenWeatherRequestHandler(request, ref openWeatherRequestHandler))
                {
                    response = openWeatherRequestHandler.DoHandle(request);
                    continue;
                }

                processResponse.Responses.Add(response);
            }
        }

        private bool TryGetOpenWeatherRequestHandler(AppRequest request, ref OpenWeatherRequestHandler openWeatherRequestHandler)
        {
            if (request.InstanceId.EqIgnoreCase(AppConstants.Connector.Instance.OPEN_WEATHER))
            {
                openWeatherRequestHandler = new OpenWeatherRequestHandler();
            }

            return openWeatherRequestHandler != null;
        }           
    }
}
