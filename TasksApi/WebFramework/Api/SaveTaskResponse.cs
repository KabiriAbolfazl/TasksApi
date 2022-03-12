namespace TasksApi.WebFramework.Api
{
    public class SaveTaskResponse : BaseResponse
    {
        public TasksApi.Entities.Task Task { get; set; }
    }
}
