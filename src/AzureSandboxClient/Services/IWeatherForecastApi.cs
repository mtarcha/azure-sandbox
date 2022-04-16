using AzureSandbox.Shared;
using Refit;

namespace AzureSandboxClient.Services
{
    public interface IWeatherForecastApi
    {
        [Get("")]
        Task<IEnumerable<WeatherForecast>> GetAsync();
    }
}
