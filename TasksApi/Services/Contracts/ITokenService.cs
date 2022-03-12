using TasksApi.Dtos;
using TasksApi.Entities;
using TasksApi.WebFramework.Api;

namespace TasksApi.Services.Contracts
{
    public interface ITokenService
    {
        Task<Tuple<string, string>> GenerateTokensAsync(int userId);
        Task<ValidateRefreshTokenResponse> ValidateRefreshTokenAsync(RefreshTokenDto refreshTokenRequest);
        Task<bool> RemoveRefreshTokenAsync(User user);
    }
}
