using movies_api_back.Models.DAO;

namespace movies_api_back.Services;

public interface ITokenService
{
    string GenerateToken(User user);
}