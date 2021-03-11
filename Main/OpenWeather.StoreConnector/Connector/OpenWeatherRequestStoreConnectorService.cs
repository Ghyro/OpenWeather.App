using System;
using System.Collections.Generic;
using Core;

namespace OpenWeather
{
    public class OpenWeatherRequestStoreConnectorService : IStoreServiceBase
    {
        private readonly IDictionary<RequestType, Func<AppRequest, AppResponse>> _knownMethods;

        public OpenWeatherRequestStoreConnectorService()
        {
            if (_knownMethods == null)
              _knownMethods = PopulateKnownMethods();
        }

        public void Handle(AppRequest request, AppResponse response)
        {
            if (!_knownMethods.TryGetValue(request.RequestType, out var method))
                throw new NotSupportedException();

            response = method.Invoke(request);
        }

        public AppResponse Fetch(AppRequest request)
        {
            // TODO: FileSystemStore
            throw new NotImplementedException();
        }

        public AppResponse Save(AppRequest request)
        {
            // TODO: FileSystemStore
            throw new NotImplementedException();
        }

        private Dictionary<RequestType, Func<AppRequest, AppResponse>> PopulateKnownMethods()
        {
            return new Dictionary<RequestType, Func<AppRequest, AppResponse>>
            {
                { RequestType.Fetch, Fetch },
                { RequestType.Save, Save }
            };
        }
    }
}
