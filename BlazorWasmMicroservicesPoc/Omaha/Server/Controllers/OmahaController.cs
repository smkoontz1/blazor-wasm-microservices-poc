using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using Omaha.Shared.V1.Responses;
using WeatherForecasts.Shared;

namespace WeatherForecasts.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    [RequiredScope("Omaha.Read")]
    public class OmahaController : ControllerBase
    {
        [HttpGet("/omaha")]
        public OmahaForecastResponse Get()
        {
            return new OmahaForecastResponse
            {
                Location = "Omaha",
                WeatherType = WeatherType.Freezing,
                TemperatureF = 32
            };
        }
    }
}