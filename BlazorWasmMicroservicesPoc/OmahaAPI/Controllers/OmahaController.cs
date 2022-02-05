using CommonAPI.Models;
using Microsoft.AspNetCore.Mvc;
using OmahaAPI.Sdk.V1.Responses;

namespace OmahaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OmahaController
    {
        [HttpGet("/omaha")]
        public OmahaForecastResponse Get()
        {
            return new OmahaForecastResponse
            {
                Location = "Omaha",
                WeatherType = WeatherTypeAPI.Freezing,
                TemperatureF = 32
            };
        }
    }
}
