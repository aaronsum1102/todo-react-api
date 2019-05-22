using System;
using Newtonsoft.Json;

namespace todo_react_api.Models.Api
{
    public class Wind
    {
        [JsonProperty("speed")]
        public float Speed { get; set; }
        [JsonProperty("deg")]
        public int Degrees { get; set; }
    }
}
