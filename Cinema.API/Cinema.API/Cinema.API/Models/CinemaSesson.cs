namespace Cinema.API.Models
{
    public class CinemaSesson
    {
        public int cinemaId { get; set; }
        public int cinemaSessonId { get; set; }
        public DateTime startedDate { get; set; }
        public TimeOnly startedTime { get; set; }
        public Movie movie { get; set; }
        public Room room { get; set; }
        
    }
}
