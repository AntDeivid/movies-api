using System.ComponentModel.DataAnnotations;

namespace movies_api_back.Models.DAO;

public class BaseClass
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
    public DateTimeOffset RegisterAt { get; set; }
}