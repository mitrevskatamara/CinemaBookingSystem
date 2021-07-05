using CinemaBookingSystem.Domain.Idenitity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingSystem.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<CinemaBookingSystemApplicationUser> GetAll();
        CinemaBookingSystemApplicationUser Get(string id);
        void Insert(CinemaBookingSystemApplicationUser entity);
        void Update(CinemaBookingSystemApplicationUser entity);
        void Delete(CinemaBookingSystemApplicationUser entity);
    }
}
