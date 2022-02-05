using CommonAPI.Models;
using LincolnAPI.Sdk.V1.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LincolnAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LincolnController : ControllerBase
    {
        [HttpGet("/lincoln")]
        public LincolnForecastResponse Get()
        {
            return new LincolnForecastResponse
            {
                Location = "Lincoln",
                WeatherType = WeatherTypeAPI.Cool
            };
        }
    }
}
