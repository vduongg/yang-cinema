using Cinema.API.Models;
using Cinema.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieService _movieService;
        public MovieController (MovieService movie)
        {
            _movieService = movie;
        }
        public async  Task<List<Movie>> getALlMovie() 
        {
            return await  _movieService.GetAllMoviesAsync();
        }
    }
}
