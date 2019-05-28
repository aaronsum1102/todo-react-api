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
    [Route("api/weather")]
    public class WeatherController : Controller
    {
        private readonly IWeatherForecastRepository _weatherForecastReposioty;

        public WeatherController(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastReposioty = weatherForecastRepository;
        }

        [HttpGet("{city}")]
        public async Task<IActionResult> GetCurrentWeatherForecast(string city)
        {   
            var forecast = await _weatherForecastReposioty.GetCurrentWeatherForecast(city);
            if(string.IsNullOrEmpty(forecast.CityName))
            {
                return NotFound();
            }
            return Ok(forecast);
        }
    }
}
