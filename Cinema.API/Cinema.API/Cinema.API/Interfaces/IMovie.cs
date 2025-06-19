using Cinema.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Interfaces
{
    public interface IMovie
    {
       Task<List<Movie>> GetAllMoviesAsync();
       Task<Movie> GetMovieByIdAsync(int id); 
       Task<Movie> CreateMovieAsync(Movie movie);
       Task<Movie> UpdateMovieAsync(Movie movie);
       Task DeleteMovieAsync(int id);

    }
}
