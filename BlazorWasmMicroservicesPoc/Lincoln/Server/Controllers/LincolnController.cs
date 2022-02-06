using Lincoln.Shared.V1.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using WeatherForecasts.Shared;

namespace Lincoln.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    [RequiredScope("Lincoln.Read")]
    public class LincolnController : ControllerBase
    {
        [HttpGet("/lincoln")]
        public LincolnForecastResponse Get()
        {
            return new LincolnForecastResponse
            {
                Location = "Lincoln",
                WeatherType = WeatherType.Chilly
            };
        }
    }
}