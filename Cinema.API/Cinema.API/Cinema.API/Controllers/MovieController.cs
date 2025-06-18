using Cinema.API.Interfaces;
using Cinema.API.Models;
using Cinema.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovie _movieService;
        public MovieController (IMovie movie)
        {
            _movieService = movie;
        }
        [HttpGet]
        public async  Task<List<Movie>> getALlMovie() 
        {
            return await  _movieService.GetAllMoviesAsync();
        }
        [HttpPost]
        public async Task<Movie> CreateMovie(Movie movie)
        {
            return await _movieService.CreateMoveAsync(movie);
        }
    }
}
