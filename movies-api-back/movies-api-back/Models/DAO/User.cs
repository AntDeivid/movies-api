using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace movies_api_back.Models.DAO;

[Table("Users")]
public class User : BaseClass
{
    public string? Name { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public byte[]? Salt { get; set; }
    
    public static byte[] GenerateSalt()
    {
        using var rng = new RNGCryptoServiceProvider();
        var buffer = new byte[16];
        rng.GetBytes(buffer);
        return buffer;
    }
    
    public static string HashPassword(string password, byte[] salt)
    {
        using var pass = new Rfc2898DeriveBytes(password, salt, 1000);
        var hash = pass.GetBytes(20);
        return Convert.ToBase64String(hash);
    }
    
    public void SetPassword(string password)
    {
        Salt = GenerateSalt();
        Password = HashPassword(password, Salt);
    }
}