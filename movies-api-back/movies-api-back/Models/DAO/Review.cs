using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movies_api_back.Models.DAO;

[Table("Reviews")]
public class Review : BaseClass
{
    public int Classification { get; set; }
    public string? Description { get; set; }
    public Guid MovieId { get; set; }
    public Guid UserId { get; set; }
    
}