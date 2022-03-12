using TasksApi.WebFramework.Api;
using Task = TasksApi.Entities.Task;
namespace TasksApi.Services.Contracts
{
    public interface ITasksService
    {
        Task<GetTasksResponse> GetTasks(int userId);
        Task<SaveTaskResponse> SaveTask(Task task);
        Task<DeleteTaskResponse> DeleteTask(int taskId, int userId);
    }
}
