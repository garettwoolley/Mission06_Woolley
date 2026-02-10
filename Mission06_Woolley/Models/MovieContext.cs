using Microsoft.EntityFrameworkCore;

namespace Mission06_Woolley.Models;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options) //Constructor
    {
    }
    
    public DbSet<Movie> Movies { get; set; }
}