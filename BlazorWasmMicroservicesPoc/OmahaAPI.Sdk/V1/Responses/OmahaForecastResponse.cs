using CommonAPI.Models;

namespace OmahaAPI.Sdk.V1.Responses
{
    public class OmahaForecastResponse
    {
        public string? Location { get; set; }
        public WeatherTypeAPI WeatherType { get; set; }
        public int TemperatureF { get; set; }
    }
}
