namespace TasksApi.Dtos
{
    public class RefreshTokenDto
    {
        public int UserId { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
    }
}
