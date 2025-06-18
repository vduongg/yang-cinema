using Cinema.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }    
        public DbSet<Actor> actors { get; set; }    
        public DbSet<Ward> wards { get; set; }  
        public DbSet<City> citys { get; set; }
        public DbSet<MovieType> movieTypes { get; set; }    
        public DbSet<CinemaSesson> cinemaSessons    { get; set; }
        public DbSet<Director> directors { get; set; }  

    }

}
