using System.Net;
using System.Net.Http;

using DTO = OpenWeather.API.DTO;


namespace OpenWeather
{
    public class ConnectorResponse
    {
        public ConnectorResponse(DTO.OpenWeatherEntityModel openWeatherEntityModel, HttpResponseMessage responseMessage)
        {
            this.OpenWeatherEntityModel = openWeatherEntityModel;
            this.IsSuccess = responseMessage.IsSuccessStatusCode;
            this.StatusCode = responseMessage.StatusCode;
        }

        public DTO.OpenWeatherEntityModel OpenWeatherEntityModel { get; }

        public bool IsSuccess { get; }

        public HttpStatusCode StatusCode { get; }
    }
}
