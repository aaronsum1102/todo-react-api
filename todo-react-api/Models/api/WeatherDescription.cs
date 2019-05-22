using System;
using Newtonsoft.Json;

namespace todo_react_api.Models.Api
{
    public class WeatherDescription
    {
        [JsonProperty("main")]
        public String Main { get; set; }
        [JsonProperty("description")]
        public String Description { get; set; }
    }
}
