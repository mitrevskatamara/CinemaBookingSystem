using CinemaBookingSystem.Domain.Idenitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
