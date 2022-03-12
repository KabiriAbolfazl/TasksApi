namespace TasksApi.WebFramework.Api
{
    public class TokenResponse : BaseResponse
    {
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}
