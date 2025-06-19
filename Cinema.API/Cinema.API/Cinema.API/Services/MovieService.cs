using Cinema.API.Data;
using Cinema.API.Interfaces;
using Cinema.API.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema.API.Services
{
    public class MovieService : IMovie 
    {

        
        private readonly DataContext _context;
        public MovieService(DataContext context)
        {
    

            _context = context;
        }

        public  async Task<Movie> CreateMovieAsync(Movie movie)
        {
            if(movie == null) 
            {
                return null;
            }
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task DeleteMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            await _context.SaveChangesAsync();
 
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task<Movie> UpdateMovieAsync(Movie _movie)
        {
            var movie = await _context.Movies.FindAsync(_movie.movieId);
            if (movie != null) { 
                movie.movieName = _movie.movieName;
                _context.Update(movie);
                await _context.SaveChangesAsync();
                return movie;
            }
            return null;
        }
    }

    
}
