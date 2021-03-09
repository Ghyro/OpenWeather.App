using System;
using System.Collections.Generic;


namespace Core
{
    using OpenWeather;

    public class OpenWeatherRequestHandler : IBaseRequestHandler
    {
        private readonly IServiceBase _service;
        private readonly IDictionary<Type, Func<AppRequest, AppResponse>> _handlerMethods;

        public OpenWeatherRequestHandler()
        {
            if (_service == null)
                _service = new OpenWeatherRequestService();
            if (_handlerMethods == null)
                _handlerMethods = InitHandlerMethods();
        }

        public AppResponse DoHandle(AppRequest request)
        {
            if (!_handlerMethods.TryGetValue(request.GetType(), out var method))
                throw new NotSupportedException();

            return method.Invoke(request);
        }

        private AppResponse DoFetch(AppRequest request)
        {            
            var fetchReq = request as FetchDataRequest;

            var fetchResp = _service.Fetch(fetchReq);

            return fetchResp;
        }

        private Dictionary<Type, Func<AppRequest, AppResponse>> InitHandlerMethods()
        {
            return new Dictionary<Type, Func<AppRequest, AppResponse>>
            {
                { typeof(FetchDataRequest) , DoFetch }
            };
        }
    }
}
