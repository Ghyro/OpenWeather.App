using System;
using Newtonsoft.Json;


namespace OpenWeather.Connector
{
    using Core;

    public static class JsonParser
    {
        public static T ConvertToAppModel<T>(string jsonResponse)
        {
            if (jsonResponse.IsNullOrEmpty())
                return default(T);

            try
            {
                var model = JsonConvert.DeserializeObject<T>(jsonResponse);
                return model;
            }
            catch (Exception ex)
            {
                throw new JsonSerializationException("An invalid response was received from the Connector service.", ex);
            }
        }
    }
}
