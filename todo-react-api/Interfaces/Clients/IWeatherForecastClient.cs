using System;
using System.Threading.Tasks;
using todo_react_api.Models.Api;

namespace todo_react_api.Interfaces.Clients
{
    public interface IWeatherForecastClient
    {
        Task<TResponse> Get<TResponse>(string url);
    }
}
