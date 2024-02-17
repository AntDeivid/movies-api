using Microsoft.EntityFrameworkCore;
using movies_api_back.Models.DAO;

namespace movies_api_back.Repositories;

public class MoviesDbContext : DbContext
{
    public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options) { }
    
    public DbSet<Movie>? Movies { get; set; }
    public DbSet<Review>? Reviews { get; set; }
    public DbSet<User>? Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Review>()
            .HasOne<Movie>()
            .WithMany();

        modelBuilder.Entity<Review>()
            .HasOne<User>()
            .WithMany();
    }
}