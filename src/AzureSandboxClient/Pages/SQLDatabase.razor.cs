using AzureSandbox.Shared;
using AzureSandboxClient.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace AzureSandboxClient.Pages
{
    public partial class SQLDatabase
    {
        [Inject]
        private IWeatherForecastApi WeatherForecastApi { get; set; }

        private IEnumerable<WeatherForecast> _forecasts;

        protected override async Task OnInitializedAsync()
        {
            _forecasts = await WeatherForecastApi.GetAsync();
        }
    }
}
