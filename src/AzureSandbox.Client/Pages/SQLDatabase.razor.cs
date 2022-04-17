using AzureSandbox.Shared;
using AzureSandbox.Client.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace AzureSandbox.Client.Pages
{
    public partial class SQLDatabase : ComponentBase
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
