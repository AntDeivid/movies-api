using Microsoft.EntityFrameworkCore;
using movies_api_back.Models.DAO;

namespace movies_api_back.Repositories.Impl;

public class MovieRepository : IMovieRepository
{
    private readonly MoviesDbContext _moviesDbContext;

    public MovieRepository(MoviesDbContext moviesDbContext)
    {
        _moviesDbContext = moviesDbContext;
    }

    public List<Movie> GetPaged(int? page)
    {
        const int pagesize = 10;
        var movies = _moviesDbContext.Movies!.Skip((page ?? 0) * pagesize).Take(pagesize).ToList();

        return movies;
    }

    public List<Movie> GetBySubstring(string subs, int? page)
    {
        const int pagesize = 10;
        var movies = _moviesDbContext.Movies!.Where(movie => movie.Title != null && EF.Functions.Like(movie.Title, $"%{subs}%"))
            .Skip((page ?? 0) * pagesize).Take(pagesize).ToList();

        return movies;
    }
}