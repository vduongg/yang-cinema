using Cinema.API.Models;

namespace Cinema.API.Interfaces
{
    public interface IDirector
    {
        Task<List<Director>> GetAllDirectorsAsync();
        Task<Director> GetDirectorByIdAsync(int id);
        Task<Director> CreateDirectorAsync(Movie movie);
        Task<Director> UpdateDirectorAsync(Movie movie);
        Task DeleteDirectorAsync(int id);
    }
}
