using System;
using System.Threading.Tasks;
using todo_react_api.Models.Api;

namespace todo_react_api.Interfaces.Respositories
{
    public interface IWeatherForecastRepository
    {
        Task<CurrentWeatherForecast> GetCurrentWeatherForecast(string city);
    }
}
