using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSandbox.Core
{
    public interface IWeatherForecastRepository
    {
        Task<IEnumerable<IWeatherForecast>> GetNewestForecastAsync(uint count, CancellationToken cancellationToken);

        Task CreateForecastAsync(IWeatherForecast weatherForecast, CancellationToken cancellationToken);
    }

    public interface ISqlWeatherForecastRepository : IWeatherForecastRepository { }

    public interface IStorageAccountWeatherForecastRepository : IWeatherForecastRepository { }

    public interface ICosmosDBWeatherForecastRepository : IWeatherForecastRepository { }
}
