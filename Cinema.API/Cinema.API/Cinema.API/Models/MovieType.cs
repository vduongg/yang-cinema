namespace Cinema.API.Models
{
    public class MovieType
    {
        public int movieTypeId { get; set; }
        public string movieTypeName { get; set; }
        public List<Movie> movies { get; set; }
    }
}
