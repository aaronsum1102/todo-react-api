using System;
using Newtonsoft.Json;

namespace todo_react_api.Models.Api
{
    public class Weather
    {
        [JsonProperty("temp")]
        public float Temperature { get; set; }
        [JsonProperty("pressure")]
        public float Pressure { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("temp_min")]
        public float MinTemperature { get; set; }
        [JsonProperty("temp_max")]
        public float MaxTemperature { get; set; }
    }
}
