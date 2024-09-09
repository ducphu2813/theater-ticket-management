using System.ComponentModel.DataAnnotations;

namespace TheaterTicket.Model.Entities;

public class Genre
{
    public Guid Id { get; set; }

    [MaxLength(100)]
    public required string Name { get; set; }
    
    //khóa ngoại của moviegenre
    public ICollection<MovieGenre> MovieGenres { get; set; }
}