using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherMvcFront.Services
{
    public interface IWeatherClient
    {
        Task<IEnumerable<WeatherForecast>> GetWeather();
    }
}
