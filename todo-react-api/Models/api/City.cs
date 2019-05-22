using System;
using Newtonsoft.Json;

namespace todo_react_api.Models.Api
{
    public class City
    {
        [JsonProperty("id")]
        public int CityId { get; set; }
        [JsonProperty("name")]
        public string CityName { get; set; }
    }
}
