using Microsoft.EntityFrameworkCore;
using TheaterTicket.Model.Entities;

namespace TheaterTicket.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Movie> Movies { get; set; }
    
    public DbSet<Genre> Genres { get; set; }
    
    public DbSet<MovieGenre> MovieGenres { get; set; }
    
    //thiết lập các quan hệ giữa các bảng
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Thiết lập mối quan hệ Movie - MovieGenre
        modelBuilder.Entity<Movie>()
            .HasMany(m => m.MovieGenres)
            .WithOne(mg => mg.Movie)
            .HasForeignKey(mg => mg.MovieId);

        // Thiết lập mối quan hệ Genre - MovieGenre
        modelBuilder.Entity<Genre>()
            .HasMany(g => g.MovieGenres)
            .WithOne(mg => mg.Genre)
            .HasForeignKey(mg => mg.GenreId);

        // Cấu hình khóa chính của MovieGenre
        modelBuilder.Entity<MovieGenre>()
            .HasKey(mg => new { mg.MovieId, mg.GenreId });

        base.OnModelCreating(modelBuilder);
    }
}