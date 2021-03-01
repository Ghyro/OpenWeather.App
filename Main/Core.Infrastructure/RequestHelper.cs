using System;
using System.Linq;


namespace Core
{
    public class RequestHelper
    {
        public static T Create<T>(AppRequest request) where T : AppRequest, new()
        {
            return (T)Activator.CreateInstance(typeof(T), request);
        }

        public static T GetRequest<T>(AppRequest request) where T : AppRequest
        {
            var req = request.OfValidType<T>();

            return req ?? null;
        }
    }
}
