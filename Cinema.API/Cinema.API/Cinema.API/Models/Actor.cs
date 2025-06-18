namespace Cinema.API.Models
{
    public class Actor
    {
        public int actorId { get; set; }
        public string actorName { get; set; }
        public List<Movie> movies { get; set; }

    }
}
