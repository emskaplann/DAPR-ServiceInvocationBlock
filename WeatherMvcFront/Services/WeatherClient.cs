using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WeatherMvcFront.Services
{
    public class WeatherClient : IWeatherClient
    {
        private HttpClient httpClient;

        public WeatherClient(HttpClient httpClient)
        {
            this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        
        public async Task<IEnumerable<WeatherForecast>> GetWeather()
        {
            return await httpClient.
                GetFromJsonAsync<IEnumerable<WeatherForecast>>("/weatherforecast");
        }
    }
}
