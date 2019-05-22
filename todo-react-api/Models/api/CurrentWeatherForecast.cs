using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace todo_react_api.Models.Api
{
    public class CurrentWeatherForecast
    {
        [JsonProperty("id")]
        public int CityId { get; set; }
        [JsonProperty("name")]
        public string CityName { get; set; }
        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }
        [JsonProperty("weather")]
        public List<WeatherDescription> WeatherDescription { get; set; }
        [JsonProperty("main")]
        public Weather Weather { get; set; }
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
        [JsonProperty("clouds")]
        public Clouds Cloudiness { get; set; }
    }
}
