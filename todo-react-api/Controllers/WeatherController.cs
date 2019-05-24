using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todo_react_api.Models.Api;
using todo_react_api.Interfaces.Respositories;

namespace todo_react_api.Controllers
{
    [Produces("application/json")]
    public class WeatherController : Controller
    {
        private readonly IWeatherForecastRepository _weatherForecastReposioty;

        public WeatherController(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastReposioty = weatherForecastRepository;
        }

        [HttpGet]
        [Route("api/weather/{city}")]
        public async Task<CurrentWeatherForecast> GetCurrentWeatherForecast(string city)
        {
            var forecast = await _weatherForecastReposioty.GetCurrentWeatherForecast(city);
            return forecast;
        }
    }
}
