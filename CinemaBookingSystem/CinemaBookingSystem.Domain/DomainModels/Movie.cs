namespace CinemaBookingSystem.Domain.DomainModels
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public Ticket Ticket { get; set; }
    }
}