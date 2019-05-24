using todo_react_api.Interfaces.Clients;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace todo_react_api.Clients
{
    public class WeatherForecastClient : IWeatherForecastClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;


        public WeatherForecastClient()
        {
            _httpClient = new HttpClient();
            _apiKey = "APPID=25c444ff04044800774dcb20061dd989";
            _httpClient.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");
        }

        public async Task<TResponse> Get<TResponse>(string url)
        {
            var response = await _httpClient.GetAsync($"weather?{_apiKey}{url}");
            return ProcessReponse<TResponse>(response);
        }

        protected TResponse ProcessReponse<TResponse>(HttpResponseMessage response)
        {
            var body = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<TResponse>(body);
        }
    }
}
