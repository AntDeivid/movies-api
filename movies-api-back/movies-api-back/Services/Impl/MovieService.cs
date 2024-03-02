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
        throw new NotImplementedException();
    }

    public List<MovieDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<MovieDto> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public MovieDto Update(Guid movieId)
    {
        throw new NotImplementedException();
    }

    public MovieDto Delete(Guid movieId)
    {
        throw new NotImplementedException();
    }
}