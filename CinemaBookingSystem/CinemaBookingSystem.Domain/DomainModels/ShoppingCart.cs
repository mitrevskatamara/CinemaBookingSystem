using CinemaBookingSystem.Domain.Idenitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {

        public string OwnerId { get; set; }
        public User Owner { get; set; }
        public virtual ICollection<Ticket> TicketInShoppingCarts { get; set; }
    }
}
