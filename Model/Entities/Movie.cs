using System.ComponentModel.DataAnnotations;

namespace TheaterTicket.Model.Entities;

public class Movie
{
    public Guid Id { get; set; }

    [MaxLength(100)]
    public required string Name { get; set; }

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
    
    //khóa ngoại của moviegenre
    public ICollection<MovieGenre> MovieGenres { get; set; }
    
}