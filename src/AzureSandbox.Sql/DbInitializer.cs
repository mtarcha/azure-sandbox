using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AzureSandbox.Sql
{
    internal class DbInitializer
    {
        private readonly WeatherForecastConstext _ctx;

        public DbInitializer(WeatherForecastConstext ctx)
        {
            _ctx = ctx;
  
        }

        public async Task SeedAsync(CancellationToken token)
        {
            var created = _ctx.Database.EnsureCreated();

            if(created)
            {
                var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

                var seeds = Enumerable.Range(1, 5).Select(index => new WeatherForecastEntity
                {
                    Location = "Houten",
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = summaries[Random.Shared.Next(summaries.Length)]
                })
                .ToArray();

                await _ctx.WeatherForecast.AddRangeAsync(seeds, token);
                await _ctx.SaveChangesAsync(token);
            }
        }
    }
}
