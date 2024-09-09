using System.ComponentModel.DataAnnotations;

namespace TheaterTicket.Model.DTO;

public class AddMovieDTO
{
    [MaxLength(100)]
    public string? Name { get; set; }

    [MaxLength(100)] 
    public string? Director { get; set; }

    [MaxLength(100)]
    public string? Author { get; set; }

    [MaxLength(1000)] 
    public string? Description { get; set; }
    
    [MaxLength(20)] 
    public string? Dub { get; set; }
    
    [MaxLength(20)] 
    public string? SubTitle { get; set; }
}