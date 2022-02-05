using CommonAPI;

namespace LincolnAPI.Sdk.V1.Responses
{
    public class LincolnForecastResponse
    {
        public string? Location { get; set; }
        public WeatherType WeatherType { get; set; }
    }
}
