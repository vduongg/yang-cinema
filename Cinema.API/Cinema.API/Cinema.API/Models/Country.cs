namespace Cinema.API.Models
{
    public class Country
    {
        public int countryId { get; set; }
        public string countryName { get; set; }
        public List<Movie> movies { get; set; }
    }
}
