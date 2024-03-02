namespace movies_api_back.Models.DTO;

public class BaseClassDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTimeOffset RegisterAt { get; set; }
}