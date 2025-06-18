using Cinema.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Interfaces
{
    public interface IMovie
    {
       Task<List<Movie>> GetAllMoviesAsync();
       Task<Movie> GetMovieByIdAsync(int id); 
       Task<Movie> CreateMoveAsync(Movie movie);
       Task<Movie> UpdateMoveAsync(Movie movie);
       Task DeleteMoveAsync(int id);

    }
}
