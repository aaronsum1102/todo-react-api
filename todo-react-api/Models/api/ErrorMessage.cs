using System;
using Newtonsoft.Json;

namespace todo_react_api.Models.Api
{
    public class ErrorMessage
    {
        [JsonProperty("code")]
        public string ErrorCode { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
