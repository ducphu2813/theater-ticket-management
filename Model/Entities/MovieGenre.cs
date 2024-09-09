namespace TheaterTicket.Model.Entities;

public class MovieGenre
{
    public Guid MovieId { get; set; } // Khóa ngoại của movie
    public Movie Movie { get; set; }

    public Guid GenreId { get; set; } // Khóa ngoại của genre
    public Genre Genre { get; set; }
}