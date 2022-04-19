using AzureSandbox.Core;
using AzureSandbox.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AzureSandboxServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISqlWeatherForecastRepository _sqlRepository;

        public WeatherForecastController(ISqlWeatherForecastRepository sqlRepository)
        {
            _sqlRepository = sqlRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get(CancellationToken token)
        {
            var result = await _sqlRepository.GetNewestForecastAsync(10, token);
            return result.Select(Map);
        }

        private static WeatherForecast Map(IWeatherForecast weatherForecast)
        {
            return new WeatherForecast
            {
                Location = weatherForecast.Location,
                Date = weatherForecast.Date.Date,
                Summary = weatherForecast.Summary,
                TemperatureC = weatherForecast.TemperatureC
            };
        }
    }
}