using AutoMapper;
using movies_api_back.Models.DAO;
using movies_api_back.Models.DTO;
using movies_api_back.Repositories;

namespace movies_api_back.Services.Impl;

public class MovieService : IMovieService
{
    private readonly IGenericRepository<Movie> _genericRepository;
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;

    public MovieService(IGenericRepository<Movie> genericRepository, IMovieRepository movieRepository, IMapper mapper)
    {
        _genericRepository = genericRepository;
        _movieRepository = movieRepository;
        _mapper = mapper;
    }

    public MovieDto Save(MovieDto movieDto)
    {
        var movie = _mapper.Map<Movie>(movieDto);
        MovieDto savedMovie = _mapper.Map<MovieDto>(_genericRepository.Save(movie));
        return savedMovie;
    }

    public List<MovieDto> GetAll()
    {
        var movies = _genericRepository.All().ToList();
        return _mapper.Map<List<MovieDto>>(movies);
    }

    public List<MovieDto> GetByName(string name, int page)
    {
        var movies = _movieRepository.GetBySubstring(name, page);
        return _mapper.Map<List<MovieDto>>(movies);
    }

    public MovieDto Update(MovieDto movieDto)
    {
        var movie = _genericRepository.Update(_mapper.Map<Movie>(movieDto));
        return _mapper.Map<MovieDto>(movie);
    }

    public MovieDto Delete(MovieDto movieDto)
    {
        var movie = _genericRepository.Delete(_mapper.Map<Movie>(movieDto));
        return _mapper.Map<MovieDto>(movie);
    }
}