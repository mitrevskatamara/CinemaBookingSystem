namespace CinemaBookingSystem.Services.Interface
{
    public class ITicketService
    {
        List<Ticket> GetAllTickets();
        Ticket GetDetailsForTicket(Guid? id);

        void EditTicket(Ticket p);
        void DeleteTicket(Guid id);
        bool AddToShoppingCart(Ticket item, string userID);
        Ticket AddTicket(Ticket ticket);
    }
}