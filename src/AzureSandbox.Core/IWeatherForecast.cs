using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSandbox.Core
{
    public interface IWeatherForecast
    {
        public string? Location { get; set; }

        public DateTimeOffset Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }
    }
}
