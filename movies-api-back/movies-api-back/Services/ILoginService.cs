namespace movies_api_back.Services;

public interface ILoginService
{
    string Authenticate(string email, string password);
}