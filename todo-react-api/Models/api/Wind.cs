using System;
using Newtonsoft.Json;

namespace todo_react_api.Models.Api
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int Cloudiness { get; set; }
    }
}
