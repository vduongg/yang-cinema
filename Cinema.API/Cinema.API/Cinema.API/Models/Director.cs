namespace Cinema.API.Models
{
    public class Director
    {
        public int directorId { get; set; }
        public string directorIdName { get; set; }
        public List<Movie> movies { get; set; }
    }
}
