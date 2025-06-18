namespace Cinema.API.Models
{
    public class Movie
    {
        public int movieId { get; set; }
        public string movieName { get; set; }
        public string description { get; set; }
        public DateTime releaseDate { get; set; }
        public List<CinemaSesson> sessonList { get; set; }
        public List<MovieType> typeList { get; set; }   
        public List<Actor> actorList { get; set; }  
        public Country country { get; set; }
        public Director director { get; set; }

    }
}
