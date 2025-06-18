namespace Cinema.API.Models
{
    public class CinemaSesson
    {
        public int cinemaSessonId { get; set; }
        public DateTime startedDate { get; set; }
        public TimeOnly startedTime { get; set; }
        public int movieId { get; set; }
        public int roomId { get; set; }
        public int cinemaId { get; set; }
    }
}
