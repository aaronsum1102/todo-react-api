using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using todo_react_api.Interfaces.Clients;
using todo_react_api.Interfaces.Respositories;
using todo_react_api.Models.Api;
using todo_react_api.Repositories;

namespace todo_react_api_test.Repositories
{   
    [TestClass]
    public class WeatherForecastReposiotyTest
    {
        private static IWeatherForecastRepository _repository;
        private static Mock<IWeatherForecastClient> _clientMock;

        [ClassInitialize]
        public static void InitialiseTest(TestContext testContext)
        {
            _clientMock = new Mock<IWeatherForecastClient>();
            _repository = new WeatherForecastRepository(_clientMock.Object);

        }

        [TestMethod]
        public async Task GetCurrentWeatherForecastTest() 
        {   
            string url = "&q=london&units=metric";
            var result = await _repository.GetCurrentWeatherForecast("london");
            _clientMock.Verify(client => client.Get<CurrentWeatherForecast>(url));

        }
    }
}
