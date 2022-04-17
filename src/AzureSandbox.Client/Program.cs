using AzureSandbox.Client;
using AzureSandbox.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var weatherForecastUri = builder.Configuration.GetValue<string>("WeatherForecastApi:Uri");

builder.Services
    .AddRefitClient<IWeatherForecastApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(weatherForecastUri));

await builder.Build().RunAsync();
