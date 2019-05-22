using System;
using todo_react_api.Models.Api;

namespace todo_react_api.Extensions
{
    public static class WeatherForecastExtensions
    {
        public static CurrentWeatherForecast ToExternal(this CurrentWeatherForecast CurrentWeatherForecast)
        {
            return new CurrentWeatherForecast()
            {
                CityId = CurrentWeatherForecast.CityId
            };
        }
    }
}
