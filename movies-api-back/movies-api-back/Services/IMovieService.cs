using movies_api_back.Models.DTO;

namespace movies_api_back.Services;

public interface IMovieService
{
    MovieDto Save(MovieDto movieDto);
    List<MovieDto> GetAll();
    List<MovieDto> GetByName(string name, int page);
    MovieDto Update(MovieDto movieDto);
    MovieDto Delete(MovieDto movieDto);
}