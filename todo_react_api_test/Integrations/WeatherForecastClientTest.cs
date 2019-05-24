using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using todo_react_api.Interfaces.Clients;
using todo_react_api.Clients;
using System.Threading.Tasks;
using todo_react_api.Models.Api;

namespace todo_react_api_test.Integrations
{
    [TestClass]
    public class WeatherForecastClientTest
    {
        private IWeatherForecastClient _client = new WeatherForecastClient();

        [TestMethod]
        public async Task Get()
        {
            string url = "&q=london&units=metric";
            var result = await _client.Get<CurrentWeatherForecast>(url);
            Assert.IsNotNull(result);
        }
    }
}
