
using CinemaBookingSystem.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Domain.DTO
{ 
    public class ShoppingCartDto
    {
        public List<Ticket> Tickets { get; set; }
        public double TotalPrice { get; set; }
    }
}
