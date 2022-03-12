using System.Text.Json.Serialization;

namespace TasksApi.WebFramework.Api
{
    public abstract class BaseResponse
    {
        [JsonIgnore()]
        public bool Success { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ErrorCode { get; set; } = string.Empty;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Error { get; set; } = string.Empty;
    }
}
