using movies_api_back.Models.DAO;

namespace movies_api_back.Repositories.Impl;

public class UserRepository : IUserRepository
{
    
    private readonly MoviesDbContext _moviesDbContext;

    public UserRepository(MoviesDbContext moviesDbContext)
    {
        _moviesDbContext = moviesDbContext ?? throw new ArgumentNullException(nameof(moviesDbContext));
    }

    public User? GetByEmail(string email)
    {
        return _moviesDbContext.Users!.FirstOrDefault(user => user.Email == email);
    }
}