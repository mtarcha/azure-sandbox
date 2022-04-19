using AzureSandbox.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AzureSandbox.Sql
{
    internal class WeatherForecastRepository : ISqlWeatherForecastRepository
    {
        private readonly WeatherForecastConstext _ctx;
        private readonly DbInitializer _initializer;

        public WeatherForecastRepository(WeatherForecastConstext ctx, DbInitializer initializer)
        {
            _ctx = ctx;
            _initializer = initializer;

        }

        public async Task CreateForecastAsync(IWeatherForecast weatherForecast, CancellationToken cancellationToken)
        {
            await _ctx.WeatherForecast.AddAsync(Map(weatherForecast), cancellationToken);
        }

        public async Task<IEnumerable<IWeatherForecast>> GetNewestForecastAsync(uint count, CancellationToken cancellationToken)
        {
            await _initializer.SeedAsync(cancellationToken);

            IEnumerable<IWeatherForecast> result = await _ctx.WeatherForecast.OrderByDescending(x => x.Date).Take((int)count).ToListAsync(cancellationToken);

            return result;
        }

        private static WeatherForecastEntity Map(IWeatherForecast weatherForecast)
        {
            return new WeatherForecastEntity
            {
                Location = weatherForecast.Location,
                Date = weatherForecast.Date,
                Summary = weatherForecast.Summary,
                TemperatureC = weatherForecast.TemperatureC
            };
        }
    }
}
