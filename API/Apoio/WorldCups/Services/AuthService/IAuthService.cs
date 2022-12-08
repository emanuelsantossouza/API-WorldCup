using WorldCups.Models;

namespace WorldCups.Services.AuthService;

public interface IAuthService
{
    Task<ServiceResponse<Guid>> Register(User user, string password);
    Task<ServiceResponse<string>> Login(string username, string password);
    Task<bool> UserExists(string username);
}