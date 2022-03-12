using TasksApi.Dtos;
using TasksApi.WebFramework.Api;

namespace TasksApi.Services.Contracts
{
    public interface IUserService
    {
        Task<TokenResponse> LoginAsync(LoginDto loginRequest);
        Task<SignupResponse> SignupAsync(SignupDto signupRequest);
        Task<LogoutResponse> LogoutAsync(int userId);
    }
}
