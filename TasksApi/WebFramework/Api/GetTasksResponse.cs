 using Task = TasksApi.Entities.Task;
namespace TasksApi.WebFramework.Api
{
    public class GetTasksResponse:BaseResponse
    {
        public List<Task> Tasks { get; set; }
    }
}
