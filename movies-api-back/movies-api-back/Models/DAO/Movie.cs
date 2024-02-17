using System.ComponentModel.DataAnnotations.Schema;
using movies_api_back.Enums;

namespace movies_api_back.Models.DAO;

[Table("Movies")]
public class Movie : BaseClass
{
    public string? Title { get; set; }
    public Genre Genre { get; set; }
    public DateOnly Premiere { get; set; }
    public string? Director { get; set; }
    public TimeOnly Duration { get; set; }
    public string? Sinopse { get; set; }

}