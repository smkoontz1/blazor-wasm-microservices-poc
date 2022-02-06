using WeatherForecasts.Shared;

namespace Lincoln.Shared.V1.Responses
{
    public class LincolnForecastResponse
    {
        public string? Location { get; set; }
        public WeatherType WeatherType { get; set; }
    }
}
