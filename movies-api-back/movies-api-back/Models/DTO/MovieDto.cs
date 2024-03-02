using movies_api_back.Enums;

namespace movies_api_back.Models.DTO;

public class MovieDto : BaseClassDto
{
    public string? Title { get; set; }
    public Genre Genre { get; set; }
    public DateOnly Premiere { get; set; }
    public string? Director { get; set; }
    public TimeOnly Duration { get; set; }
    public string? Sinopse { get; set; }
}