using movies_api_back.Models.DAO;

namespace movies_api_back.Repositories;

public interface IUserRepository
{
    User? GetByEmail(string email);
}