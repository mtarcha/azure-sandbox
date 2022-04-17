using AzureSandbox.Shared;
using Refit;

namespace AzureSandbox.Client.Services
{
    public interface IWeatherForecastApi
    {
        [Get("")]
        Task<IEnumerable<WeatherForecast>> GetAsync();
    }
}
