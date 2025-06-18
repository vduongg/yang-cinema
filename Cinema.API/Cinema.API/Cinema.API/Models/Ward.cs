namespace Cinema.API.Models
{
    public class Ward
    {
        public int wardId { get; set; }
        public string wardName { get; set; }
        public int wardCode { get; set; }
        public List<Cinema> cinemas { get; set; }
    }
}
