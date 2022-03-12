using System.Text.Json.Serialization;

namespace TasksApi.WebFramework.Api
{
    public class DeleteTaskResponse:BaseResponse
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int TaskId { get; set; }
    }
}
