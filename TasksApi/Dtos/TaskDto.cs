namespace TasksApi.Dtos
{
    public class TaskDto
    {
        public string Name { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime Ts { get; set; }
    }
}
