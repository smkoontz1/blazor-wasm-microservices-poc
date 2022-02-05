using CommonAPI.Models;

namespace LincolnAPI.Sdk.V1.Responses
{
    public class LincolnForecastResponse
    {
        public string? Location { get; set; }
        public WeatherTypeAPI WeatherType { get; set; }
    }
}
