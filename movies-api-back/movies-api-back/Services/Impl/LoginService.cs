using AutoMapper;
using movies_api_back.Models.DAO;

namespace movies_api_back.Services.Impl;

public class LoginService : ILoginService
{
    private readonly IUserService _userService;
    private readonly ITokenService _tokenService;
    private readonly IMapper _mapper;

    public LoginService(IUserService userService, ITokenService tokenService, IMapper mapper)
    {
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        _tokenService = tokenService ?? throw new ArgumentNullException(nameof(tokenService));
        _mapper = mapper;
    }

    public string Authenticate(string email, string password)
    {
        var savedUser = _userService.GetByEmail(email);
        if (savedUser == null) throw new UnauthorizedAccessException();
        var salt = Convert.FromBase64String(savedUser.Salt);
        var hashedPassword = User.HashPassword(password, salt);
        if (savedUser.Password != hashedPassword) throw new UnauthorizedAccessException();
        return _tokenService.GenerateToken(_mapper.Map<User>(savedUser));
    }
}