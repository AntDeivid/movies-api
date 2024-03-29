using AutoMapper;
using movies_api_back.Models.DAO;
using movies_api_back.Models.DTO;
using movies_api_back.Repositories;

namespace movies_api_back.Services.Impl;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IGenericRepository<User> _genericRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper, IGenericRepository<User> genericRepository)
    {
        _userRepository = userRepository;
        _mapper = mapper;
        _genericRepository = genericRepository;
    }

    public UserDto Save(UserDto userDto)
    {
        var user = _mapper.Map<User>(userDto);
        user.SetPassword(userDto.Password!);
        var savedUser = _genericRepository.Save(user);
        return _mapper.Map<UserDto>(savedUser);
    }

    public UserDto Update(UserDto userDto)
    {
        var user = _mapper.Map<User>(userDto);
        var updatedUser = _genericRepository.Update(user);
        return _mapper.Map<UserDto>(updatedUser);
    }

    public UserDto GetByEmail(string email)
    {
        var user = _userRepository.GetByEmail(email);
        return _mapper.Map<UserDto>(user);
    }

    public UserDto Delete(UserDto userDto)
    {
        var user = _mapper.Map<User>(userDto);
        var deletedUser = _genericRepository.Delete(user);
        return _mapper.Map<UserDto>(deletedUser);
    }
}