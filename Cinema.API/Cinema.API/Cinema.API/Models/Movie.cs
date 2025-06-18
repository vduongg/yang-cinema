namespace Cinema.API.Models
{
    public class Movie
    {
        public int movieId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime releaseDate { get; set; }
    }
}
