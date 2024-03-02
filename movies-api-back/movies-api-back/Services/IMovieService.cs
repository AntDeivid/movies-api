using movies_api_back.Models.DTO;

namespace movies_api_back.Services;

public interface IMovieService
{
    MovieDto Save(MovieDto movieDto);
    List<MovieDto> GetAll();
    List<MovieDto> GetByName(string name);
    MovieDto Update(Guid movieId);
    MovieDto Delete(Guid movieId);
}