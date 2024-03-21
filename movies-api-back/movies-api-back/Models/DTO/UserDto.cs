namespace movies_api_back.Models.DTO;

public class UserDto : BaseClassDto
{
    public string? Name { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Salt { get; set; }
}