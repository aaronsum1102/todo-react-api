﻿using System;
using Newtonsoft.Json;

namespace todo_react_api.Models.Api
{
    public class Coordinates
    {
        [JsonProperty("lon")]
        public float Longitude { get; set; }
        [JsonProperty("lat")]
        public float Latitude { get; set; }
    }
}
