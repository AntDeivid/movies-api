using movies_api_back.Models.DAO;

namespace movies_api_back.Repositories;

public interface IMovieRepository
{
    public List<Movie> GetPaged(int? page);

    public List<Movie> GetBySubstring(string subs, int? page);
}