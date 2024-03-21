using AutoMapper;
using movies_api_back.Models.DAO;
using movies_api_back.Models.DTO;

namespace movies_api_back.Util;

public class MappingConfiguration : Profile
{
    public MappingConfiguration()
    {
        CreateMap<Movie, MovieDto>()
            .ReverseMap();

        CreateMap<User, UserDto>()
            .ReverseMap();
    }
}