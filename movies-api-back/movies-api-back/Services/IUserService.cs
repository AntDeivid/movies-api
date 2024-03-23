using movies_api_back.Models.DTO;

namespace movies_api_back.Services;

public interface IUserService
{
    UserDto Save(UserDto userDto);
    UserDto Update(UserDto userDto);
    UserDto GetByEmail(string email);
    UserDto Delete(UserDto userDto);
}