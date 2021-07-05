using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Services.Interface
{
    public interface IBackgroundEmailSender
    {
        Task DoWork();
    }
}
