using CommonAPI;

namespace OmahaAPI.Sdk.V1.Responses
{
    public class OmahaForecastResponse
    {
        public string? Location { get; set; }
        public WeatherType WeatherType { get; set; }
        public int TemperatureF { get; set; }
    }
}
