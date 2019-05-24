using System;
using todo_react_api.Models.Api;
using todo_react_api.Interfaces.Respositories;
using System.Threading.Tasks;
using todo_react_api.Interfaces.Clients;

namespace todo_react_api.Repositories
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private readonly IWeatherForecastClient _weatherForecastClient;

        public WeatherForecastRepository(IWeatherForecastClient weatherForecastClient)
        {
            _weatherForecastClient = weatherForecastClient;
        }
        public async Task<CurrentWeatherForecast> GetCurrentWeatherForecast(string city)
        {
            return await _weatherForecastClient.Get<CurrentWeatherForecast>($"&q={city}&units=metric");
        }
    }
}
