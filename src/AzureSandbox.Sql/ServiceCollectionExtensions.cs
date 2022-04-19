using AzureSandbox.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSandbox.Sql
{
    public static class ServiceCollectionExtensions
    {
        public static void AddEFSqlServer(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<WeatherForecastConstext>(cfg =>
            {
                cfg.UseSqlServer(connectionString);
            });


            services.AddTransient<DbInitializer>();
            services.AddTransient<ISqlWeatherForecastRepository, WeatherForecastRepository>();
        }
    }
}
