using CommonAPI;
using Microsoft.AspNetCore.Mvc;

namespace OmahaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OmahaController
    {
        [HttpGet("/omaha")]
        public string Get()
        {
            return "todo";
            //return new WeatherForecast
            //{
            //    Location = "Omaha",
            //    WeatherType = WeatherType.Freezing
            //};
        }
    }
}
