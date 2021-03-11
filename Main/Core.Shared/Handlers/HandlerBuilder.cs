namespace Core
{
    public class HandlerBuilder
    {
        public void DoHandle(ProcessRequest processRequest, ProcessResponse processResponse)
        {
            foreach (var request in processRequest.Requests)
            {
                var handler = GetRequestHandlerByInstanceId(request);

                if (handler != null)
                    processResponse.Responses.Add(handler.DoHandle(request));
            }
        }

        private static IBaseRequestHandler GetRequestHandlerByInstanceId(AppRequest request)
        {
            if (request.InstanceId.EqIgnoreCase(AppConstants.Connector.Instance.OPEN_WEATHER))            
                return new OpenWeatherRequestHandler();            

            return null;
        }           
    }
}
