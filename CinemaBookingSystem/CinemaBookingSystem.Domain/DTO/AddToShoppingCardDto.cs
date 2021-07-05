
using CinemaBookingSystem.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Domain.DTO
{
    public class AddToShoppingCardDto
    {
        public Ticket Ticket { get; set; }
        public Guid TicketId { get; set; }
        public int Quantity { get; set; }
    }
}
